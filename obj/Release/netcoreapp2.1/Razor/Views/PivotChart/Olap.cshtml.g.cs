#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760dcfe9f774bfb021bf6a7de74eecc6ebd368ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PivotChart_Olap), @"mvc.1.0.view", @"/Views/PivotChart/Olap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PivotChart/Olap.cshtml", typeof(AspNetCore.Views_PivotChart_Olap))]
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
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760dcfe9f774bfb021bf6a7de74eecc6ebd368ea", @"/Views/PivotChart/Olap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_PivotChart_Olap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Date].[Fiscal]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Customer].[Customer Geography]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Measures].[Internet Sales Amount]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("catalog", "Adventure Works DW 2008 SE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cube", "Adventure Works", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data", "//bi.syncfusion.com/olap/msmdpump.dll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "460px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Date - Fiscal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Amount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PivotChart1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load", "loadTheme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.PivotChartProperties __Syncfusion_JavaScript_Models_PivotChartProperties;
        private global::Syncfusion.JavaScript.Models.PivotDataSource __Syncfusion_JavaScript_Models_PivotDataSource;
        private global::Syncfusion.JavaScript.PivotGridTagHelperMocks __Syncfusion_JavaScript_PivotGridTagHelperMocks;
        private global::Syncfusion.JavaScript.Models.Field __Syncfusion_JavaScript_Models_Field;
        private global::Syncfusion.JavaScript.Models.MeasuresItems __Syncfusion_JavaScript_Models_MeasuresItems;
        private global::Syncfusion.JavaScript.DataVisualization.Models.CommonSeriesOptions __Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions;
        private global::Syncfusion.JavaScript.DataVisualization.Models.NewTooltip __Syncfusion_JavaScript_DataVisualization_Models_NewTooltip;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ModelSize __Syncfusion_JavaScript_DataVisualization_Models_ModelSize;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Axis __Syncfusion_JavaScript_DataVisualization_Models_Axis;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Title __Syncfusion_JavaScript_DataVisualization_Models_Title;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Legend __Syncfusion_JavaScript_DataVisualization_Models_Legend;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(54, 50, true);
                WriteLiteral("<span class=\"sampleName\">PivotChart / Olap</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(125, 179, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo for Syncfusion Essential JS1 for ASP.NET Core pivot chart control describes how to bind the OLAP cube data from SSAS (XML/A).\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(332, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(334, 1240, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pivot-chart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7374df5b0f2e4ca88e09b815453b98f0", async() => {
                    BeginContext(405, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(411, 700, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-data-source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8533dad78a7f445ca5927d0f43afe0ee", async() => {
                        BeginContext(531, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(541, 109, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-rows", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cf25aa500554f01af754b758b0986ca", async() => {
                            BeginContext(555, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(569, 56, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-row-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a702d175f2c42948b7f777de860734b", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(625, 10, true);
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
                        BeginContext(650, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(660, 137, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1e6f8ef99249c58d2153bc4eb737a9", async() => {
                            BeginContext(677, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(691, 78, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae9cdda755dc4984b2ac5c1f1966e116", async() => {
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
                            BeginContext(769, 10, true);
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
                        BeginContext(797, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(807, 282, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-values", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39545401e88e490aa6a7ee2ae85bf868", async() => {
                            BeginContext(823, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(837, 225, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-value-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edad05c5e2124423946804d247cdcc12", async() => {
                                BeginContext(866, 18, true);
                                WriteLiteral("\r\n                ");
                                EndContext();
                                BeginContext(884, 148, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measures", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "733f067dab224a34b59711cf9a3c7c62", async() => {
                                    BeginContext(896, 22, true);
                                    WriteLiteral("\r\n                    ");
                                    EndContext();
                                    BeginContext(918, 83, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measure-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "815d0755f9ee413a974f049497642aa5", async() => {
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_MeasuresItems = CreateTagHelper<global::Syncfusion.JavaScript.Models.MeasuresItems>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MeasuresItems);
                                    __Syncfusion_JavaScript_Models_MeasuresItems.FieldName = (string)__tagHelperAttribute_2.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1001, 18, true);
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
                                BeginContext(1032, 14, true);
                                WriteLiteral("\r\n            ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
#line 16 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml"
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
                            BeginContext(1062, 10, true);
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
                        BeginContext(1089, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_PivotDataSource = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotDataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotDataSource);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Catalog = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Cube = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Data = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1111, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1117, 155, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-common-series-options", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cbc0162ec6b44db89c111094b364775", async() => {
                        BeginContext(1180, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1190, 50, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-chart-tooltip", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e4c571f6abc48aab5b988dc2c13e0f0", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_NewTooltip = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.NewTooltip>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_NewTooltip);
#line 24 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_NewTooltip.Visible = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("visible", __Syncfusion_JavaScript_DataVisualization_Models_NewTooltip.Visible, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1240, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CommonSeriesOptions>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions);
#line 23 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions.Type = global::Syncfusion.JavaScript.DataVisualization.SeriesType.Column;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions.EnableAnimation = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable-animation", __Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions.EnableAnimation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1272, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1278, 45, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-size", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f182bba5d4f54c9ab8ba2e403f41ffa9", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_ModelSize = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ModelSize>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ModelSize);
                    __Syncfusion_JavaScript_DataVisualization_Models_ModelSize.Width = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __Syncfusion_JavaScript_DataVisualization_Models_ModelSize.Height = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1323, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1329, 93, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-primary-x-axis", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "351c5cc112bc44ecb694e9eb702b5a7d", async() => {
                        BeginContext(1347, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1357, 40, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-title", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ac55fdfc63499b9d662a2ce6a81ae5", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Title = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Title>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Title);
                        __Syncfusion_JavaScript_DataVisualization_Models_Title.Text = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1397, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Axis = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Axis>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Axis);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1422, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1428, 86, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-primary-y-axis", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8fef5796fff4bdcafbe7b3704f65351", async() => {
                        BeginContext(1446, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1456, 33, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-title", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a1ee5dd5d441ffa9dc8aba77aa7345", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Title = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Title>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Title);
                        __Syncfusion_JavaScript_DataVisualization_Models_Title.Text = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1489, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Axis = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Axis>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Axis);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1514, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1520, 35, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-legend", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "882fefc1eeca4476bc64e77090d5c5c2", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Legend = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Legend>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Legend);
#line 33 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Legend.RowCount = 2;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("row-count", __Syncfusion_JavaScript_DataVisualization_Models_Legend.RowCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1555, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_PivotChartProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotChartProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotChartProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#line 7 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\PivotChart\Olap.cshtml"
__Syncfusion_JavaScript_Models_PivotChartProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_PivotChartProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_PivotChartProperties.Load = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1574, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1601, 284, true);
                WriteLiteral(@"
    <style>
        #PivotChart1 {
            min-height: 275px;
            min-width: 525px;
            height: 460px;
            width: 100%;
            float: left;
        }
        .cols-sample-area {
            width: 100% !important;
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
