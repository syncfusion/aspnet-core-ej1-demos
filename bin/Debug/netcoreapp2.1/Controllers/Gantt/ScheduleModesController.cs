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
using Microsoft.AspNetCore.Mvc;
using Syncfusion.JavaScript;

namespace samplebrowser.Controllers
{
    public partial class GanttController : Controller
    {
        //
        // GET: /ScheduleModes/

        public ActionResult GanttScheduleModes()
        {
            var datasource = GanttScheduleModeData.GetDataSource();
            ViewBag.datasource = datasource;
            return View();
        }

        public class GanttScheduleModeData
        {
            #region Create DataSource for Gantt control
            public static List<ScheduleModeData> GetDataSource()
            {
                List<ScheduleModeData> list = new List<ScheduleModeData>();
                list.Add(new ScheduleModeData()
                {
                    TaskID = 1,
                    TaskName = "Parent Task 1",
                    StartDate = "02/27/2017",
                    EndDate = "03/03/2017",
                    Progress = "40",
                    Children = (new List<ScheduleModeData>()
                    {
                        new ScheduleModeData()
                        {
                            TaskID = 2,
                            TaskName = "Child Task 1",
                            StartDate = "02/27/2017",
                            EndDate = "03/03/2017",
                            Progress = "40",
                        },
                        new ScheduleModeData()
                        {
                            TaskID = 3,
                            TaskName = "Child Task 2",
                            StartDate = "02/27/2017",
                            EndDate = "03/03/2017",
                            Progress = "40"
                        },
                        new ScheduleModeData()
                        {
                            TaskID = 4,
                            TaskName = "Child Task 3",
                            StartDate = "02/27/2017",
                            EndDate = "03/03/2017",
                            Progress = "40"
                        }
                    })

                });

                list.Add(new ScheduleModeData()
                {
                    TaskID = 5,
                    TaskName = "Parent Task 2",
                    StartDate = "03/18/2017",
                    EndDate = "03/22/2017",
                    Progress = "40",
                    Children = (new List<ScheduleModeData>()
                    {
                        new ScheduleModeData()
                        {
                            TaskID = 6,
                            TaskName = "Child Task 1",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Progress = "40",
                        },
                        new ScheduleModeData()
                        {
                            TaskID = 7,
                            TaskName = "Child Task 2",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Progress = "40",
                        },
                        new ScheduleModeData()
                        {
                            TaskID = 8,
                            TaskName = "Child Task 3",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Progress = "40",
                        },
                         new ScheduleModeData()
                        {
                            TaskID = 9,
                            TaskName = "Child Task 4",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            Progress = "40",
                        }
                    })

                });
                list.Add(new ScheduleModeData()
                {
                    TaskID = 10,
                    TaskName = "Parent Task 3",
                    StartDate = "03/13/2017",
                    EndDate = "03/17/2017",
                    Progress = "40",

                    Children = (new List<ScheduleModeData>()
                    {
                        new ScheduleModeData()
                        {

                            TaskID = 11,
                            TaskName = "Child Task 1",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Progress = "40"
                        },
                        new ScheduleModeData()
                        {
                            TaskID = 12,
                            TaskName = "Child Task 2",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Progress = "40",
                        },
                        new ScheduleModeData()
                        {
                            TaskID = 13,
                            TaskName = "Child Task 3",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Progress = "40"
                        }
                    })

                });

                return list;
            }
            #endregion
        }
        #region ScheduleModeData Creation
        public class ScheduleModeData
        {
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int TaskID { get; set; }
            public string TaskName { get; set; }
            public string Progress { get; set; }
            public List<ScheduleModeData> Children { get; set; }
        }
        #endregion
    }
}
