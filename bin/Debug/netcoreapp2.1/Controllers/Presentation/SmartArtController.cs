#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Syncfusion.Presentation;
using Microsoft.AspNetCore.Hosting;
using Syncfusion.OfficeChart;
using Syncfusion.Drawing;

namespace samplebrowser.Controllers
{
    public partial class PresentationController : Controller
    {
        public IActionResult SmartArt()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult SmartArt(string Browser)
        {
            IPresentation presentation = Syncfusion.Presentation.Presentation.Create();
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

            //Method call to edit slides
            CreateSlide1(presentation);
            CreateSlide2(presentation);
            CreateSlide3(presentation);
            CreateSlide4(presentation);

            MemoryStream ms = new MemoryStream();

            //Saves the presentation to the memory stream.
            presentation.Save(ms);
            //Set the position of the stream to beginning.
            ms.Position = 0;

            //Initialize the file stream to download the presentation.
            FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/vnd.openxmlformats-officedocument.presentationml.presentation");
            //Set the file name.
            fileStreamResult.FileDownloadName = "SmartArt.pptx";

            return fileStreamResult;
        }

        #region Slide
        #region Slide1
        #region Slide1
        private void CreateSlide1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide1.Shapes.AddSmartArt(SmartArtType.BasicBlockList, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("One");
            ISmartArtNode node2 = smartArt.Nodes[1];
            node2.TextBody.AddParagraph("Two");
            ISmartArtNode node3 = smartArt.Nodes[2];
            node3.TextBody.AddParagraph("Three");
            ISmartArtNode node4 = smartArt.Nodes[3];
            node4.TextBody.AddParagraph("Four");
            ISmartArtNode node5 = smartArt.Nodes[4];
            node5.TextBody.AddParagraph("Five");
        }
        #endregion

        # region Slide2
        private void CreateSlide2(IPresentation presentation)
        {
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide.Shapes.AddSmartArt(SmartArtType.StepUpProcess, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("First");
            ISmartArtNode node2 = smartArt.Nodes[1];
            node2.TextBody.AddParagraph("Second");
            ISmartArtNode node3 = smartArt.Nodes[2];
            node3.TextBody.AddParagraph("Three");
        }
        #endregion

        # region Slide3
        private void CreateSlide3(IPresentation presentation)
        {
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide.Shapes.AddSmartArt(SmartArtType.BasicCycle, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("Requirement");
            ISmartArtNode node2 = smartArt.Nodes[1];
            node2.TextBody.AddParagraph("Analyzing");
            ISmartArtNode node3 = smartArt.Nodes[2];
            node3.TextBody.AddParagraph("Estimation");
            ISmartArtNode node4 = smartArt.Nodes[3];
            node4.TextBody.AddParagraph("Implementing");
            ISmartArtNode node5 = smartArt.Nodes[4];
            node5.TextBody.AddParagraph("Testing");
        }
        #endregion

        # region Slide4
        private void CreateSlide4(IPresentation presentation)
        {
            ISlide slide = presentation.Slides.Add(SlideLayoutType.Blank);
            ISmartArt smartArt = slide.Shapes.AddSmartArt(SmartArtType.Hierarchy, 100, 100, 640, 427);
            ISmartArtNode node1 = smartArt.Nodes[0];
            node1.TextBody.AddParagraph("Grand Father");
            ISmartArtNode childNode1 = node1.ChildNodes[0];
            childNode1.TextBody.AddParagraph("Son1");
            ISmartArtNode childNode2 = node1.ChildNodes[1];
            childNode2.TextBody.AddParagraph("Son2");
            ISmartArtNode childnode1 = childNode1.ChildNodes[0];
            childnode1.TextBody.AddParagraph("Son1");
            ISmartArtNode childnode2 = childNode1.ChildNodes[1];
            childnode2.TextBody.AddParagraph("Son2");
            ISmartArtNode childnode2s1 = childNode2.ChildNodes[0];
            childnode2s1.TextBody.AddParagraph("Son1");
        }
        #endregion
        #endregion
        #endregion
    }
}
