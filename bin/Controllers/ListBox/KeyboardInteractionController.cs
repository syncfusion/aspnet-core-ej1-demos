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

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ListBoxController : Controller
    {
        //
        // GET: /KeyboardInteraction/
        List<Fonts> ft = new List<Fonts>();
        public ActionResult KeyboardInteraction()
        {
            ft.Add(new Fonts { font = "Algerian" });
            ft.Add(new Fonts { font = "ARIAL" });
            ft.Add(new Fonts { font = "Bimini" });
            ft.Add(new Fonts { font = "Courier" });
            ft.Add(new Fonts { font = "Cursive" });
            ft.Add(new Fonts { font = "Fantasy" });
            ft.Add(new Fonts { font = "Georgia" });
            ft.Add(new Fonts { font = "Impact" });
            ft.Add(new Fonts { font = "New york" });
            ft.Add(new Fonts { font = "Sans-Serif" });
            ft.Add(new Fonts { font = "Scripts" });
            ft.Add(new Fonts { font = "Times" });
            ft.Add(new Fonts { font = "Times New Roman" });
            ft.Add(new Fonts { font = "Verdana" });
            ft.Add(new Fonts { font = "Zapfellipt bt" });
            ViewBag.datasource = ft;
            return View();
        }

    }
}
