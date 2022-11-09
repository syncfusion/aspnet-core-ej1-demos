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
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ListBoxController : Controller
    {
        //
        // GET: /LocalData/
        List<Bikes> bike = new List<Bikes>();
        public ActionResult LocalData()
        {
            bike.Add(new Bikes { empid = "bk1", text = "Aache RTR" });
            bike.Add(new Bikes { empid = "bk2", text = "CBR 150-R" });
            bike.Add(new Bikes { empid = "bk3", text = "CBZ Xtreme" });
            bike.Add(new Bikes { empid = "bk4", text = "Discover" });
            bike.Add(new Bikes { empid = "bk5", text = "Dazzler" });
            bike.Add(new Bikes { empid = "bk6", text = "Flame" });
            bike.Add(new Bikes { empid = "bk7", text = "Fazzer" });
            bike.Add(new Bikes { empid = "bk8", text = "FZ-S" });
            bike.Add(new Bikes { empid = "bk9", text = "Pulsar" });
            bike.Add(new Bikes { empid = "bk10", text = "Shine" });
            bike.Add(new Bikes { empid = "bk11", text = "R15" });
            bike.Add(new Bikes { empid = "bk12", text = "Unicorn" });
            ViewBag.datasource = bike;
            return View();
        }

    }
}
