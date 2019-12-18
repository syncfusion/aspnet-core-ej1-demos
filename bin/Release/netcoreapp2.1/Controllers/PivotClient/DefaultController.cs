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

namespace samplebrowser.Controllers.PivotClient
{
    public partial class PivotClientController : Controller
    {
        public ActionResult Default()
        {
            return View();
        }
        private readonly IHttpContextAccessor _contextAccessor;

        public PivotClientController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public ActionResult ExportPivotClient()
        {
            var context = _contextAccessor.HttpContext;
            var args = context.Request.Form.ElementAt(0).Value;
            PivotClientExport olapClient = new PivotClientExport();
            return olapClient.ExportPivotClient(string.Empty, args, context.Response);

        }
    }
}