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
using samplebrowser.Models;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript.Models;
using Newtonsoft.Json;
using System.Collections;
using Syncfusion.XlsIO;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {

        private NORTHWNDContext _contextData;

        public static List<Employees> emp = new List<Employees>();

        // GET: /<controller>/
        public ActionResult HierarchyGridExporting()
        {
            if (emp.Count == 0)
                BindParentData();
            ViewBag.parent = emp;
            ViewBag.child = _context.Orders.Take(100).ToList();
            return View();
        }
        public ActionResult HierarchyExportToExcel(string GridModel)
        {
            ExcelExport exp = new ExcelExport();
            var DataSource = emp;
            GridProperties gridProp = ConvertGridModel(GridModel);
            gridProp.ChildGrid.DataSource = _context.Orders.Take(100).ToList();
            GridExcelExport excelExp = new GridExcelExport();
            excelExp.FileName = "Export.xlsx"; excelExp.Excelversion = ExcelVersion.Excel2010;
            excelExp.Theme = "flat-saffron";
            excelExp.IncludeChildGrid = true;
            return exp.Export(gridProp, DataSource, excelExp);
        }

        public ActionResult HierarchyExportToWord(string GridModel)
        {
            WordExport exp = new WordExport();
            var DataSource = emp;
            GridProperties gridProp = ConvertGridModel(GridModel);
            gridProp.ChildGrid.DataSource = _context.Orders.Take(100).ToList();
            GridWordExport wrdExp = new GridWordExport();
            wrdExp.FileName = "Export.docx"; wrdExp.Theme = "flat-saffron";
            wrdExp.IncludeChildGrid = true;
            return exp.Export(gridProp, DataSource, wrdExp);
        }
        public ActionResult HierarchyExportToPdf(string GridModel)
        {
            PdfExport exp = new PdfExport();
            var DataSource = emp;
            GridProperties gridProp = ConvertGridModel(GridModel);
            gridProp.ChildGrid.DataSource = _context.Orders.Take(100).ToList();
            GridPdfExport pdfExp = new GridPdfExport();
            pdfExp.FileName = "Export.pdf"; pdfExp.Theme = "flat-saffron";
            pdfExp.IncludeChildGrid = true;
            return exp.Export(gridProp, DataSource, pdfExp);
        }
        private GridProperties ConvertGridModel(string gridProperty)
        {
            GridProperties gridProp = new GridProperties();
            gridProp = (GridProperties)JsonConvert.DeserializeObject(gridProperty, typeof(GridProperties));
            return gridProp;
        }
        private void BindParentData()
        {
            emp.Add(new Employees(1, "Nancy", "Davolio", new DateTime(1948, 12, 08), "USA", "Sales Representative"));
            emp.Add(new Employees(2, "Andrew", "Fuller", new DateTime(1952, 02, 19), "USA", "Vice President, Sales"));
            emp.Add(new Employees(3, "Janet", "Leverling", new DateTime(1963, 08, 30), "USA", "Sales Representative"));
            emp.Add(new Employees(4, "Margaret", "Peacock", new DateTime(1937, 09, 19), "USA", "Sales Representative"));
            emp.Add(new Employees(5, "Steven", "Buchanan", new DateTime(1955, 03, 04), "UK", "Sales Manager"));
            emp.Add(new Employees(6, "Michael", "Suyama", new DateTime(1963, 07, 02), "UK", "Sales Representative"));
            emp.Add(new Employees(7, "Robert", "King", new DateTime(1960, 05, 29), "UK", "Sales Representative"));
            emp.Add(new Employees(8, "Laura", "Callahan", new DateTime(1958, 01, 09), "USA", "Inside Sales Coordinator"));
            emp.Add(new Employees(9, "Sans", "Serif", new DateTime(1958, 10, 10), "USA", "Sales Representative"));

        }
        public class Employees
        {
            public Employees()
            {

            }
            public Employees(int EmployeeId, string FirstName, string LastName, DateTime BirthDate, string Country, string title)
            {

                this.EmployeeID = EmployeeId;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.BirthDate = BirthDate;
                this.Country = Country;
                this.Title = title;
            }
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Country { get; set; }
            public string Title { get; set; }
        }
    }
}
