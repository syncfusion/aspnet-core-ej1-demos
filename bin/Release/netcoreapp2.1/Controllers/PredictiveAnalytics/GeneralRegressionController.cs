#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.PMML;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace samplebrowser.Controllers
{
    public class PredictiveAnalyticsController : Controller
    {
        private Syncfusion.PMML.Table inputTable = null;
        private Syncfusion.PMML.Table outputTable = null;
        private string pmmlPath = string.Empty,
                inputPath = string.Empty,
                samplePath = string.Empty;
        private readonly IHostingEnvironment _hostingEnvironment;
        public PredictiveAnalyticsController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public ActionResult GeneralRegression()   
        {
            LoadSample();
            return View();
        }        

        /// <summary>
        /// Serialize the values in a list
        /// </summary>
        /// <param name="inputTable">input table values</param>
        /// <param name="outputTable">output table values</param>
        public void serializeTable(Syncfusion.PMML.Table inputTable, Syncfusion.PMML.Table outputTable)
        {
            List<AuditLogitClassification> datasource = new List<AuditLogitClassification>();
            
            for (int i = 0; i < inputTable.RowCount; i++)
            {
                AuditLogitClassification auditLogit = new AuditLogitClassification();

                auditLogit.ID = inputTable[i, 0];
                auditLogit.Age = inputTable[i, 1];
                auditLogit.Employment = inputTable[i, 2];
                auditLogit.Education = inputTable[i, 3];
                auditLogit.Marital = inputTable[i, 4];
                auditLogit.Occupation = inputTable[i, 5];
                auditLogit.Income = inputTable[i, 6];
                auditLogit.Sex = inputTable[i, 7];
                auditLogit.Deductions = inputTable[i, 8];
                auditLogit.Hours = inputTable[i, 9];
                auditLogit.Accounts = inputTable[i, 10];
                auditLogit.Adjustment = inputTable[i, 11];
                auditLogit.Adjusted = inputTable[i, 12];
                auditLogit.Predicted_Adjusted = outputTable[i, 0];
                auditLogit.AuditLowriskProbability = outputTable[i, 1];
                auditLogit.AuditHighriskProbability = outputTable[i, 2];

                //Adds audit object to grid's datasource
                datasource.Add(auditLogit);
            }

            ViewBag.datasource = datasource;
        }  

        /// <summary>
        /// Method to load Samples
        /// </summary>
        /// <param name="sample">Sample values</param>
        public void LoadSample()
        {
            samplePath = _hostingEnvironment.WebRootPath + @"/PredictiveAnalytics/";

            inputPath = samplePath + "Audit.csv";
            pmmlPath = string.Format("{0}{1}.pmml", samplePath, "Audit");
            Stream inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            inputTable = new Syncfusion.PMML.Table(inputStream, true, ',');
            outputTable = PredictResult(inputTable, pmmlPath);

            serializeTable(inputTable, outputTable);
        }

        #region PredictResult

        /// <summary>
        /// Predicts the results for given PMML and CSV file and serialize the results in a CSV file
        /// </summary>
        public Table PredictResult(Table inputTable, string pmmlPath)
        {
            Stream pmmlStream = new FileStream(pmmlPath, FileMode.Open, FileAccess.Read);
            //Get PMML Evaluator instance
            PMMLEvaluator evaluator = new PMMLEvaluatorFactory().
              GetPMMLEvaluatorInstance(pmmlStream);

            string[] predictedCategories = null;

            //Predict the value for each record using the PMML Evaluator instance
            for (int i = 0; i < inputTable.RowCount; i++)
            {
                var audit = GetDataObject(inputTable, i);

                //Get result
                PredictedResult predictedResult = evaluator.GetResult(audit, null);

                if (i == 0)
                {
                    //Get the predicted propability fields
                    predictedCategories = predictedResult.GetPredictedCategories();
                    //Initialize the output table
                    InitializeTable(inputTable.RowCount, predictedResult.PredictedField, predictedCategories);
                }

                //Add predicted value
                outputTable[i, 0] = predictedResult.PredictedValue;

                for (int j = 1; j <= predictedCategories.Length; j++)
                    outputTable[i, j] = predictedResult.GetPredictedProbability(predictedCategories[j - 1]);
            }
            return outputTable;
        }

        #endregion PredictResult        

        #region Initialize OutputTable

        /// <summary>
        /// Initialize the outputTable
        /// </summary>
        /// <param name="rowCount">rowCount of output table</param>
        /// <param name="predictedfield">predictedfield name</param>
        /// <param name="predictedCategories">probableFields</param>
        private void InitializeTable(int rowCount, string predictedfield, string[] predictedCategories)
        {
            //Create instance to hold evaluated results
            outputTable = new Table(rowCount, predictedCategories.Length + 1);
            //Add predicted column names
            outputTable.ColumnNames[0] = "Predicted_" + predictedfield;
            outputTable.ColumnNames[1] = "AuditLowriskProbability";
            outputTable.ColumnNames[2] = "AuditHighriskProbability";
        }

        #endregion Initialize OutputTable

        #region GetDataObject

        /// <summary>
        /// Returns the row as anonymous object
        /// </summary>
        /// <param name="inputTable"> input Table values</param>
        /// <param name="row">input row</param>
        /// <returns>Anonymous object</returns>
        public object GetDataObject(Table inputTable, int row)
        {
            var audit = new
            {
                ID = inputTable[row, "ID"],
                Age = inputTable[row, "Age"],
                Employment = inputTable[row, "Employment"],
                Education = inputTable[row, "Education"],
                Marital = inputTable[row, "Marital"],
                Occupation = inputTable[row, "Occupation"],
                Income = inputTable[row, "Income"],
                Sex = inputTable[row, "Sex"],
                Deductions = inputTable[row, "Deductions"],
                Hours = inputTable[row, "Hours"],
                Accounts = inputTable[row, "Accounts"],
                Adjustment = inputTable[row, "Adjustment"],
                Adjusted = inputTable[row, "Adjusted"]
            };
            return audit;
        }

        #endregion GetDataObject       

    }
	
	public class AuditLogitClassification
    {
        public object ID { get; set; }
        public object Age { get; set; }
        public object Employment { get; set; }
        public object Education { get; set; }
        public object Marital { get; set; }
        public object Occupation { get; set; }
        public object Income { get; set; }
        public object Sex { get; set; }
        public object Deductions { get; set; }
        public object Hours { get; set; }
        public object Accounts { get; set; }
        public object Adjustment { get; set; }
        public object Adjusted { get; set; }
        public object Predicted_Adjusted { get; set; }
        public object AuditLowriskProbability { get; set; }
        public object AuditHighriskProbability { get; set; } 
    }
}