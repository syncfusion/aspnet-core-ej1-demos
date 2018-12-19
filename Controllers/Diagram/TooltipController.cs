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

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: /<controller>/
        public ActionResult Tooltip()
        {
            ViewBag.tipone = new Dictionary<string, object> { { "Description", "Queries about the customer" } };
            ViewBag.tiptwo = new Dictionary<string, object> { { "Description", "Whether the provided information is enough?" } };
            ViewBag.tipthree = new Dictionary<string, object> { { "Description", "Analysing the query" } };
            ViewBag.tipfour = new Dictionary<string, object> { { "Description", "Whether the reported/requested bug/feature is valid?" } };
            ViewBag.tipfive = new Dictionary<string, object> { { "Description", "Send the invalid message to customer" } };
            ViewBag.tipsix = new Dictionary<string, object> { { "Description", "Requesting for more information" } };
            ViewBag.tipseven = new Dictionary<string, object> { { "Description", "Share the User Guide/Knowledge Base link" } };
            ViewBag.tipeight = new Dictionary<string, object> { { "Description", "Log the bug/feature" } };
            ViewBag.tipnine = new Dictionary<string, object> { { "Description", "Fix the bug/Add the feature" } };
            ViewBag.tipten = new Dictionary<string, object> { { "Description", "Provide the solution" } };
            ViewBag.tipeleven = new Dictionary<string, object> { { "Description", "Share the task details" } };
            return View();
        }
    }
}
