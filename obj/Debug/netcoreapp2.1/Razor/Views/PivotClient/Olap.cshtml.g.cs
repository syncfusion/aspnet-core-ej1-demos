#pragma checksum "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\PivotClient\Olap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ccf2374db8e3fa8ea7838df1caac50058a043e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PivotClient_Olap), @"mvc.1.0.view", @"/Views/PivotClient/Olap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PivotClient/Olap.cshtml", typeof(AspNetCore.Views_PivotClient_Olap))]
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
#line 1 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\PivotClient\Olap.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ccf2374db8e3fa8ea7838df1caac50058a043e", @"/Views/PivotClient/Olap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_PivotClient_Olap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "910px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Customer].[Customer Geography]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Product].[Product Categories]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Measures].[Internet Sales Amount]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("catalog", "Adventure Works DW 2008 SE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cube", "Adventure Works", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data", "//bi.syncfusion.com/olap/msmdpump.dll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PivotClient1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "OLAP Browser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("before-export", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("render-success", "setChartProperties", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load-report", "reportSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("fetch-report", "reportSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("save-report", "reportSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.PivotClientProperties __Syncfusion_JavaScript_Models_PivotClientProperties;
        private global::Syncfusion.JavaScript.PivotClientSize __Syncfusion_JavaScript_PivotClientSize;
        private global::Syncfusion.JavaScript.Models.PivotDataSource __Syncfusion_JavaScript_Models_PivotDataSource;
        private global::Syncfusion.JavaScript.PivotGridTagHelperMocks __Syncfusion_JavaScript_PivotGridTagHelperMocks;
        private global::Syncfusion.JavaScript.Models.Field __Syncfusion_JavaScript_Models_Field;
        private global::Syncfusion.JavaScript.Models.MeasuresItems __Syncfusion_JavaScript_Models_MeasuresItems;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(54, 51, true);
                WriteLiteral("<span class=\"sampleName\">PivotClient / Olap</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(126, 198, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo for Syncfusion Essential JS1 for ASP.NET Core pivot client control describes how to bind the pivot data, which is in JSON format at script-side.\">\r\n");
                EndContext();
            }
            );
            BeginContext(327, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(354, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(356, 981, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pivot-client", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc66dc26d52c4e5889dfe0c62993db33", async() => {
                    BeginContext(559, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(565, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-size", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91447963a74c4faa9bb8b5511ba31769", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_PivotClientSize = CreateTagHelper<global::Syncfusion.JavaScript.PivotClientSize>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotClientSize);
                    __Syncfusion_JavaScript_PivotClientSize.Width = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(596, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(602, 715, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-data-source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8717eb627ebf4899a107934bfb7f0da4", async() => {
                        BeginContext(722, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(732, 125, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-rows", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57b487952b284b9b8b67d3784f2f5fce", async() => {
                            BeginContext(746, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(760, 72, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-row-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7222237c62ee40f5a2e3086f96521d14", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_1.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(832, 10, true);
                            WriteLiteral("\r\n        ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(857, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(867, 136, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d876b630c01c4e529da3a9982854681b", async() => {
                            BeginContext(884, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(898, 77, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e68ed1d7e1804681bae91a3632f8f9f5", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_2.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(975, 10, true);
                            WriteLiteral("\r\n        ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1003, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1013, 282, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-values", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5d30fccb45845a2bc0006e6e6c68ef6", async() => {
                            BeginContext(1029, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(1043, 225, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-value-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cff06e9ab2a4698912116c6dee2c0bd", async() => {
                                BeginContext(1072, 18, true);
                                WriteLiteral("\r\n                ");
                                EndContext();
                                BeginContext(1090, 148, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measures", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70aa2773f2fd41c29777fbe1fe83a40b", async() => {
                                    BeginContext(1102, 22, true);
                                    WriteLiteral("\r\n                    ");
                                    EndContext();
                                    BeginContext(1124, 83, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measure-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e2eb628d2a4a688bc26c2a4892f073", async() => {
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_MeasuresItems = CreateTagHelper<global::Syncfusion.JavaScript.Models.MeasuresItems>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MeasuresItems);
                                    __Syncfusion_JavaScript_Models_MeasuresItems.FieldName = (string)__tagHelperAttribute_3.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1207, 18, true);
                                    WriteLiteral("\r\n                ");
                                    EndContext();
                                }
                                );
                                __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1238, 14, true);
                                WriteLiteral("\r\n            ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
#line 18 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\PivotClient\Olap.cshtml"
__Syncfusion_JavaScript_Models_Field.Axis = global::Syncfusion.JavaScript.AxisName.Column;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("axis", __Syncfusion_JavaScript_Models_Field.Axis, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1268, 10, true);
                            WriteLiteral("\r\n        ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1295, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_PivotDataSource = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotDataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotDataSource);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Catalog = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Cube = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Data = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1317, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_PivotClientProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotClientProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotClientProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_PivotClientProperties.Title = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_PivotClientProperties.BeforeExport = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_PivotClientProperties.RenderSuccess = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_PivotClientProperties.LoadReport = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_PivotClientProperties.FetchReport = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Syncfusion_JavaScript_Models_PivotClientProperties.SaveReport = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1337, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1365, 1678, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function setChartProperties(args) {
            this._pivotChart.model.load = ""loadTheme"";
			this._pivotChart.model.preRender = ""preRender"";
            if (args._successAction == undefined || args._successAction == ""Filter"") {
                this._pivotChart.model.legend.rowCount = 2;
                this._pivotChart.model.primaryXAxis = { title: { text: ""Customer Geography"" }, labelRotation: 270 };
                this._pivotChart.model.primaryYAxis = { title: { text: ""Internet Sales Amount"" } };
            }
        }
		function preRender(sender) {
            sender.model.border.opacity = 1;
            if (sender.model.theme.indexOf(""light"") > -1 || sender.model.theme == ""bootstrap"" || sender.model.theme == ""material"") {
                sender.model.background = ""white"";
                sender.model.chartArea.background = ""white"";
            }
            else {
                sender.model.background = ""black"";
                sender.mo");
                WriteLiteral(@"del.chartArea.background = ""black""
            }
        }
        function Export(args) {
            args.url = ""ExportPivotClient"";
        }
        function reportSettings(args) {
            if (args.fetchReportSetting)
                args.fetchReportSetting.url = ""//js.syncfusion.com/ejservices/api/PivotClient/Olap"";
            else if (args.loadReportSetting)
                args.loadReportSetting.url = ""//js.syncfusion.com/ejservices/api/PivotClient/Olap"";
            else
                args.saveReportSetting.url = ""//js.syncfusion.com/ejservices/api/PivotClient/Olap"";
            return args;
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(3068, 205, true);
                WriteLiteral("\r\n    <style>\r\n        #PivotClient1 {\r\n            min-height: 275px; \r\n            min-width: 525px\r\n        }\r\n        .cols-sample-area {\r\n            width: 100% !important;\r\n        }\r\n    </style>\r\n");
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
