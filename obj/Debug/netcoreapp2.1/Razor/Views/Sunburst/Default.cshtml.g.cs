#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c91b691681e8e00f8122ce94934a6e9e1e3671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sunburst_Default), @"mvc.1.0.view", @"/Views/Sunburst/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sunburst/Default.cshtml", typeof(AspNetCore.Views_Sunburst_Default))]
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
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c91b691681e8e00f8122ce94934a6e9e1e3671", @"/Views/Sunburst/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Sunburst_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Employees Count", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "600", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-member-path", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-member-path", "JobDescription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-member-path", "JobGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-member-path", "JobRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value-member-path", "EmployeesCount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstProperties __Syncfusion_JavaScript_DataVisualization_Models_SunburstProperties;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstTooltip __Syncfusion_JavaScript_DataVisualization_Models_SunburstTooltip;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstTitle __Syncfusion_JavaScript_DataVisualization_Models_SunburstTitle;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstSize __Syncfusion_JavaScript_DataVisualization_Models_SunburstSize;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstDataLabelSettings __Syncfusion_JavaScript_DataVisualization_Models_SunburstDataLabelSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstZoomSettings __Syncfusion_JavaScript_DataVisualization_Models_SunburstZoomSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstLegend __Syncfusion_JavaScript_DataVisualization_Models_SunburstLegend;
        private global::Syncfusion.JavaScript.SunburstCollectionTag __Syncfusion_JavaScript_SunburstCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SunburstLevel __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(105, 49, true);
                WriteLiteral("<span class=\"sampleName\">Sunburst/ Default</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(175, 144, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates the default rendering of the Syncfusion ASP.NET Web Forms Sunburst control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(347, 78, true);
                WriteLiteral("\r\n    <div class=\"Common\">\r\n    <div style=\"height:600px\">\r\n        \r\n        ");
                EndContext();
                BeginContext(425, 1121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-sunburstchart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949eaf8748f944029696234c4bdaf0af", async() => {
                    BeginContext(512, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(526, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-tooltip", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b0be66a7514c1d8e4e8d4c3bffbf9d", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstTooltip = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstTooltip>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstTooltip);
#line 13 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SunburstTooltip.Visible = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("visible", __Syncfusion_JavaScript_DataVisualization_Models_SunburstTooltip.Visible, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(592, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(606, 70, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-title", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f526d4d21444f56a52123693d405a0b", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstTitle = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstTitle>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstTitle);
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstTitle.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(676, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(690, 58, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-size", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46e27d7e3f5d4d8599aa270c4e42a248", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstSize = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstSize>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstSize);
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstSize.Height = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(748, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(762, 90, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-data-label-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c9b6b96c2ad436d9eae1fb0caaf1234", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstDataLabelSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstDataLabelSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstDataLabelSettings);
#line 16 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SunburstDataLabelSettings.Visible = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("visible", __Syncfusion_JavaScript_DataVisualization_Models_SunburstDataLabelSettings.Visible, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(852, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(866, 77, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-zoom-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7b3222a2d141639c38db5486bca2fc", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstZoomSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstZoomSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstZoomSettings);
#line 17 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SunburstZoomSettings.Enable = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable", __Syncfusion_JavaScript_DataVisualization_Models_SunburstZoomSettings.Enable, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(943, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(957, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-legend", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f82cd78142348628731f9275e996797", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_SunburstLegend = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstLegend>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstLegend);
#line 18 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SunburstLegend.Visible = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("visible", __Syncfusion_JavaScript_DataVisualization_Models_SunburstLegend.Visible, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SunburstLegend.Position = SunburstLegendPosition.Top;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("position", __Syncfusion_JavaScript_DataVisualization_Models_SunburstLegend.Position, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1060, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1074, 443, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-levels", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a4ee56e4964545a34c7046d5bab931", async() => {
                        BeginContext(1098, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1116, 75, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "645bea7cdde946f7af734ea398914e3e", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel.GroupMemberPath = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1191, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1209, 82, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18dd8d6320424944b634a6fe34a5060e", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel.GroupMemberPath = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1291, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1309, 76, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdee4cb3ab7c4a868d12cb0f4c25c962", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel.GroupMemberPath = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1385, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1403, 75, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-sunburstchart-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27a82e691a6845d5af58b9da4bab43f0", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_SunburstLevel.GroupMemberPath = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1478, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_SunburstCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.SunburstCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_SunburstCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1517, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_SunburstProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SunburstProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SunburstProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 12 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SunburstProperties.InnerRadius = 0.2;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("inner-radius", __Syncfusion_JavaScript_DataVisualization_Models_SunburstProperties.InnerRadius, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_SunburstProperties.ValueMemberPath = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1546, 36, true);
                WriteLiteral("\r\n        \r\n    </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1608, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1621, "\"", 1669, 1);
#line 31 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Sunburst\Default.cshtml"
WriteAttributeValue("", 1627, Url.Content("~/scripts/Sunburst_Data.js"), 1627, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1670, 280, true);
                WriteLiteral(@"></script>
    <script>
        
     $(""document"").ready(function () {
         var mapObj = $(""#container"").data(""ejSunburstChart"");
         mapObj.model.dataSource = default_DataSource;
         $(""#container"").ejSunburstChart(""redraw"");

     });


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
