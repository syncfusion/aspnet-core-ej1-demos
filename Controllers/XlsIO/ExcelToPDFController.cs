#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
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
        //
        // GET: /ExcelToPDF/

        public ActionResult ExcelToPDF(string button, string Group1, IFormFile file)
        {           
            if (button == null)
                return View();

            XlsIORenderer renderer = new XlsIORenderer();
			
			Stream fileStream = null;
            if (file == null)
            {
                string basePath = _hostingEnvironment.WebRootPath;
                fileStream = new FileStream(basePath + @"/XlsIO/ExcelToPDF.xlsx", FileMode.Open, FileAccess.Read);
            }
            else
            {
                fileStream = file.OpenReadStream();
            }
            fileStream.Position = 0;

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

            pdfDoc = renderer.ConvertToPDF(fileStream, settings);
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

    }
}
