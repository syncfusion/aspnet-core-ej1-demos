#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
    public partial class ReportDesignerController : Controller
    {
        // GET: /<controller>/

        public IActionResult Default()
        {
            return View();
        }
    }
}
