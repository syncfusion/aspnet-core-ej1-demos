#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\Pdf\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30ff81bf30791e8f5ebfb2047ffeed2c316b70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_Portfolio), @"mvc.1.0.view", @"/Views/Pdf/Portfolio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/Portfolio.cshtml", typeof(AspNetCore.Views_Pdf_Portfolio))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30ff81bf30791e8f5ebfb2047ffeed2c316b70d", @"/Views/Pdf/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 68, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">User Interaction / Portfolio</span>\r\n");
                EndContext();
            }
            );
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(121, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\Pdf\Portfolio.cshtml"
      Html.BeginForm("Portfolio", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(194, 1240, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""Outer"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to create portfolio in the PDF document. You can also extract and remove files from the PDF portfolio.

                    <br />
                    This feature allows the user to bring content together from variety of sources including documents, drawings, images, emails, spreadsheets, and web pages.
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
              ");
                WriteLiteral("      More information about the portfolio can be found in this documentation <a href=\"https://help.syncfusion.com/file-formats/pdf/working-with-portfolio\">section.</a>\r\n\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 31 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\Pdf\Portfolio.cshtml"
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
