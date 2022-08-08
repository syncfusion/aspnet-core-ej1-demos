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
using Microsoft.AspNetCore.Mvc;

namespace samplebrowser.Controllers
{
    public partial class TreeGridController : Controller
    {
        //
        // GET: /TreeGridColumnFiltering/

        public ActionResult TreeGridColumnFiltering()
        {
            ViewBag.datasource = this.GetFilteringDataSource();
            StageDetails stages = new StageDetails();
            ViewBag.dropData = stages.GetStageCollection();
            StateDetails state = new StateDetails();
            ViewBag.stateData = state.GetStateCollection();
            return View();
        }
        
        private List<BusinessObject> GetFilteringDataSource()
        {
            List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();

            BusinessObject Record1 = null;

            Record1 = new BusinessObject()
            {
                TaskId = 1,
                TaskName = "Planning",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Progress = 100,
                Priority = "Normal",
                InProgress = false,
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child1 = new BusinessObject()
            {
                TaskId = 2,
                TaskName = "Plan timeline",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Priority = "Low",
                Progress = 100,
                InProgress = true
            };

            BusinessObject Child2 = new BusinessObject()
            {
                TaskId = 3,
                TaskName = "Plan budget",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Progress = 100,
                InProgress = false
            };

            BusinessObject Child3 = new BusinessObject()
            {
                TaskId = 4,
                TaskName = "Allocate resources",
                FilterStartDate = new DateTime(2017, 02, 03),
                FilterEndDate = new DateTime(2017, 02, 07),
                Priority = "High",
                Progress = 100,
                InProgress = false
            };

            BusinessObject Child4 = new BusinessObject()
            {
                TaskId = 5,
                TaskName = "Planning complete",
                FilterStartDate = new DateTime(2017, 02, 07),
                FilterEndDate = new DateTime(2017, 02, 07),
                Priority = "Low",
                Progress = 0,
                InProgress = true
            };

            Record1.Children.Add(Child1);
            Record1.Children.Add(Child2);
            Record1.Children.Add(Child3);
            Record1.Children.Add(Child4);

            BusinessObject Record2 = new BusinessObject()
            {
                TaskId = 6,
                TaskName = "Design",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 14),
                Progress = 86,
                Priority = "High",
                InProgress = false,
                Children = new List<BusinessObject>(),
            };

            BusinessObject Child5 = new BusinessObject()
            {
                TaskId = 7,
                TaskName = "Software Specification",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Priority = "Critical",
                Progress = 60,
                InProgress = true,
            };

            BusinessObject Child6 = new BusinessObject()
            {
                TaskId = 8,
                TaskName = "Develop prototype",
                FilterStartDate = new DateTime(2017, 02, 10),
                FilterEndDate = new DateTime(2017, 02, 12),
                Priority = "Normal",
                Progress = 100,
                InProgress = false
            };

            BusinessObject Child7 = new BusinessObject()
            {
                TaskId = 9,
                TaskName = "Get approval from customer",
                FilterStartDate = new DateTime(2017, 02, 13),
                FilterEndDate = new DateTime(2017, 02, 14),
                Progress = 100,
                InProgress = true
            };

            BusinessObject Child8 = new BusinessObject()
            {
                TaskId = 10,
                TaskName = "Design complete",
                FilterStartDate = new DateTime(2017, 02, 14),
                FilterEndDate = new DateTime(2017, 02, 14),
                Priority = "High",
                Progress = 0,
                InProgress = false
            };

            Record2.Children.Add(Child5);
            Record2.Children.Add(Child6);
            Record2.Children.Add(Child7);
            Record2.Children.Add(Child8);

            BusinessObjectCollection.Add(Record1);
            BusinessObjectCollection.Add(Record2);

            return BusinessObjectCollection;
        }
    }
    public class Stage
    {
        public int id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }
    public class StageDetails
    {
        public List<Stage> GetStageCollection()
        {
            List<Stage> stageCollection = new List<Stage>();

            stageCollection.Add(new Stage() { id = 1, text = "Low", value = "Low" });
            stageCollection.Add(new Stage() { id = 2, text = "Normal", value = "Normal" });
            stageCollection.Add(new Stage() { id = 3, text = "High", value = "High" });
            stageCollection.Add(new Stage() { id = 4, text = "Critical", value = "Critical" });
            return stageCollection;
        }
    }
    public class State
    {
        public int id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }
    public class StateDetails
    {
        public List<State> GetStateCollection()
        {
            List<State> stateCollection = new List<State>();

            stateCollection.Add(new State() { id = 1, text = "Yes", value = "true" });
            stateCollection.Add(new State() { id = 2, text = "No", value = "false" });           
            return stateCollection;
        }
    }
}
