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
        // GET: /Grouping/

        List<Countries> veg= new List<Countries>();
        public ActionResult Grouping()
        {
            veg.Add(new Countries { text= "Bahrain", category= "B" }); 
            veg.Add(new Countries { text= "Brazil", category= "B" });
            veg.Add(new Countries { text= "Argentina", category= "A" });
            veg.Add(new Countries { text= "Bangladesh", category= "B" }); 
            veg.Add(new Countries { text= "Burma", category= "B" }); 
            veg.Add(new Countries { text= "Afghanistan", category= "A" }); 
            veg.Add(new Countries { text= "Antigua and Barbuda", category= "A" });
            veg.Add(new Countries { text= "Barbados", category= "B" }); 
            veg.Add(new Countries { text= "Botswana", category= "B" }); 
            veg.Add(new Countries { text= "Albania", category= "A" }); 
            veg.Add(new Countries { text= "Andorra", category= "A" });
            veg.Add(new Countries { text= "Belarus", category= "B" }); 
            veg.Add(new Countries { text= "Bolivia", category= "B" }); 
            veg.Add(new Countries { text= "Algeria", category= "A" }); 
            veg.Add(new Countries { text= "Angola", category= "A" });  
            ViewBag.datasource = veg;
            return View();
        }

    }
}
