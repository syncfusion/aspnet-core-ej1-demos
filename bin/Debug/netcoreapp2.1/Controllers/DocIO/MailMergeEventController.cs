#region Copyright
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
using System.Reflection;
using System.Xml;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {       
        public ActionResult MailMergeEvent(string Group1, string Button)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            string contenttype1 = "application/msword";
            string dataPath = basePath + @"/DocIO/MailMergeEventTemplate.doc";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (Group1 == null)
                return View();
            if (Button == "View Template")
            {
                return File(fileStream, contenttype1, "MailMergeEventTemplate.doc");
            }
            fileStream.Dispose();
            fileStream = null;

            try
            {
                // Load the template.                
                FileStream fileStreamPath = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                WordDocument document = new WordDocument(fileStreamPath, FormatType.Doc);
                fileStreamPath.Dispose();
                fileStreamPath = null;
                
                // Using Merge events to do conditional formatting during runtime.
                document.MailMerge.MergeField += new MergeFieldEventHandler(AlternateRows_MergeField);
                document.MailMerge.MergeImageField += new MergeImageFieldEventHandler(MergeField_ProductImage);

                //Create MailMergeDataTable
                MailMergeDataTable mailMergeDataTablePriceList = GetMailMergeDataTablePriceList();
                MailMergeDataTable mailMergeDataTableProductData = GetMailMergeDataTableProductData();

                // Execute Mail Merge with groups.
                document.MailMerge.ExecuteGroup(mailMergeDataTablePriceList);               
                document.MailMerge.ExecuteGroup(mailMergeDataTableProductData);
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
        private void AlternateRows_MergeField(object sender, MergeFieldEventArgs args)
        {
            // Conditionally format data during Merge.
            if (args.RowIndex % 2 == 0)
            {
                args.CharacterFormat.TextColor = Syncfusion.Drawing.Color.FromArgb(255, 102, 0);
            }
        }

        private void MergeField_ProductImage(object sender, MergeImageFieldEventArgs args)
        {
            // Get the image from disk during Merge.
            if (args.FieldName == "ProductImage")
            {
                string ProductFileName = args.FieldValue.ToString();
                FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/images/DocIO/"+ ProductFileName, FileMode.Open, FileAccess.Read);
                args.ImageStream = fs;
            }
        }
       
        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>       
        private MailMergeDataTable GetMailMergeDataTablePriceList()
        {
            List<Product_PriceList> product_PriceList = new List<Product_PriceList>();
            FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/DocIO/ProductPriceList.xml", FileMode.Open, FileAccess.Read);
            XmlReader reader = XmlReader.Create(fs);
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Products")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            while (reader.LocalName != "Products")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Product_PriceList":
                            product_PriceList.Add(GetProduct_PriceList(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Products") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            MailMergeDataTable dataTable1 = new MailMergeDataTable("Product_PriceList", product_PriceList);
            reader.Dispose();
            fs.Dispose();
            return dataTable1;
        }
        /// <summary>
        /// Gets the product price list.
        /// </summary>
        /// <param name="reader">The reader.</param>       
        private Product_PriceList GetProduct_PriceList(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Product_PriceList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            Product_PriceList product_PriceList = new Product_PriceList();
            while (reader.LocalName != "Product_PriceList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "ProductName":
                            product_PriceList.ProductName = reader.ReadElementContentAsString();
                            break;
                        case "Price":
                            product_PriceList.Price = reader.ReadElementContentAsString();
                            break;
                       
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Product_PriceList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return product_PriceList;
        }
        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>        
        private MailMergeDataTable GetMailMergeDataTableProductData()
        {
            List<ProductDetail> productDetail = new List<ProductDetail>();
            FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/DocIO/Product.xml", FileMode.Open, FileAccess.Read);
            XmlReader reader = XmlReader.Create(fs);
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "ProductList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            while (reader.LocalName != "ProductList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Products":
                            productDetail.Add(GetProductDetail(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "ProductList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            MailMergeDataTable dataTable2 = new MailMergeDataTable("ProductDetail", productDetail);
            reader.Dispose();
            fs.Dispose();
            return dataTable2;
        }
        /// <summary>
        /// Gets the product details.
        /// </summary>
        /// <param name="reader">The reader.</param>
        private ProductDetail GetProductDetail(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Products")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            ProductDetail productDetail = new ProductDetail();
            while (reader.LocalName != "Products")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "SNO":
                            productDetail.SNO = reader.ReadElementContentAsString();
                            break;
                        case "ProductName":
                            productDetail.ProductName = reader.ReadElementContentAsString();
                            break;
                        case "ProductImage":
                            productDetail.ProductImage = reader.ReadElementContentAsString();
                            break;
                       
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Products") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return productDetail;
        }
    }


        public class Product_PriceList
    {
        #region Fields
        private string m_productName;
        private string m_price;

        #endregion
        #region Properties
        public string ProductName
        {
            get { return m_productName; }
            set { m_productName = value; }
        }
        public string Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        #endregion
        #region Constructor
        public Product_PriceList(string productName, string price)
        {
            m_productName = productName;
            m_price = price;

        }
        public Product_PriceList()
        { }
    }
    #endregion
    public class ProductDetail
    {
        #region Fields
        private string m_sNO;
        private string m_productName;
        private string m_productImage;

        #endregion
        #region Properties
        public string SNO
        {
            get { return m_sNO; }
            set { m_sNO = value; }
        }
        public string ProductName
        {
            get { return m_productName; }
            set { m_productName = value; }
        }
        public string ProductImage
        {
            get { return m_productImage; }
            set { m_productImage = value; }
        }

        #endregion
        #region Constructor
        public ProductDetail(string sNO, string productName, string productImage)
        {
            m_sNO = sNO;
            m_productName = productName;
            m_productImage = productImage;

        }
        public ProductDetail()
        { }
        #endregion
    }
}


