#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Syncfusion.EJ.ReportDesigner;
using Syncfusion.EJ.ReportViewer;
using Syncfusion.RDL.ServerProcessor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace samplebrowser.Controllers
{
    public partial class ReportDesignerController : Controller, IReportDesignerController
    {
        private IMemoryCache _cache;
        private IHostingEnvironment _hostingEnvironment;
        public static string RootPath;
        const string CachePath = "Reports\\ReportServer\\Cache\\";

        internal ExternalServer Server
        {
            get;
            set;
        }

        internal string ServerURL
        {
            get;
            set;
        }

        public ActionResult Default()
        {
            return View();
        }

        public ReportDesignerController(IMemoryCache memoryCache, IHostingEnvironment hostingEnvironment)
        {
            _cache = memoryCache;
            _hostingEnvironment = hostingEnvironment;
            ReportDesignerController.RootPath = _hostingEnvironment.WebRootPath;
            ExternalServer externalServer = new ExternalServer();
            this.Server = externalServer;
            this.ServerURL = "Sample";
            externalServer.ReportServerUrl = this.ServerURL;
            ReportDesignerHelper.ReportingServer = externalServer;
        }

        public string GetFilePath(string fileName)
        {
            string targetFolder = this._hostingEnvironment.WebRootPath + "\\";
            targetFolder += CachePath;

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            if (!Directory.Exists(targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken))
            {
                Directory.CreateDirectory(targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken);
            }

            var folderPath = targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken + "\\";
            return folderPath + fileName;
        }

        [HttpGet]
        public object GetImage(string key, string image)
        {
            return ReportDesignerHelper.GetImage(key, image, this);
        }

        public object GetResource(ReportResource resource)
        {
            return ReportHelper.GetResource(resource, this, _cache);
        }

        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
            reportOption.ReportModel.ReportingServer = this.Server;
            reportOption.ReportModel.ReportServerUrl = this.ServerURL;
            reportOption.ReportModel.ReportServerCredential = new NetworkCredential("Sample", "Passwprd");
        }

        public void OnReportLoaded(ReportViewerOptions reportOption)
        {

        }

        [HttpPost]
        public object PostDesignerAction([FromBody] Dictionary<string, object> jsonResult)
        {
            return ReportDesignerHelper.ProcessDesigner(jsonResult, this, null, this._cache);
        }

        public object PostFormDesignerAction()
        {
            return ReportDesignerHelper.ProcessDesigner(null, this, null, this._cache);
        }

        public object PostFormReportAction()
        {
            return ReportHelper.ProcessReport(null, this, this._cache);
        }

        [HttpPost]
        public object PostReportAction([FromBody] Dictionary<string, object> jsonResult)
        {
            return ReportHelper.ProcessReport(jsonResult, this, this._cache);
        }

        public bool UploadFile(IFormFile httpPostedFile)
        {
            string targetFolder = this._hostingEnvironment.WebRootPath + "\\";
            string fileName = !string.IsNullOrEmpty(ReportDesignerHelper.SaveFileName) ? ReportDesignerHelper.SaveFileName : Path.GetFileName(httpPostedFile.FileName);
            targetFolder += CachePath;

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            if (!Directory.Exists(targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken))
            {
                Directory.CreateDirectory(targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken);
            }

            using (var reader = new StreamReader(httpPostedFile.OpenReadStream()))
            {
                string contentAsString = reader.ReadToEnd();
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(contentAsString);
                if (System.IO.File.Exists(targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken + "\\" + fileName))
                {
                    System.IO.File.Delete(targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken + "\\" + fileName);
                }
                System.IO.File.WriteAllBytes(targetFolder + "\\" + ReportDesignerHelper.EJReportDesignerToken + "\\" + fileName, bytes);
                reader.Close();
                reader.Dispose();
            }
            return true;
        }

        [HttpPost]
        public void UploadReportAction()
        {
            ReportDesignerHelper.ProcessDesigner(null, this, this.Request.Form.Files[0], this._cache);
        }

        public FileModel GetFile(string filename, bool isOverride)
        {
            throw new NotImplementedException();
        }

        public List<FileModel> GetFiles(FileType fileType)
        {
            throw new NotImplementedException();
        }
    }

    public sealed class ExternalServer : ReportingServer
    {
        public override List<CatalogItem> GetItems(string folderName, ItemTypeEnum type)
        {
            List<CatalogItem> _items = new List<CatalogItem>();
            string targetFolder = ReportDesignerController.RootPath + @"\Reports\ReportServer\";

            if (type == ItemTypeEnum.DataSet)
            {
                foreach (var file in Directory.GetFiles(targetFolder + "DataSet"))
                {
                    CatalogItem catalogItem = new CatalogItem();
                    catalogItem.Name = Path.GetFileNameWithoutExtension(file);
                    catalogItem.Type = ItemTypeEnum.DataSet;
                    catalogItem.Id = Regex.Replace(catalogItem.Name, @"[^0-9a-zA-Z]+", "_");
                    _items.Add(catalogItem);
                }
            }
            else if (type == ItemTypeEnum.DataSource)
            {
                foreach (var file in Directory.GetFiles(targetFolder + "DataSource"))
                {
                    CatalogItem catalogItem = new CatalogItem();
                    catalogItem.Name = Path.GetFileNameWithoutExtension(file);
                    catalogItem.Type = ItemTypeEnum.DataSource;
                    catalogItem.Id = Regex.Replace(catalogItem.Name, @"[^0-9a-zA-Z]+", "_");
                    _items.Add(catalogItem);
                }
            }
            else if (type == ItemTypeEnum.Folder
                && (string.IsNullOrEmpty(folderName) || folderName.Trim() == "/"))
            {
                foreach (var file in Directory.GetDirectories(targetFolder + "Report"))
                {
                    CatalogItem catalogItem = new CatalogItem();
                    catalogItem.Name = Path.GetFileNameWithoutExtension(file);
                    catalogItem.Type = ItemTypeEnum.Folder;
                    catalogItem.Id = Regex.Replace(catalogItem.Name, @"[^0-9a-zA-Z]+", "_");
                    _items.Add(catalogItem);
                }
            }
            else if (type == ItemTypeEnum.Report
                && !string.IsNullOrEmpty(folderName) && !(folderName.Trim() == "/"))
            {
                foreach (var file in Directory.GetFiles(targetFolder + @"Report\" + folderName))
                {
                    CatalogItem catalogItem = new CatalogItem();
                    catalogItem.Name = Path.GetFileNameWithoutExtension(file);
                    catalogItem.Type = ItemTypeEnum.Report;
                    catalogItem.Id = Regex.Replace(catalogItem.Name, @"[^0-9a-zA-Z]+", "_");
                    _items.Add(catalogItem);
                }
            }

            return _items;
        }

        public override bool CreateReport(string reportName, string folderName, byte[] reportdata, out string exception)
        {
            string tmpReportName = reportName;
            exception = null;
            string catagoryName = null;

            if (folderName != null)
            {
                catagoryName = folderName.TrimStart('/').TrimEnd('/').Trim();
            }

            if (string.IsNullOrEmpty(catagoryName) && string.IsNullOrEmpty(tmpReportName))
            {
                exception = "Please select any category";
                return false;
            }

            if (!Path.HasExtension(reportName))
            {
                reportName += ".rdl";
            }

            string targetFolder = ReportDesignerController.RootPath + @"\Reports\ReportServer\Report\";
            string reportPat = targetFolder + catagoryName + @"\" + reportName;
            File.WriteAllBytes(reportPat, reportdata.ToArray());

            return true;
        }

        public override System.IO.Stream GetReport()
        {
            string reportPath = this.ReportPath.TrimStart('/').TrimEnd('/').Trim();
            string reportName = reportPath.Substring(reportPath.IndexOf('/') + 1).Trim();
            string catagoryName = reportPath.Substring(0, reportPath.IndexOf('/')).Trim();

            string targetFolder = ReportDesignerController.RootPath + @"\Reports\ReportServer\Report\";

            string reportPat = targetFolder + catagoryName + @"\" + reportName + ".rdl";

            if (File.Exists(reportPat))
            {
                return this.ReadFiles(reportPat);
            }

            return null;
        }

        private Stream ReadFiles(string filePath)
        {
            using (FileStream fileStream = File.OpenRead(filePath))
            {
                fileStream.Position = 0;
                MemoryStream memStream = new MemoryStream();
                memStream.SetLength(fileStream.Length);
                fileStream.Read(memStream.GetBuffer(), 0, (int)fileStream.Length);
                return memStream;
            }
            return null;
        }

        public override bool EditReport(byte[] reportdata)
        {
            string reportPath = this.ReportPath.TrimStart('/').TrimEnd('/').Trim();
            string reportName = reportPath.Substring(reportPath.IndexOf('/') + 1).Trim();
            string catagoryName = reportPath.Substring(0, reportPath.IndexOf('/')).Trim();

            string targetFolder = ReportDesignerController.RootPath + @"\Reports\ReportServer\Report\";

            string reportPat = targetFolder + catagoryName + @"\" + reportName + ".rdl";
            File.WriteAllBytes(reportPat, reportdata.ToArray());

            return true;
        }

        public override DataSourceDefinition GetDataSourceDefinition(string dataSource)
        {
            if (dataSource != null && dataSource.Contains("/"))
            {
                string[] _dataSrcPathHierarchy = dataSource.Split('/');
                dataSource = _dataSrcPathHierarchy.Last().TrimStart('/');
            }

            string targetFolder = ReportDesignerController.RootPath + @"\Reports\ReportServer\DataSource\";

            string dataSourcePath = targetFolder + dataSource + ".rds";

            if (File.Exists(dataSourcePath))
            {
                var _sharedDatasetInfo = new SharedDatasetinfo();
                var stream = this.ReadFiles(dataSourcePath);
                int length = Convert.ToInt32(stream.Length);
                byte[] data = new byte[length];
                stream.Read(data, 0, length);
                stream.Close();
                return this.GetDataSourceDefinition(data, dataSource, null);
            }

            return null;
        }

        DataSourceDefinition GetDataSourceDefinition(byte[] dataSourceContent, string name, string guid)
        {
            var _rptDefinition = new DataSourceDefinition();
            var _datasourceStream = this.GetFileToStream(dataSourceContent);
            var _umpDefinition = this.DeseralizeObj<DataSourceDefinition>(_datasourceStream);
            _rptDefinition = _umpDefinition;
            return _rptDefinition;
        }

        public override SharedDatasetinfo GetSharedDataDefinition(string dataSet)
        {
            string targetFolder = ReportDesignerController.RootPath + @"\Reports\ReportServer\DataSet\";
            string dataSetPath = targetFolder + dataSet + ".rsd";

            if (File.Exists(dataSetPath))
            {
                var _sharedDatasetInfo = new SharedDatasetinfo();
                var stream = this.ReadFiles(dataSetPath);
                int length = Convert.ToInt32(stream.Length);
                byte[] data = new byte[length];
                stream.Read(data, 0, length);
                stream.Close();
                var _datasetStream = this.GetFileToStream(data);
                _sharedDatasetInfo.DataSetStream = _datasetStream;
                _sharedDatasetInfo.Guid = Guid.Empty.ToString();
                return _sharedDatasetInfo;
            }

            return null;
        }

        T DeseralizeObj<T>(Stream str)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReader reader = XmlReader.Create(str);
            return (T)serializer.Deserialize(reader);
        }

        private Stream GetFileToStream(byte[] _fileContent)
        {
            MemoryStream memStream = new MemoryStream();
            memStream.Write(_fileContent, 0, _fileContent.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            return memStream;
        }
    }
}
