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
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ListBoxController : Controller
    {
        //
        // GET: /RTL/

        List<Countries> countryList = new List<Countries>();
        public ActionResult rtl()
        {
            countryList.Add(new Countries { country = "الجیریا" });
            countryList.Add(new Countries { country = "ارمینیا" });
            countryList.Add(new Countries { country = "بنگلا دیش" });
            countryList.Add(new Countries { country = "کیوبا" });
            countryList.Add(new Countries { country = "ڈنمارک" });
            countryList.Add(new Countries { country = "مصر" });
            countryList.Add(new Countries { country = "فن لینڈ" });
            countryList.Add(new Countries { country = "بھارت" });
            countryList.Add(new Countries { country = "ملائیشیا" });
            countryList.Add(new Countries { country = "نیوزی لینڈ" });
            countryList.Add(new Countries { country = "ناروے" });
            ViewBag.datasource = countryList;
            return View();
        }

    }
}
