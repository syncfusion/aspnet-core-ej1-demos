#pragma checksum "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9801b2be5bb41172ec086fcd685072f72cc89f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_DataTable), @"mvc.1.0.view", @"/Views/XlsIO/DataTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/DataTable.cshtml", typeof(AspNetCore.Views_XlsIO_DataTable))]
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
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db9801b2be5bb41172ec086fcd685072f72cc89f", @"/Views/XlsIO/DataTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_DataTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("update-url", "NormalUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("adaptor", "remoteSaveAdaptor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "SalesPerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "SalesJanJune", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Jan-June", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "SalesJulyDec", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "July-Dec", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Change", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Change", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Grid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("isVisible", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.GridProperties __Syncfusion_JavaScript_Models_GridProperties;
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        private global::Syncfusion.JavaScript.Models.EditSettings __Syncfusion_JavaScript_Models_EditSettings;
        private global::Syncfusion.JavaScript.GridCollectionTag __Syncfusion_JavaScript_GridCollectionTag;
        private global::Syncfusion.JavaScript.Models.Column __Syncfusion_JavaScript_Models_Column;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(73, 63, true);
                WriteLiteral(" <span class=\"sampleName\">XlsIO/GettingStarted/DataTable</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(164, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : DataTable : Syncfusion";

#line default
#line hidden
                BeginContext(246, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
      Html.BeginForm("DataTable", "XlsIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(319, 520, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <label>
                            Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                            note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
                        </label>
                    </div>
                    <br />
                </div>
            </div>
");
                EndContext();
                BeginContext(841, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(853, 1040, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "821199e8bd0945a7a7a401f1b30e753d", async() => {
                    BeginContext(938, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(956, 120, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce03e973157749d982aa099b3d78d6a9", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
#line 21 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_DataSource.Json = (System.Data.DataTable)ViewBag.datasource;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("json", __Syncfusion_JavaScript_DataSource.Json, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_DataSource.UpdateURL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_DataSource.Adaptor = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1076, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(1094, 129, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-edit-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1550f562c3e4891b367e76b580f7e92", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_EditSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditSettings);
#line 22 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowAdding = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-adding", __Syncfusion_JavaScript_Models_EditSettings.AllowAdding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowEditing = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-editing", __Syncfusion_JavaScript_Models_EditSettings.AllowEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowDeleting = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-deleting", __Syncfusion_JavaScript_Models_EditSettings.AllowDeleting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.EditMode = (EditMode.Normal);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("edit-mode", __Syncfusion_JavaScript_Models_EditSettings.EditMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1223, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(1241, 628, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5050fe898f8c4d5d863d6fa3c1e457f8", async() => {
                        BeginContext(1252, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1274, 102, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "400edbbf937f427eb421c2244b6cf11f", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 24 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 50;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 24 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Center;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.IsPrimaryKey = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("is-primary-key", __Syncfusion_JavaScript_Models_Column.IsPrimaryKey, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1376, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1398, 92, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed6717bc68e4c79b5d2829aae6318e9", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 25 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 160;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 25 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Center;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1490, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1512, 97, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26bc3da3541e42edafa85a6882b22154", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 26 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 100;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 26 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Center;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1609, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1631, 97, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0261a19d6f3b431e9a1b123acd2deedb", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 27 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 100;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 27 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Center;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1728, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1750, 89, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d349a908626546cf899bf95c7adcb6ee", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 28 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 100;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_11.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 28 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Center;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1839, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_GridCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.GridCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_GridCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1869, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
#line 20 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.AllowScrolling = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-scrolling", __Syncfusion_JavaScript_Models_GridProperties.AllowScrolling, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.Height = 300;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_Models_GridProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.Width = 540;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_GridProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1893, 1081, true);
                WriteLiteral(@"
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        <strong> Save As :</strong>
                    </label>
                    <input id=""rbtnXls"" type=""radio"" name=""SaveOption"" value=""Xls"" />
                    <label for=""rbtnXls"">
                        XLS
                    </label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <input id=""rbtnXlsx"" type=""radio"" name=""SaveOption"" value=""Xlsx"" checked=""checked"" />
                    <label for=""rbtnXlsx"">
                        XLSX
                    </label>
                </div>
                <br />
                <div class=""celldiv"">
                    <input id=""input"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Input Template"" style=""width:162px;"" />
                    <input id=""import"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Import From Excel"" style=""width:162px;"" />
  ");
                WriteLiteral("                  <input id=\"export\" class=\"buttonStyle\" ");
                EndContext();
                BeginContext(2975, 25, false);
#line 51 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"
                                                      Write(ViewBag.exportButtonState);

#line default
#line hidden
                EndContext();
                BeginContext(3000, 122, true);
                WriteLiteral(" type=\"submit\" name=\"button\" value=\"Export To Excel\" style=\"width:162px;\" />\r\n                </div>\r\n            </div>\r\n");
                EndContext();
                BeginContext(3124, 178, true);
                WriteLiteral("            <script type=\"text/javascript\">\r\n\r\n        function EnableExport()\r\n        {\r\n            $(\'#export\').prop(\"disabled\", false);\r\n\r\n        }\r\n            </script>\r\n");
                EndContext();
#line 63 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\DataTable.cshtml"

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
