#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.XlsIO;

namespace samplebrowser_core_2_0.Controllers.XlsIO
{
    public partial class XlsIOController : Controller
    {
        public ActionResult Performance(string SaveOption, string Import, string rowCount, string colCount)
        {
            if (SaveOption == null)
                return View();

            int rows = Convert.ToInt32(rowCount);
            int columns = Convert.ToInt32(colCount);
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Creating new workbook
            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet sheet = workbook.Worksheets[0];


            #region Generate Excel
            if(Import == "importonsave")
            {
                DataTable dataTable = new DataTable();
                for (int column = 1; column <= columns; column++)
                {
                    dataTable.Columns.Add("Column: " + column.ToString(), typeof(int));
                }
                //Adding data into data table
                for (int row = 1; row < rows; row++)
                {
                    dataTable.Rows.Add();
                    for (int column = 1; column <= columns; column++)
                    {
                        dataTable.Rows[row - 1][column - 1] = row * column;
                    }
                }
                sheet.ImportDataTable(dataTable,1,1,true,true);
            }
            else
            {
                IMigrantRange migrantRange = workbook.Worksheets[0].MigrantRange;
                for (int column = 1; column <= columns; column++)
                {
                    migrantRange.ResetRowColumn(1, column);
                    migrantRange.Text = "Column: " + column.ToString();
                }

                //Writing Data using normal interface
                for (int row = 2; row <= rows; row++)
                {
                    //double columnSum = 0.0; 
                    for (int column = 1; column <= columns; column++)
                    {
                        //Writing number
                        migrantRange.ResetRowColumn(row, column);
                        migrantRange.Number = row * column;
                    }
                }
            }
            #endregion

            string ContentType = null;
            string fileName = null;
            if (SaveOption == "ExcelXls")
            {
                ContentType = "Application/vnd.ms-excel";
                fileName = "Sample.xls";
            }
            else
            {
                workbook.Version = ExcelVersion.Excel2013;
                ContentType = "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                fileName = "Sample.xlsx";
            }

            MemoryStream ms = new MemoryStream();
            workbook.SaveAs(ms);
            ms.Position = 0;

            return File(ms, ContentType, fileName);

        }
    }
}