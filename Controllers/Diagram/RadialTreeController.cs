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
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using samplebrowser.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: /<controller>/
        public ActionResult RadialTree()
        {
            List<radialtreeData> radialtreeData = new List<radialtreeData>();
            radialtreeData.Add(new radialtreeData { Id = "parent", Name = "Maria Anders", Designation = "Managing Director", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "true", RatingColor = "#C34444" });
            radialtreeData.Add(new radialtreeData { Id = "1", Name = "Ana Trujillo", Designation = "Project Manager", ImageUrl = "../images/radialtree/Thomas.PNG", IsExpand = "false", RatingColor = "#68C2DE", ReportingPerson = "parent" });
            radialtreeData.Add(new radialtreeData { Id = "2", Name = "Lino Rodri", Designation = "Project Manager", ImageUrl = "../images/radialtree/Robin.PNG", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "parent" });
            radialtreeData.Add(new radialtreeData { Id = "3", Name = "Philip Cramer", Designation = "Project Manager", ImageUrl = "../images/radialtree/Robin.PNG", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "parent" });
            radialtreeData.Add(new radialtreeData { Id = "4", Name = "Pedro Afonso", Designation = "Project Manager", ImageUrl = "../images/radialtree/Paul.png", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "parent" });
            radialtreeData.Add(new radialtreeData { Id = "5", Name = "Anto Moreno", Designation = "Project Lead", ImageUrl = "../images/radialtree/image53.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "1" });
            radialtreeData.Add(new radialtreeData { Id = "6", Name = "Elizabeth Roel", Designation = "Project Lead", ImageUrl = "../images/radialtree/Maria.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "1" });
            radialtreeData.Add(new radialtreeData { Id = "7", Name = "Aria Cruz", Designation = "Project Lead", ImageUrl = "../images/radialtree/Jenny.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "1" });
            radialtreeData.Add(new radialtreeData { Id = "8", Name = "Eduardo Roel", Designation = "Project Lead", ImageUrl = "../images/radialtree/image55.png", IsExpand = "true", RatingColor = "#93B85A", ReportingPerson = "1" });
            radialtreeData.Add(new radialtreeData { Id = "9", Name = "Howard Snyd", Designation = "Project Lead", ImageUrl = "../images/radialtree/Jenny.png", IsExpand = "false", RatingColor = "#68C2DE", ReportingPerson = "2" });
            radialtreeData.Add(new radialtreeData { Id = "10", Name = "Daniel Tonini", Designation = "Project Lead", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "true", RatingColor = "#93B85A", ReportingPerson = "2" });
            radialtreeData.Add(new radialtreeData { Id = "11", Name = "Nardo Batista", Designation = "Project Lead", ImageUrl = "../images/radialtree/Maria.PNG", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "89" });
            radialtreeData.Add(new radialtreeData { Id = "12", Name = "Michael Holz", Designation = "Project Lead", ImageUrl = "../images/radialtree/Thomas.PNG", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "89" });
            radialtreeData.Add(new radialtreeData { Id = "13", Name = "Kloss Perrier", Designation = "Project Lead", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "90" });
            radialtreeData.Add(new radialtreeData { Id = "14", Name = "Liz Nixon", Designation = "Project Lead", ImageUrl = "../images/radialtree/Jenny.png", IsExpand = "false", RatingColor = "#68C2DE", ReportingPerson = "3" });
            radialtreeData.Add(new radialtreeData { Id = "15", Name = "Paul Henriot", Designation = "Project Lead", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "false", RatingColor = "#D46E89", ReportingPerson = "3" });
            radialtreeData.Add(new radialtreeData { Id = "16", Name = "Paula Parente", Designation = "Project Lead", ImageUrl = "../images/radialtree/John.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "90" });
            radialtreeData.Add(new radialtreeData { Id = "17", Name = "Matti Kenna", Designation = "Project Lead", ImageUrl = "../images/radialtree/Jenny.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "4" });
            radialtreeData.Add(new radialtreeData { Id = "18", Name = "Laura Callahan", Designation = "Project Lead", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "false", RatingColor = "#D46E89", ReportingPerson = "4" });
            radialtreeData.Add(new radialtreeData { Id = "19", Name = "Simon Roel", Designation = "Project Lead", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "true", RatingColor = "#93B85A", ReportingPerson = "4" });
            radialtreeData.Add(new radialtreeData { Id = "20", Name = "Thomas Hardy", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image57.png", IsExpand = "false", RatingColor = "#68C2DE", ReportingPerson = "12" });
            radialtreeData.Add(new radialtreeData { Id = "21", Name = "Martín Kloss", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "5" });
            radialtreeData.Add(new radialtreeData { Id = "22", Name = "Maria Larsson", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image51.png", IsExpand = "false", RatingColor = "#EBB92E", ReportingPerson = "6" });
            radialtreeData.Add(new radialtreeData { Id = "23", Name = "Diego Roel", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image55.png", IsExpand = "false", RatingColor = "#D46E89", ReportingPerson = "7" });
            radialtreeData.Add(new radialtreeData { Id = "24", Name = "José Pedro", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "true", RatingColor = "#D46E89", ReportingPerson = "8" });
            radialtreeData.Add(new radialtreeData { Id = "25", Name = "Manu Pereira", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image56.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "8" });
            radialtreeData.Add(new radialtreeData { Id = "26", Name = "Annette Roel", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image55.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "25" });
            radialtreeData.Add(new radialtreeData { Id = "27", Name = "Catherine Kaff", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image57.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "8" });
            radialtreeData.Add(new radialtreeData { Id = "28", Name = "Lúcia Carvalho", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Robin.PNG", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "12" });
            radialtreeData.Add(new radialtreeData { Id = "29", Name = "Alej Camino", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Thomas.PNG", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "13" });
            radialtreeData.Add(new radialtreeData { Id = "30", Name = "Liu Wong", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image57.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "14" });
            radialtreeData.Add(new radialtreeData { Id = "31", Name = "Karin Josephs", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image55.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "14" });
            radialtreeData.Add(new radialtreeData { Id = "32", Name = "Ruby Anabela", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "16" });
            radialtreeData.Add(new radialtreeData { Id = "33", Name = "Pirkko King", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "17" });
            radialtreeData.Add(new radialtreeData { Id = "34", Name = "Karl Jablonski", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "18" });
            radialtreeData.Add(new radialtreeData { Id = "35", Name = "Zbyszek Yang", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "19" });
            radialtreeData.Add(new radialtreeData { Id = "36", Name = "Nancy", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image56.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "5" });
            radialtreeData.Add(new radialtreeData { Id = "37", Name = "Anne", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "false", RatingColor = "#68C2DE", ReportingPerson = "6" });
            radialtreeData.Add(new radialtreeData { Id = "38", Name = "Isabel Castro", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image55.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "7" });
            radialtreeData.Add(new radialtreeData { Id = "39", Name = "Nardo Batista", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image57.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "9" });
            radialtreeData.Add(new radialtreeData { Id = "40", Name = "Rene Phillips", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image55.png", IsExpand = "false", RatingColor = "#68C2DE", ReportingPerson = "16" });
            radialtreeData.Add(new radialtreeData { Id = "41", Name = "Rita Pfalzheim", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "false", RatingColor = "#D46E89", ReportingPerson = "9" });
            radialtreeData.Add(new radialtreeData { Id = "42", Name = "Janete Limeira", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image57.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "11" });
            radialtreeData.Add(new radialtreeData { Id = "43", Name = "Christina kaff", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "20" });
            radialtreeData.Add(new radialtreeData { Id = "44", Name = "Peter Franken", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image55.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "21" });
            radialtreeData.Add(new radialtreeData { Id = "45", Name = "Carlos Schmitt", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "23" });
            radialtreeData.Add(new radialtreeData { Id = "46", Name = "Yoshi Wilson", Designation = "Senior S/w Engg", ImageUrl = "../images/radialtree/image57.png", IsExpand = "false", RatingColor = "#EBB92E", ReportingPerson = "23" });
            radialtreeData.Add(new radialtreeData { Id = "47", Name = "Jean Fresnière", Designation = "S/w Engg", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "false", RatingColor = "#D46E89", ReportingPerson = "24" });
            radialtreeData.Add(new radialtreeData { Id = "48", Name = "Simon Roel", Designation = "S/w Engg", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "25" });
            radialtreeData.Add(new radialtreeData { Id = "49", Name = "Rene Phillips", Designation = "S/w Engg", ImageUrl = "../images/radialtree/Jenny.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "55" });
            radialtreeData.Add(new radialtreeData { Id = "50", Name = "Paula Wilson", Designation = "S/w Engg", ImageUrl = "../images/radialtree/eric.PNG", IsExpand = "None", RatingColor = "#68C2DE", ReportingPerson = "43" });
            radialtreeData.Add(new radialtreeData { Id = "51", Name = "Jose Pavarotti", Designation = "S/w Engg", ImageUrl = "../images/radialtree/Maria.PNG", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "43" });
            radialtreeData.Add(new radialtreeData { Id = "52", Name = "Palle Ibsen", Designation = "S/w Engg", ImageUrl = "../images/radialtree/image51.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "29" });
            radialtreeData.Add(new radialtreeData { Id = "53", Name = "Lúcia Carvalho", Designation = "S/w Engg", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "30" });
            radialtreeData.Add(new radialtreeData { Id = "53", Name = "Lúcia Carvalho", Designation = "S/w Engg", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "30" });
            radialtreeData.Add(new radialtreeData { Id = "54", Name = "Hanna Moos", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image57.png", IsExpand = "true", RatingColor = "#D46E89", ReportingPerson = "30" });
            radialtreeData.Add(new radialtreeData { Id = "55", Name = "Peter Citeaux", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "33" });
            radialtreeData.Add(new radialtreeData { Id = "56", Name = "Elizabeth Mary", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "33" });
            radialtreeData.Add(new radialtreeData { Id = "57", Name = "Victoria Ash", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "34" });
            radialtreeData.Add(new radialtreeData { Id = "58", Name = "Janine Labrune", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image55.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "35" });
            radialtreeData.Add(new radialtreeData { Id = "59", Name = "Martine Rancé", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "11" });
            radialtreeData.Add(new radialtreeData { Id = "60", Name = "Carine Schmitt", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "11" });
            radialtreeData.Add(new radialtreeData { Id = "61", Name = "Paolo Accorti", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "38" });
            radialtreeData.Add(new radialtreeData { Id = "62", Name = "André Fonseca", Designation = "Project Trainee", ImageUrl = "../images/radialtree/John.png", IsExpand = "true", RatingColor = "#EBB92E", ReportingPerson = "41" });
            radialtreeData.Add(new radialtreeData { Id = "63", Name = "Mario Pontes", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "6" });
            radialtreeData.Add(new radialtreeData { Id = "64", Name = "John Steel", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Maria.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "7" });
            radialtreeData.Add(new radialtreeData { Id = "65", Name = "Renate Jose", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image51.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "42" });
            radialtreeData.Add(new radialtreeData { Id = "66", Name = "Jaime Yorres", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "20" });
            radialtreeData.Add(new radialtreeData { Id = "67", Name = "Alex Feuer", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "21" });
            radialtreeData.Add(new radialtreeData { Id = "68", Name = "Yvonne Wong", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "6" });
            radialtreeData.Add(new radialtreeData { Id = "69", Name = "Yoshi Kenna", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image55.png", IsExpand = "false", RatingColor = "#EBB92E", ReportingPerson = "40" });
            radialtreeData.Add(new radialtreeData { Id = "70", Name = "Helen Marie", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image51.png", IsExpand = "true", RatingColor = "#EBB92E", ReportingPerson = "24" });
            radialtreeData.Add(new radialtreeData { Id = "71", Name = "Joseph Kaff", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "70" });
            radialtreeData.Add(new radialtreeData { Id = "72", Name = "Horst Kloss", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Clayton.PNG", IsExpand = "None", RatingColor = "#68C2DE", ReportingPerson = "70" });
            radialtreeData.Add(new radialtreeData { Id = "73", Name = "Sergio roel", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image55.PNG", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "37" });
            radialtreeData.Add(new radialtreeData { Id = "74", Name = "Mauri Moroni", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.PNG", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "60" });
            radialtreeData.Add(new radialtreeData { Id = "75", Name = "Janete Limeira", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image51.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "29" });
            radialtreeData.Add(new radialtreeData { Id = "76", Name = "Jonas Bergsen", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.PNG", IsExpand = "None", RatingColor = "#68C2DE", ReportingPerson = "18" });
            radialtreeData.Add(new radialtreeData { Id = "77", Name = "Miguel Angel", Designation = "Project Trainee", ImageUrl = "../images/radialtree/eric.PNG", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "18" });
            radialtreeData.Add(new radialtreeData { Id = "78", Name = "Art Nancy", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "true", RatingColor = "#D46E89", ReportingPerson = "88" });
            radialtreeData.Add(new radialtreeData { Id = "79", Name = "Pascal Cartrain", Designation = "Project Trainee", ImageUrl = "../images/radialtree/John.png", IsExpand = "true", RatingColor = "#EBB92E", ReportingPerson = "88" });
            radialtreeData.Add(new radialtreeData { Id = "80", Name = "Helvetis Nagy", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "34" });
            radialtreeData.Add(new radialtreeData { Id = "81", Name = "Rita Müller", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Paul.png", IsExpand = "None", RatingColor = "#68C2DE", ReportingPerson = "35" });
            radialtreeData.Add(new radialtreeData { Id = "82", Name = "Georg Pipps", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "36" });
            radialtreeData.Add(new radialtreeData { Id = "83", Name = "Horst Kloss", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Paul.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "37" });
            radialtreeData.Add(new radialtreeData { Id = "84", Name = "Paula Wilson", Designation = "Project Trainee", ImageUrl = "../images/radialtree/Jenny.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "38" });
            radialtreeData.Add(new radialtreeData { Id = "85", Name = "Jose Michael", Designation = "Project Trainee", ImageUrl = "../images/radialtree/eric.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "37" });
            radialtreeData.Add(new radialtreeData { Id = "86", Name = "Mauri Moroni", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image55.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "40" });
            radialtreeData.Add(new radialtreeData { Id = "87", Name = "Michael Holz", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "41" });
            radialtreeData.Add(new radialtreeData { Id = "88", Name = "Alej Camino", Designation = "Project Trainee", ImageUrl = "../images/radialtree/image51.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "42" });
            radialtreeData.Add(new radialtreeData { Id = "89", Name = "Jytte Petersen", Designation = "Project Manager", ImageUrl = "../images/radialtree/image55.PNG", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "parent" });
            radialtreeData.Add(new radialtreeData { Id = "90", Name = "Mary Saveley", Designation = "Project Manager", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "false", RatingColor = "#93B85A", ReportingPerson = "parent" });
            radialtreeData.Add(new radialtreeData { Id = "91", Name = "Robert King", Designation = "Project Manager", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "true", RatingColor = "#D46E89", ReportingPerson = "parent" });
            radialtreeData.Add(new radialtreeData { Id = "92", Name = "Francisco Yang", Designation = "CSR", ImageUrl = "../images/radialtree/image55.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "100" });
            radialtreeData.Add(new radialtreeData { Id = "93", Name = "Yang Wang", Designation = "CSR", ImageUrl = "../images/radialtree/image57.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "80" });
            radialtreeData.Add(new radialtreeData { Id = "94", Name = "Ann Devon", Designation = "CSR", ImageUrl = "../images/radialtree/Robin.png", IsExpand = "false", RatingColor = "#68C2DE", ReportingPerson = "80" });
            radialtreeData.Add(new radialtreeData { Id = "95", Name = "Roland Mendel", Designation = "CSR", ImageUrl = "../images/radialtree/image57.png", IsExpand = "true", RatingColor = "#68C2DE", ReportingPerson = "19" });
            radialtreeData.Add(new radialtreeData { Id = "96", Name = "Yoshi Latimer", Designation = "SR", ImageUrl = "../images/radialtree/eric.png", IsExpand = "true", RatingColor = "#D46E89", ReportingPerson = "13" });
            radialtreeData.Add(new radialtreeData { Id = "97", Name = "Patricia Kenna", Designation = "SR", ImageUrl = "../images/radialtree/Maria.png", IsExpand = "true", RatingColor = "#EBB92E", ReportingPerson = "100" });
            radialtreeData.Add(new radialtreeData { Id = "98", Name = "Helen Bennett", Designation = "SR", ImageUrl = "../images/radialtree/image51.png", IsExpand = "None", RatingColor = "#D46E89", ReportingPerson = "42" });
            radialtreeData.Add(new radialtreeData { Id = "99", Name = "Carlos Nagy", Designation = "SR", ImageUrl = "../images/radialtree/Clayton.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "42" });
            radialtreeData.Add(new radialtreeData { Id = "100", Name = "Felipe Kloss", Designation = "SR", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "false", RatingColor = "#EBB92E", ReportingPerson = "77" });
            radialtreeData.Add(new radialtreeData { Id = "101", Name = "Fran Wilson", Designation = "SR", ImageUrl = "../images/radialtree/image53.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "46" });
            radialtreeData.Add(new radialtreeData { Id = "102", Name = "John Rovelli", Designation = "SR", ImageUrl = "../images/radialtree/Jenny.png", IsExpand = "None", RatingColor = "#93B85A", ReportingPerson = "46" });
            radialtreeData.Add(new radialtreeData { Id = "103", Name = "Georg Pipps", Designation = "SR", ImageUrl = "../images/radialtree/Thomas.png", IsExpand = "None", RatingColor = "#EBB92E", ReportingPerson = "55" });
            ViewBag.datasource = radialtreeData;
            return View();
        }
    }
}
