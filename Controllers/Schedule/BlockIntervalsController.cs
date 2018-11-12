#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.JavaScript.Models;
using Microsoft.AspNetCore.Mvc;
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        // GET: /<controller>/
        public ActionResult BlockIntervals()
        {
            List<ResourceFields> Owners = new List<ResourceFields>();
            Owners.Add(new ResourceFields { Text = "Airline 1", Id = "1", GroupId = "1", Color = "#f8a398" });
            Owners.Add(new ResourceFields { Text = "Airline 2", Id = "3", GroupId = "2", Color = "#56ca85" });
            Owners.Add(new ResourceFields { Text = "Airline 3", Id = "5", GroupId = "1", Color = "#51a0ed" });

            ViewBag.Grouping = new List<String>() { "Owners" };
            ViewBag.OwnerData = Owners;
            ViewBag.appointments = new ScheduleData().GetAppData();
            ViewBag.blockData = new ScheduleData().GetBlockData();
            return View();
        }
    }
}
