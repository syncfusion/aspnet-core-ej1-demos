#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Pdf\FindText.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2665c8dc7e0e205523326c1885ed07e7dea269d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_FindText), @"mvc.1.0.view", @"/Views/Pdf/FindText.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/FindText.cshtml", typeof(AspNetCore.Views_Pdf_FindText))]
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
#line 5 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2665c8dc7e0e205523326c1885ed07e7dea269d0", @"/Views/Pdf/FindText.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_FindText : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<samplebrowser.Models.FindTextMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 56, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Find Text Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(82, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(156, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Pdf\FindText.cshtml"
      Html.BeginForm("FindText", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(228, 1173, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <label class=""rowdiv"">
                        Click the button to find a text from the PDF document using Essential PDF.
                    </label>
                </div>
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div style=""border: solid 1px #EDEDED; padding: 5px 7px 5px 7px;"">
                                <table style=""width:100%"">
                                    <tr>
                                        <td align=""right"">
                                            <input type=""submit"" class=""Button"" value=""View Template"" name=""ViewTemplate"" />
                                            <input type=""submit"" class=""Button"" value=""Find Text"" name=""Find"" />
                                        </td>
                                    </tr>
                                </t");
                WriteLiteral("able>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 34 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Pdf\FindText.cshtml"
            Html.EndForm();
        }

#line default
#line hidden
                BeginContext(1442, 16, true);
                WriteLiteral("    <br />\r\n    ");
                EndContext();
                BeginContext(1459, 80, false);
#line 37 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Pdf\FindText.cshtml"
Write(Html.TextAreaFor(s=>s.Message, 1,1, new { @style = "width:100%; height:56px"  }));

#line default
#line hidden
                EndContext();
                BeginContext(1539, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1570, 117, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .frame {\r\n            width: 85%;\r\n        }\r\n    </style>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<samplebrowser.Models.FindTextMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
