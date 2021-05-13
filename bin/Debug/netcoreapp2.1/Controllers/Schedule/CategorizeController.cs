#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
using Syncfusion.JavaScript.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        // GET: /<controller>/
        public ActionResult Categorize()
        {
            List<Appointment> appointmentMenu = new List<Appointment>();
            appointmentMenu.Add(new Appointment() { Id = "open", Text = "Open Appointment" });
            appointmentMenu.Add(new Appointment() { Id = "delete", Text = "Delete Appointment" });
            appointmentMenu.Add(new Appointment() { Id = "custommenu3", Text = "Custom Menu3" });
            appointmentMenu.Add(new Appointment() { Id = "custommenu4", Text = "Custom Menu4" });
            appointmentMenu.Add(new Appointment() { Id = "categorize", Text = "Categorize" });

            List<Cells> cellMenu = new List<Cells>();
            cellMenu.Add(new Cells() { Id = "new", Text = "New Appointment" });
            cellMenu.Add(new Cells() { Id = "recurrence", Text = "New Recurring Appointment" });
            cellMenu.Add(new Cells() { Id = "today", Text = "Today" });
            cellMenu.Add(new Cells() { Id = "gotodate", Text = "Go to date" });
            cellMenu.Add(new Cells() { Id = "settings", Text = "Settings" });
            cellMenu.Add(new Cells() { Id = "view", Text = "View", ParentId = "settings" });
            cellMenu.Add(new Cells() { Id = "timemode", Text = "TimeMode", ParentId = "settings" });
            cellMenu.Add(new Cells() { Id = "view_Day", Text = "Day", ParentId = "view" });
            cellMenu.Add(new Cells() { Id = "view_Week", Text = "Week", ParentId = "view" });
            cellMenu.Add(new Cells() { Id = "view_Workweek", Text = "Workweek", ParentId = "view" });
            cellMenu.Add(new Cells() { Id = "view_Month", Text = "Month", ParentId = "view" });
            cellMenu.Add(new Cells() { Id = "timemode_Hour12", Text = "12 Hours", ParentId = "timemode" });
            cellMenu.Add(new Cells() { Id = "timemode_Hour24", Text = "24 Hours", ParentId = "timemode" });
            cellMenu.Add(new Cells() { Id = "workhours", Text = "Work Hours", ParentId = "settings" });
            cellMenu.Add(new Cells() { Id = "custommenu1", Text = "Custom Menu1" });
            cellMenu.Add(new Cells() { Id = "custommenu2", Text = "Custom Menu2" });

            List<Categorize> categorizeValue = new List<Categorize>();
            categorizeValue.Add(new Categorize { text = "Blue Category", id = 1, color = "#43b496", fontColor = "#ffffff" });
            categorizeValue.Add(new Categorize { text = "Green Category", id = 2, color = "#7f993e", fontColor = "#ffffff" });
            categorizeValue.Add(new Categorize { text = "Orange Category", id = 3, color = "#cc8638", fontColor = "#ffffff" });
            categorizeValue.Add(new Categorize { text = "Purple Category", id = 4, color = "#ab54a0", fontColor = "#ffffff" });
            categorizeValue.Add(new Categorize { text = "Red Category", id = 5, color = "#dd654e", fontColor = "#ffffff" });
            categorizeValue.Add(new Categorize { text = "Yellow Category", id = 6, color = "#d0af2b", fontColor = "#ffffff" });

            ViewBag.appData = appointmentMenu;
            ViewBag.cellData = cellMenu;
            ViewBag.categorizeData = categorizeValue;
            ViewBag.appointments = new ScheduleData().GetAppData();
            return View();
        }
    }

    public class Categorize
    {
        public string text { set; get; }
        public int id { set; get; }
        public string fontColor { set; get; }
        public string color { set; get; }
    }
}
