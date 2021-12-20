#region Copyright Syncfusion Inc. 2001-2021
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Syncfusion.XlsIO;
using Syncfusion.XlsIORenderer;

namespace samplebrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /WorksheetToImage/

        public ActionResult WorksheetToImage(string Group1, string OpenType,string button)
        {
            string basePath = _hostingEnvironment.WebRootPath;

            if (Group1 == null)
                return View();
            else if (button == "Input Template")
            {
                Stream ms = new FileStream(basePath + @"/XlsIO/ExpenseReport.xlsx", FileMode.Open, FileAccess.Read);
                return File(ms, "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Template.xlsx");
            }
            else
            {
                // The instantiation process consists of two steps.
                // Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                // Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Read file to memory stream
                Stream file = new FileStream(basePath + @"/XlsIO/ExpenseReport.xlsx", FileMode.Open, FileAccess.Read);

                // An existing workbook is opened.
                IWorkbook workbook = application.Workbooks.Open(file);

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];

                try
                {
                    //Create XlsIORenderer instance.
                    application.XlsIORenderer = new XlsIORenderer();

                    //Create a memory stream to store the generated image.
                    MemoryStream image = new MemoryStream();
                    ExportImageOptions imageOptions = new ExportImageOptions();
                    string fileName = null;
                    string ContentType = null;

                    //Save as PNG image
                    if (Group1 == "PNG")
                    {
                        imageOptions.ImageFormat = ExportImageFormat.Png;
                        fileName = "Image.png";
                        ContentType = "image/png";

                    }
                    //Save as JPEG image
                    else
                    {
                        imageOptions.ImageFormat = ExportImageFormat.Jpeg;
                        fileName = "Image.jpeg";
                        ContentType = "image/jpeg";

                    }
                    worksheet.ConvertToImage(worksheet.UsedRange, imageOptions, image);
                    image.Position = 0;
                    return File(image, ContentType, fileName);
                }
                catch (Exception)
                { }
                finally
                {

                }
                workbook.Close();
                excelEngine.Dispose();
            }
            return View();
        }
    }
}