#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\MergeDocuments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ef1dcd0b29ebf84e134d7940ebe93ec9a9ebff7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_MergeDocuments), @"mvc.1.0.view", @"/Views/Pdf/MergeDocuments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/MergeDocuments.cshtml", typeof(AspNetCore.Views_Pdf_MergeDocuments))]
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
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef1dcd0b29ebf84e134d7940ebe93ec9a9ebff7", @"/Views/Pdf/MergeDocuments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_MergeDocuments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 81, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Modify Documents / Merge Documents Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(134, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 7 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\MergeDocuments.cshtml"
      Html.BeginForm("MergeDocuments", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(214, 79, true);
                WriteLiteral("            <div class=\"Common\">\r\n                <label>\r\n                    ");
                EndContext();
                BeginContext(294, 17, false);
#line 11 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\MergeDocuments.cshtml"
               Write(ViewData["Error"]);

#line default
#line hidden
                EndContext();
                BeginContext(311, 1212, true);
                WriteLiteral(@"
                </label>
                <div class=""tablediv"" style=""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to merge two different PDF documents into single PDF document. It is also possible to import pages to the PDF document.                   
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
                    This feature can be used to assemble PDF documents for printing, electronic distribution, and bundle PDF for archiving.
                    More information about the m");
                WriteLiteral("erge and import pages can be found in this documentation <a href=\"https://help.syncfusion.com/file-formats/pdf/merge-documents\">section.</a>\r\n\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 33 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\MergeDocuments.cshtml"
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
