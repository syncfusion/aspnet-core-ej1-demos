#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using samplebrowser.Helpers;
using Microsoft.AspNetCore.Hosting;

namespace samplebrowser.Controllers
{
    public class SourceCodeTabController : Controller
    {
        private IHostingEnvironment _appEnv;
        public SourceCodeTabController(IHostingEnvironment appEnv)
        {
            _appEnv = appEnv;
        }
        public ActionResult Index(string file)
        {
            return Content(new SourceTabActionResult(file, "false", _appEnv).getContent(_appEnv));
        }

    }
}
