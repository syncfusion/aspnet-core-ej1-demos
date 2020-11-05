#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Data;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Reflection;
using System.Text;
using Syncfusion.Drawing;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {       
        #region  EmployeeReport
        public ActionResult EmployeeReport(string Group1, string Button)
        {
            if (Group1 == null)
                return View();
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPathEmployee = basePath + @"/DocIO/EmployeesReportDemo.doc";
            string contenttype1 = "application/msword";
            FileStream fileStream = new FileStream(dataPathEmployee, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (Button == "View Template")
                return File(fileStream, contenttype1, "EmployeesReportDemo.doc");
            fileStream.Dispose();
            fileStream = null;
            // Creating a new document.
            WordDocument document = new WordDocument();
            // Load template          
            fileStream = new FileStream(dataPathEmployee, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            document.Open(fileStream, FormatType.Doc);
            fileStream.Dispose();
            fileStream = null;
            document.MailMerge.MergeImageField += new MergeImageFieldEventHandler(MergeField_EmployeeImage);
            //Create MailMergeDataTable
            MailMergeDataTable mailMergeDataTable = GetMailMergeDataTableEmployee();
            // Execute Mail Merge with groups. 
            document.MailMerge.ExecuteGroup(mailMergeDataTable);
            try
            {
                FormatType type = FormatType.Docx;
                string filename = "Sample.docx";
                string contenttype = "application/vnd.ms-word.document.12";
                #region Document SaveOption
                //Save as .doc format
                if (Group1 == "WordDoc")
                {
                    type = FormatType.Doc;
                    filename = "Sample.doc";
                    contenttype = "application/msword";
                }
                //Save as .xml format
                else if (Group1 == "WordML")
                {
                    type = FormatType.WordML;
                    filename = "Sample.xml";
                    contenttype = "application/msword";
                }
                #endregion Document SaveOption
                MemoryStream ms = new MemoryStream();
                document.Save(ms, type);
                document.Close();
                ms.Position = 0;
                return File(ms, contenttype, filename);
            }
            catch (Exception)
            { }
            return View();
        }
        private void MergeField_EmployeeImage(object sender, MergeImageFieldEventArgs args)
        {
            // Get the image from disk during Merge.
            if (args.FieldName == "Photo")
            {
                string ProductFileName = args.FieldValue.ToString();
                byte[] bytes = Convert.FromBase64String(ProductFileName);
                MemoryStream ms = new MemoryStream(bytes);
                args.ImageStream = ms;
            }
        }
        #endregion  EmployeeReport

        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>        
        private MailMergeDataTable GetMailMergeDataTableEmployee()
        {
            List<Employees> employees = new List<Employees>();
            FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/DocIO/EmployeesList.xml", FileMode.Open, FileAccess.Read);
            XmlReader reader = XmlReader.Create(fs);
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Employees")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            while (reader.LocalName != "Employees")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Employee":
                            employees.Add(GetEmployees(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Employees") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            MailMergeDataTable dataTable = new MailMergeDataTable("Employees", employees);
            reader.Dispose();
            fs.Dispose();
            return dataTable;
        }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <param name="reader">The reader.</param>        
        private Employees GetEmployees(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Employee")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            Employees employee = new Employees();
            while (reader.LocalName != "Employee")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "EmployeeID":
                            employee.EmployeeID = reader.ReadElementContentAsString();
                            break;
                        case "LastName":
                            employee.LastName = reader.ReadElementContentAsString();
                            break;
                        case "FirstName":
                            employee.FirstName = reader.ReadElementContentAsString();
                            break;
                        case "Title":
                            employee.Title = reader.ReadElementContentAsString();
                            break;
                        case "TitleOfCourtesy":
                            employee.TitleOfCourtesy = reader.ReadElementContentAsString();
                            break;
                        case "BirthDate":
                            employee.BirthDate = reader.ReadElementContentAsString();
                            break;
                        case "HireDate":
                            employee.HireDate = reader.ReadElementContentAsString();
                            break;
                        case "Address":
                            employee.Address = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            employee.City = reader.ReadElementContentAsString();
                            break;
                        case "Region":
                            employee.Region = reader.ReadElementContentAsString();
                            break;
                        case "PostalCode":
                            employee.PostalCode = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            employee.Country = reader.ReadElementContentAsString();
                            break;
                        case "HomePhone":
                            employee.HomePhone = reader.ReadElementContentAsString();
                            break;
                        case "Extension":
                            employee.Extension = reader.ReadElementContentAsString();
                            break;
                        case "Photo":
                            employee.Photo = reader.ReadElementContentAsString();
                            break;
                        case "Notes":
                            employee.Notes = reader.ReadElementContentAsString();
                            break;
                        case "ReportsTo":
                            employee.ReportsTo = reader.ReadElementContentAsString();
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Employee") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return employee;
        }
    }
    public class Employees
    {
        #region Fields
        private string m_employeeID;
        private string m_lastName;
        private string m_firstName;
        private string m_title;
        private string m_titleOfCourtesy;
        private string m_birthDate;
        private string m_hireDate;
        private string m_address;
        private string m_city;
        private string m_region;
        private string m_postalCode;
        private string m_country;
        private string m_homePhone;
        private string m_extension;
        private string m_photo;
        private string m_notes;
        private string m_reportsTo;
        #endregion
        #region Properties
        public string EmployeeID
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return m_titleOfCourtesy; }
            set { m_titleOfCourtesy = value; }
        }
        public string BirthDate
        {
            get { return m_birthDate; }
            set { m_birthDate = value; }
        }
        public string HireDate
        {
            get { return m_hireDate; }
            set { m_hireDate = value; }
        }
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }
        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }
        public string Region
        {
            get { return m_region; }
            set { m_region = value; }
        }
        public string PostalCode
        {
            get { return m_postalCode; }
            set { m_postalCode = value; }
        }
        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }
        public string HomePhone
        {
            get { return m_homePhone; }
            set { m_homePhone = value; }
        }
        public string Extension
        {
            get { return m_extension; }
            set { m_extension = value; }
        }
        public string Photo
        {
            get { return m_photo; }
            set { m_photo = value; }
        }
        public string Notes
        {
            get { return m_notes; }
            set { m_notes = value; }
        }
        public string ReportsTo
        {
            get { return m_reportsTo; }
            set { m_reportsTo = value; }
        }


        #endregion
        #region Constructor
        public Employees(string employeeID, string lastName, string firstName, string title, string titleOfCourtesy, string birthDate, string hireDate, string address, string city, string region, string postalCode, string country, string homePhone, string extension, string photo, string notes, string reportsTo)
        {
            m_employeeID = employeeID;
            m_lastName = lastName;
            m_firstName = firstName;
            m_title = title;
            m_titleOfCourtesy = titleOfCourtesy;
            m_birthDate = birthDate;
            m_hireDate = hireDate;
            m_address = address;
            m_city = city;
            m_region = region;
            m_postalCode = postalCode;
            m_country = country;
            m_homePhone = homePhone;
            m_extension = extension;
            m_photo = photo;
            m_notes = notes;
            m_reportsTo = reportsTo;

        }
        public Employees()
        { }
        #endregion
    }
}

