#pragma checksum "D:\Work\GitHub\aspnet-core-ej1-demos\Views\XlsIO\WorksheetToHTML.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1706af47b533f5abf025659c38ac3544f273bfcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_WorksheetToHTML), @"mvc.1.0.view", @"/Views/XlsIO/WorksheetToHTML.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/WorksheetToHTML.cshtml", typeof(AspNetCore.Views_XlsIO_WorksheetToHTML))]
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
#line 1 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\XlsIO\WorksheetToHTML.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1706af47b533f5abf025659c38ac3544f273bfcc", @"/Views/XlsIO/WorksheetToHTML.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_WorksheetToHTML : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 55, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / WorksheetToHTML</span>");
                EndContext();
            }
            );
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(161, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\XlsIO\WorksheetToHTML.cshtml"
           ViewBag.Title = "    Essential XlsIO (Excel) : Worksheet To HTML : Syncfusion";

#line default
#line hidden
                BeginContext(288, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\XlsIO\WorksheetToHTML.cshtml"
  Html.BeginForm("WorksheetToHTML", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(357, 1370, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                <label>
                    Click the convert button below to view the converted HTML document using Essential XlsIO.
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        <strong>Convert Type: </strong>
                    </label>
                    &nbsp;
                    <input type=""radio"" id=""rdButtonPng"" name=""Group1"" value=""Workbook"" checked=""checked"" />
                    <label for=""rdButtonPng"">
                        Workbook
                    </label>
                    &nbsp;
                    <input type=""radio"" id=""rdButtonJpeg"" name=""Group1"" value=""Worksheet"" />
                    <label for=""rdButtonJpeg"">
                        Worksheet
                    </label>
                </div>
                <br />

       ");
                WriteLiteral(@"         <div class=""celldiv"">
                    <input id=""viewtemplate"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Input Template"" style=""width:125px;""/>
                    <input class=""buttonStyle"" type=""submit"" value=""Convert"" style=""width:125px;"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 44 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\XlsIO\WorksheetToHTML.cshtml"
    Html.EndForm();
} 

#line default
#line hidden
                BeginContext(1768, 14, true);
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
