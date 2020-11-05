#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
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

namespace samplebrowser.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        //
        // GET: /WorksheetToHTML/

        public ActionResult WorksheetToHTML(string Group1,string button)
        {
            string basePath = _hostingEnvironment.WebRootPath;

            if (Group1 == null)
                return View();
            else if (button == "Input Template")
            {
                Stream ms = new FileStream(basePath + @"/XlsIO/NorthwindTemplate.xlsx", FileMode.Open, FileAccess.Read);
                return File(ms, "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Template.xlsx");
            }
            else
            {
                // The instantiation process consists of two steps.
                // Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                // Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                //Read file to memory stream
                Stream file = new FileStream(basePath + @"/XlsIO/NorthwindTemplate.xlsx", FileMode.Open, FileAccess.Read);

                // An existing workbook is opened.
                IWorkbook workbook = application.Workbooks.Open(file);

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];

                try
                {
                    //Create a memory stream to store the generated html file.
                    Stream stream = new MemoryStream();
                    FileStreamResult fileStreamResult = null;
                    //Convert Workbook to HTML file.
                    if (Group1 == "Workbook")
                    {
                        workbook.SaveAsHtml(stream);
                    }
                    //Convert Worksheet to HTML file.
                    else
                    {
                        worksheet.SaveAsHtml(stream);
                    }
                    stream.Position = 0;
                    fileStreamResult = new FileStreamResult(stream, "text/html");
                    return fileStreamResult;
                }
                catch (Exception)
                { }
                finally
                {
                    workbook.Close();
                    excelEngine.Dispose();
                }
            }
            return View();
        }
    }
}