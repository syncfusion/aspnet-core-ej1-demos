#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Syncfusion.XlsIO;
using Syncfusion.EJ.Export;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        // GET: /<controller>/
        public ActionResult XLSExport()
        {
            ViewBag.appointments = new ScheduleData().GetAppData();
            return View();
        }
		
		public ActionResult ExportAsExcel()
        {
            List<AppointData> scheduleAppointments = (List<AppointData>)JsonConvert.DeserializeObject(Request.Form["ScheduleAppointment"], typeof(List<AppointData>));
			for (int a = 0, len = scheduleAppointments.Count; a < len; a++)
            {
                scheduleAppointments[a].StartTime = Convert.ToDateTime(scheduleAppointments[a].StartTime).ToString();
                scheduleAppointments[a].EndTime = Convert.ToDateTime(scheduleAppointments[a].EndTime).ToString();
            }
            ExcelExport xlExport = new ExcelExport();
            return xlExport.Export(scheduleAppointments);
        }
    }
	
	public class AppointData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool? AllDay { get; set; }
        public bool? Recurrence { get; set; }
        public string RecurrenceRule { get; set; }
    }
}
