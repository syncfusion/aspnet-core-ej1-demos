#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\AutoTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34f5f3bf76f43b98368aa3db64b361843a5458f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_AutoTag), @"mvc.1.0.view", @"/Views/Pdf/AutoTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/AutoTag.cshtml", typeof(AspNetCore.Views_Pdf_AutoTag))]
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
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34f5f3bf76f43b98368aa3db64b361843a5458f", @"/Views/Pdf/AutoTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_AutoTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 59, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">PDF /Autotag Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(85, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(114, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\AutoTag.cshtml"
      Html.BeginForm("Autotag", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(185, 1290, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style=""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to create tagged PDF or accessible PDF from the scratch using auto tag feature.The auto tag feature will tag the document based on PDF element created in the document.
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

                    This feature can be used for the people who require assistive technologies when the electronic content is ready.The Essential PDF su");
                WriteLiteral(@"pports creating tagged PDF with Section 508 compliant.More information about the tagged PDF can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-tagged-pdf"">section.</a>

                </div>
            </div>
");
                EndContext();
#line 30 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\AutoTag.cshtml"
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
