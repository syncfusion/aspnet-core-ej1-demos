#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
        // GET: /Cascading/

        List<groups> group = new List<groups>();
        List<Countries> country = new List<Countries>();
        public ActionResult Cascading()
        {
            group.Add(new groups { parentId = "a", text = "Group A" });
            group.Add(new groups { parentId = "b", text = "Group B" });
            group.Add(new groups { parentId = "c", text = "Group C" });
            group.Add(new groups { parentId = "d", text = "Group D" });
            group.Add(new groups { parentId = "e", text = "Group E" });
            group.Add(new groups { parentId = "f", text = "Group F" });
            group.Add(new groups { parentId = "g", text = "Group G" });
            group.Add(new groups { parentId = "h", text = "Group H" });
            group.Add(new groups { parentId = "i", text = "Group I" });
            group.Add(new groups { parentId = "j", text = "Group J" });
            ViewBag.datasource = group;
            country.Add(new Countries { value = 11, parentId = "a", text = "Algeria", sprite = "flag-dz" });
            country.Add(new Countries { value = 12, parentId = "a", text = "Armenia", sprite = "flag-am" });
            country.Add(new Countries { value = 13, parentId = "a", text = "Bangladesh", sprite = "flag-bd" });
            country.Add(new Countries { value = 14, parentId = "a", text = "Cuba", sprite = "flag-cu" });
            country.Add(new Countries { value = 15, parentId = "b", text = "Denmark", sprite = "flag-dk" });
            country.Add(new Countries { value = 16, parentId = "b", text = "Egypt", sprite = "flag-eg" });
            country.Add(new Countries { value = 17, parentId = "c", text = "Finland", sprite = "flag-fi" });
            country.Add(new Countries { value = 18, parentId = "c", text = "India", sprite = "flag-in" });
            country.Add(new Countries { value = 19, parentId = "c", text = "Malaysia", sprite = "flag-my" });
            country.Add(new Countries { value = 20, parentId = "d", text = "New Zealand", sprite = "flag-nz" });
            country.Add(new Countries { value = 21, parentId = "d", text = "Norway", sprite = "flag-no" });
            country.Add(new Countries { value = 22, parentId = "d", text = "Romania", sprite = "flag-ro" });
            country.Add(new Countries { value = 23, parentId = "e", text = "Singapore", sprite = "flag-sg" });
            country.Add(new Countries { value = 24, parentId = "e", text = "Thailand", sprite = "flag-th" });
            country.Add(new Countries { value = 25, parentId = "e", text = "Ukraine", sprite = "flag-ua" });
            country.Add(new Countries{ value =26, parentId ="f", text ="Falkland Islands",sprite =  "flag-ua"});
            country.Add(new Countries{ value =27, parentId ="f",text = "Faroe Islands", sprite = "flag-ua"});
            country.Add(new Countries { value = 28, parentId = "f", text = "Fiji", sprite = "flag-ua" });
            country.Add(new Countries{ value =29, parentId ="g",text = "Germany",sprite =  "flag-ua"});
            country.Add(new Countries{ value =30, parentId ="g",text = "Greece",sprite =  "flag-ua"});
            country.Add(new Countries{ value =31, parentId ="g",text = "Greenland",sprite =  "flag-ua"});
            country.Add(new Countries{ value =32, parentId ="g",text = "Ghana",sprite =  "flag-ua"});
            country.Add(new Countries{ value =33, parentId ="h",text = "Hong Kong",sprite =  "flag-ua"});
            country.Add(new Countries{ value =34, parentId ="h",text = "Haiti", sprite = "flag-ua"});
            country.Add(new Countries{ value =35, parentId ="i",text = "Iceland",sprite =  "flag-ua"});
            country.Add(new Countries{ value =36, parentId ="i",text = "Indonesia", sprite = "flag-ua"});
            country.Add(new Countries{ value =37, parentId ="i",text = "Ireland",sprite =  "flag-ua"});
            country.Add(new Countries{ value =38, parentId ="j",text = "Jamaica",sprite =  "flag-ua"});
            country.Add(new Countries{ value =39, parentId ="j",text = "Japan", sprite = "flag-ua"});
            country.Add(new Countries{ value =40, parentId ="j",text = "Jordan", sprite = "flag-ua"});
            ViewBag.datasource1 = country;
            return View();
        }

    }
}
