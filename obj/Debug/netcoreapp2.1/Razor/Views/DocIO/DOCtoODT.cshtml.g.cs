#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89b5a003772cf339ca50c60bd122e99827b7d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_DOCtoODT), @"mvc.1.0.view", @"/Views/DocIO/DOCtoODT.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/DOCtoODT.cshtml", typeof(AspNetCore.Views_DocIO_DOCtoODT))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89b5a003772cf339ca50c60bd122e99827b7d09", @"/Views/DocIO/DOCtoODT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_DOCtoODT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 62, true);
                WriteLiteral(" <span class=\"sampleName\">Import and Export/Word to ODT</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(192, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Export, Word to ODT, Conversion : Syncfusion";

#line default
#line hidden
                BeginContext(295, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml"
      Html.BeginForm("DOCtoODT", "DocIO", FormMethod.Post, new { enctype = "multipart/form-data" });
        {

#line default
#line hidden
                BeginContext(408, 737, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to convert the Word document to ODT using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the resultant ODT document generated by Essential DocIO.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Select Document :
                                ");
                EndContext();
                BeginContext(1146, 102, false);
#line 19 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml"
                           Write(Html.TextBox("file", "", new { type = "file", accept = ".doc,.docx,.rtf,.dot,.dotm,.dotx,docm,.xml" }));

#line default
#line hidden
                EndContext();
                BeginContext(1248, 419, true);
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Convert to ODT"" style=""width:150px;height:27px"" />
                            <br />
                            <div class=""text-danger"">
                                ");
                EndContext();
                BeginContext(1668, 15, false);
#line 26 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml"
                           Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1683, 671, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO provides support to convert the Word document to Open Document Text format.
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about ODT conversion can be found on this
                        <a href=""https://help.syncfusion.com/file-formats/docio/conversion"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 41 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\DOCtoODT.cshtml"

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
