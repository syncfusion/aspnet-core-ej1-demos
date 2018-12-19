#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
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
          
        public static List<OrdersView> ordersdata = new List<OrdersView>();
        public ActionResult DialogTemplateEditing()
        {
            if (ordersdata.Count() == 0)
                GetData();
            ViewBag.datasource = ordersdata;
            return View();
        }
        public void GetData()
        {
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                ordersdata.Add(new OrdersView(code + 1, "ALFKI", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin", "Germany", "Alfred's Futterkiste"));
                ordersdata.Add(new OrdersView(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid","Mexico", "Ana Trujillo Emparedados y helados"));
                ordersdata.Add(new OrdersView(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester","UK", "Antonio Moreno Taquería"));
                ordersdata.Add(new OrdersView(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille","Sweden", "Bon app'"));
                ordersdata.Add(new OrdersView(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen","France", "Bottom-Dollar Markets"));
                code += 5;
            }
        }
        public ActionResult Update([FromBody]CRUDModel<OrdersView> myObject)
        {
            var ord = myObject.Value;
            OrdersView val = ordersdata.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.EmployeeID = ord.EmployeeID;
            val.CustomerID = ord.CustomerID;
            val.Freight = ord.Freight;
            val.OrderDate = ord.OrderDate;
            val.ShipCity = ord.ShipCity;
            val.ShipName = ord.ShipName;
            return Json(myObject.Value);
        }
        public ActionResult Insert([FromBody]CRUDModel<OrdersView> value)
        {
            ordersdata.Insert(ordersdata.Count, value.Value);
            return Json(ordersdata);
        }
        public ActionResult Delete([FromBody]CRUDModel<OrdersView> value)
        {
            ordersdata.Remove(ordersdata.Where(or => or.OrderID == int.Parse(value.Key.ToString())).FirstOrDefault());
            return Json(value);
        }
        public class OrdersView
        {
            public OrdersView()
            {

            }
            public OrdersView(long OrderID, string CustomerId, int EmployeeId, double Freight, DateTime OrderDate, string ShipCity, string ShipCountry, string ShipName)
            {
                this.OrderID = OrderID;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.OrderDate = OrderDate;
                this.ShipCity = ShipCity;
                this.ShipCountry = ShipCountry;
                this.ShipName = ShipName;
            }

            public long? OrderID { get; set; }
            public string CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public double? Freight { get; set; }
            public DateTime OrderDate { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }
            public string ShipName { get; set; }
        }
    }
}