#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
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
    public partial class ToolbarController : Controller
    {
        //
        // GET: /ToolbarMethods/
        List<ToolbarMethods> m = new List<ToolbarMethods>();
        public ActionResult Methods()
        {
            m.Add(new ToolbarMethods { text = "None", value = "none" });
            m.Add(new ToolbarMethods { text = "Left", value = "Left" });
            m.Add(new ToolbarMethods { text = "Center", value = "Center" });
            m.Add(new ToolbarMethods { text = "Right", value = "Right" });
            m.Add(new ToolbarMethods { text = "Justify", value = "Justify" });
            m.Add(new ToolbarMethods { text = "Bold", value = "Bold" });
            m.Add(new ToolbarMethods { text = "Italic", value = "Italic" });
            m.Add(new ToolbarMethods { text = "StrikeThrough", value = "StrikeThrough" });
            m.Add(new ToolbarMethods { text = "Underline", value = "Underline" });
            ViewBag.datasource = m;
            return View();
        }

    }
    public class ToolbarMethods
    {
        public string id { get; set; }    
        public string text { get; set; }
        public string value { get; set; }
    }
}
