#pragma checksum "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\ImportNestedCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "903cd6917a12edb38ca484dd52f5e36c2e8455d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_ImportNestedCollection), @"mvc.1.0.view", @"/Views/XlsIO/ImportNestedCollection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/ImportNestedCollection.cshtml", typeof(AspNetCore.Views_XlsIO_ImportNestedCollection))]
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
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\ImportNestedCollection.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"903cd6917a12edb38ca484dd52f5e36c2e8455d9", @"/Views/XlsIO/ImportNestedCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_ImportNestedCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 60, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO/ImportNestedCollection</span>");
                EndContext();
            }
            );
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(165, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\ImportNestedCollection.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : Import Nested Collection : Syncfusion";

#line default
#line hidden
                BeginContext(262, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\ImportNestedCollection.cshtml"
      Html.BeginForm("ImportNestedCollection", "XlsIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(350, 1516, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <label>
                            Essential XlsIO allows you to import data directly from nested collection objects with import data layout and group options.
                        </label>
				        <br />
				        <label>
                            This sample demonstrates the usage of Nested Collection objects using Essential XlsIO.
                        </label>
                        <br />
                        <label>
                            Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
                        </label>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <table>
       ");
                WriteLiteral(@"                         <tr>
                                    <td style=""width:110px;"">
                                        <label>
                                            Layout Options
                                        </label>
                                    </td>
                                    <td>
                                        <select name=""LayoutOptions"" id=""layoutOption"" style=""width:200px;"">
                                            ");
                EndContext();
                BeginContext(1866, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa884e0f8c04c968bc9aa5c454d0e35", async() => {
                    BeginContext(1874, 7, true);
                    WriteLiteral("Default");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1890, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(1936, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8f8e70dbc854dc391698549da5bb20c", async() => {
                    BeginContext(1944, 5, true);
                    WriteLiteral("Merge");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1958, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(2004, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ab6bd9f5ad6411798eb9c04ae807d05", async() => {
                    BeginContext(2012, 6, true);
                    WriteLiteral("Repeat");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2027, 3820, true);
                WriteLiteral(@"
                                        </select>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <table>
                                <tr>
								<td style=""width:110px;""></td>
                                    <td>
                                        <input id=""chb1"" type=""checkbox"" name=""checkbox"" value=""Group"" />
                                        <label id=""lb4"">Apply Group</label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class=""rowdiv"" name=""Group Option"" id=""groupOption"">
					<br/>
                        <div class=""celldiv"">
               ");
                WriteLiteral(@"             <table>
                                <tr>
                                    <td style=""width:110px;""></td>
                                    <td>
                                        <label id=""lb1"">Option</label>
                                        <br />
                                        <input id=""rdbExpand"" type=""radio"" name=""rdb1"" checked=""checked"" value=""Expand"" />
                                        <label id=""lb2"">Expand</label>
                                        <br />
                                        <input id=""rdbCollapse"" type=""radio"" name=""rdb1"" value=""Collapse"" />
                                        <label id=""lb3"">Collapse at Level</label>
                                        &nbsp;&nbsp;&nbsp;
                                        <input id=""txb1"" name=""textBox"" type=""text"" value=""1"" style=""width:50px;"" />
                                    </td>
                                </tr>
                            </table>");
                WriteLiteral(@"
                        </div>
                    </div>
                    <br />
                    <div class=""celldiv"">
                        <table>
                            <tr>
                                <td style=""width:110px;""></td>
                                <td>
                                    <input id=""generate"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Create Excel"" style=""width:185px;"" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
            <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#groupOption"").hide();
            $(""#txb1"").hide();
            $(""#chb1"").click(function () {

                var other = $('#chb1:checked').val();
                if (other == undefined) {
                    $(""#groupOption"").hide();
                }
                else {
 ");
                WriteLiteral(@"                   $(""#groupOption"").show();
                }
            });
            $(""#rdbCollapse"").click(function () {

                var other = $('#rdbCollapse:checked').val();
                if (other == undefined) {
                    $(""#txb1"").hide();
                }
                else {
                    $(""#txb1"").show();
                }
            });
            $(""#rdbExpand"").click(function () {

                var other = $('#rdbExpand:checked').val();
                if (other == undefined) {
                    $(""#txb1"").show();
                }
                else {
                    $(""#txb1"").hide();
                }
            });
        });
            </script>
");
                EndContext();
#line 131 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\ImportNestedCollection.cshtml"
        Html.EndForm();
    }

#line default
#line hidden
                BeginContext(5882, 316, true);
                WriteLiteral(@"<style>
    .ename {
        font-weight: bold;
        display: block !important;
        opacity: .87;
    }

    .eimg {
        padding: 10px 8px;
        width: 16px;
        height: 16px;
        float: left;
    }

    .e-dropdownbase .e-list-item * {
        display: block;
    }
</style>
");
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
