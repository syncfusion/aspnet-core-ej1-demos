#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
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
using samplebrowser.Models;

namespace samplebrowser.Controllers
{
    public partial class ComboBoxController : Controller
    {
        // GET: /Rtl/
        public ActionResult Rtl()
        {
            ViewBag.datasource = CarsList.GetCarList();
            return View();
        }
    }
}
