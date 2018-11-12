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
        public ActionResult OrganizationalChart()
        {
            Dictionary<string, object> addInfo = new Dictionary<String, object>();
            addInfo.Add("orientation","vertical");
            addInfo.Add("type", "alternate");
            ViewBag.addInfo = addInfo;
            List<organizationalData> organizationalData = new List<organizationalData>();
            organizationalData.Add(new organizationalData { Id = "parent", Function = "Project Management" });
            organizationalData.Add(new organizationalData { Id = "1", Function = "R&D Team", Phase = "parent" });
            organizationalData.Add(new organizationalData { Id = "2", Function = "HR Team", Phase = "parent" });
            organizationalData.Add(new organizationalData { Id = "3", Function = "Sales Team", Phase = "parent" });
            organizationalData.Add(new organizationalData { Id = "4", Function = "Philosophy", Phase = "1" });
            organizationalData.Add(new organizationalData { Id = "5", Function = " Organization", Phase = "1" });
            organizationalData.Add(new organizationalData { Id = "6", Function = "Technology", Phase = "1" });
            organizationalData.Add(new organizationalData { Id = "7", Function = " Funding", Phase = "1" });
            organizationalData.Add(new organizationalData { Id = "8", Function = "Resource", Phase = "1" });
            organizationalData.Add(new organizationalData { Id = "9", Function = "Targeting", Phase = "1" });
            organizationalData.Add(new organizationalData { Id = "10", Function = "Evaluation", Phase = "1" });
            organizationalData.Add(new organizationalData { Id = "11", Function = "Recruitment", Phase = "2" });
            organizationalData.Add(new organizationalData { Id = "12", Function = "Relation", Phase = "2" });
            organizationalData.Add(new organizationalData { Id = "13", Function = "Design", Phase = "3" });
            organizationalData.Add(new organizationalData { Id = "14", Function = "Operation", Phase = "3" });
            organizationalData.Add(new organizationalData { Id = "15", Function = "Support", Phase = "3" });
            organizationalData.Add(new organizationalData { Id = "16", Function = "Quality", Phase = "3" });
            organizationalData.Add(new organizationalData { Id = "17", Function = "Interaction", Phase = "3" });
            organizationalData.Add(new organizationalData { Id = "18", Function = "Support", Phase = "3" });
            organizationalData.Add(new organizationalData { Id = "19", Function = "Coordination", Phase = "3" });
            ViewBag.datasource = organizationalData;
            return View();
        }
    }
}
