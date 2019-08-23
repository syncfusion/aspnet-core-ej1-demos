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
    public partial class EditorController : Controller
    {
        //
        // GET: /EditorMethods/
        List<LocalData> data = new List<LocalData>();

        public ActionResult Methods()
        {
            data.Add(new LocalData { value = "(999)999-9999", text = "Phone No" });
            data.Add(new LocalData { value = "aa-99-99-a", text = "Insurance No" });
            data.Add(new LocalData { value = "AAA-AA-AAAA", text = "AlphaNumeric" });
            data.Add(new LocalData { value = "C99999", text = "Currency" });
            data.Add(new LocalData { value = "99999 - 9999", text = "ZipCode" });
            ViewBag.datasource = data;
            return View();
        }

    }
}
