#region Copyright Syncfusion Inc. 2001-2021
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
    public partial class DateTimePickerController : Controller
    {
        public class datetimemodel
        {
            public object Value
            {
                get; set;
            }
        }
        // GET: /DateTimePickerFor/
        public ActionResult DateTimePickerFor()
        {
            datetimemodel datetime = new datetimemodel();
            datetime.Value = DateTime.Now;
            return View(datetime);
        }
        [HttpPost]
        public ActionResult DateTimePickerFor(datetimemodel model)
        {
            datetimemodel datetime = new datetimemodel();
            datetime.Value = DateTime.Now;
            return View(datetime);
        }

    }
}
