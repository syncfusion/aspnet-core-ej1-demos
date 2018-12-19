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

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers

{
    public partial class TagCloudController : Controller
    {
        //
        // GET: /TagCloudEvents/
        List<WebsiteCollection> cars = new List<WebsiteCollection>(); 
        public ActionResult Events()
        {
            cars.Add(new WebsiteCollection { text = "Hindustan Motors", url = "//www.zigwheels.com/newcars/Hindustan-Motors", frequency = 10 });
            cars.Add(new WebsiteCollection { text = "Bentley Continental ", url = "//www.zigwheels.com/newcars/Bentley/Continental", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "BMW 7", url = "//www.zigwheels.com/newcars/BMW/7-Series", frequency = 8 });
            cars.Add(new WebsiteCollection { text = "Bugatti Veyron", url = "//www.zigwheels.com/newcars/Bugatti/Veyron", frequency = 2 });
            cars.Add(new WebsiteCollection { text = "Honda", url = "//www.zigwheels.com/newcars/Honda", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "Chevrolet Beat", url = "//www.zigwheels.com/newcars/Chevrolet/Beat", frequency = 7 });
            cars.Add(new WebsiteCollection { text = "Force Motors", url = "//www.zigwheels.com/newcars/Force-Motors/Gurkha", frequency = 5 });
            cars.Add(new WebsiteCollection { text = "Ford", url = "//www.zigwheels.com/newcars/Ford", frequency = 8 });
            cars.Add(new WebsiteCollection { text = "Ferrari FF", url = "//www.zigwheels.com/newcars/Ferrari/FF", frequency = 5 });
            cars.Add(new WebsiteCollection { text = "Audi A7", url = "//www.zigwheels.com/newcars/Audi/A7", frequency = 20 });
            cars.Add(new WebsiteCollection { text = "HM Mitsubishi", url = "//www.zigwheels.com/newcars/HM-Mitsubishi", frequency = 1 });
            cars.Add(new WebsiteCollection { text = "Hyundai Santro", url = "//www.zigwheels.com/newcars/Hyundai/Santro-Xing", frequency = 9 });
            cars.Add(new WebsiteCollection { text = "Jaguar XKR", url = "//www.zigwheels.com/newcars/Jaguar/XKR", frequency = 0 });
            cars.Add(new WebsiteCollection { text = "Rolls Royce", url = "//www.zigwheels.com/newcars/Rolls-Royce", frequency = 6 });
            cars.Add(new WebsiteCollection { text = "Land Rover Range", url = "//www.zigwheels.com/newcars/Land-Rover/Range-Rover", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "Mercedes Benz", url = "//www.zigwheels.com/newcars/Mercedes-Benz/A-Class", frequency = 3 });
            cars.Add(new WebsiteCollection { text = "Lamborghini", url = "//www.zigwheels.com/newcars/Lamborghini/Gallardo", frequency = 14 });
            cars.Add(new WebsiteCollection { text = "Volvo S60", url = "//www.zigwheels.com/newcars/Volvo/S60", frequency = 1 });
            ViewBag.datasource = cars;
            return View();
        }

    }
}
