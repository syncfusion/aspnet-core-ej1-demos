#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using Syncfusion.EJ.Export;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;

namespace samplebrowser.Controllers.PivotGrid
{
    public partial class PivotGridController : Controller
    {
        private IHttpContextAccessor _contextAccessor;

        public ActionResult Exporting()
        {
            return View();
        }

        public PivotGridController(IHttpContextAccessor contextAccessor, IHostingEnvironment envrnmt)
        {
            _contextAccessor = contextAccessor;
        }

        public ActionResult ExcelExport()
        {
            PivotGridExcelExport pGrid = new PivotGridExcelExport();
            var context = _contextAccessor.HttpContext;
            var args = context.Request.Form.ElementAt(0).Value;
            string fileName = "Sample";
            return pGrid.ExportToExcel(fileName, args, context.Response);
        }
        public ActionResult PDFExport()
        {
            PivotGridPDFExport pGrid = new PivotGridPDFExport();
            var context = _contextAccessor.HttpContext;
            var args = context.Request.Form.ElementAt(0).Value;
            string fileName = "Sample";
            return pGrid.ExportToPDF(fileName, args, context.Response);
        }

        public ActionResult WordExport()
        {
            PivotGridWordExport pGrid = new PivotGridWordExport();
            var context = _contextAccessor.HttpContext;
            var args = context.Request.Form.ElementAt(0).Value;
            string fileName = "Sample";
            return pGrid.ExportToWord(fileName, args, context.Response);
        }
    }
}