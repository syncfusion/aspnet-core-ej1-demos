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

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ToolbarController : Controller
    {
        // GET: InlineToolbar
        List<InlineToolbar> I = new List<InlineToolbar>();
        public ActionResult InlineToolbar()
        {
            I.Add(new InlineToolbar { id = "1", spriteCss = "e-icon e-cut_01", group = "g1", tooltiptext="Cut"});
            I.Add(new InlineToolbar { id = "2", spriteCss = "e-icon e-copy_02", group = "g1",tooltiptext="Copy" });
            I.Add(new InlineToolbar { id = "3", spriteCss = "e-icon e-paste_01", group = "g1" ,tooltiptext="Paste"});
            I.Add(new InlineToolbar { id = "4", spriteCss = "e-icon e-edit", group = "g1" ,tooltiptext="Edit"});
            I.Add(new InlineToolbar { id = "5", spriteCss = "e-icon e-save", group = "g1",tooltiptext="Save" });
            I.Add(new InlineToolbar { id = "6", spriteCss = "e-icon e-bold_01", group = "g2" ,tooltiptext="Bold"});
            I.Add(new InlineToolbar { id = "7", spriteCss = "e-icon e-underline_01", group = "g2" ,tooltiptext="Underline"});
            I.Add(new InlineToolbar { id = "8", spriteCss = "e-icon  e-strikethrough_01", group = "g2" ,tooltiptext="strikethrough"});
            I.Add(new InlineToolbar { id = "9", spriteCss = "e-icon e-align-left_01", group = "g3" ,tooltiptext="Align Left"});
            I.Add(new InlineToolbar { id = "10", spriteCss = "e-icon e-align-center_01", group = "g3" ,tooltiptext="Align Center"});
            I.Add(new InlineToolbar { id = "11", spriteCss = "e-icon e-align-right_01", group = "g3" ,tooltiptext="Align Right" });
            I.Add(new InlineToolbar { id = "12", spriteCss = "e-icon  e-align-justify_01", group = "g3",tooltiptext="Align Justify"});
            I.Add(new InlineToolbar { id = "13", spriteCss = "e-icon  e-reload", group = "g4" ,tooltiptext="Reload"});
            I.Add(new InlineToolbar { id = "14", spriteCss = "e-icon e-delete", group = "g4",tooltiptext="delete" });
            I.Add(new InlineToolbar { id = "15", spriteCss = "e-icon e-print_02", group = "g4", tooltiptext = "Print" });
            I.Add(new InlineToolbar { id = "16", spriteCss = "e-icon e-excel-export", group = "g4" ,tooltiptext="Export"});
            ViewBag.datasource = I;
            return View();
        }
    }
    public class InlineToolbar
    {
        public string id { get; set; }
        public string spriteCss { get; set; }
        public string group { get; set; }

        public string tooltiptext { get; set; }

    }
}