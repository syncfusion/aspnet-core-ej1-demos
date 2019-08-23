#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Drawing;
using Microsoft.AspNetCore.Http;

namespace samplebrowser.Controllers
{
    public partial class PdfController : Controller
    {
        //
        // GET: /DigitalSignature/

        public ActionResult DigitalSignature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DigitalSignature(string Browser, string password, string Reason, string Location, string Contact, string RadioButtonList2, string NewPDF, string submit, IFormFile file, IFormFile certificate)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPath = string.Empty;
            dataPath = basePath + @"/PDF/";

            if (submit == "Sign PDF")
            {
                if (file != null && file.Length > 0 && certificate != null && certificate.Length > 0 && certificate.FileName.Contains(".pfx") && password != null && Location != null && Reason != null && Contact != null)
                {
                    PdfLoadedDocument ldoc = new PdfLoadedDocument(file.OpenReadStream());
                    PdfCertificate pdfCert = new PdfCertificate(certificate.OpenReadStream(), password);
                    FileStream jpgFile = new FileStream(dataPath + "PDFDemo.jpg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    PdfBitmap bmp = new PdfBitmap(jpgFile);
                    PdfPageBase page = ldoc.Pages[0];
                    PdfSignature signature = new PdfSignature(ldoc, page, pdfCert, "Signature");
                    signature.Bounds = new RectangleF(new PointF(5, 5), bmp.PhysicalDimension);
                    signature.ContactInfo = Contact;
                    signature.LocationInfo = Location;
                    signature.Reason = Reason;
                    MemoryStream stream = new MemoryStream();
                    ldoc.Save(stream);
                    stream.Position = 0;
                    ldoc.Close(true);

                    //Download the PDF document in the browser.
                    FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf");
                    fileStreamResult.FileDownloadName = "SignedPDF.pdf";
                    return fileStreamResult;
                    return View();
                }
                else
                {
                    ViewBag.lab = "NOTE: Fill all fields and then create PDF";
                    return View();
                }
            }
            else
            {
                //Read the PFX file
                FileStream pfxFile = new FileStream(dataPath + "PDF.pfx", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                PdfDocument doc = new PdfDocument();
                PdfPage page = doc.Pages.Add();
                PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
                PdfPen pen = new PdfPen(brush, 0.2f);
                PdfFont font = new PdfStandardFont(PdfFontFamily.Courier, 12, PdfFontStyle.Regular);
                PdfCertificate pdfCert = new PdfCertificate(pfxFile, "syncfusion");
                PdfSignature signature = new PdfSignature(page, pdfCert, "Signature");
                FileStream jpgFile = new FileStream(dataPath + "logo.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                PdfBitmap bmp = new PdfBitmap(jpgFile);
                signature.Bounds = new RectangleF(new PointF(5, 5), page.GetClientSize());
                signature.ContactInfo = "johndoe@owned.us";
                signature.LocationInfo = "Honolulu, Hawaii";
                signature.Reason = "I am author of this document.";

                if (RadioButtonList2 == "Standard")
                    signature.Certificated = true;
                else
                    signature.Certificated = false;
                PdfGraphics graphics = signature.Appearence.Normal.Graphics;

                string validto = "Valid To: " + signature.Certificate.ValidTo.ToString();
                string validfrom = "Valid From: " + signature.Certificate.ValidFrom.ToString();

                graphics.DrawImage(bmp, 0, 0);

                doc.Pages[0].Graphics.DrawString(validfrom, font, pen, brush, 0, 90);
                doc.Pages[0].Graphics.DrawString(validto, font, pen, brush, 0, 110);

                doc.Pages[0].Graphics.DrawString(" Protected Document. Digitally signed Document.", font, pen, brush, 0, 130);
                doc.Pages[0].Graphics.DrawString("* To validate Signature click on the signature on this page \n * To check Document Status \n click document status icon on the bottom left of the acrobat reader.", font, pen, brush, 0, 150);

                // Save the pdf document to the Stream.
                MemoryStream stream = new MemoryStream();

                doc.Save(stream);

                //Close document
                doc.Close();

                stream.Position = 0;

                // Download the PDF document in the browser.
                FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf");
                fileStreamResult.FileDownloadName = "SignedPDF.pdf";
                return fileStreamResult;

                return View();
            }
        }
    }
}
