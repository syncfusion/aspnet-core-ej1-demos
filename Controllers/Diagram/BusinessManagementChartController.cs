#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
        public ActionResult BusinessManagementChart()
        {
            List<businessManagementData> businessManagementData = new List<businessManagementData>();
            businessManagementData.Add(new businessManagementData { Id = "parent", Role = "Board", color = "#71AF17" });
            businessManagementData.Add(new businessManagementData { Id = "1", Role = "General Manager", Manager = "parent", ChartType = "right", color = "#71AF17" });
            businessManagementData.Add(new businessManagementData { Id = "11", Role = "Assistant Manager", Manager = "1", color = "#71AF17" });
            businessManagementData.Add(new businessManagementData { Id = "2", Role = "Human Resource Manager", Manager = "1", ChartType = "right", color = "#1859B7" });
            businessManagementData.Add(new businessManagementData { Id = "3", Role = "Trainers", Manager = "2", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "4", Role = "Recruiting Team", Manager = "2", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "5", Role = "Finance Asst. Manager", Manager = "2", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "6", Role = "Design Manager", Manager = "1", ChartType = "right", color = "#1859B7" });
            businessManagementData.Add(new businessManagementData { Id = "7", Role = "Design Supervisor", Manager = "6", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "8", Role = "Development Supervisor", Manager = "6", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "9", Role = "Drafting Supervisor", Manager = "6", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "10", Role = "Operation Manager", Manager = "1", ChartType = "right", color = "#1859B7" });
            businessManagementData.Add(new businessManagementData { Id = "11", Role = "Statistic Department", Manager = "10", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "12", Role = "Logistic Department", Manager = "10", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "16", Role = "Marketing Manager", Manager = "1", ChartType = "right", color = "#1859B7" });
            businessManagementData.Add(new businessManagementData { Id = "17", Role = "Oversea sales Manager", Manager = "16", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "18", Role = "Petroleum Manager", Manager = "16", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "20", Role = "Service Dept. Manager", Manager = "16", color = "#2E95D8" });
            businessManagementData.Add(new businessManagementData { Id = "21", Role = "Quality Department", Manager = "16", color = "#2E95D8" });
            ViewBag.datasource = businessManagementData;
            return View();
        }
    }
}
