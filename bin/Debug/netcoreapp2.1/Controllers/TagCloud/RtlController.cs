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

namespace samplebrowser.Controllers
{

    public partial class TagCloudController : Controller
    {
        //
        // GET: /TagCloudRtl/
        List<WebsiteCollection> links = new List<WebsiteCollection>(); 
        public ActionResult Rtl()
        {
            links.Add(new WebsiteCollection { text = "جوجل", url = "//www.google.com", frequency = 12 });
            links.Add(new WebsiteCollection { text = "كل الأشياء الرقمية", url = "//allthingsd.com/", frequency = 3 });
            links.Add(new WebsiteCollection { text = "الفنون تكنيكا", url = "//arstechnica.com/", frequency = 8 });
            links.Add(new WebsiteCollection { text = "بيزنس ويك", url = "//www.businessweek.com/", frequency = 2 });
            links.Add(new WebsiteCollection { text = "ياهو", url = "//in.yahoo.com/", frequency = 12 });
            links.Add(new WebsiteCollection { text = "مركز الشبكات", url = "//www.centernetworks.com/", frequency = 5 });
            links.Add(new WebsiteCollection { text = "حن", url = "//news.cnet.com/crave/", frequency = 8 });
            links.Add(new WebsiteCollection { text = "جير أزمة", url = "//techcrunch.com/gadgets/", frequency = 20 });
            links.Add(new WebsiteCollection { text = "يوميا تك", url = "//www.dailytech.com/", frequency = 1 });
            links.Add(new WebsiteCollection { text = "التقنية بلا حدود", url = "//www.engadget.com/", frequency = 5 });
            links.Add(new WebsiteCollection { text = "الأسبوع المعلومات", url = "//www.informationweek.com/", frequency = 0 });
            links.Add(new WebsiteCollection { text = "إستخدام آمن", url = "//www.pcworld.com/", frequency = 11 });
            links.Add(new WebsiteCollection { text = "جمهورية التكنولوجيا", url = "//techrepublic.com/", frequency = 3 });
            links.Add(new WebsiteCollection { text = "الثعبان", url = "//valleywag.gawker.com/", frequency = 6 });
            links.Add(new WebsiteCollection { text = "ريديف", url = "//in.rediff.com/", frequency = 9 });
            ViewBag.datasource = links;
            return View();
        }

    }
}
