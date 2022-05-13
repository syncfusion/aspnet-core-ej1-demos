#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
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
    public partial class TagCloudController : Controller
    {
        //
        // GET: /TagCloudDefault/
        List<WebsiteCollection> sites = new List<WebsiteCollection>(); 
        public ActionResult Default()
        {
            sites.Add(new WebsiteCollection { text = "Google", url = "//www.google.com", frequency = 12 });
            sites.Add(new WebsiteCollection { text = "All Things Digital", url = "//allthingsd.com/", frequency = 3 });
            sites.Add(new WebsiteCollection { text = "Arts Technica", url = "//arstechnica.com/", frequency = 8 });
            sites.Add(new WebsiteCollection { text = "Business Week", url = "//www.businessweek.com/", frequency = 2 });
            sites.Add(new WebsiteCollection { text = "Yahoo", url = "//in.yahoo.com/", frequency = 12 });
            sites.Add(new WebsiteCollection { text = "Center Networks", url = "//www.centernetworks.com/", frequency = 5 });
            sites.Add(new WebsiteCollection { text = "Crave", url = "//news.cnet.com/crave/", frequency = 8 });
            sites.Add(new WebsiteCollection { text = "Crunch Gear", url = "//techcrunch.com/gadgets/", frequency = 20 });
            sites.Add(new WebsiteCollection { text = "Daily Tech", url = "//www.dailytech.com/", frequency = 1 });
            sites.Add(new WebsiteCollection { text = "Electronista", url = "//www.electronista.com/", frequency = 3 });
            sites.Add(new WebsiteCollection { text = "Engadget", url = "//www.engadget.com/", frequency = 5 });
            sites.Add(new WebsiteCollection { text = "Gearlog", url = "//www.gearlog.com/", frequency = 9 });
            sites.Add(new WebsiteCollection { text = "Information Week", url = "//www.informationweek.com/", frequency = 0 });
            sites.Add(new WebsiteCollection { text = "PCWorld", url = "//www.pcworld.com/", frequency = 11 });
            sites.Add(new WebsiteCollection { text = "Tech Republic", url = "//techrepublic.com/", frequency = 3 });
            sites.Add(new WebsiteCollection { text = "Valleywag", url = "//valleywag.gawker.com/", frequency = 6 });
            sites.Add(new WebsiteCollection { text = "Rediff", url = "//in.rediff.com/", frequency = 9 });
            sites.Add(new WebsiteCollection { text = "WebProNews", url = "//www.webpronews.com/", frequency = 2 });
            ViewBag.datasource = sites;
            return View();
        }

    }
    public class WebsiteCollection
    {
        public string text { get; set; }
        public string url { get; set; }
        public int frequency { get; set; }
    }
}
