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

namespace samplebrowser.Models
{
    public class ServiceData
    {
        public string id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }
    public class localData
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string TeamLead { get; set; }
        public string Color { get; set; }
    }
    public class groups
    {
        public string text { get; set; }
        public string parentId { get; set; }
        public int id { get; set; }
        public int parent { get; set; }
    }
    public class hierarchicalData
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string fillColor { get; set; }
            
    }
    public class radialtreeData
   {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ImageUrl { get; set; }
        public string IsExpand { get; set; }
        public string RatingColor { get; set; }
        public string ReportingPerson { get; set; }
    }
    public class teamManagementData
   {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ImageUrl { get; set; }
        public string IsExpand { get; set; }
        public string RatingColor { get; set; }
        public string ReportingPerson { get; set; }
    }
    public class universityData
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string Supervision { get; set; }
        public string ChartType { get; set; }
        public string Color { get; set; }
    }
    public class Cars
    {
        public string text { get; set; }
    }

    public class organizationalData
    {
        public string Id { get; set; }
        public string Function { get; set; }
        public string Phase { get; set; }
    }
    public class businessManagementData
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string Manager { get; set; }
        public string ChartType { get; set; }
        public string color { get; set; }
    }
    public class LocalData
    {
        public string id { get; set; }
        public string text { get; set; }
        public string value { get; set; }
    }    
    public class Bikes
    {
        public string text { get; set; }
        public string empid { get; set; }
    }
    public class TreeDropDown
    {
        public int id { get; set; }
        public int pid { get; set; }
        public string name { get; set; }
        public bool hasChild { get; set; }
        public bool expanded { get; set; }
        public string spriteCss { get; set; }
    }
    public class Fonts
    {
        public string font { get; set; }
    }
    public class Books
    {
        public string category { get; set; }
        public int id { get; set; }
        public string text { get; set; }
    }
    public class EmployeeSpecialists
    {
        public string text { get; set; }
        public string eimg { get; set; }
        public string desig { get; set; }
        public string country { get; set; }
    }

    public class VegetableCollection
    {
        public string Veg { get; set; }
        public string Group { get; set; }

    }
    public class Colors
    {
        public string text { get; set; }
        public static List<Colors> GetColors()
        {
            List<Colors> color = new List<Colors>();
            color.Add(new Colors { text = "AliceBlue" });
            color.Add(new Colors { text = "AntiqueWhite" });
            color.Add(new Colors { text = "Black" });
            color.Add(new Colors { text = "Blue" });
            color.Add(new Colors { text = "Brown" });
            color.Add(new Colors { text = "Chocolate" });
            color.Add(new Colors { text = "Cyan" });
            color.Add(new Colors { text = "DarkBlue" });
            color.Add(new Colors { text = "DarkGreen" });
            color.Add(new Colors { text = "DarkRed" });
            color.Add(new Colors { text = "ForestGreen" });
            color.Add(new Colors { text = "Fuchsia" });
            color.Add(new Colors { text = "LemonChiffon" });
            color.Add(new Colors { text = "Lime" });
            color.Add(new Colors { text = "Magenta" });
            color.Add(new Colors { text = "Olive" });
            color.Add(new Colors { text = "Orange" });
            color.Add(new Colors { text = "OrangeRed" });
            color.Add(new Colors { text = "Pink" });
            color.Add(new Colors { text = "Purple" });
            color.Add(new Colors { text = "PowderBlue" });
            color.Add(new Colors { text = "Red" });
            color.Add(new Colors { text = "RosyBrown" });
            color.Add(new Colors { text = "RoyalBlue" });
            color.Add(new Colors { text = "Silver" });
            color.Add(new Colors { text = "SkyBlue" });
            color.Add(new Colors { text = "SlateGray" });
            color.Add(new Colors { text = "Tan" });
            color.Add(new Colors { text = "Teal" });
            color.Add(new Colors { text = "Turquoise" });
            color.Add(new Colors { text = "Violet" });
            color.Add(new Colors { text = "Wheat" });
            color.Add(new Colors { text = "Yellow" });
            color.Add(new Colors { text = "YellowGreen" });
            return color;
        }
    }
    public class States
    {
        public string index { get; set; }
        public string countryName { get; set; }
        public static List<States> GetStates()
        {
            List<States> state = new List<States>();
            state.Add(new States { index = "s1", countryName = "Alabama" });
            state.Add(new States { index = "s2", countryName = "Alaska" });
            state.Add(new States { index = "s3", countryName = "Arizona" });
            state.Add(new States { index = "s4", countryName = "Arkansas" });
            state.Add(new States { index = "s5", countryName = "California" });
            state.Add(new States { index = "s6", countryName = "Colorado" });
            state.Add(new States { index = "s7", countryName = "Connecticut" });
            state.Add(new States { index = "s8", countryName = "Delaware" });
            state.Add(new States { index = "s9", countryName = "Florida" });
            state.Add(new States { index = "s10", countryName = "Georgia" });
            state.Add(new States { index = "s11", countryName = "Hawaii" });
            state.Add(new States { index = "s12", countryName = "Idaho" });
            state.Add(new States { index = "s13", countryName = "Illinois" });
            state.Add(new States { index = "s14", countryName = "Indiana" });
            state.Add(new States { index = "s15", countryName = "Iowa" });
            state.Add(new States { index = "s16", countryName = "Kansas" });
            state.Add(new States { index = "s17", countryName = "Kentucky" });
            state.Add(new States { index = "s18", countryName = "Louisiana" });
            state.Add(new States { index = "s19", countryName = "Maine" });
            state.Add(new States { index = "s20", countryName = "Maryland" });
            state.Add(new States { index = "s21", countryName = "Massachusetts" });
            state.Add(new States { index = "s22", countryName = "Michigan" });
            state.Add(new States { index = "s23", countryName = "Montana" });
            state.Add(new States { index = "s24", countryName = "New Mexico" });
            state.Add(new States { index = "s25", countryName = "New York" });
            state.Add(new States { index = "s26", countryName = "North Carolina" });
            state.Add(new States { index = "s27", countryName = "Nevada" });
            state.Add(new States { index = "s28", countryName = "New Jersey" });
            state.Add(new States { index = "s29", countryName = "Pennsylvania" });
            state.Add(new States { index = "s30", countryName = "Ohio" });
            state.Add(new States { index = "s31", countryName = "Rhode Island" });
            state.Add(new States { index = "s32", countryName = "South Carolina" });
            state.Add(new States { index = "s33", countryName = "Tennessee" });
            state.Add(new States { index = "s34", countryName = "Utah" });
            state.Add(new States { index = "s35", countryName = "Virginia" });
            state.Add(new States { index = "s36", countryName = "Washington" });
            return state;
        }
    }

    public class Languages
    {
        public string text { get; set; }
        public string skill { get; set; }
        public static List<Languages> GetLanguages()
        {
            List<Languages> language = new List<Languages>();
            language.Add(new Languages { text = "ActionScript" });
            language.Add(new Languages { text = "AppleScript" });
            language.Add(new Languages { text = "Asp" });
            language.Add(new Languages { text = "BASIC" });
            language.Add(new Languages { text = "BeanShell" });
            language.Add(new Languages { text = "C" });
            language.Add(new Languages { text = "C++" });
            language.Add(new Languages { text = "C#" });
            language.Add(new Languages { text = "Clojure" });
            language.Add(new Languages { text = "COBOL" });
            language.Add(new Languages { text = "ColdFusion" });
            language.Add(new Languages { text = "DataFlex" });
            language.Add(new Languages { text = "DCL" });
            language.Add(new Languages { text = "Erlang" });
            language.Add(new Languages { text = "E#" });
            language.Add(new Languages { text = "Fortran" });
            language.Add(new Languages { text = "F#" });
            language.Add(new Languages { text = "Flex" });
            language.Add(new Languages { text = "Google Apps Script" });
            language.Add(new Languages { text = "Groovy" });
            language.Add(new Languages { text = "Haskell" });
            language.Add(new Languages { text = "Hope" });
            language.Add(new Languages { text = "IBM HAScript" });
            language.Add(new Languages { text = "Java" });
            language.Add(new Languages { text = "JavaScript" });
            language.Add(new Languages { text = "J#" });
            language.Add(new Languages { text = "Lisp" });
            language.Add(new Languages { text = "MATLAB" });
            language.Add(new Languages { text = "Oak" });
            language.Add(new Languages { text = "Perl" });
            language.Add(new Languages { text = "PHP" });
            language.Add(new Languages { text = "Python" });
            language.Add(new Languages { text = "Ruby" });
            language.Add(new Languages { text = "Scala" });
            language.Add(new Languages { text = "Scheme" });
            language.Add(new Languages { text = "T-SQL" });
            language.Add(new Languages { text = "WebQL" });
            language.Add(new Languages { text = "ZOPL" });
            return language;
        }
    }

    public class Flowers
    {
        public string text { get; set; }
        public static List<Flowers> GetFlowers()
        {
            List<Flowers> flower = new List<Flowers>();
            flower.Add(new Flowers { text = "Anemone Galilee" });
            flower.Add(new Flowers { text = "Allium drumstick" });
            flower.Add(new Flowers { text = "Artichoke thistle" });
            flower.Add(new Flowers { text = "Boronia" });
            flower.Add(new Flowers { text = "Bouvardia" });
            flower.Add(new Flowers { text = "Blue lace flower" });
            flower.Add(new Flowers { text = "Bird of paradise" });
            flower.Add(new Flowers { text = "Cone flower" });
            flower.Add(new Flowers { text = "Cosmos" });
            flower.Add(new Flowers { text = "Calla lily white" });
            flower.Add(new Flowers { text = "Common Yarrow" });
            flower.Add(new Flowers { text = "Delphinium Belladonna" });
            flower.Add(new Flowers { text = "Daffodil" });
            flower.Add(new Flowers { text = "Freesia" });
            flower.Add(new Flowers { text = "Foxtail fern" });
            flower.Add(new Flowers { text = "Gayfeather" });
            flower.Add(new Flowers { text = "Gardenia" });
            flower.Add(new Flowers { text = "Heather" });
            flower.Add(new Flowers { text = "Hydrangea" });
            flower.Add(new Flowers { text = "Ivy" });
            flower.Add(new Flowers { text = "Japhette orchid" });
            flower.Add(new Flowers { text = "Kangaroo paw yellow" });
            flower.Add(new Flowers { text = "Lace fern" });
            flower.Add(new Flowers { text = "Lumex" });
            flower.Add(new Flowers { text = "Mimosa" });
            flower.Add(new Flowers { text = "Moon orchid" });
            flower.Add(new Flowers { text = "Nerine" });
            flower.Add(new Flowers { text = "Paper Reed" });
            flower.Add(new Flowers { text = "Pincushion" });
            flower.Add(new Flowers { text = "Queen Anne's lace" });
            flower.Add(new Flowers { text = "Red Rover" });
            flower.Add(new Flowers { text = "Rice flower" });
            flower.Add(new Flowers { text = "Strawberry banksia" });
            flower.Add(new Flowers { text = "Saponaria" });
            flower.Add(new Flowers { text = "Thorow-wax" });
            flower.Add(new Flowers { text = "Telstar" });
            flower.Add(new Flowers { text = "Waxflower" });
            flower.Add(new Flowers { text = "Watsonia" });
            return flower;
        }
    }

    public class Flags
    {
        public string text { get; set; }
        public string key { get; set; }
        public string sprite { get; set; }
        public static List<Flags> GetFlags()
        {
            List<Flags> flag = new List<Flags>();
            flag.Add(new Flags { text = "Algeria", key = "flag-dz" });
            flag.Add(new Flags { text = "Armenia", key = "flag-am" });
            flag.Add(new Flags { text = "Brazil", key = "flag-br" });
            flag.Add(new Flags { text = "Bangladesh", key = "flag-bd" });
            flag.Add(new Flags { text = "Canada", key = "flag-ca" });
            flag.Add(new Flags { text = "Cuba", key = "flag-cu" });
            flag.Add(new Flags { text = "China", key = "flag-cn" });
            flag.Add(new Flags { text = "Denmark", key = "flag-dk" });
            flag.Add(new Flags { text = "Estonia", key = "flag-ee" });
            flag.Add(new Flags { text = "Egypt", key = "flag-eg" });
            flag.Add(new Flags { text = "France", key = "flag-fr" });
            flag.Add(new Flags { text = "Finland", key = "flag-fi" });
            flag.Add(new Flags { text = "Greenland", key = "flag-gl" });
            flag.Add(new Flags { text = "India", key = "flag-in" });
            flag.Add(new Flags { text = "Indonesia", key = "flag-id" });
            flag.Add(new Flags { text = "Malaysia", key = "flag-my" });
            flag.Add(new Flags { text = "Mexico", key = "flag-mx" });
            flag.Add(new Flags { text = "New Zealand", key = "flag-nz" });
            flag.Add(new Flags { text = "Netherlands", key = "flag-nl" });
            flag.Add(new Flags { text = "Norway", key = "flag-no" });
            flag.Add(new Flags { text = "Portugal", key = "flag-pt" });
            flag.Add(new Flags { text = "Poland", key = "flag-pl" });
            flag.Add(new Flags { text = "Qatar", key = "flag-qa" });
            flag.Add(new Flags { text = "Romania", key = "flag-ro" });
            flag.Add(new Flags { text = "Spain", key = "flag-es" });
            flag.Add(new Flags { text = "Singapore", key = "flag-sg" });
            flag.Add(new Flags { text = "Saudi Arabia", key = "flag-sa" });
            flag.Add(new Flags { text = "Thailand", key = "flag-th" });
            flag.Add(new Flags { text = "Turkey", key = "flag-tr" });
            flag.Add(new Flags { text = "Ukraine", key = "flag-ua" });
            flag.Add(new Flags { text = "United States", key = "flag-us" });
            flag.Add(new Flags { text = "Uruguay", key = "flag-uy" });
            flag.Add(new Flags { text = "Viet Nam", key = "flag-vn" });
            return flag;
        }
    }

    public class Countries
    {
        public string text { get; set; }
        public string category { get; set; }
        public int value { get; set; }
        public string parentId { get; set; }
        public string sprite { get; set; }
        public string country { get; set; }
        public int id { get; set; }
        public int parent { get; set; }
        public static List<Countries> GetCountries()
        {
            List<Countries> country = new List<Countries>();
            country.Add(new Countries { text = "Austria", category = "A" });
            country.Add(new Countries { text = "Australia", category = "A" });
            country.Add(new Countries { text = "Antarctica", category = "A" });
            country.Add(new Countries { text = "Bangladesh", category = "B" });
            country.Add(new Countries { text = "Brazil", category = "B" });
            country.Add(new Countries { text = "Canada", category = "C" });
            country.Add(new Countries { text = "Cuba", category = "C" });
            country.Add(new Countries { text = "Denmark", category = "D" });
            country.Add(new Countries { text = "Dominica", category = "D" });
            country.Add(new Countries { text = "Europe", category = "E" });
            country.Add(new Countries { text = "Egypt", category = "E" });
            country.Add(new Countries { text = "England", category = "E" });
            country.Add(new Countries { text = "India", category = "I" });
            country.Add(new Countries { text = "Indonesia", category = "I" });
            country.Add(new Countries { text = "Ireland", category = "I" });
            country.Add(new Countries { text = "Italy", category = "I" });
            country.Add(new Countries { text = "France", category = "F" });
            country.Add(new Countries { text = "Finland", category = "F" });
            country.Add(new Countries { text = "Germany", category = "G" });
            country.Add(new Countries { text = "Greece", category = "G" });
            country.Add(new Countries { text = "Greenland", category = "G" });
            country.Add(new Countries { text = "Haiti", category = "H" });
            country.Add(new Countries { text = "Hong Kong", category = "H" });
            country.Add(new Countries { text = "Japan", category = "J" });
            country.Add(new Countries { text = "Jordan", category = "J" });
            country.Add(new Countries { text = "Jamaica", category = "J" });
            country.Add(new Countries { text = "Kenya", category = "K" });
            country.Add(new Countries { text = "Kuwait", category = "K" });
            country.Add(new Countries { text = "Korea", category = "K" });
            country.Add(new Countries { text = "Latvia", category = "L" });
            country.Add(new Countries { text = "Lebanon", category = "L" });
            country.Add(new Countries { text = "Leichenstein", category = "L" });
            country.Add(new Countries { text = "Malaysia", category = "M" });
            country.Add(new Countries { text = "Mexico", category = "M" });
            country.Add(new Countries { text = "Mozambique", category = "M" });
            country.Add(new Countries { text = "Madagascar", category = "M" });
            country.Add(new Countries { text = "Midway Islands", category = "M" });
            country.Add(new Countries { text = "Nepal", category = "N" });
            country.Add(new Countries { text = "New Zealand", category = "N" });
            country.Add(new Countries { text = "Oman", category = "O" });
            country.Add(new Countries { text = "Philippines", category = "P" });
            country.Add(new Countries { text = "Poland", category = "P" });
            country.Add(new Countries { text = "Qatar", category = "Q" });
            country.Add(new Countries { text = "Romania", category = "R" });
            country.Add(new Countries { text = "Russia", category = "R" });
            country.Add(new Countries { text = "Switzerland", category = "S" });
            country.Add(new Countries { text = "Sweden", category = "S" });
            country.Add(new Countries { text = "Scotland", category = "S" });
            country.Add(new Countries { text = "Tibet", category = "T" });
            country.Add(new Countries { text = "Turkey", category = "T" });
            country.Add(new Countries { text = "United States", category = "U" });
            country.Add(new Countries { text = "Uruguay", category = "U" });
            country.Add(new Countries { text = "Vatican City", category = "V" });
            country.Add(new Countries { text = "Vietnam", category = "V" });
            country.Add(new Countries { text = "Zambia", category = "Z" });
            country.Add(new Countries { text = "Zimbabwe", category = "Z" });
            return country;
        }
    }
    public class WebsiteCollection
    {
        public string text { get; set; }
        public string url { get; set; }
        public int frequency { get; set; }
    }
    public class PlacesData
    {

        public PlacesData(int _id, string _text)
        {
            this.ID = _id;
            this.Text = _text;
        }
        public PlacesData()
        {

        }

        public int ID
        {
            get;
            set;
        }
        public string Text
        {
            get;
            set;
        }

        public List<PlacesData> GetLocation()
        {
            List<PlacesData> data = new List<PlacesData>();
            data.Add(new PlacesData(1, "Amsterdam"));
            data.Add(new PlacesData(2, "Warsaw"));
            data.Add(new PlacesData(3, "Emmerich am Rhein"));
            data.Add(new PlacesData(4, "Berlin"));
            data.Add(new PlacesData(5, "Konin"));
            data.Add(new PlacesData(6, "Moscow"));
            data.Add(new PlacesData(7, "Poznan"));
            data.Add(new PlacesData(8, "Milan"));
            data.Add(new PlacesData(9, "Paris"));
            data.Add(new PlacesData(10, "Brussels"));
            data.Add(new PlacesData(11, "Strasbourg"));
            data.Add(new PlacesData(12, "Chur"));
            data.Add(new PlacesData(3, "Budapest"));
            data.Add(new PlacesData(4, "Vienna"));
            data.Add(new PlacesData(5, "Prague"));
            data.Add(new PlacesData(6, "Dortmund"));
            data.Add(new PlacesData(7, "Cologne"));
            data.Add(new PlacesData(8, "Munchen"));
            data.Add(new PlacesData(9, "Tonio"));
            return data;
        }
    }
    public class GenDropDown
    {
        public GenDropDown() { }
        public GenDropDown(int _id, string _text)
        {
            this.ID = _id;
            this.GText = _text;
        }
        public int ID
        {
            get;
            set;
        }
        public string GText { get; set; }
        public List<GenDropDown> GetGenList()
        {
            List<GenDropDown> gdata = new List<GenDropDown>();
            gdata.Add(new GenDropDown(1, "Male"));
            gdata.Add(new GenDropDown(2, "Female"));
            return gdata;
        }
    }
    public class BerthDropDown
    {
        public BerthDropDown() { }
        public BerthDropDown(int _id, string _text)
        {
            this.ID = _id;
            this.BerthPref = _text;
        }
        public int ID
        {
            get;
            set;
        }
        public string BerthPref { get; set; }
        public List<BerthDropDown> GetBerthList()
        {
            List<BerthDropDown> bdata = new List<BerthDropDown>();
            bdata.Add(new BerthDropDown(1, "Upper"));
            bdata.Add(new BerthDropDown(2, "Lower"));
            bdata.Add(new BerthDropDown(3, "Window"));
            bdata.Add(new BerthDropDown(4, "Middle"));
            bdata.Add(new BerthDropDown(5, "Aisel"));
            return bdata;
        }
    }
    public class TrainsList
    {
        public TrainsList()
        {

        }
        public TrainsList(string TrainNo, string TrainName, string Depature, string Arrival,
            int Availability)
        {
            this.TrainNo = TrainNo;
            this.TrainName = TrainName;
            this.Depature = Depature;
            this.Arrival = Arrival;
            this.Availability = Availability;
        }
        public string TrainNo { get; set; }
        public string TrainName { get; set; }
        public string Depature { get; set; }
        public string Arrival { get; set; }
        public int Availability { get; set; }

        public List<TrainsList> GetTrainDetails()
        {
            List<TrainsList> trains = new List<TrainsList>();
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Amsterdam", "Warsaw", 4));
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Berlin", "Moscow", 23));
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Berlin", "Konin", 14));
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Emmerich am Rhein", "Warsaw", 73));
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Warsaw", "Amsterdam", 14));
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Konin", "Berlin", 203));
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Moscow", "Berlin", 33));
            trains.Add(new TrainsList("EN447", "JAN KIEPURA 2", "Warsaw", "Emmerich am Rhein", 63));
            trains.Add(new TrainsList("EC41", "Berlin-Warszawa-Express", "Berlin", "Poznan", 65));
            trains.Add(new TrainsList("EC41", "Berlin-Warszawa-Express", "Berlin", "Warsaw", 96));
            trains.Add(new TrainsList("EC41", "Berlin-Warszawa-Express", "Poznan", "Berlin", 86));
            trains.Add(new TrainsList("EC41", "Berlin-Warszawa-Express", "Warsaw", "Berlin", 54));
            trains.Add(new TrainsList("EC9242", "EC Dumas", "Milan", "Paris", 23));
            trains.Add(new TrainsList("EC9242", "EC Dumas", "Milan", "Tonio", 53));
            trains.Add(new TrainsList("EC9242", "EC Dumas", "Paris", "Milan", 30));
            trains.Add(new TrainsList("EC9242", "EC Dumas", "Tonio", "Milan", 93));
            trains.Add(new TrainsList("EC96", "EC Iris", "Brussels", "Chur", 73));
            trains.Add(new TrainsList("EC96", "EC Iris", "Brussels", "Strasbourg", 5));
            trains.Add(new TrainsList("EC96", "EC Iris", "Strasbourg", "Chur", 32));
            trains.Add(new TrainsList("EC96", "EC Iris", "Chur", "Brussels", 59));
            trains.Add(new TrainsList("EC96", "EC Iris", "Chur", "Strasbourg", 7));
            trains.Add(new TrainsList("EC96", "EC Iris", "Strasbourg", "Brussels", 123));
            trains.Add(new TrainsList("EN466", "Wiener Walzer", "Budapest", "Vienna", 43));
            trains.Add(new TrainsList("EN466", "Wiener Walzer", "Budapest", "Prague", 39));
            trains.Add(new TrainsList("EN466", "Wiener Walzer", "Vienna", "Budapest", 23));
            trains.Add(new TrainsList("EN466", "Wiener Walzer", "Prague", "Budapest", 3));
            trains.Add(new TrainsList("TEE21", "Rheinpfeil", "Dortmund", "Cologne", 95));
            trains.Add(new TrainsList("TEE21", "Rheinpfeil", "Dortmund", "München", 13));
            trains.Add(new TrainsList("TEE21", "Rheinpfeil", "Cologne", "Dortmund", 213));
            trains.Add(new TrainsList("TEE21", "Rheinpfeil", "München", "Dortmund", 350));
            return trains;
        }
    }
    public class MenuJson
    {
        public string mtext { get; set; }
        public string sprite { get; set; }
        public int pid { get; set; }
        public string parent { get; set; }
    }

    public class ToolbarOrientation
    {
        public string edid { get; set; }
        public string spriteCss { get; set; }
    }

    public class ToolbarLocalBinding
    {
        public string empid { get; set; }
        public string spriteCss { get; set; }
        public string text { get; set; }
        public string group { get; set; }

    }
    public class ToolbarMethods
    {
        public string text { get; set; }
        public string value { get; set; }
    }

    public class ListData
    {
        public string texts { get; set; }
    }
    public static class ListDataModal
    {
        public static List<ListData> listTempSource = new List<ListData>();
        public static List<ListData> setListDataSource()
        {
            listTempSource.Add(new ListData { texts = "Discover Music" });
            listTempSource.Add(new ListData { texts = "Sales and Events" });
            listTempSource.Add(new ListData { texts = "Categories" });
            listTempSource.Add(new ListData { texts = "MP3 Albums" });
            listTempSource.Add(new ListData { texts = "More in Music" });
            return listTempSource;
        }
        public static void clearSource()
        {
            listTempSource.Clear();
        }
    }
        
    public class CarsList
    {
        public int uniqueKey { get; set; }
        public string text { get; set; }
        public string company { get; set; }
        public static List<CarsList> GetCarList()
        {
            List<CarsList> car = new List<CarsList>();
            car.Add(new CarsList { text = "Audi S6" });
            car.Add(new CarsList { text = "Austin-Healey" });
            car.Add(new CarsList { text = "Alfa Romeo" });
            car.Add(new CarsList { text = "Aston Martin" });
            car.Add(new CarsList { text = "BMW 7" });
            car.Add(new CarsList { text = "Bentley Mulsanne" });
            car.Add(new CarsList { text = "Bugatti Veyron" });
            car.Add(new CarsList { text = "Chevrolet Camaro" });
            car.Add(new CarsList { text = "Cadillac" });
            car.Add(new CarsList { text = "Duesenberg J" });
            car.Add(new CarsList { text = "Dodge Sprinter" });
            car.Add(new CarsList { text = "Elantra" });
            car.Add(new CarsList { text = "Excavator" });
            car.Add(new CarsList { text = "Ford Boss 302" });
            car.Add(new CarsList { text = "Ferrari 360" });
            car.Add(new CarsList { text = "Ford Thunderbird" });
            car.Add(new CarsList { text = "GAZ Siber" });
            car.Add(new CarsList { text = "Honda S2000" });
            car.Add(new CarsList { text = "Hyundai Santro" });
            car.Add(new CarsList { text = "Isuzu Swift" });
            car.Add(new CarsList { text = "Infiniti Skyline" });
            car.Add(new CarsList { text = "Jaguar XJS" });
            car.Add(new CarsList { text = "Kia Sedona EX" });
            car.Add(new CarsList { text = "Koenigsegg Agera" });
            car.Add(new CarsList { text = "Lotus Esprit" });
            car.Add(new CarsList { text = "Lamborghini Diablo" });
            car.Add(new CarsList { text = "Mercedes-Benz" });
            car.Add(new CarsList { text = "Mercury Coupe" });
            car.Add(new CarsList { text = "Maruti Alto 800" });
            car.Add(new CarsList { text = "Nissan Qashqai" });
            car.Add(new CarsList { text = "Oldsmobile S98" });
            car.Add(new CarsList { text = "Opel Superboss" });
            car.Add(new CarsList { text = "Porsche 356" });
            car.Add(new CarsList { text = "Pontiac Sunbird" });
            car.Add(new CarsList { text = "Scion SRS/SC/SD" });
            car.Add(new CarsList { text = "Saab Sportcombi" });
            car.Add(new CarsList { text = "Subaru Sambar" });
            car.Add(new CarsList { text = "Suzuki Swift" });
            car.Add(new CarsList { text = "Triumph Spitfire" });
            car.Add(new CarsList { text = "Toyota 2000GT" });
            car.Add(new CarsList { text = "Volvo P1800" });
            car.Add(new CarsList { text = "Volkswagen Shirako" });
            return car;
        }
    }

    public class IconCss
    {
        public string Name { get; set; }
        public string IconClass { get; set; }
        public static List<IconCss> GetIconList()
        {
            List<IconCss> icon = new List<IconCss>();
            icon.Add(new IconCss { Name = "Categorize and Move", IconClass = "mailtools categorize" });
            icon.Add(new IconCss { IconClass = "mailtools done", Name = "Done" });
            icon.Add(new IconCss { IconClass = "mailtools flag", Name = "Flag & Move" });
            icon.Add(new IconCss { IconClass = "mailtools forward", Name = "Forward" });
            icon.Add(new IconCss { IconClass = "mailtools movetofolder", Name = "Move to Folder" });
            icon.Add(new IconCss { IconClass = "mailtools newmail", Name = "New E-mail" });
            icon.Add(new IconCss { IconClass = "mailtools meeting", Name = "New Meeting" });
            icon.Add(new IconCss { IconClass = "mailtools reply", Name = "Reply & Delete" });
            return icon;
        }
    }

    public class empList
    {
        public string text { get; set; }
        public string eimg { get; set; }
        public string status { get; set; }
        public string country { get; set; }
        public static List<empList> GetEmpList()
        {
            List<empList> emp = new List<empList>();
            emp.Add(new empList { text = "Natalie", eimg = "1", status = "Available", country = "USA" });
            emp.Add(new empList { text = "John Linden", eimg = "2", status = "Available", country = "USA" });
            emp.Add(new empList { text = "Erik Linden", eimg = "3", status = "Available", country = "England" });
            emp.Add(new empList { text = "Leverling", eimg = "4", status = "Available", country = "England" });
            emp.Add(new empList { text = "Suyama", eimg = "5", status = "Available", country = "USA" });
            return emp;
        }
    }

    public class ListLocalData
    {
        public string texts { get; set; }
        public string primaryKeys { get; set; }
        public string parentPrimaryKeyss { get; set; }
    }
    public static class ListLocalDataModal
    {
        public static List<ListLocalData> listSource = new List<ListLocalData>();
        public static List<ListLocalData> setListSource()
        {
            listSource.Add(new ListLocalData { texts = "Discover Music", primaryKeys = "1" });
            listSource.Add(new ListLocalData { texts = "Hot Singles", parentPrimaryKeyss = "1" });
            listSource.Add(new ListLocalData { texts = "Rising Artists", parentPrimaryKeyss = "1" });
            listSource.Add(new ListLocalData { texts = "Live Music", parentPrimaryKeyss = "1" });
            listSource.Add(new ListLocalData { texts = "Best of 2013 So Far", parentPrimaryKeyss = "1" });

            listSource.Add(new ListLocalData { texts = "Sales and Events", primaryKeys = "2" });
            listSource.Add(new ListLocalData { texts = "100 Albums - $5 Each", parentPrimaryKeyss = "2" });
            listSource.Add(new ListLocalData { texts = "Hip-Hop and R&B Sale", parentPrimaryKeyss = "2" });
            listSource.Add(new ListLocalData { texts = "CD Deals", parentPrimaryKeyss = "2" });

            listSource.Add(new ListLocalData { texts = "Categories", primaryKeys = "3" });
            listSource.Add(new ListLocalData { texts = "Songs", parentPrimaryKeyss = "3" });
            listSource.Add(new ListLocalData { texts = "Bestselling Albums", parentPrimaryKeyss = "3" });
            listSource.Add(new ListLocalData { texts = "New Releases", parentPrimaryKeyss = "3" });
            listSource.Add(new ListLocalData { texts = "Bestselling Songs", parentPrimaryKeyss = "3" });

            listSource.Add(new ListLocalData { texts = "MP3 Albums", primaryKeys = "4" });
            listSource.Add(new ListLocalData { texts = "Rock", parentPrimaryKeyss = "4" });
            listSource.Add(new ListLocalData { texts = "Gospel", parentPrimaryKeyss = "4" });
            listSource.Add(new ListLocalData { texts = "Latin Music", parentPrimaryKeyss = "4" });
            listSource.Add(new ListLocalData { texts = "Jazz", parentPrimaryKeyss = "4" });

            listSource.Add(new ListLocalData { texts = "More in Music", primaryKeys = "5" });
            listSource.Add(new ListLocalData { texts = "Music Trade-In", parentPrimaryKeyss = "5" });
            listSource.Add(new ListLocalData { texts = "Redeem a Gift Card", parentPrimaryKeyss = "5" });
            listSource.Add(new ListLocalData { texts = "Band T-Shirts", parentPrimaryKeyss = "5" });
            listSource.Add(new ListLocalData { texts = "Mobile MVC", parentPrimaryKeyss = "5" });

            return listSource;
        }
        public static void clearSource()
        {
            listSource.Clear();
        }
    }
}
