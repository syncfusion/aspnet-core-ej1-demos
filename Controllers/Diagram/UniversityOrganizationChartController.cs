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

namespace samplebrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: /<controller>/
        public ActionResult UniversityOrganizationChart()
        {
            List<universityData> universityData = new List<universityData>();
            universityData.Add(new universityData { Id = "parent", Role = "University President", Color = "#822B86" });
            universityData.Add(new universityData { Id = "1", Role = "Chancellor", Supervision = "parent", Color = "#3c418B" });
            universityData.Add(new universityData { Id = "2", Role = "Vice President", Supervision = "parent", Color = "#3c418B" });
            universityData.Add(new universityData { Id = "3", Role = "Student Affairs", Supervision = "2", ChartType = "left", Color = "#3c418B" });
            universityData.Add(new universityData { Id = "4", Role = "Admin & Finance", Supervision = "2", Color = "#3c418B" });
            universityData.Add(new universityData { Id = "5", Role = "Academics", Supervision = "2", Color = "#3c418B" });
            universityData.Add(new universityData { Id = "6", Role = "External Relations", Supervision = "2", ChartType = "right", Color = "#3c418B" });
            universityData.Add(new universityData { Id = "7", Role = "Activities and Special events", Supervision = "3", Color = "#267011" });
            universityData.Add(new universityData { Id = "8", Role = "Educational Service Center", Supervision = "3", Color = "#267011" });
            universityData.Add(new universityData { Id = "9", Role = "Health Care", Supervision = "3", Color = "#267011" });
            universityData.Add(new universityData { Id = "10", Role = "Housing and Food Service Center", Supervision = "3", Color = "#267011" });
            universityData.Add(new universityData { Id = "11", Role = "Students Development", Supervision = "3", Color = "#267011" });
            universityData.Add(new universityData { Id = "13", Role = "General Maintenance", Supervision = "4", Color = "#267011" });
            universityData.Add(new universityData { Id = "14", Role = "Budget and Audit", Supervision = "4", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "15", Role = "Human Resource", Supervision = "4", Color = "#267011" });
            universityData.Add(new universityData { Id = "16", Role = "Information Technology", Supervision = "4", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "17", Role = "Facilities Management", Supervision = "4", Color = "#267011" });
            universityData.Add(new universityData { Id = "117", Role = "Environment Maintenance", Supervision = "4", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "217", Role = "Custodial Service", Supervision = "4", Color = "#267011" });
            universityData.Add(new universityData { Id = "18", Role = "Faculties", Supervision = "5", Color = "#267011" });
            universityData.Add(new universityData { Id = "19", Role = "Educational Service", Supervision = "5", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "20", Role = "University Library", Supervision = "5", Color = "#267011" });
            universityData.Add(new universityData { Id = "21", Role = "Center for Planning", Supervision = "5", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "22", Role = "Summer Session", Supervision = "5", Color = "#267011" });
            universityData.Add(new universityData { Id = "23", Role = "Fund Development", Supervision = "6", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "24", Role = "Admission", Supervision = "6", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "25", Role = "Alumini Relations", Supervision = "6", Color = "#71AF17" });
            universityData.Add(new universityData { Id = "12", Role = "Recruitment & Promotion", Supervision = "6", Color = "#71AF17" });
            ViewBag.datasource = universityData;
            return View();
        }
    }
}
