#region Copyright Syncfusion Inc. 2001-2022
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.XlsIO;
using Syncfusion.XlsIORenderer;
using Syncfusion.Drawing;
using System.Globalization;
using System.IO;
using Syncfusion.Pdf;
using Microsoft.AspNetCore.Http;

namespace samplebrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        string basePath = string.Empty;
        //
        // GET: /ExcelToPDF/
        public ActionResult ExcelToPDF(string button, string checkboxStream, string Group1, IFormFile file)
        {           
            if (button == null)
                return View();
            basePath = _hostingEnvironment.WebRootPath;
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            if (checkboxStream != null)
            {
                application.SubstituteFont += new Syncfusion.XlsIO.Implementation.SubstituteFontEventHandler(SubstituteFont);
            }

            XlsIORenderer renderer = new XlsIORenderer();
			
			Stream fileStream = null;
            if (file == null)
            {
                fileStream = new FileStream(basePath + @"/XlsIO/ExcelToPDF.xlsx", FileMode.Open, FileAccess.Read);
            }
            else
            {
                fileStream = file.OpenReadStream();
            }
            fileStream.Position = 0;

            //Loads file stream into Word document
            IWorkbook workbook = application.Workbooks.Open(fileStream);

            //Intialize the PdfDocument Class
            PdfDocument pdfDoc = new PdfDocument();

            //Intialize the ExcelToPdfConverterSettings class
            XlsIORendererSettings settings = new XlsIORendererSettings();
			settings.IsConvertBlankPage = false;
			
            //Set the Layout Options for the output Pdf page.
            if (Group1 == "NoScaling")
                settings.LayoutOptions = LayoutOptions.NoScaling;
            else if (Group1 == "FitAllRowsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
            else if (Group1 == "FitAllColumnsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
            else
                settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

            //Assign the output PdfDocument to the TemplateDocument property of ExcelToPdfConverterSettings 
            settings.TemplateDocument = pdfDoc;
            settings.DisplayGridLines = GridLinesDisplayStyle.Invisible;
            //Convert the Excel document to PDf

            pdfDoc = renderer.ConvertToPDF(workbook, settings);
            fileStream.Dispose();

            MemoryStream stream = new MemoryStream();
            pdfDoc.Save(stream);
            try
            {
                stream.Position = 0;
                return File(stream, "application/pdf", "ExcelToPDF.pdf");
            }
            catch (Exception)
            { }
            finally
            {

            }
            return View();
        }
        public void SubstituteFont(object sender, Syncfusion.XlsIO.Implementation.SubstituteFontEventArgs args)
        {
            Stream fileStream = new FileStream(basePath + @"/XlsIO/bahnschrift.ttf", FileMode.Open);
            MemoryStream memoryStream = new MemoryStream();
            fileStream.CopyTo(memoryStream);
            fileStream.Close();
            args.AlternateFontStream = memoryStream;
        }
    }
}
