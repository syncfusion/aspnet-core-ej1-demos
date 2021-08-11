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
using Microsoft.AspNetCore.Mvc;
namespace samplebrowser.Controllers
{
    public partial class TreeMapController : Controller
    {
        //
        // GET: /hierarchical/

        public ActionResult Hierarchical()
        {
           ViewBag.hierarchicalData = SalesData.GetData();
            return View();
        }

    }

    public class SalesData
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public double Sales { get; set; }
        public double Expense { get; set; }

        public static List<SalesData> GetData()
        {
            List<SalesData> lt = new List<SalesData>();
            lt.Add(new SalesData() { Country = "United States", Name = "New York", Sales = 2353, Expense = 2000 });
            lt.Add(new SalesData() { Country = "United States", Name = "Los Angeles", Sales = 3453, Expense = 3000 });
            lt.Add(new SalesData() { Country = "United States", Name = "San Francisco", Sales = 8456, Expense = 8000 });
            lt.Add(new SalesData() { Country = "United States", Name = "Chicago", Sales = 6785, Expense = 7000 });
            lt.Add(new SalesData() { Country = "United States", Name = "Miami", Sales = 7045, Expense = 6000 });
            lt.Add(new SalesData() { Country = "Canada", Name = "Toronto", Sales = 7045, Expense = 7000 });
            lt.Add(new SalesData() { Country = "Canada", Name = "Vancouver", Sales = 4352, Expense = 4000 });
            lt.Add(new SalesData() { Country = "Canada", Name = "Winnipeg", Sales = 7843, Expense = 7500 });
            lt.Add(new SalesData() { Country = "Mexico", Name = "Mexico City", Sales = 7843, Expense = 6500 });
            lt.Add(new SalesData() { Country = "Mexico", Name = "Cancun", Sales = 6683, Expense = 6000 });
            lt.Add(new SalesData() { Country = "Mexico", Name = "Acapulco", Sales = 2454, Expense = 2000 });

            return lt;
        }
    }

}
