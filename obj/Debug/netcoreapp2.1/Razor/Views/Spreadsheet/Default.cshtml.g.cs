#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db3c07380d623a391fcd9138dd6990b11a914c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Spreadsheet_Default), @"mvc.1.0.view", @"/Views/Spreadsheet/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Spreadsheet/Default.cshtml", typeof(AspNetCore.Views_Spreadsheet_Default))]
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
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3c07380d623a391fcd9138dd6990b11a914c9e", @"/Views/Spreadsheet/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Spreadsheet_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("import-mapper", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("excel-url", "ExcelExport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("csv-url", "CsvExport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Spreadsheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-complete", "loadComplete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("open-failure", "openFailure", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.WorkbookProperties __Syncfusion_JavaScript_Models_WorkbookProperties;
        private global::Syncfusion.JavaScript.Models.SpreadsheetScrollSettings __Syncfusion_JavaScript_Models_SpreadsheetScrollSettings;
        private global::Syncfusion.JavaScript.SheetCollectionTag __Syncfusion_JavaScript_SheetCollectionTag;
        private global::Syncfusion.JavaScript.Models.Sheet __Syncfusion_JavaScript_Models_Sheet;
        private global::Syncfusion.JavaScript.Models.RangeSetting __Syncfusion_JavaScript_Models_RangeSetting;
        private global::Syncfusion.JavaScript.Models.SpreadsheetImportSettings __Syncfusion_JavaScript_Models_SpreadsheetImportSettings;
        private global::Syncfusion.JavaScript.Models.SpreadsheetExportSettings __Syncfusion_JavaScript_Models_SpreadsheetExportSettings;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 130, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This demo shows default Functionalities of Syncfusion ASP.NET Core Spreadsheet control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(174, 70, true);
                WriteLiteral("<span class=\"sampleName\"> Spreadsheet / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(279, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 292, "\"", 346, 1);
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml"
WriteAttributeValue("", 298, Url.Content("~/Scripts/jquery.validate.min.js"), 298, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(347, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 370, "\"", 436, 1);
#line 7 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml"
WriteAttributeValue("", 376, Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js"), 376, 60, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(437, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(477, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(479, 597, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-spread-sheet", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc973a7d9204a0facaf2215637be127", async() => {
                    BeginContext(596, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(602, 64, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-scroll-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60a47719bb0a468cbc4aa4c703e975e1", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_SpreadsheetScrollSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpreadsheetScrollSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpreadsheetScrollSettings);
#line 11 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml"
__Syncfusion_JavaScript_Models_SpreadsheetScrollSettings.Width = 900;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_SpreadsheetScrollSettings.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml"
__Syncfusion_JavaScript_Models_SpreadsheetScrollSettings.Height = 470;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_Models_SpreadsheetScrollSettings.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(666, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(672, 203, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sheets", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e2e382ab9f4f31a65ca430a5651ef1", async() => {
                        BeginContext(682, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(692, 166, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sheet", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "957c2a7a1ebe43c9b455bbaa469ea6c6", async() => {
                            BeginContext(701, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(715, 123, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38a98ccbae9541abbed320f7ee438cdb", async() => {
                                BeginContext(733, 86, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range-setting", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccb7bfec79b8458491cf460c38ae341c", async() => {
                                }
                                );
                                __Syncfusion_JavaScript_Models_RangeSetting = CreateTagHelper<global::Syncfusion.JavaScript.Models.RangeSetting>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RangeSetting);
#line 14 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml"
__Syncfusion_JavaScript_Models_RangeSetting.Datasource = ViewBag.Datasource;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_RangeSetting.Datasource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml"
__Syncfusion_JavaScript_Models_RangeSetting.ShowHeader = true;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("show-header", __Syncfusion_JavaScript_Models_RangeSetting.ShowHeader, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_SheetCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.SheetCollectionTag>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_SheetCollectionTag);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(838, 10, true);
                            WriteLiteral("\r\n        ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_Sheet = CreateTagHelper<global::Syncfusion.JavaScript.Models.Sheet>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Sheet);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(858, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_SheetCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.SheetCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_SheetCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(875, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(881, 62, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-import-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f46c0245885a4d65baf3af65304b7ee5", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_SpreadsheetImportSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpreadsheetImportSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpreadsheetImportSettings);
                    __Syncfusion_JavaScript_Models_SpreadsheetImportSettings.ImportMapper = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(943, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(949, 107, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-export-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a743a6d871d4e33904ee1b0d80fee4c", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_SpreadsheetExportSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpreadsheetExportSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpreadsheetExportSettings);
                    __Syncfusion_JavaScript_Models_SpreadsheetExportSettings.ExcelUrl = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_JavaScript_Models_SpreadsheetExportSettings.CsvUrl = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1056, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_WorkbookProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.WorkbookProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_WorkbookProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 10 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Spreadsheet\Default.cshtml"
__Syncfusion_JavaScript_Models_WorkbookProperties.AllowFormulaBar = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-formula-bar", __Syncfusion_JavaScript_Models_WorkbookProperties.AllowFormulaBar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_WorkbookProperties.LoadComplete = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_WorkbookProperties.OpenFailure = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1076, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1104, 803, true);
                WriteLiteral(@"
<script type=""text/javascript"">

        function loadComplete(args) {
            var xlFormat = this.XLFormat;
            if (!this.model.isImport) {
                this.setWidthToColumns([ 142, 132, 110, 105, 102, 112, 122, 122, 102 ]);
                xlFormat.format({ ""style"": { ""font-weight"": ""bold"" } }, ""A1:H1"");
                xlFormat.format({ ""type"": ""shortdate"" }, ""B2:B11"");
                xlFormat.format({ ""type"": ""time"" }, ""C2:C11"");
                xlFormat.format({ ""type"": ""currency"" }, ""E2:H11"");
            }
        }

        function openFailure(args) {
            var alertDlg = $(""#"" + this._id + ""_alertdlg"");
            this._renderAlertDlgContent(alertDlg, ""Alert"", args.statusText);
            alertDlg.ejDialog(""open"");
        }

</script>
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
