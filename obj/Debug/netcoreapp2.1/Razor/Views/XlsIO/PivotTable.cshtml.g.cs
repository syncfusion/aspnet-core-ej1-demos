#pragma checksum "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\XlsIO\PivotTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bdd0adaf44bc81b78a85ad6d50f2e7245dbbf50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_PivotTable), @"mvc.1.0.view", @"/Views/XlsIO/PivotTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/PivotTable.cshtml", typeof(AspNetCore.Views_XlsIO_PivotTable))]
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
#line 1 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\XlsIO\PivotTable.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdd0adaf44bc81b78a85ad6d50f2e7245dbbf50", @"/Views/XlsIO/PivotTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_PivotTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(73, 50, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / PivotTable</span>");
                EndContext();
            }
            );
            BeginContext(126, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(156, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\XlsIO\PivotTable.cshtml"
            ViewBag.Title = "    Essential XlsIO (Excel) : Pivot Table, Formatting : Syncfusion";

#line default
#line hidden
                BeginContext(287, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\XlsIO\PivotTable.cshtml"
  Html.BeginForm("PivotTable", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(351, 3222, true);
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
                    <li>Creating pivot tables from template data</li>
                    <li>Customizing pivot tables with various properties</li>
                    <li>Formatting pivot tables with built-in styles</li>
                </ul>
            </div>
            <br />
            <div class=""rowdiv"">
                <label>
                    Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                    note th");
                WriteLiteral(@"at Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        <strong>Page Filter :</strong>
                    </label>
                    <input id=""ckbPageFilter"" type=""checkbox"" name=""PageFilter"" checked=""checked"" value=""PageFilter"" onclick=""MultipleFilterDisable();"" />
                    <label for=""rbtnPageFilter"">
                        Page Filter
                    </label>
                    <input id=""ckbMultiplePageFilter"" type=""checkbox"" name=""MultiplePageFilter"" value=""MultiplePageFilter"" onclick=""PageFilterDisable();"" />
                    <label for=""rbtnMultiplePageFilter"">
                        Multiple Page Filter
                    </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                <br />
   ");
                WriteLiteral(@"             <div class=""celldiv"">
                    <label>
                        <strong>Row and Column Filter :</strong>
                    </label>
                    <input id=""ckbRowFilter"" type=""checkbox"" name=""RowFilter"" value=""RowFilter"" onclick=""Enable();"" />
                    <label for=""rbtnRowFilter"">
                        Row Filter
                    </label>
                    <input id=""ckbColumnFilter"" type=""checkbox"" name=""ColumnFilter"" value=""ColumnFilter"" onclick=""Enable();"" />
                    <label for=""rbtnColumnFilter"">
                        Column Filter
                    </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                <div class=""celldiv"">
                    <input id=""createdocument"" class=""buttonStyle"" name=""button"" type=""submit"" value=""Create Document"" style=""width: 200px;"" />
                    <input id=""customizepivottable"" class=""buttonStyle"" name=""button"" type=""submit"" value=");
                WriteLiteral("\"Customize Pivot Table\"\r\n                           style=\"width: 200px;\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 72 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\XlsIO\PivotTable.cshtml"
    Html.EndForm();
    }
  

#line default
#line hidden
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(3648, 857, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        function PageFilterDisable() {
            $(""#ckbPageFilter"").attr(""checked"", false);
        }
        function MultipleFilterDisable() {
            $(""#ckbMultiplePageFilter"").attr(""checked"", false);
        }
        function Enable() {
            if (!$(""#ckbRowFilter"").attr(""checked"") && !$(""#ckbColumnFilter"").attr(""checked"")) {
                $(""#rbtnLabelFilter"").attr(""disabled"", false);
                $(""#rbtnValueFilter"").attr(""disabled"", false);
                $(""#RCMultipleFilter"").attr(""disabled"", false);
            }
            else {
                $(""#rbtnLabelFilter"").attr(""disabled"", true);
                $(""#rbtnValueFilter"").attr(""disabled"", true);
                $(""#RCMultipleFilter"").attr(""disabled"", true);
            }
        }
    </script>

");
                EndContext();
            }
            );
            BeginContext(4508, 2, true);
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
