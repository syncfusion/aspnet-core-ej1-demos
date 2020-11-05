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
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class ListBoxController : Controller
    {
        //
        // GET: /Multiselect/
        List<Languages> mlang = new List<Languages>();
        public ActionResult MultiSelect()
        {
            mlang.Add(new Languages { skill = "ActionScript" });
            mlang.Add(new Languages { skill = "AppleScript" });
            mlang.Add(new Languages { skill = "Asp" });
            mlang.Add(new Languages { skill = "BASIC" });
            mlang.Add(new Languages { skill = "C" });
            mlang.Add(new Languages { skill = "C++" });
            mlang.Add(new Languages { skill = "Clojure" });
            mlang.Add(new Languages { skill = "COBOL" });
            mlang.Add(new Languages { skill = "ColdFusion" });
            mlang.Add(new Languages { skill = "Erlang" });
            mlang.Add(new Languages { skill = "Fortran" });
            mlang.Add(new Languages { skill = "Groovy" });
            mlang.Add(new Languages { skill = "Haskell" });
            mlang.Add(new Languages { skill = "Java" });
            mlang.Add(new Languages { skill = "JavaScript" });
            mlang.Add(new Languages { skill = "Lisp" });
            mlang.Add(new Languages { skill = "Perl" });
            mlang.Add(new Languages { skill = "PHP" });
            mlang.Add(new Languages { skill = "Python" });
            mlang.Add(new Languages { skill = "Ruby" });
            mlang.Add(new Languages { skill = "Scala" });
            mlang.Add(new Languages { skill = "Scheme" });
            ViewBag.datasource = mlang;
            return View();
        }

    }
}
