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

namespace samplebrowser.Controllers.PivotChart
{
    public partial class PivotChartController : Controller
    {
        private IHttpContextAccessor _contextAccessor;

        public ActionResult Exporting()
        {
            return View();
        }

        public PivotChartController(IHttpContextAccessor contextAccessor, IHostingEnvironment envrnmt)
        {
            _contextAccessor = contextAccessor;
        }

        public ActionResult ExportToPDF()
        {
            PivotChartPDFExport pivotChart = new PivotChartPDFExport();
            var context = _contextAccessor.HttpContext;
            var args = context.Request.Form.ElementAt(0).Value;
            Dictionary<string, string> clientParams = JsonConvert.DeserializeObject<Dictionary<string, string>>(args);
            clientParams["fileName"] = "sample";
            return pivotChart.ExportToPDF(clientParams);
        }

        public ActionResult ExportToExcel()
        {
            PivotChartExcelExport pivotChart = new PivotChartExcelExport();
            var context = _contextAccessor.HttpContext;
            var args = context.Request.Form.ElementAt(0).Value;
            Dictionary<string, string> clientParams = JsonConvert.DeserializeObject<Dictionary<string, string>>(args);
            clientParams["fileName"] = "sample";
            return pivotChart.ExportToExcel(clientParams);
        }
        public ActionResult ExportToWord()
        {
            PivotChartWordExport pivotChart = new PivotChartWordExport();
            var context = _contextAccessor.HttpContext;
            var args = context.Request.Form.ElementAt(0).Value;
            Dictionary<string, string> clientParams = JsonConvert.DeserializeObject<Dictionary<string, string>>(args);
            clientParams["fileName"] = "sample";
            return pivotChart.ExportToWord(clientParams);
        }
    }
}