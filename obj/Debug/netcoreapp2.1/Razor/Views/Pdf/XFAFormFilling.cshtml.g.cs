#pragma checksum "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Pdf\XFAFormFilling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "258ea47daa40a45a078764aa3a57fe8ed6e8a5a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_XFAFormFilling), @"mvc.1.0.view", @"/Views/Pdf/XFAFormFilling.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/XFAFormFilling.cshtml", typeof(AspNetCore.Views_Pdf_XFAFormFilling))]
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
#line 1 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258ea47daa40a45a078764aa3a57fe8ed6e8a5a8", @"/Views/Pdf/XFAFormFilling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_XFAFormFilling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 63, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">XFA Form Filling Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(116, 28, true);
                WriteLiteral("\r\n    <div class=\"Common\">\r\n");
                EndContext();
#line 7 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Pdf\XFAFormFilling.cshtml"
          Html.BeginForm("XFAFormFilling", "Pdf", FormMethod.Post);
            {

#line default
#line hidden
                BeginContext(228, 1362, true);
                WriteLiteral(@"            <div class=""tablediv"" style=""font-size:14px"">
                <div class=""rowdiv"">
                    <div class=""celldiv"">
                        <div>
                            <table width=""100%"">
                                <tr>
                                    <td>
                                        Click the button to view an PDF document generated by Essential PDF. Please note
                                        that Adobe Reader or its equivalent is required to view the resultant document.
                                    </td>
                                <tr>
                                    <td align=""left"" width=""100%"">
                                        <br />
                                        <input id=""viewtemplate"" type=""submit"" name=""submit1"" value=""View Template"" style=""width:150px; text-transform:capitalize"" />
                                        &emsp;
                                        <input id=""createpdf"" type=""");
                WriteLiteral(@"submit"" name=""submit"" value=""Generate PDF"" style=""width:150px; text-transform:capitalize"" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <br />
");
                EndContext();
#line 33 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Pdf\XFAFormFilling.cshtml"
                Html.EndForm();
            }

#line default
#line hidden
                BeginContext(1639, 12, true);
                WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
