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
using Syncfusion.JavaScript;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class GridController : Controller
    {
        public static List<OrderData> orderdetail = new List<OrderData>();
        public ActionResult Filtering()
        {
            if (orderdetail.Count() == 0)
               BindDataSource();
            ViewBag.datasource = orderdetail;
            return View();
        }
        public void BindDataSource()
        {
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                orderdetail.Add(new OrderData(code + 1, "ALFKI", i + 0, 2.3 * i, "Berlin"));
                orderdetail.Add(new OrderData(code + 2, "ANATR", i + 2, 3.3 * i, "Madrid"));
                orderdetail.Add(new OrderData(code + 3, "ANTON", i + 1, 4.3 * i, "Cholchester"));
                orderdetail.Add(new OrderData(code + 4, "BLONP", i + 3, 5.3 * i, "Marseille"));
                orderdetail.Add(new OrderData(code + 5, "BOLID", i + 4, 6.3 * i, "Tsawassen"));
                code += 5;
            }
        }
        public class OrderData
        {
            public OrderData()
            {
 
            }
            public OrderData(int OrderID, string CustomerId, int EmployeeId, double Freight, string ShipCity)
            {
                this.OrderID = OrderID;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.ShipCity = ShipCity;
            }

            public int? OrderID { get; set; }
            public string CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public double? Freight { get; set; }
            public string ShipCity { get; set; }
        }
    }
}