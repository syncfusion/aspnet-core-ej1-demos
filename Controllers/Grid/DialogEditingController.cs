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
using Syncfusion.JavaScript;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        public static List<OrdersViews> orderdata = new List<OrdersViews>();
        public ActionResult DialogEditing()
        {
            if (orderdata.Count() == 0)
                GetDataSource();
            ViewBag.datasource = orderdata;
            return View();
        }
        public void GetDataSource()
        {
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                orderdata.Add(new OrdersViews(code + 1, "ALFKI", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin"));
                orderdata.Add(new OrdersViews(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid"));
                orderdata.Add(new OrdersViews(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester"));
                orderdata.Add(new OrdersViews(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille"));
                orderdata.Add(new OrdersViews(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen"));
                code += 5;
            }
        }
        public ActionResult DialogUpdate([FromBody]CRUDModel<OrdersViews> myObject)
        {
            var ord = myObject.Value;
            OrdersViews val = orderdata.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            return Json(myObject.Value);
        }
        public ActionResult DialogInsert([FromBody]CRUDModel<OrdersViews> value)
        {
            orderdata.Insert(orderdata.Count, value.Value);
            return Json(orderdata);
        }
        public ActionResult DialogDelete([FromBody]CRUDModel<OrdersViews> value)
        {
            orderdata.Remove(orderdata.Where(or => or.OrderID == int.Parse(value.Key.ToString())).FirstOrDefault());
            return Json(value);
        }
        public class OrdersViews
        {
            public OrdersViews()
            {

            }
            public OrdersViews(long OrderID, string CustomerId, int EmployeeId, double Freight, DateTime OrderDate, string ShipCity)
            {
                this.OrderID = OrderID;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.OrderDate = OrderDate;
                this.ShipCity = ShipCity;
            }

            public long? OrderID { get; set; }
            public string CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public double? Freight { get; set; }
            public DateTime OrderDate { get; set; }
            public string ShipCity { get; set; }
        }
    }
}
