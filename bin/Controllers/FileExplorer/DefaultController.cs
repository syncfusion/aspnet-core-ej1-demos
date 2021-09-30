#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
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
using Syncfusion.JavaScript;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers
{
    public partial class FileExplorerController : Controller
    {
        public FileExplorerOperations operation;
        public ActionResult Default()
        {
            return View();
        }
        public FileExplorerController(IHostingEnvironment hostingEnvironment)
        {
            this.operation = new FileExplorerOperations(hostingEnvironment.ContentRootPath);
        }

        public ActionResult Download(FileExplorerParams args)
        {
            return operation.Download(args.Path, args.Names);
        }

        public ActionResult Upload(FileExplorerParams args)
        {
            //operation.Upload(args.FileUpload, args.Path);
            //return Json("");
            throw new Exception("Restricted to modify data in this demo");
        }
        public ActionResult GetImage(FileExplorerParams args)
        {
            return operation.GetImage(args.Path);
        }

        public ActionResult FileActionDefault([FromBody] FileExplorerParams args)
        {
            try
            {
                if (args.ActionType != "Paste" && args.ActionType != "GetDetails")
                {
                    var FilePath = operation.GetPhysicalPath(args.Path);
                    if (!FilePath.ToLower().Contains("fileexplorercontent"))
                        throw new ArgumentException( FilePath+ "is not accessible. Access is denied.");
                }

                switch (args.ActionType)
                {
                    case "Read":
                        return Json(operation.Read(args.Path, args.ExtensionsAllow));
                    //case "CreateFolder":
                    //    return Json(operation.CreateFolder(args.Path, args.Name));
                    //case "Paste":
                    //    return Json(operation.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles));
                    //case "Remove":
                    //    return Json(operation.Remove(args.Names, args.Path, args.SelectedItems));
                    //case "Rename":
                    //    return Json(operation.Rename(args.Path, args.Name, args.NewName, args.CommonFiles));
                    case "GetDetails":
                        return Json(operation.GetDetails(args.Path, args.Names));
                    case "Search":
                        return Json(operation.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive));
                    //provide restriction to modify data in our online samples
                    default:
                        throw new Exception("Restricted to modify data in this demo");
                }
                return Json("");
            }
            catch (Exception e)
            {
                FileExplorerResponse Response = new FileExplorerResponse();
                Response.error = e.GetType().FullName + ", " + e.Message;
                return Json(Response);
            }
        }

    }
}
