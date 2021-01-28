#pragma checksum "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Pdf\Conformance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d1927032038eb91ada88430c3de0b31ba81d2f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_Conformance), @"mvc.1.0.view", @"/Views/Pdf/Conformance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/Conformance.cshtml", typeof(AspNetCore.Views_Pdf_Conformance))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1927032038eb91ada88430c3de0b31ba81d2f3", @"/Views/Pdf/Conformance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_Conformance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 74, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Conformance/PDF Conformance Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(129, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Pdf\Conformance.cshtml"
      Html.BeginForm("Conformance", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(204, 2491, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates various PDF conformance support in Essential PDF. Essential PDF provides support for PDF/A-1b, PDF/A-2b, and PDF/A-3b  conformance.
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
							<div style=""border: solid 1px #EDEDED; padding: 5px 7px 5px 7px;"">
							<table>
									<tr>
                                        <td align=""left"" width=""100%"">
                                            <span style=""display: inline-block; width: 165px; margin-left: 10px"">
                                                <input type=""radio"" checked=""checked"" value=""Pdf_A1B"" name=""radioButton"" id=""radioButton1""><label for=""radioButton1"">&nbsp;&nbsp;PDF/A-1b</label>
                                            </span>
          ");
                WriteLiteral(@"                                  <span style=""display: inline-block; width: 165px; margin-left: 10px"">
                                                <input type=""radio"" value=""Pdf_A2B"" name=""radioButton"" id=""radioButton2""><label for=""radioButton2"">&nbsp;&nbsp;PDF/A-2b</label>
                                            </span>
                                            <span style=""display: inline-block; width: 165px; margin-left: 10px"">
                                                <input type=""radio"" value=""Pdf_A3B"" name=""radioButton"" id=""radioButton3""><label for=""radioButton3"">&nbsp;&nbsp;PDF/A-3b</label>
                                            </span>
                                        </td>
                                    </tr>
							</table>
							</div>
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
                            </div>
                        </div>
    ");
                WriteLiteral(@"                </div>
                </div>
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">

                    This feature can be used for long term archiving and standardization. More information about conformance can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-pdf-conformance"">section</a>.

                </div>
            </div>
");
                EndContext();
#line 47 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Pdf\Conformance.cshtml"
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
