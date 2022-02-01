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
using Syncfusion.JavaScript.Shared.Serializer;
using System.ComponentModel;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Syncfusion.JavaScript.DataVisualization.HeatMapEnums;
using System.Threading.Tasks;
using samplebrowser.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.HeatMap
{
    public partial class HeatMapController : Controller
    {
        // GET: /<controller>/
        public ActionResult Virtualization()
        {
            TableMapping TableMapping = new TableMapping();
            TableMapping.HeaderMapping = new HeaderMapping() { PropertyName = "Year", DisplayName = "Year", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Right } };
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "January", DisplayName = "January" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "February", DisplayName = "February" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "March", DisplayName = "March" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "April", DisplayName = "April" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "May", DisplayName = "May" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "June", DisplayName = "June" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "July", DisplayName = "July" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "August", DisplayName = "August" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "September", DisplayName = "September" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "October", DisplayName = "October" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "November", DisplayName = "November" });
            TableMapping.ColumnMapping.Add(new HeaderMapping() { PropertyName = "December", DisplayName = "December" });
            ViewBag.itemsource = GetVirtualSource();
            ViewBag.itemsmapping = TableMapping;
            List<string> collection = new List<string>();
            collection.Add("heatmapLegend");
            ViewBag.legendcollection = collection;
            return View();
        }
        public sealed class attribute : Attribute
        {

        }
        public Collection GetVirtualSource()
        {
            Collection collection = new Collection();
            Random random = new Random();
            for (int i = 0; i < 900; i++)
            {
                collection.Add(new HeatMapVirtualData()
                {
                    Year = 2016 - i,
                    Jan = random.Next(0, 100),
                    Feb = random.Next(0, 100),
                    Mar = random.Next(0, 100),
                    Apr = random.Next(0, 100),
                    May = random.Next(0, 100),
                    Jun = random.Next(0, 100),
                    Jul = random.Next(0, 100),
                    Aug = random.Next(0, 100),
                    Sep = random.Next(0, 100),
                    Oct = random.Next(0, 100),
                    Nov = random.Next(0, 100),
                    Dec = random.Next(0, 100),
                });
            }
            return collection;
        }

        [Serializable]
        public class HeatMapVirtualData
        {
            private double year;
            [JsonProperty("Year")]
            [DefaultValue("")]
            public double Year
            {
                get { return year; }
                set { year = value; }
            }

            private double jan;
            [JsonProperty("January")]
            [DefaultValue("")]
            public double Jan
            {
                get { return jan; }
                set { jan = value; }
            }
            private double feb;
            [JsonProperty("February")]
            [DefaultValue("")]
            public double Feb
            {
                get { return feb; }
                set { feb = value; }
            }

            private double mar;
            [JsonProperty("March")]
            [DefaultValue("")]
            public double Mar
            {
                get { return mar; }
                set { mar = value; }
            }

            private double apr;
            [JsonProperty("April")]
            [DefaultValue("")]
            public double Apr
            {
                get { return apr; }
                set { apr = value; }
            }

            private double may;
            [JsonProperty("May")]
            [DefaultValue("")]
            public double May
            {
                get { return may; }
                set { may = value; }
            }

            private double jun;
            [JsonProperty("June")]
            [DefaultValue("")]
            public double Jun
            {
                get { return jun; }
                set { jun = value; }
            }

            private double jul;
            [JsonProperty("July")]
            [DefaultValue("")]
            public double Jul
            {
                get { return jul; }
                set { jul = value; }
            }

            private double aug;
            [JsonProperty("August")]
            [DefaultValue("")]
            public double Aug
            {
                get { return aug; }
                set { aug = value; }
            }

            private double sep;
            [JsonProperty("September")]
            [DefaultValue("")]
            public double Sep
            {
                get { return sep; }
                set { sep = value; }
            }

            private double oct;
            [JsonProperty("October")]
            [DefaultValue("")]
            public double Oct
            {
                get { return oct; }
                set { oct = value; }
            }

            private double nov;
            [JsonProperty("November")]
            [DefaultValue("")]
            public double Nov
            {
                get { return nov; }
                set { nov = value; }
            }

            private double dec;
            [JsonProperty("December")]
            [DefaultValue("")]
            public double Dec
            {
                get { return dec; }
                set { dec = value; }
            }
        }
    }
}
