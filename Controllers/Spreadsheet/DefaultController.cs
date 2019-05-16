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
using Syncfusion.JavaScript.Models;
using Syncfusion.JavaScript;
using Syncfusion.XlsIO;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ.Export;

namespace samplebrowser.Controllers.SpreadsheetASP
{
    public partial class SpreadsheetController : Controller
    {
        public ActionResult Default()
        {
            var DataSource = GetAllItemDetails().ToList();
            ViewBag.Datasource = DataSource;
            return View();
        }
        public string Import(ImportRequest importRequest)
        {
            return Spreadsheet.Open(importRequest);
        }
        public ActionResult ExcelExport(string sheetModel, string sheetData, string fileName, string password)
        {
            return Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.XLSX);
        }
        public ActionResult CsvExport(string sheetModel, string sheetData, string fileName, string password)
        {
            return Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.CSV);
        }
        public ActionResult PdfExport(string sheetModel, string sheetData, string fileName, string password)
        {
            return Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.PDF);
        }
        public IEnumerable<object> GetAllItemDetails()
            {
                
                    List<ItemDetail> lItems = new List<ItemDetail>();

                    lItems.Add(new ItemDetail() { ItemName = "Casual Shoes", Date = new DateTime(2014, 02, 14), Time = new DateTime(2014, 02, 14, 11, 34, 32), Quantity = 10, Price = 20, Amount = 200, Discount = 1, Profit = 10 });
                    lItems.Add(new ItemDetail() { ItemName = "Sports Shoes", Date = new DateTime(2014, 06, 11), Time = new DateTime(2014, 06, 11, 05, 56, 32), Quantity = 20, Price = 30, Amount = 600, Discount = 5, Profit = 50 });
                    lItems.Add(new ItemDetail() { ItemName = "Formal Shoes", Date = new DateTime(2014, 07, 27), Time = new DateTime(2014, 07, 27, 03, 32, 44), Quantity = 20, Price = 15, Amount = 300, Discount = 7, Profit = 27 });
                    lItems.Add(new ItemDetail() { ItemName = "Sandals & Floaters", Date = new DateTime(2014, 11, 21), Time = new DateTime(2014, 11, 21, 06, 23, 54), Quantity = 15, Price = 20, Amount = 300, Discount = 11, Profit = 67 });
                    lItems.Add(new ItemDetail() { ItemName = "Flip- Flops & Slippers", Date = new DateTime(2014, 06, 23), Time = new DateTime(2014, 06, 23, 12, 43, 59), Quantity = 30, Price = 10, Amount = 300, Discount = 10, Profit = 70 });
                    lItems.Add(new ItemDetail() { ItemName = "Sneakers", Date = new DateTime(2014, 07, 22), Time = new DateTime(2014, 07, 22, 10, 55, 53), Quantity = 40, Price = 20, Amount = 800, Discount = 13, Profit = 66 });
                    lItems.Add(new ItemDetail() { ItemName = "Running Shoes", Date = new DateTime(2014, 02, 04), Time = new DateTime(2014, 02, 04, 03, 44, 34), Quantity = 20, Price = 10, Amount = 200, Discount = 3, Profit = 14 });
                    lItems.Add(new ItemDetail() { ItemName = "Loafers", Date = new DateTime(2014, 11, 30), Time = new DateTime(2014, 11, 30, 03, 12, 52), Quantity = 31, Price = 10, Amount = 310, Discount = 6, Profit = 29 });
                    lItems.Add(new ItemDetail() { ItemName = "Cricket Shoes", Date = new DateTime(2014, 07, 09), Time = new DateTime(2014, 07, 09, 11, 32, 14), Quantity = 41, Price = 30, Amount = 1210, Discount = 12, Profit = 166 });
                    lItems.Add(new ItemDetail() { ItemName = "T-Shirts", Date = new DateTime(2014, 10, 31), Time = new DateTime(2014, 10, 31, 12, 01, 44), Quantity = 50, Price = 10, Amount = 500, Discount = 9, Profit = 55 });

                    return lItems;
                
            }
            

        

        public class ItemDetail
        {
            public string ItemName { get; set; }
            public DateTime Date { get; set; }
            public DateTime Time { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
            public int Amount { get; set; }
            public int Discount { get; set; }
            public int Profit { get; set; }
        }
       
    }
}
