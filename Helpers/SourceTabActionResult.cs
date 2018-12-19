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
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.AspNetCore.Hosting;

namespace samplebrowser.Helpers
{
    public class SourceTabActionResult : ActionResult
    {
        public static IHttpContextAccessor HttpContextAccessor;
        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        private string FileName
        {
            get;
            set;
        }
        public IHostingEnvironment ApplicationPath
        {
            get;
            set;
        }
        private bool SeperateWindow { get; set; }
        public SourceTabActionResult(string fileName, string seperateWindow, IHostingEnvironment path)
        {
            this.FileName = fileName;
            this.SeperateWindow = seperateWindow == "true";
            this.ApplicationPath = path;
        }
        public string getContent(IHostingEnvironment path)
        {
            ProductXmlDataEngine xmlEngine = new ProductXmlDataEngine();
            TabType tabType = xmlEngine.GetTabType(this.FileName);

            string content = xmlEngine.GetTabContent(tabType, this.FileName,path);
            var copybutton = "<span class='copycode copycodedown'>COPY TO CLIPBOARD</span>";
            string scriptTag = "<script>$(function(){initiateCopyHandler();});</script>";
            return content + copybutton + scriptTag;
        }

        public override void ExecuteResult(ActionContext context)
        {
        }

    }    
}
