#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\DataSorting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d1f3c13b6eb5d59903f4a901d79cfdcac066b80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_DataSorting), @"mvc.1.0.view", @"/Views/XlsIO/DataSorting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/DataSorting.cshtml", typeof(AspNetCore.Views_XlsIO_DataSorting))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\DataSorting.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1f3c13b6eb5d59903f4a901d79cfdcac066b80", @"/Views/XlsIO/DataSorting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_DataSorting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
                BeginContext(75, 51, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / DataSorting</span>");
                EndContext();
            }
            );
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(156, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\DataSorting.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) :Sort Value, Sort Color : Syncfusion";

#line default
#line hidden
                BeginContext(250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\DataSorting.cshtml"
      Html.BeginForm("DataSorting", "XlsIO", FormMethod.Post);
    {

#line default
#line hidden
                BeginContext(323, 1650, true);
                WriteLiteral(@"        <div class=""Common"">
            <div class=""tablediv"">
                <div class=""rowdiv"">
                    <label>
                        Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                        note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
                    </label>
                </div>
                <br />
                <div class=""rowdiv"">
                    <table id=""PanelTable"" width=""450px"">
                        <tr>
                            <td style=""font-weight: bold"">
                                Sort On Values
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <strong>Choose the column to sort:</strong>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
       ");
                WriteLiteral(@"                     <td>
                                <table>
                                    <tr>
                                        <td>
                                            First Column:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </td>
                                        <td>
                                            <select name=""FirstColumn"" id=""firstColumn"">
                                                ");
                EndContext();
                BeginContext(1973, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a209336a200e453cbc99f03e259d7a41", async() => {
                    BeginContext(1981, 2, true);
                    WriteLiteral("ID");
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
                BeginContext(1992, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(2042, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05964d41bffe422387e22cb14c191090", async() => {
                    BeginContext(2050, 4, true);
                    WriteLiteral("Name");
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
                BeginContext(2063, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(2113, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f490764cce4d44f592c26baede12fac2", async() => {
                    BeginContext(2121, 6, true);
                    WriteLiteral("Salary");
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
                BeginContext(2136, 1238, true);
                WriteLiteral(@"
                                            </select>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <div id=""dAddSecondLevel"">
                                    <input type=""checkbox"" id=""addSecondLevel"" name=""SecondLevel"" value=""SecondLevel"" />
                                    Add Level
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table id=""tblSecond"">
                                    <tr>
                                        <td>
                                            Second Column:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             ");
                WriteLiteral("                           </td>\r\n                                        <td>\r\n                                            <select name=\"SecColumn\" id=\"secColunn\">\r\n                                                ");
                EndContext();
                BeginContext(3374, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e43243db4b7421bb785cc01273396fa", async() => {
                    BeginContext(3382, 2, true);
                    WriteLiteral("ID");
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
                BeginContext(3393, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(3443, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "055433b3555f46e1b1026fa09394133d", async() => {
                    BeginContext(3451, 4, true);
                    WriteLiteral("Name");
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
                BeginContext(3464, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(3514, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e42e013be8741d496d1a8fec5ef76b2", async() => {
                    BeginContext(3522, 6, true);
                    WriteLiteral("Salary");
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
                BeginContext(3537, 1443, true);
                WriteLiteral(@"
                                            </select>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <table id=""tblCheckbox"">
                                    <tr>
                                        <td>
                                            <input type=""checkbox"" id=""addThirdLevel"" name=""ThirdLevel"" value=""ThirdLevel"" />
                                            Add Level
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table id=""tblThird"">
                                    <tr>
                                        <td>
                                 ");
                WriteLiteral(@"           Third Column:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        </td>
                                        <td>
                                            <select name=""ThirdColumn"" id=""third"">
                                                ");
                EndContext();
                BeginContext(4980, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "633dce526eb24fb689608919345c4ba8", async() => {
                    BeginContext(4988, 2, true);
                    WriteLiteral("ID");
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
                BeginContext(4999, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(5049, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e39f557b3beb431f8c8ea9515ca36c90", async() => {
                    BeginContext(5057, 4, true);
                    WriteLiteral("Name");
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
                BeginContext(5070, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(5120, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa995c22e76a42839444b060454e0712", async() => {
                    BeginContext(5128, 6, true);
                    WriteLiteral("Salary");
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
                BeginContext(5143, 5624, true);
                WriteLiteral(@"
                                            </select>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Order By
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table id=""tblButton"" width=""150px"" border=""0"">
                                    <tr>
                                        <td>
                                            <table width=""150px"" border=""0"">
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>
                                           ");
                WriteLiteral(@"                     <td>
                                                                    <input id=""ascending"" type=""radio"" name=""SortBy"" checked=""checked"" value=""Ascending"" />
                                                                </td>
                                                                <td>
                                                                        Ascending
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <table>
                                                            <tr>
                                                       ");
                WriteLiteral(@"         <td>
                                                                    <input id=""decending"" type=""radio"" name=""SortBy"" value=""Descending"" />
                                                                </td>
                                                                <td>
                                                                        Descending
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>
                                <input id=""sortvalues"" type=""submit"" na");
                WriteLiteral(@"me=""SortData"" value=""Sort Values"" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <input id=""viewtemplate"" type=""submit"" name=""view"" value=""View Input Template"" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <script type=""text/javascript"">
            $(document).ready(function () {
                $(""#tblSecond"").hide();
                $(""#tblThird"").hide();
                $(""#tblCheckbox"").hide();
                $(""#pOnTop"").hide();
                $(""#pOnBottom"").hide();
                $(""#cmbSortOn"").change(function () {

                    var other = $('#cmbSortOn').val();
                    if (other == ""Values"") {
                        $(""#pOnTop"").hide();
                        $(""#pOnBottom"").hide();
    ");
                WriteLiteral(@"                    $(""#pAscending"").show();
                        $(""#pDescending"").show();
                        $(""#dAddSecondLevel"").show();
                        $(""#firstColumn"").val(""ID"");
                    }
                    else {
                        $(""#firstColumn"").val(""City"");
                        $(""#pOnTop"").show();
                        $(""#pOnBottom"").show();
                        $(""#pAscending"").hide();
                        $(""#pDescending"").hide();
                        $(""#dAddSecondLevel"").hide();
                    }
                });
                $(""#addSecondLevel"").click(function () {

                    var other = $('#addSecondLevel:checked').val();
                    if (other == undefined) {
                        $(""#tblSecond"").hide();
                        $(""#tblCheckbox"").hide();
                        $(""#tblThird"").hide();
                    }
                    else {
                        $(""#tblSecond"").s");
                WriteLiteral(@"how();
                        $(""#tblCheckbox"").show();
                    }
                });

                $(""#addThirdLevel"").click(function () {
                    var other = $('#addThirdLevel:checked').val();
                    if (other == undefined) {
                        $(""#tblThird"").hide();
                    }
                    else {
                        $(""#tblThird"").show();
                    }
                });
            });
        </script>
");
                EndContext();
#line 213 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\DataSorting.cshtml"
        Html.EndForm();
    } 

#line default
#line hidden
                BeginContext(10801, 2, true);
                WriteLiteral("\r\n");
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
