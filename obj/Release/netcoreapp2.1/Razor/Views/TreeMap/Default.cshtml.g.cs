#pragma checksum "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aee4b61d7735bb4b3ea3a928a3633f0510e1dbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeMap_Default), @"mvc.1.0.view", @"/Views/TreeMap/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeMap/Default.cshtml", typeof(AspNetCore.Views_TreeMap_Default))]
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
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aee4b61d7735bb4b3ea3a928a3633f0510e1dbe", @"/Views/TreeMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label-path", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-path", "Continent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "#77D8D8", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("legendlabel", "1% Growth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "#AED960", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("legendlabel", "2% Growth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "#FFAF51", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("legendlabel", "3% Growth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "#F3D240", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("legendlabel", "4% Growth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("treemap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("highlight-border-brush", "fdaa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color-value-path", "Growth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("weight-value-path", "Population", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapProperties __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties;
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLegend __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend;
        private global::Syncfusion.JavaScript.DataVisualization.Models.LeafItemsSetting __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting;
        private global::Syncfusion.JavaScript.TreeMapCollectionTag __Syncfusion_JavaScript_TreeMapCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel;
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapRangeColorMapping __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 62, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">TreeMap / FlatCollection</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(271, 165, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates layout types based on continents population in the Syncfusion ASP.NET Web Forms Treemap control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(464, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
      
        var datasource = ViewData["Population"];
     

#line default
#line hidden
                BeginContext(532, 83, true);
                WriteLiteral("     <div class=\"Common\">\r\n    <div style=\"min-height:380px;padding:2px\">\r\n        ");
                EndContext();
                BeginContext(615, 1173, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-map", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27a8ba7d8b3442cb83a222a557011f0b", async() => {
                    BeginContext(801, 12, true);
                    WriteLiteral("\r\n          ");
                    EndContext();
                    BeginContext(813, 149, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-legend-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1261a9d46cc14153bd60f493beaed8c6", async() => {
                        BeginContext(930, 12, true);
                        WriteLiteral("\r\n          ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLegend>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend);
#line 20 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.IconWidth = 17;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("icon-width", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.IconWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.IconHeight = 17;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("icon-height", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.IconHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.DockPosition = TreeMapDockPosition.Top;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("dock-position", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.DockPosition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.Height = 40;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.Width = 600;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLegend.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(962, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(976, 85, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-leaf-item-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e66b8df0a44d47b4b863f03ab0ea8b1e", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.LeafItemsSetting>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting);
#line 22 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting.ShowLabels = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-labels", __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting.ShowLabels, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting.LabelPath = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1061, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1075, 128, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-levels", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b53730b95a74b78bf9a53635ca0fe10", async() => {
                        BeginContext(1085, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1103, 75, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69144638549d4accad5ca3adf4815f3b", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupPath = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 24 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap = 5;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("group-gap", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight = 25;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("header-height", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1178, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_TreeMapCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.TreeMapCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TreeMapCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1203, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1217, 547, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range-color-mappings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9db509c131341c29f79b4f50c3e6eef", async() => {
                        BeginContext(1241, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1259, 103, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range-color-mapping", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de260e4126444aaac0e1f42cbe1b709", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapRangeColorMapping>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping);
#line 27 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From = 0;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("from", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To = 1;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("to", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Color = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Legendlabel = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1362, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1380, 103, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range-color-mapping", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feccd74c450540c7a02da1979ad39972", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapRangeColorMapping>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping);
#line 28 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From = 0;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("from", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To = 2;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("to", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Color = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Legendlabel = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1483, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1501, 103, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range-color-mapping", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6eb6d52b6c54571af0f136bf9069160", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapRangeColorMapping>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping);
#line 29 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From = 0;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("from", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To = 3;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("to", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Color = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Legendlabel = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1604, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1622, 103, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range-color-mapping", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89be7bddaf794707b7c506a426c1d435", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapRangeColorMapping>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping);
#line 30 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From = 0;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("from", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.From, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 30 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To = 4;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("to", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.To, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Color = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapRangeColorMapping.Legendlabel = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1725, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_TreeMapCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.TreeMapCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TreeMapCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1764, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.HighlightBorderBrush = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 18 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.ColorValuePath = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.WeightValuePath = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#line 19 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\TreeMap\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.ShowLegend = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-legend", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.ShowLegend, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1788, 576, true);
                WriteLiteral(@"
        </div>
     </div>
  <script  id=""headertemplate"" type=""application/jsrender"">
    
	  <div>
            <span style=""color:gray;font-size:16px;font-weight:normal;"">{{:header}}</span><br />            
      </div>                        
    </script>  
    <script  id=""labeltemplate"" type=""application/jsrender"">    
    
	    <div style=""background-color: transparent;"">
            <span style=""color:white;font-size:large;font-weight:normal;"">{{:label}}</span><br />            
        </div>                        
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
