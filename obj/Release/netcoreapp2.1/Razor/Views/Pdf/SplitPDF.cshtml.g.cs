#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Pdf\SplitPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b5004416d79b4df8a5e5f6a4b00c44d30513be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_SplitPDF), @"mvc.1.0.view", @"/Views/Pdf/SplitPDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/SplitPDF.cshtml", typeof(AspNetCore.Views_Pdf_SplitPDF))]
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
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5004416d79b4df8a5e5f6a4b00c44d30513be1", @"/Views/Pdf/SplitPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_SplitPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 74, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Modify Documents / SplitPDF Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(127, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Pdf\SplitPDF.cshtml"
        using (Html.BeginForm("SplitPDF", "Pdf", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
                BeginContext(249, 370, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to split the PDF pages into multiple PDF documents.
                </div>
                <div id=""errorlabel"" value=""error"">
                    <p style=""color: #FF0000;"">
                        ");
                EndContext();
                BeginContext(620, 35, false);
#line 14 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Pdf\SplitPDF.cshtml"
                   Write(Html.Label("", (string)ViewBag.lab));

#line default
#line hidden
                EndContext();
                BeginContext(655, 1183, true);
                WriteLiteral(@"
                </div>
                <br />
                <div>
                    <input type=""file"" name=""file"" value=""PDF document to split"" accept=""application/pdf"" />
                </div>
                <div style=""padding-top:7px"">
                    <label for=""page index"">Enter split page no</label>
                    <input type=""text"" name=""pageIndex"" id=""pageIndex"" style=""margin-left: 12px"" value=""1"" width:70%"" />
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">

                    This feature will");
                WriteLiteral(" be used to split the necessary pages from the PDF document, split a large sized PDF into a smaller one and more.\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 40 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Pdf\SplitPDF.cshtml"
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
