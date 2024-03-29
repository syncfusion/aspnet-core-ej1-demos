#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\PivotLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c713be232234a90aa87a7c26606663ca7199bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_PivotLayout), @"mvc.1.0.view", @"/Views/XlsIO/PivotLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/PivotLayout.cshtml", typeof(AspNetCore.Views_XlsIO_PivotLayout))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\PivotLayout.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c713be232234a90aa87a7c26606663ca7199bc", @"/Views/XlsIO/PivotLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_PivotLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(73, 51, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / PivotLayout</span>");
                EndContext();
            }
            );
            BeginContext(127, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(157, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\PivotLayout.cshtml"
            ViewBag.Title = "    Essential XlsIO (Excel) : Pivot Table Layout, Pivot Table Formatting : Syncfusion";

#line default
#line hidden
                BeginContext(307, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\PivotLayout.cshtml"
  Html.BeginForm("PivotLayout", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(372, 2560, true);
                WriteLiteral(@"    <div class=""Common1"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                When there is a need to summarize large reports, Excel allows you to summarize data through pivot table insertion. Microsoft Excel supplies various built-in styles for pivot tables, allowing the creation of pivot tables with rich formats and more flexibility in summarizing reports. 
                <br />
                <br />
                <b>Features:</b>
                <br />
                <br />
                <ul>
                    <li>Create and layout pivot table from template data</li>
                    <li>Format pivot table cells with cell styles</li>
                    <li>Convert pivot table to PDF</li>
                </ul>
            </div>
            <br />
            <div class=""rowdiv"">
                <label>
                    Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                    note that Microsoft Exce");
                WriteLiteral(@"l Viewer or Microsoft Excel is required to view the resultant document.
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        <strong>Layout options:</strong>
                    </label>
                    <input id=""rbtncompact"" type=""radio"" name=""LayoutOption"" value=""Compact"" checked=""checked"" />
                    <label for=""rbtncompact"">
                        Compact
                    </label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <input id=""rbtnoutline"" type=""radio"" name=""LayoutOption"" value=""Outline"" />
                    <label for=""rbtnoutline"">
                        Outline
                    </label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <input id=""rbtntabular"" type=""radio"" name=""LayoutOption"" value=""Tabular"" />
                    <label for=""rbtntabular"">
       ");
                WriteLiteral(@"                 Tabular
                    </label>
                </div>
                <br />
                <div class=""celldiv"">
                    <input id=""createpivottable"" class=""buttonStyle"" name=""button"" type=""submit"" value=""Create Pivot Table"" style=""width: 200px;"" />
                    <input id=""convertpivottable"" class=""buttonStyle"" name=""button"" type=""submit"" value=""Convert to PDF"" style=""width: 200px;"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 62 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\PivotLayout.cshtml"
    Html.EndForm();
    }
  

#line default
#line hidden
            }
            );
            BeginContext(2983, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
