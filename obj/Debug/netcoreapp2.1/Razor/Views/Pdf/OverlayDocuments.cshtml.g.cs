#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\OverlayDocuments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69d49c59e85d7c281b1edb1eea6710869724788e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_OverlayDocuments), @"mvc.1.0.view", @"/Views/Pdf/OverlayDocuments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/OverlayDocuments.cshtml", typeof(AspNetCore.Views_Pdf_OverlayDocuments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d49c59e85d7c281b1edb1eea6710869724788e", @"/Views/Pdf/OverlayDocuments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_OverlayDocuments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 83, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Modify Documents / Overlay Documents Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(109, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(136, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\OverlayDocuments.cshtml"
      Html.BeginForm("OverlayDocuments", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(216, 79, true);
                WriteLiteral("            <div class=\"Common\">\r\n                <label>\r\n                    ");
                EndContext();
                BeginContext(296, 17, false);
#line 10 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\OverlayDocuments.cshtml"
               Write(ViewData["Error"]);

#line default
#line hidden
                EndContext();
                BeginContext(313, 932, true);
                WriteLiteral(@"
                </label>
                <div class=""tablediv""style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to overlay two different PDF documents into a single PDF document.
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


                    This feature can be used to draw template pages from one document into another for easy designing.
                </div>
            </div>
");
                EndContext();
#line 32 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\OverlayDocuments.cshtml"
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
