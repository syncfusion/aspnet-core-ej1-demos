#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eeebcbbe5162d6e2ba22d03e365daec0c8bff7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_WordToPDF), @"mvc.1.0.view", @"/Views/DocIO/WordToPDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/WordToPDF.cshtml", typeof(AspNetCore.Views_DocIO_WordToPDF))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eeebcbbe5162d6e2ba22d03e365daec0c8bff7b", @"/Views/DocIO/WordToPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_WordToPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(104, 50, true);
                WriteLiteral(" <span class=\"sampleName\">DocIO/Word To PDF</span>");
                EndContext();
            }
            );
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(184, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Word To PDF : Syncfusion";

#line default
#line hidden
                BeginContext(267, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml"
      Html.BeginForm("WordToPDF", "DocIO", FormMethod.Post, new { enctype = "multipart/form-data" });

        {

#line default
#line hidden
                BeginContext(385, 863, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample illustrates how to convert Word document to PDF using Essential DocIO and Essential PDF.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the resultant PDF document being converted from Word document using Essential DocIO and Essential PDF. Please note that PDF viewer is required to view the resultant PDF.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Select Document :
                                ");
                EndContext();
                BeginContext(1249, 102, false);
#line 23 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml"
                           Write(Html.TextBox("file", "", new { type = "file", accept = ".doc,.docx,.rtf,.dot,.dotm,.dotx,docm,.xml" }));

#line default
#line hidden
                EndContext();
                BeginContext(1351, 2438, true);
                WriteLiteral(@" <br />
                            </div>
                            <div class=""rowdiv"">                              
                                PDF Options :
                                <br />
                                <input type=""checkbox"" name=""RenderingMode1"" value=""PreserveStructureTags"" id=""preserveStructureTags"" />
                                <label for=""preserveStructureTags"" style=""font-weight:normal"">
                                    Preserve structure tags, generates PDF document with accessiblity support.
                                </label>
                                <br />
                                <input type=""checkbox"" name=""RenderingMode2"" value=""PreserveFormFields"" checked=""true"" id=""preserveFormFields"" />
                                <label for=""preserveFormFields"" style=""font-weight:normal"">
                                    Preserve form fields, generates PDF document with PDF form fields for equivalent Word document form fields.");
                WriteLiteral(@"
                                </label>
                                <br />
                                <input type=""checkbox"" name=""RenderingMode3"" value=""PreserveWordHeadingsToPDFBookmarks"" checked=""true"" id=""preserveWordHeadingsToPDFBookmarks"" />
                                <label for=""preserveWordHeadingsToPDFBookmarks"" style=""font-weight:normal"">
                                    Convert Word headings to PDF bookmarks, generates PDF document with bookmarks for Word document paragraph with heading style and outline level.
                                </label>
                                <br />
                                <input type=""checkbox"" name=""RenderingMode4"" value=""ShowRevisions"" id=""showRevisions"" />
                                <label for=""showRevisions"" style=""font-weight:normal"">
                                    Show the revision marks in the generated PDF for tracked changes or revisions in the Word document.
                                </label>
 ");
                WriteLiteral(@"                           </div>
                            <div class=""rowdiv"" style=""margin-top: 8px"">
                                <input class=""buttonStyle"" type=""submit"" value=""Convert to PDF"" name=""button"" style=""width:150px;height:27px"" />
                                <br />
                                <div class=""text-danger"">
                                    ");
                EndContext();
                BeginContext(3790, 15, false);
#line 52 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml"
                               Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(3805, 1475, true);
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
					<br />
                    <div class=""rowdiv"">
                        DocIO provides support to render Word document from flow to fixed page model and export as PDF or Image. With this support to render Word document,
                        <ul>
                            <li>
                                You can generate invoice and other reports in PDF, starting from Word document.
                            </li>
                            <li>
                                You can view or print the contents of Word document by converting as PDF and loading generated PDF via PDF viewer.
                            </li>
                            <li>
                                You can generate PDF more faster by enabling fast render option and embed fonts by enabling embed font option.
                            </li>
                ");
                WriteLiteral(@"        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about Word to PDF conversion can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/conversion#converting-word-document-to-pdf"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 79 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\WordToPDF.cshtml"
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
