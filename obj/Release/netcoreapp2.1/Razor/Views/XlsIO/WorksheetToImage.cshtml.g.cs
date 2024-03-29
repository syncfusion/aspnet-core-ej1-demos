#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\WorksheetToImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f776f091416564ebf08cb335dbd06efd65e415c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_WorksheetToImage), @"mvc.1.0.view", @"/Views/XlsIO/WorksheetToImage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/WorksheetToImage.cshtml", typeof(AspNetCore.Views_XlsIO_WorksheetToImage))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\WorksheetToImage.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f776f091416564ebf08cb335dbd06efd65e415c0", @"/Views/XlsIO/WorksheetToImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_WorksheetToImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(71, 56, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / WorksheetToImage</span>");
                EndContext();
            }
            );
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(158, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 5 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\WorksheetToImage.cshtml"
           ViewBag.Title = "    Essential XlsIO (Excel) : Worksheet To Image : Syncfusion";

#line default
#line hidden
                BeginContext(286, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\WorksheetToImage.cshtml"
  Html.BeginForm("WorksheetToImage", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(356, 2274, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                A worksheet is converted to an image with few limitations. The image is of any format, and can also be saved as the memory stream.
                <br />
                <b>Features</b>
                <br />
                <ul>
                    <li>Convert entire Excel worksheet into Image.</li>
                    <li>Convert specific Excel range into Image.</li>
                    <li>Convert Excel document with,</li>
                    <li>Pivot tables</li>
                    <li>Conditional formatting</li>
                    <li>Styles</li>
                    <li>Rich-text formatting</li>
                    <li>Text alignments</li>
                    <li>Images</li>
                    <li>Text boxes</li>
                    <li>Unicode characters</li>
                </ul>
            </div>
            <div class=""rowdiv"">
                <label>
                   ");
                WriteLiteral(@" Click the button below to convert the Excel worksheet to image using Essential XlsIO.
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        <strong>Image Format:</strong>
                    </label>
                    &nbsp;&nbsp;&nbsp; &nbsp;
                    <input type=""radio"" id=""rdButtonPng"" name=""Group1"" value=""PNG"" checked=""checked"" />
                    <label for=""rdButtonPng"">
                        PNG
                    </label>
                    &nbsp; &nbsp; &nbsp; &nbsp;
                    <input type=""radio"" id=""rdButtonJpeg"" name=""Group1"" value=""JPEG"" />
                    <label for=""rdButtonJpeg"">
                        JPEG
                    </label>
                </div>
                <br />

                <div class=""celldiv"">
                    <input id=""viewtemplate"" class=""buttonStyle"" type=""submit"" name=""butt");
                WriteLiteral("on\" value=\"Input Template\" style=\"width:110px;\" />\r\n                    <input class=\"buttonStyle\" type=\"submit\" value=\"Convert\" style=\"width:120px;\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 61 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\WorksheetToImage.cshtml"
    Html.EndForm();
} 

#line default
#line hidden
                BeginContext(2671, 14, true);
                WriteLiteral("              ");
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
