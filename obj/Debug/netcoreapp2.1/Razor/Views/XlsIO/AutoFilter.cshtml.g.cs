#pragma checksum "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d70e7f8df2e2c2f2c20fbac39aefe942545bb7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_AutoFilter), @"mvc.1.0.view", @"/Views/XlsIO/AutoFilter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/AutoFilter.cshtml", typeof(AspNetCore.Views_XlsIO_AutoFilter))]
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
#line 1 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70e7f8df2e2c2f2c20fbac39aefe942545bb7e2", @"/Views/XlsIO/AutoFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_AutoFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
                BeginContext(75, 50, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / AutoFilter</span>");
                EndContext();
            }
            );
            BeginContext(128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(155, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : Auto Filter : Syncfusion";

#line default
#line hidden
                BeginContext(239, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml"
      Html.BeginForm("AutoFilter", "XlsIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(315, 1049, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <label>
                            This sample demonstrates how to apply different types of filters within a range.
                        </label>
                        <br />
                        <br />
                        <label>
                            Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                            note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
                        </label>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <label>
                                Select the Filter Type 
                            </label> &nbsp;
                            <select name=""FilterType"" id=""filterType"">
       ");
                WriteLiteral("                         ");
                EndContext();
                BeginContext(1364, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f754921f06c48deaf0090080d77b6c4", async() => {
                    BeginContext(1372, 13, true);
                    WriteLiteral("Custom Filter");
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
                BeginContext(1394, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1428, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d10e2dee8aa34ed59ac8b4c7c1b45d0c", async() => {
                    BeginContext(1436, 11, true);
                    WriteLiteral("Text Filter");
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
                BeginContext(1456, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1490, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd0f9485c554b14900000eba3ca8871", async() => {
                    BeginContext(1498, 15, true);
                    WriteLiteral("DateTime Filter");
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
                BeginContext(1522, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1556, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a12e2926954957b77fc0c522dc2469", async() => {
                    BeginContext(1564, 14, true);
                    WriteLiteral("Dynamic Filter");
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
                BeginContext(1587, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1621, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51aca1811d84ee684f1b8afea0a87f5", async() => {
                    BeginContext(1629, 12, true);
                    WriteLiteral("Color Filter");
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
                BeginContext(1650, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1684, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d31798da6d849a495667bc9823df5ee", async() => {
                    BeginContext(1692, 11, true);
                    WriteLiteral("Icon Filter");
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
                BeginContext(1712, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1746, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "018d5fe6262c494f83e3bfb9c11ac658", async() => {
                    BeginContext(1754, 15, true);
                    WriteLiteral("Advanced Filter");
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
                BeginContext(1778, 2225, true);
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <br />
                    <div name=""Action Type"" id=""actionType"">
                        <label id=""lb1"">Action Type</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input id=""rdb1"" type=""radio"" name=""rdb1"" checked=""checked"" value=""FilterIN"" />
                        <label id=""lb2"">Filter In Place</label> &nbsp;&nbsp;&nbsp;
                        <input id=""rdb2"" type=""radio"" name=""rdb1"" value=""FilterCopy"" />
                        <label id=""lb3"">Filter Copy</label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <i");
                WriteLiteral(@"nput id=""chb1"" type=""checkbox"" name=""checkbox"" value=""Unique"" />
                        <label id=""lb4"">Unique Records</label>
                    </div>

                    <div name=""Color Filter Type"" id=""colorFilterType"">
                        <label id=""lb2"">Filter Type</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input id=""rdb3"" type=""radio"" name=""rdb3"" checked=""checked"" value=""FontColor"" />
                        <label id=""lb3"">Font Color</label> &nbsp;&nbsp;&nbsp;
                        <input id=""rdb4"" type=""radio"" name=""rdb3"" value=""CellColor"" />
                        <label id=""lb4"">Cell Color</label>
                        <br />
                        <br />
                        <label>
                            Color 
                        </label> &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&n");
                WriteLiteral("bsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                        <select name=\"ColorsList\" id=\"colorsList\" style=\"width:120px;\">\r\n                            ");
                EndContext();
                BeginContext(4003, 20, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17a64bc463cf46e8aead0ca115e32ab4", async() => {
                    BeginContext(4011, 3, true);
                    WriteLiteral("Red");
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
                BeginContext(4023, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4053, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a310ca6734743aba72fa5d8b1b688f8", async() => {
                    BeginContext(4061, 4, true);
                    WriteLiteral("Blue");
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
                BeginContext(4074, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4104, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10773172fe304804a72fc168282532a8", async() => {
                    BeginContext(4112, 5, true);
                    WriteLiteral("Green");
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
                BeginContext(4126, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4156, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34204cd5b96b4c6eb60655c472b29022", async() => {
                    BeginContext(4164, 6, true);
                    WriteLiteral("Yellow");
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
                BeginContext(4179, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4209, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b4db3f58a544b3b08288ea15b353ba", async() => {
                    BeginContext(4217, 5, true);
                    WriteLiteral("Empty");
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
                BeginContext(4231, 449, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <div name=""IconSet Type"" id=""iconSetType"">
                        <label id=""lb5"">IconSet Type</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <select name=""IconSetTypeList"" id=""iconSetTypeList"" onchange=""onIconSetIndexChanged()"" style=""width:120px;"">
                            ");
                EndContext();
                BeginContext(4680, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1afdd861e029481892ced6cff2e5526a", async() => {
                    BeginContext(4688, 12, true);
                    WriteLiteral("ThreeSymbols");
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
                BeginContext(4709, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4739, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b6b99171ae449097d20fb67e67cfaa", async() => {
                    BeginContext(4747, 10, true);
                    WriteLiteral("FourRating");
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
                BeginContext(4766, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4796, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fae34d370344d30ac1dea263c36fdfb", async() => {
                    BeginContext(4804, 10, true);
                    WriteLiteral("FiveArrows");
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
                BeginContext(4823, 972, true);
                WriteLiteral(@"
                        </select>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <div>
                            <table>
                                <tr>
                                    <td>
                                        <label>
                                            Icon ID
                                        </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <div class=""control"" id=""iconListComboBox"">
");
                EndContext();
#line 93 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml"
                                              
                                                Html.EJ()
                                                    .ComboBox("selectIcon")
                                                    .Width("55%")
                                                    .Datasource((IEnumerable<MVCSampleBrowser.Models.icons>)ViewBag.datasource)
                                                    .ComboBoxFields(h => h.Text("iconId"))
                                                    .ItemTemplate("<div><img class=\"eimg\" src=\"../Images/XlsIO/autofilter/${image}.png\" /><div class=\"ename\"> ${iconId} </div></div>")
                                                    .Placeholder("Select Icon")
                                                    .ShowClearButton()
                                                    .Index(0)
                                                    .Text("1")
                                                    .ClientSideEvents(e => e.Change("onChange"))
                                                    .Render();
                                            

#line default
#line hidden
                BeginContext(6946, 134, true);
                WriteLiteral("                                        </div>\r\n                                        <div class=\"control\" id=\"iconListComboBox2\">\r\n");
                EndContext();
#line 109 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml"
                                              
                                                Html.EJ()
                                                    .ComboBox("selectIcon2")
                                                    .Width("55%")
                                                    .Datasource((IEnumerable<MVCSampleBrowser.Models.icons>)ViewBag.datasource2)
                                                    .ComboBoxFields(h => h.Text("iconId"))
                                                    .ItemTemplate("<div><img class=\"eimg\" src=\"../Images/XlsIO/autofilter/${image}.png\" /><div class=\"ename\"> ${iconId} </div></div>")
                                                    .Placeholder("Select Icon")
                                                    .Index(0)
                                                    .ClientSideEvents(e => e.Change("onChange"))
                                                    .Text("1")
                                                    .Render();
                                            

#line default
#line hidden
                BeginContext(8161, 134, true);
                WriteLiteral("                                        </div>\r\n                                        <div class=\"control\" id=\"iconListComboBox3\">\r\n");
                EndContext();
#line 124 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml"
                                              
                                                Html.EJ()
                                                    .ComboBox("selectIcon3")
                                                    .Width("55%")
                                                    .Datasource((IEnumerable<MVCSampleBrowser.Models.icons>)ViewBag.datasource3)
                                                    .ComboBoxFields(h => h.Text("iconId"))
                                                    .ItemTemplate("<div><img class=\"eimg\" src=\"../Images/XlsIO/autofilter/${image}.png\" /><div class=\"ename\"> ${iconId} </div></div>")
                                                    .Placeholder("Select Icon")
                                                    .Index(0)
                                                    .Text("1")
                                                    .ClientSideEvents(e => e.Change("onChange"))
                                                    .Render();
                                            

#line default
#line hidden
                BeginContext(9376, 3986, true);
                WriteLiteral(@"                                        </div>

                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <br />
                    <div class=""celldiv"">
                        <table>
                            <tr>
                                <td>
                                    <input id=""viewtemplate"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Input Template"" style=""width:120px;"" />
                                </td>
                                <td style=""width:10px;"">
                                    &nbsp;&nbsp;
                                </td>
                                <td>
                                    <input id=""generate"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Create Document"" style=""width:120px;"" />
                                </td>
                            </tr>
         ");
                WriteLiteral(@"               </table>
                    </div>
                    <div>
                        <input id=""iconIdText"" name=""iconText"" type=""radio"" checked=""checked"" value=""0"" hidden=""hidden"" />
                    </div>
                </div>
            </div>
            <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#actionType"").hide();
            $(""#colorFilterType"").hide();
            $(""#iconSetType"").hide();
            $(""#iconListComboBox2"").hide();
            $(""#iconListComboBox3"").hide();
            $(""#filterType"").change(function () {

                var other = $('#filterType').val();
                if (other == ""Advanced Filter"") {
                    $(""#actionType"").show();
                    $(""#colorFilterType"").hide();
                    $(""#iconSetType"").hide();
                }
                else if (other == ""Icon Filter"") {
                    $(""#colorFilterType"").hide();
                    $(""#actio");
                WriteLiteral(@"nType"").hide();
                    $(""#iconSetType"").show();
                }
                else if (other == ""Color Filter"") {
                    $(""#colorFilterType"").show();
                    $(""#actionType"").hide();
                    $(""#iconSetType"").hide();
                }
                else {
                    $(""#actionType"").hide();
                    $(""#colorFilterType"").hide();
                    $(""#iconSetType"").hide();
                }
            });
        });
            </script>
            <script type=""text/javascript"">
        function onIconSetIndexChanged() {
            if (iconSetTypeList.selectedIndex == 0) {
                $(""#iconListComboBox"").show();
                $(""#iconListComboBox2"").hide();
                $(""#iconListComboBox3"").hide();
            }
            else if (iconSetTypeList.selectedIndex == 1) {
                $(""#iconListComboBox"").hide();
                $(""#iconListComboBox2"").show();
                $(""#ico");
                WriteLiteral(@"nListComboBox3"").hide();
            }
            else if (iconSetTypeList.selectedIndex == 2) {
                $(""#iconListComboBox"").hide();
                $(""#iconListComboBox2"").hide();
                $(""#iconListComboBox3"").show();
            }
            document.getElementById(""iconIdText"").value = $(""#selectIcon"").data(""ejComboBox"").activeIndex;
         }
        function onChange() {
            if (iconSetTypeList.selectedIndex == 0)
                document.getElementById(""iconIdText"").value = $(""#selectIcon"").data(""ejComboBox"").activeIndex;
            else if (iconSetTypeList.selectedIndex == 1)
                document.getElementById(""iconIdText"").value = $(""#selectIcon2"").data(""ejComboBox"").activeIndex;
            else
                document.getElementById(""iconIdText"").value = $(""#selectIcon3"").data(""ejComboBox"").activeIndex;
        }
            </script>
");
                EndContext();
#line 226 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\XlsIO\AutoFilter.cshtml"
        Html.EndForm();
    }

#line default
#line hidden
                BeginContext(13397, 316, true);
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
