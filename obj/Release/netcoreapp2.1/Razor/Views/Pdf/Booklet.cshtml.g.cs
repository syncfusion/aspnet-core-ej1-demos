#pragma checksum "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Pdf\Booklet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7f16da41571447d8b0188e04d9c6a68b5b94d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_Booklet), @"mvc.1.0.view", @"/Views/Pdf/Booklet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/Booklet.cshtml", typeof(AspNetCore.Views_Pdf_Booklet))]
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
#line 1 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7f16da41571447d8b0188e04d9c6a68b5b94d1", @"/Views/Pdf/Booklet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_Booklet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 73, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Modify Documents / Booklet Sample</span>\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(124, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Pdf\Booklet.cshtml"
      Html.BeginForm("Booklet", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(195, 79, true);
                WriteLiteral("            <div class=\"Common\">\r\n                <label>\r\n                    ");
                EndContext();
                BeginContext(275, 17, false);
#line 9 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Pdf\Booklet.cshtml"
               Write(ViewData["Error"]);

#line default
#line hidden
                EndContext();
                BeginContext(292, 2354, true);
                WriteLiteral(@"
                </label>
                <div class=""tablediv"" style=""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to create a booklet from the existing PDF document. 
                </div>
                <br/>
                <b>Page Settings</b>
                <div class=""tablediv"" style=""padding-top:7px"">
                    <div style=""border: solid 1px #EDEDED; padding: 5px 7px 5px 7px;"">
                        <table width=""100%"">
                            <tr>
                                <td align=""left"" width=""40%"">
                                    <label>
                                        Page Width : &nbsp
                                    </label>
                                    <input id=""pagewidth"" type=""text"" class=""TextBox"" value=""595"" name=""PageWidth"" />
                                </td>
                                <td align=""center"" width=""30%"">
                                    <label class=""LabelRi");
                WriteLiteral(@"ght"">
                                        Page Height : &nbsp
                                    </label>
                                    <input id=""pageheight"" type=""text"" name=""PageHeight"" class=""TextBox"" value=""550"" />
                                </td>
                                <td align=""right"" width=""30%"">
                                    <input id=""doubleside"" type=""checkbox"" name=""CheckBoxDoubleSide"" value=""DoubleSide"" />
                                    <label> Double Side</label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <br/>
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
                            </div>");
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">
                    This feature can be used to print the PDF document in book format.
                </div>
            </div>
");
                EndContext();
#line 55 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Pdf\Booklet.cshtml"
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
