#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Syncfusion.EJ.ReportViewer;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Syncfusion.Report;

namespace samplebrowser.Controllers
{
    public partial class ReportViewerController : Controller, IReportController
    {
        private IMemoryCache _cache;
        private IHostingEnvironment _hostingEnvironment;

        public ReportViewerController(IMemoryCache memoryCache, IHostingEnvironment hostingEnvironment)
        {
            _cache = memoryCache;
            _hostingEnvironment = hostingEnvironment;
        }

        //
        // GET: /Default/

        public ActionResult Default()
        {
            return View();
        }


        [HttpPost]
        public object PostReportAction([FromBody] Dictionary<string, object> jsonResult)
        {
            return ReportHelper.ProcessReport(jsonResult, this, this._cache);
        }

        [ActionName("GetResource")]
        [AcceptVerbs("GET")]
        public object GetResource(ReportResource resource)
        {
            return ReportHelper.GetResource(resource, this, _cache);
        }

        [HttpPost]
        public object PostFormReportAction()
        {
            return ReportHelper.ProcessReport(null, this, this._cache);
        }

        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            FileStream inputStream = new FileStream(basePath + @"\Reports\"+ reportOption.ReportModel.ReportPath, FileMode.Open, FileAccess.Read);
            reportOption.ReportModel.Stream = inputStream;
        }

        public void OnReportLoaded(ReportViewerOptions reportOption)
        {
            if (reportOption.ReportModel.ProcessingMode == ProcessingMode.Local)
            {
                reportOption.ReportModel.DataSources.Clear();
                reportOption.ReportModel.DataSources.Add(new ReportDataSource { Name = "Sales", Value = new AdventureWorks().GetData() });
            }
        }
    }

    public class AdventureWorks
    {
        public string ProdCat { get; set; }
        public string SubCat { get; set; }
        public string OrderYear { get; set; }
        public string OrderQtr { get; set; }
        public double Sales { get; set; }

        public IList GetData()
        {
            List<AdventureWorks> AdventureWorksCollection = new List<AdventureWorks>();
            AdventureWorks AdventureWork = null;
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Helmets",
                OrderYear = "2002",
                OrderQtr = "Q1",
                Sales = 4945.6925
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 957715.1942
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Forks",
                OrderYear = "2002",
                OrderQtr = "Q4",
                Sales = 23543.1060
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = "2002",
                OrderQtr = "Q1",
                Sales = 3171787.6112
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Helmets",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 33853.1033
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Wheels",
                OrderYear = "2002",
                OrderQtr = "Q4",
                Sales = 163921.8870
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 4119658.6506
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Socks",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 6968.6884
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 3734891.6389
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 608352.8754
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Handlebars",
                OrderYear = "2002",
                OrderQtr = "Q4",
                Sales = 18309.4452
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 286591.8208
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Tires and Tubes",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 41940.3364
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 440260.9831
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 457688.8401
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Vests",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 66882.6450
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Pumps",
                OrderYear = "2002",
                OrderQtr = "Q4",
                Sales = 3226.3860
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 51600.6190
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Chains",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 3476.0176
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Handlebars",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 17194.2146
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 565229.8810
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 243.7175
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = "2002",
                OrderQtr = "Q2",
                Sales = 155311.4063
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = "2002",
                OrderQtr = "Q2",
                Sales = 220935.1648
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Locks",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 15.0000
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 827287.5234
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Bike Racks",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 75920.4000
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Bottom Brackets",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 17453.6400
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Touring Bikes",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 3298006.2858
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Brakes",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 18571.4700
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = "2002",
                OrderQtr = "Q4",
                Sales = 56782.4280
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Pedals",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 54185.2014
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Jerseys",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 173041.0492
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Jerseys",
                OrderYear = "2002",
                OrderQtr = "Q2",
                Sales = 16931.2362
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Headsets",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 19701.9001
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = "2002",
                OrderQtr = "Q4",
                Sales = 458089.4246
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Shorts",
                OrderYear = "2003",
                OrderQtr = "Q1",
                Sales = 11230.1280
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = "2002",
                OrderQtr = "Q4",
                Sales = 4189621.8590
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Brakes",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 26659.0800
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Wheels",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 83.2981
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Vests",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 81085.6900
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Cranksets",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 80244.1372
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Socks",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 6183.1422
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Wheels",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 163929.9435
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 67088.3037
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 779.8960
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Socks",
                OrderYear = "2002",
                OrderQtr = "Q1",
                Sales = 1273.8550
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 4930692.7825
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Shorts",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 84192.3708
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Jerseys",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 48901.7598
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Shorts",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 26207.2314
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = "2002",
                OrderQtr = "Q2",
                Sales = 3478963.5378
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Shorts",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 21423.6288
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Derailleurs",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 25385.2550
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Handlebars",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 21675.6840
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Bottom Brackets",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 13339.1820
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Clothing",
                SubCat = "Jerseys",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 31334.6088
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Helmets",
                OrderYear = "2002",
                OrderQtr = "Q2",
                Sales = 11638.8628
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Headsets",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 14102.2548
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Handlebars",
                OrderYear = "2002",
                OrderQtr = "Q3",
                Sales = 35341.0863
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Touring Bikes",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 3766585.3623
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Chains",
                OrderYear = "2003",
                OrderQtr = "Q4",
                Sales = 2217.8992
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Accessories",
                SubCat = "Locks",
                OrderYear = "2003",
                OrderQtr = "Q2",
                Sales = 3939.0000
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 3844123.5588
            };
            AdventureWorksCollection.Add(AdventureWork);
            AdventureWork = new AdventureWorks()
            {
                ProdCat = "Components",
                SubCat = "Handlebars",
                OrderYear = "2003",
                OrderQtr = "Q3",
                Sales = 43624.0992
            };
            AdventureWorksCollection.Add(AdventureWork);
         
            return AdventureWorksCollection;
        }
    }
}
