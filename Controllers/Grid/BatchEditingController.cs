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
using System.Collections;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.JavaScript;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        public static List<Order> orddata = new List<Order>();

        public ActionResult BatchEditing()
        {
            if (orddata.Count() == 0)
                BindData();
            ViewBag.data = EmployeeID;
            return View();
        }
        public void BindData()
        {
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                orddata.Add(new Order(code + 1, "ALFKI", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin"));
                orddata.Add(new Order(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid"));
                orddata.Add(new Order(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester"));
                orddata.Add(new Order(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille"));
                orddata.Add(new Order(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen"));
                code += 5;
            }
        }
        public List<object> EmployeeID
        {
            get
            {
                var employeeID = orddata.Select(s => s.EmployeeID).Distinct().ToList();
                var EmployeeID = new List<object>();
                foreach (var id in employeeID)
                {
                    EmployeeID.Add(new { value = id, text = id });
                }
                return EmployeeID;
            }
        }

        public ActionResult DataSource([FromBody]DataManager dm)
        {
            IEnumerable data = orddata;
            DataOperations operation = new DataOperations();
            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                data = operation.PerformSorting(data, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0) //Filtering
            {
                data = operation.PerformWhereFilter(data, dm.Where, dm.Where[0].Operator);
            }
            int count = data.Cast<Order>().Count();
            if (dm.Skip != 0)
            {
                data = operation.PerformSkip(data, dm.Skip);
            }
            if (dm.Take != 0)
            {
                data = operation.PerformTake(data, dm.Take);
            }
            return Json(new { result = data, count = count });

        }
        public ActionResult BatchUpdate([FromBody]submitvalue myObject)
        {
            if (myObject.Changed != null && myObject.Changed.Count > 0)
            {
                foreach (var temp in myObject.Changed)
                {
                    var ord = temp;
                    Order val = orddata.Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
                    val.OrderID = ord.OrderID;
                    val.EmployeeID = ord.EmployeeID;
                    val.CustomerID = ord.CustomerID;
                    val.Freight = ord.Freight;
                    val.OrderDate = ord.OrderDate;
                    val.ShipCity = ord.ShipCity;
                }
            }
            if (myObject.Added != null && myObject.Added.Count > 0)
            {
                foreach (var temp in myObject.Added)
                {
                    orddata.Insert(0, temp);
                }
            }
            if (myObject.Deleted != null && myObject.Deleted.Count > 0)
            {
                foreach (var temp in myObject.Deleted)
                {
                    orddata.Remove(orddata.Where(or => or.OrderID == temp.OrderID).FirstOrDefault());
                }
            }

            var data = orddata;
            return Json(data);
        }
        public class submitvalue
        {
            public List<Order> Added { get; set; }
            public List<Order> Changed { get; set; }
            public List<Order> Deleted { get; set; }
            public object Key { get; set; }
        }
        public class Order
        {
            public Order()
            {

            }
            public Order(long OrderId, string CustomerId, int EmployeeId, double Freight, DateTime? OrderDate, string ShipCity)
            {
                this.OrderID = OrderId;
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
            public DateTime? OrderDate { get; set; }
            public string ShipCity { get; set; }
        }
      
       
    }
}
