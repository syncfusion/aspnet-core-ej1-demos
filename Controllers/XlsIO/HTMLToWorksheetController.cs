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
        // GET: /HTMLToWorksheet/

        public ActionResult HTMLToWorksheet(string button)
        {
            string basePath = _hostingEnvironment.WebRootPath;

            if (button == null)
                return View();
            else if (button == "Input Template")
            {
                Stream ms = new FileStream(basePath + @"/XlsIO/HTMLToExcel.html", FileMode.Open, FileAccess.Read);
                return File(ms, "text/html", "Import-HTML-Table.html");
            }
            else
            {
                // The instantiation process consists of two steps.
                // Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();

                // Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                // A workbook is created.
                IWorkbook workbook = application.Workbooks.Create(1);

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];

                Stream file = new FileStream(basePath + @"/XlsIO/HTMLToExcel.html", FileMode.Open, FileAccess.Read);

                worksheet.ImportHtmlTable(file, 1, 1);

                worksheet.UsedRange.AutofitColumns();				
				worksheet.UsedRange.AutofitRows();

                MemoryStream ms = new MemoryStream();
                workbook.SaveAs(ms);
                ms.Position = 0;

                excelEngine.Dispose();

                return File(ms, "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Import-HTML-Table.xlsx");
            }
        }
    }
}