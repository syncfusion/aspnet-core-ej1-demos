#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.IO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.DocIO
{
    public partial class DocIOController : Controller
    {
        #region doc to ODT
        public ActionResult DOCtoODT(string button)
        {
            if (button == null)
                return View();
            if (Request.Form.Files != null)
            {
                var extension = Path.GetExtension(Request.Form.Files[0].FileName).ToLower();
                if (extension == ".doc" || extension == ".docx" || extension == ".dot" || extension == ".dotx" || extension == ".dotm" || extension == ".docm"
                   || extension == ".xml" || extension == ".rtf")
                {
                    MemoryStream stream = new MemoryStream();
                    Request.Form.Files[0].CopyTo(stream);
                    WordDocument document = new WordDocument(stream, FormatType.Automatic);
                    stream.Dispose();
                    stream = null;
                    //Convert word document into ODT document
                    try
                    {
                        #region Document SaveOption
                        //Save as .odt format
                        FormatType type = FormatType.Odt;
                        string filename = "WordToODT.odt";
                        string contenttype = "application/msword";
                        #endregion Document SaveOption
                        MemoryStream ms = new MemoryStream();
                        document.Save(ms, type);
                        document.Close();
                        ms.Position = 0;
                        return File(ms, contenttype, filename);
                    }
                    catch (Exception)
                    { }
                    finally
                    {

                    }
                }
                else
                {
                    ViewBag.Message = string.Format("Please choose Word format document to convert to ODT");
                }
            }
            else
            {
                ViewBag.Message = string.Format("Browse a Word document and then click the button to convert as a ODT document");
            }

            return View();

        }
        #endregion doc to ODT
    }
}