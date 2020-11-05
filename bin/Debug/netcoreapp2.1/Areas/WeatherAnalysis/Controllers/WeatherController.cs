#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
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
using samplebrowser.Areas.WeatherAnalysis.Models;

namespace samplebrowser.Areas.WeatherAnalysis.Controllers
{ 
    [Area("WeatherAnalysis")]
   public class WeatherController : Controller
    {
        public ActionResult Index()
        {
            var DataSource = new WeatherData().GetWeatherData;
            ViewBag.datasource = DataSource;

            var AverageWeatherData = new WeatherData().AverageWeatherData;
            ViewBag.datasource1 = AverageWeatherData;

            return View();
        }       
    }
}