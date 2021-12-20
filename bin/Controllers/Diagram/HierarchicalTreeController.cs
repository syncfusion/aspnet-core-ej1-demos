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

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: /<controller>/
        public ActionResult HierarchicalTree()
        {
            List<hierarchicalData> hierarchicalData = new List<hierarchicalData>();
            hierarchicalData.Add(new hierarchicalData { Name = "Diagram", fillColor = "#916DAF" });
            hierarchicalData.Add(new hierarchicalData { Name = "Layout", Category = "Diagram", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Tree Layout", Category = "Layout", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Organizational Chart", Category = "Layout", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Hierarchical Tree", Category = "Tree Layout", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Radial Tree", Category = "Tree Layout", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Mind Map", Category = "Hierarchical Tree", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Family Tree", Category = "Hierarchical Tree", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Management", Category = "Organizational Chart", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Human Resource", Category = "Management", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "University", Category = "Management", fillColor = "#88C65C" });
            hierarchicalData.Add(new hierarchicalData { Name = "Business", Category = "Management", fillColor = "#88C65C" });
            ViewBag.datasource = hierarchicalData;
            return View();
        }
    }
}
