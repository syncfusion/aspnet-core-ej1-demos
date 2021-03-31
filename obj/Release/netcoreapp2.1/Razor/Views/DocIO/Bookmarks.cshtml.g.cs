#pragma checksum "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\Bookmarks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed99ead91f7d6f33b72f0867f24bc5c85d402cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_Bookmarks), @"mvc.1.0.view", @"/Views/DocIO/Bookmarks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/Bookmarks.cshtml", typeof(AspNetCore.Views_DocIO_Bookmarks))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\Bookmarks.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\Bookmarks.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed99ead91f7d6f33b72f0867f24bc5c85d402cc", @"/Views/DocIO/Bookmarks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_Bookmarks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 57, true);
                WriteLiteral(" <span class=\"sampleName\">Insert Content/Bookmarks</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(187, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\Bookmarks.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Bookmark : Syncfusion";

#line default
#line hidden
                BeginContext(267, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\Bookmarks.cshtml"
      Html.BeginForm("Bookmarks", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(340, 3627, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to insert bookmarks into the Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match");
                WriteLiteral(@"-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: ");
                WriteLiteral(@"8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        Bookmark helps to identify a part of the document for future reference. The document elements like paragraph, table, etc., can be marked with a bookmark and it can be accessed by its name.
                        <ul>
                            <li>
                                With DocIO, you can insert and delete bookmarks in the Word document.
                            </li>
                            <li>
                                Using bookmark navigator, you can navigate through the document elements and select a specific bookmark in the Word document.
                            </li>
                            <li>
                                Once after selecti");
                WriteLiteral(@"ng a bookmark, you can edit, modify or delete the contents within that bookmark.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the bookmarks can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-bookmarks"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 55 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\Bookmarks.cshtml"

            Html.EndForm();
        }

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
