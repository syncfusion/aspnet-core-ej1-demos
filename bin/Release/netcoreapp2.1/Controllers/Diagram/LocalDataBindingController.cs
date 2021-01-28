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
        public ActionResult LocalDataBinding()
        {
            List<localData> localData = new List<localData>();
            localData.Add(new localData { Id = "parent", Role = "Marketing Director", Color = "#f79663" });
            localData.Add(new localData { Id = "1", Role = "Manager", TeamLead = "parent", Color = "#f79663" });
            localData.Add(new localData { Id = "3", Role = "Fundraiser", TeamLead = "1", Color = "#5cc3b5" });
            localData.Add(new localData { Id = "4", Role = "Programmer", TeamLead = "1", Color = "#5cc3b5" });
            localData.Add(new localData { Id = "6", Role = "Communicator", TeamLead = "3", Color = "#67a961" });
            localData.Add(new localData { Id = "7", Role = "Advertisor", TeamLead = "3", Color = "#67a961" });
            localData.Add(new localData { Id = "8", Role = "Funding Officer", TeamLead = "3", Color = "#67a961" });
            localData.Add(new localData { Id = "9", Role = "Inter", TeamLead = "6", Color = "#67a961" });
            localData.Add(new localData { Id = "10", Role = " Officer", TeamLead = "7", Color = "#67a961" });
            localData.Add(new localData { Id = "11", Role = " Officer", TeamLead = "7", Color = "#67a961" });
            localData.Add(new localData { Id = "12", Role = " Asst.Director", TeamLead = "4", Color = "#e9b833" });
            localData.Add(new localData { Id = "13", Role = " Asst.Director", TeamLead = "4", Color = "#e9b833" });
            localData.Add(new localData { Id = "14", Role = " Asst.Director", TeamLead = "4", Color = "#e9b833" });
            ViewBag.datasource = localData;
            return View();
        }
    }
}
