var dayData = [
          {
              "TaskID": 1,
              "TaskName": "Parent Task 1",
              "StartDate": "02/23/2014",
              "duration":7,
              "Progress": "40",
              "Children": [
                   { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": "02/23/2014 08:00:00 AM", "duration": 7, "Progress": "40" },
                   { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": "02/23/2014 08:00:00 AM", "duration": 7, "Progress": "40", },
                   { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": "02/23/2014 08:00:00 AM", "duration": 7, "Progress": "40", }
              ]
          },
          {
              "TaskID": 5,
              "TaskName": "Parent Task 2",
              "StartDate": "02/24/2014",
              "duration": 7,
              "Progress": "40",
              "Children": [
                   { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": "02/23/2014 10:00:00 PM", "duration": 7, "Progress": "40" },
                   { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": "02/23/2014 10:00:00 PM", "duration": 7, "Progress": "40", },
                   { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": "02/23/2014 10:00:00 PM", "duration": 7, "Progress": "40", },
                   { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": "02/23/2014 10:00:00 PM", "duration": 7, "Progress": "40" }
              ]
          },
          {
              "TaskID": 10,
              "TaskName": "Parent Task 3",
              "StartDate": "02/25/2014",
              "duration": 7,
              "Progress": "40",
              "Children": [
                   { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": "02/24/2014 12:00:00 PM", "duration": 7, "Progress": "40" },
                   { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": "02/24/2014 12:00:00 PM", "duration": 7, "Progress": "40", },
                   { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": "02/24/2014 12:00:00 PM", "duration": 7, "Progress": "40", },
                   { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": "02/24/2014 12:00:00 PM", "duration": 7, "Progress": "40", },
                   { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": "02/24/2014 12:00:00 PM", "duration": 7, "Progress": "40", }
              ]
          }

];
var hourData = [
          {
              "TaskID": 1,
              "TaskName": "Parent Task 1",
              "StartDate": "02/23/2014",
              "duration": 40,
              "Progress": "40",
              "Children": [
                   { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": "02/23/2014 01:00:00 AM", "duration": 40, "Progress": "40" },
                   { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": "02/23/2014 01:00:00 AM", "duration": 40, "Progress": "40", },
                   { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": "02/23/2014 01:00:00 AM", "duration": 40, "Progress": "40", }
              ]
          },
          {
              "TaskID": 5,
              "TaskName": "Parent Task 2",
              "StartDate": "02/23/2014",
              "duration": 40,
              "Progress": "40",
              "Children": [
                   { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": "02/23/2014 02:00:00 AM", "duration": 40, "Progress": "40" },
                   { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": "02/23/2014 02:00:00 AM", "duration": 40, "Progress": "40", },
                   { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": "02/23/2014 02:00:00 AM", "duration": 40, "Progress": "40", },
                   { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": "02/23/2014 02:00:00 AM", "duration": 40, "Progress": "40" }
              ]
          },
          {
              "TaskID": 10,
              "TaskName": "Parent Task 3",
              "StartDate": "02/23/2014",
              "duration": 40,
              "Progress": "40",
              "Children": [
                   { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": "02/23/2014 03:00:00 AM", "duration": 40, "Progress": "40" },
                   { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": "02/23/2014 03:00:00 AM", "duration": 40, "Progress": "40", },
                   { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": "02/23/2014 03:00:00 AM", "duration": 40, "Progress": "40", },
                   { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": "02/23/2014 03:00:00 AM", "duration": 40, "Progress": "40", },
                   { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": "02/23/2014 03:00:00 AM", "duration": 40, "Progress": "40", }
              ]
          }

];
var weekData = [
     {
         "TaskID": 1,
         "TaskName": "Parent Task 1",
         "StartDate": "02/23/2014",
         "EndDate": "02/28/2014",
         "Progress": "40",
         "Children": [
              { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": "02/23/2014", "EndDate": "02/28/2014", "Progress": "40" },
              { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": "02/23/2014", "EndDate": "02/28/2014", "Progress": "40", },
              { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": "02/23/2014", "EndDate": "02/28/2014", "Progress": "40", }
         ]
     },
     {
         "TaskID": 5,
         "TaskName": "Parent Task 2",
         "StartDate": "03/03/2014",
         "EndDate": "03/07/2014",
         "Progress": "40",
         "Children": [
              { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": "03/03/2014", "EndDate": "03/07/2014", "Progress": "40" },
              { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": "03/03/2014", "EndDate": "03/07/2014", "Progress": "40", },
              { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": "03/03/2014", "EndDate": "03/07/2014", "Progress": "40", },
              { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": "03/03/2014", "EndDate": "03/07/2014", "Progress": "40" }
         ]
     },
     {
         "TaskID": 10,
         "TaskName": "Parent Task 3",
         "StartDate": "03/10/2014",
         "EndDate": "03/14/2014",
         "Progress": "40",
         "Children": [
              { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": "03/10/2014", "EndDate": "03/14/2014", "Progress": "40" },
              { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": "03/10/2014", "EndDate": "03/14/2014", "Progress": "40", },
              { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": "03/10/2014", "EndDate": "03/14/2014", "Progress": "40", },
              { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": "03/10/2014", "EndDate": "03/14/2014", "Progress": "40", },
              { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": "03/10/2014", "EndDate": "03/14/2014", "Progress": "40", }
         ]
     }

];
var monthData = [
     {
         "TaskID": 1,
         "TaskName": "Parent Task 1",
         "StartDate": "02/23/2014",
         "EndDate": "04/28/2014",
         "Progress": "40",
         "Children": [
              { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": "02/23/2014", "EndDate": "03/28/2014", "Progress": "40" },
              { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": "02/23/2014", "EndDate": "03/28/2014", "Progress": "40", },
              { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": "02/23/2014", "EndDate": "03/28/2014", "Progress": "40", }
         ]
     },
     {
         "TaskID": 5,
         "TaskName": "Parent Task 2",
         "StartDate": "05/03/2014",
         "EndDate": "07/07/2014",
         "Progress": "40",
         "Children": [
              { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": "04/13/2014", "EndDate": "05/20/2014", "Progress": "40" },
              { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": "04/13/2014", "EndDate": "05/20/2014", "Progress": "40", },
              { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": "04/13/2014", "EndDate": "05/20/2014", "Progress": "40", },
              { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": "04/13/2014", "EndDate": "05/20/2014", "Progress": "40" }
         ]
     },
     {
         "TaskID": 10,
         "TaskName": "Parent Task 3",
         "StartDate": "08/10/2014",
         "EndDate": "10/14/2014",
         "Progress": "40",
         "Children": [
              { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": "06/10/2014", "EndDate": "07/14/2014", "Progress": "40" },
              { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": "06/10/2014", "EndDate": "07/14/2014", "Progress": "40", },
              { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": "06/10/2014", "EndDate": "07/14/2014", "Progress": "40", },
              { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": "06/10/2014", "EndDate": "07/14/2014", "Progress": "40", },
              { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": "06/10/2014", "EndDate": "07/14/2014", "Progress": "40", }
         ]
     }

];
