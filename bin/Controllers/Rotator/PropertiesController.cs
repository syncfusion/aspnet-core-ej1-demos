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
    public partial class RotatorController : Controller
    {
        //
        // GET: /RotatorProperties/
        List<LocalData> pagerPosition = new List<LocalData>();
        List<LocalData> animation = new List<LocalData>();
        public ActionResult Properties()
        {
            pagerPosition.Add(new LocalData { value = "topleft", text = "TopLeft" });
            pagerPosition.Add(new LocalData { value = "topright", text = "TopRight" });
            pagerPosition.Add(new LocalData { value = "bottomleft", text = "BottomLeft" });
            pagerPosition.Add(new LocalData { value = "bottomright", text = "BottomRight" });
            pagerPosition.Add(new LocalData { value = "outside", text = "Outside" });
            ViewBag.datasource = pagerPosition;
            animation.Add(new LocalData { value = "slide", text = "Slide" });
            animation.Add(new LocalData { value = "slowSlide", text = "SlowSlide" });
            animation.Add(new LocalData { value = "fastSlide", text = "FastSlide" });
            animation.Add(new LocalData { value = "slideshow", text = "Slideshow" });
            ViewBag.animationsource = animation;
            return View();
        }

    }
    public class LocalData
    {
        public string id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }
}
