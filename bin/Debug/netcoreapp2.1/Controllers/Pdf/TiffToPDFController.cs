#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace samplebrowser.Controllers
{
    public partial class PdfController : Controller
    {
        public ActionResult TiffToPDF()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TiffToPDF(string submit1, string submit, string InsideBrowser)
        {
			string basePath = _hostingEnvironment.WebRootPath;
            string dataPath = string.Empty;
            dataPath = basePath + @"/PDF/";
			
			//Load TIFF image to stream
            FileStream imageFileStream = new FileStream(dataPath + "image.tiff", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			
			if (submit1 == "View TIFF image")
			{
				return File(imageFileStream, "application/image", "image.tiff");
			}
			else
			{
				//Create a new PDF document
				PdfDocument document = new PdfDocument();

				//Add a section to the PDF document
				PdfSection section = document.Sections.Add();

				//Declare the PDF page
				PdfPage page;

				//Declare PDF page graphics
				PdfGraphics graphics;

                //Load Multi-frame Tiff image
                PdfTiffImage tiffImage = new PdfTiffImage(imageFileStream);

				//Get the frame count
				int frameCount = tiffImage.FrameCount;

				//Access each frame draw into the page
				for (int i = 0; i < frameCount; i++)
				{

					page = section.Pages.Add();

					section.PageSettings.Margins.All = 0;

					graphics = page.Graphics;

					tiffImage.ActiveFrame = i;

					graphics.DrawImage(tiffImage, 0, 0, page.GetClientSize().Width, page.GetClientSize().Height);

				}

				MemoryStream stream = new MemoryStream();

				document.Save(stream);

				document.Close();

				stream.Position = 0;

				//Download the PDF document in the browser.
				FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf");
				fileStreamResult.FileDownloadName = "TiffToPDF.pdf";
				return fileStreamResult;
			}
        }
    }
}