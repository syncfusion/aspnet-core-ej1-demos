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

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class RotatorController : Controller
    {
        //
        // GET: /RotatorThumbnail/
        List<localdata> LocalElement = new List<localdata>();
        public ActionResult Thumbnail()
        {
            LocalElement.Add(new localdata { text = "green", url = "../Images/rotator/green.jpg" });
            LocalElement.Add(new localdata { text = "snow", url = "../Images/rotator/snow.jpg" });
            LocalElement.Add(new localdata { text = "wheat", url = "../Images/rotator/wheat.jpg" });
            LocalElement.Add(new localdata { text = "tablet", url = "../Images/rotator/tablet.jpg" });
            LocalElement.Add(new localdata { text = "sea", url = "../Images/rotator/sea.jpg" });
            LocalElement.Add(new localdata { text = "bread", url = "../Images/rotator/bread.jpg" });
            LocalElement.Add(new localdata { text = "snowfall", url = "../Images/rotator/snowfall.jpg" });
            ViewBag.datasource = LocalElement;
            return View();
        }

    }
}
