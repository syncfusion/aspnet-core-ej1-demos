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
using Microsoft.AspNetCore.Mvc;
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        // GET: /<controller>/
        public ActionResult FirstDayOfWeek()
        {
            ViewBag.weekDays = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            ViewBag.selectedItems = new List<int>() { 1, 2, 3, 4, 5 };
            ViewBag.appointments = new ScheduleData().GetAppData();
            return View();
        }
    }
}
