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
using Syncfusion.JavaScript;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        public static List<OrderDetails> order = new List<OrderDetails>();
        public ActionResult InlineEditing()
        {
            if (order.Count() == 0)
                BindDataSource();
            ViewBag.datasource = order;
            return View();
        }
        public void BindDataSource()
        {
                int code = 10000;
                for (int i = 1; i < 10; i++)
                {
                    order.Add(new OrderDetails(code + 1, "ALFKI", i + 0, 2.3 * i, "Berlin"));
                    order.Add(new OrderDetails(code + 2, "ANATR", i + 2, 3.3 * i, "Madrid"));
                    order.Add(new OrderDetails(code + 3, "ANTON", i + 1, 4.3 * i, "Cholchester"));
                    order.Add(new OrderDetails(code + 4, "BLONP", i + 3, 5.3 * i, "Marseille"));
                    order.Add(new OrderDetails(code + 5, "BOLID", i + 4, 6.3 * i, "Tsawassen"));
                    code += 5;
                }
        }
        public ActionResult NormalUpdate([FromBody]CRUDModel<OrderDetails> myObject)
        {
                var ord = myObject.Value;
                OrderDetails val = order.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
                val.OrderID = ord.OrderID;
                val.EmployeeID = ord.EmployeeID;
                val.CustomerID = ord.CustomerID;
                val.Freight = ord.Freight;
                val.ShipCity = ord.ShipCity;
                return Json(myObject.Value);
        }
        public ActionResult NormalInsert([FromBody]CRUDModel<OrderDetails> value)
        {
            order.Insert(order.Count, value.Value);
            return Json(order);
        }
        public ActionResult NormalDelete([FromBody]CRUDModel<OrderDetails> value)
        {
            order.Remove(order.Where(or => or.OrderID == int.Parse(value.Key.ToString())).FirstOrDefault());
            return Json(value);
        }
        public class OrderDetails
        {
            public OrderDetails()
            {

            }
            public OrderDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, string ShipCity)
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
