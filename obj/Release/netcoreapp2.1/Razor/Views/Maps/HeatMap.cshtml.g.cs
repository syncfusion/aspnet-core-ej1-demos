#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e002a3f6f7fbef8f0fca5d23e2a1b76b0450bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maps_HeatMap), @"mvc.1.0.view", @"/Views/Maps/HeatMap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Maps/HeatMap.cshtml", typeof(AspNetCore.Views_Maps_HeatMap))]
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
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e002a3f6f7fbef8f0fca5d23e2a1b76b0450bd", @"/Views/Maps/HeatMap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Maps_HeatMap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Population", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("left-label", "0.5 M", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("right-label", "40 M", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selection-color", "#FFC200", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("stroke", "white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("highlight-color", "#DAD1CF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("highlight-stroke", "#1A5D65", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selection-stroke", "white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value-path", "population", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tooltip-template", "template", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("shape-data-path", "name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("shape-property-path", "name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("map"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.MapProperties __Syncfusion_JavaScript_DataVisualization_Models_MapProperties;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ZoomSettings __Syncfusion_JavaScript_DataVisualization_Models_ZoomSettings;
        private global::Syncfusion.JavaScript.MapCollectionTag __Syncfusion_JavaScript_MapCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ShapeLayer __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer;
        private global::Syncfusion.JavaScript.DataVisualization.Models.MapLegendSetting __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ShapeSetting __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 52, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">Map / Heat Map</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(257, 161, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample indicates to render the legend label from right to left in the Syncfusion ASP.NET Web Forms Maps control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(450, 399, true);
                WriteLiteral(@"
      <div class=""Common"">
	   <div  id=""title"" style=""background-color: #FAFAF9;border-color: lightgray;border-width: 2px;opacity: 0.7;height: 60px;width:250px;"" >
			<span style=""color:Black;font-size:22px;margin:15px;margin-top:13px;margin-left:20px;margin-right:20px;height:25px;font-weight:Normal;"">USA Population 2013</span>   
       </div>
	   <div style=""min-height:435px;"">
        ");
                EndContext();
                BeginContext(849, 1237, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-map", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "381e03a1973b447fa2df85a9038b03fe", async() => {
                    BeginContext(866, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(880, 55, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-zoom-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ca83ce4f3ab4d0493eecc87b71e9dcf", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_ZoomSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ZoomSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ZoomSettings);
#line 19 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ZoomSettings.EnableZoom = false;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable-zoom", __Syncfusion_JavaScript_DataVisualization_Models_ZoomSettings.EnableZoom, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(935, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(949, 1118, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-layers", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f73af23ab9747648fc3387f9c332990", async() => {
                        BeginContext(959, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(977, 1065, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-layer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c82b97d36434ab98c3f56b751fc014a", async() => {
                            BeginContext(1274, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1296, 294, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-legend-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b17de3e2602d4b3bb0da392e8777fed4", async() => {
                                BeginContext(1548, 22, true);
                                WriteLiteral("\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.MapLegendSetting>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting);
#line 24 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.ShowLegend = true;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("show-legend", __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.ShowLegend, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Height = 15;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Width = 150;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Position = DockPosition.BottomLeft;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("position", __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Position, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Type = LegendType.Layers;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 25 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Mode = LegendMode.Interactive;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("mode", __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Mode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.Title = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.LeftLabel = (string)__tagHelperAttribute_1.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                            __Syncfusion_JavaScript_DataVisualization_Models_MapLegendSetting.RightLabel = (string)__tagHelperAttribute_2.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1590, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1612, 402, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-shape-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c365be1a0a5420a8a56c7587244630c", async() => {
                                BeginContext(1971, 24, true);
                                WriteLiteral("\r\n\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ShapeSetting>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting);
#line 27 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.AutoFill = false;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("auto-fill", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.AutoFill, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.HighlightBorderWidth = 1;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("highlight-border-width", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.HighlightBorderWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.StrokeThickness = 0.3;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("stroke-thickness", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.StrokeThickness, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.SelectionColor = (string)__tagHelperAttribute_3.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.Stroke = (string)__tagHelperAttribute_4.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.HighlightColor = (string)__tagHelperAttribute_5.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.HighlightStroke = (string)__tagHelperAttribute_6.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.SelectionStroke = (string)__tagHelperAttribute_7.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 29 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.SelectionStrokeWidth = 2.5;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("selection-stroke-width", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.SelectionStrokeWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.ValuePath = (string)__tagHelperAttribute_8.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 29 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.EnableGradient = true;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("enable-gradient", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.EnableGradient, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(2014, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ShapeLayer>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer);
#line 21 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.LayerType = LayerType.Geometry;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("layer-type", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.LayerType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableMouseHover = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("enable-mouse-hover", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableMouseHover, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableSelection = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("enable-selection", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableSelection, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowTooltip = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-tooltip", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowTooltip, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.TooltipTemplate = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShapeDataPath = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShapePropertyPath = (string)__tagHelperAttribute_11.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 22 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowMapItems = false;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-map-items", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowMapItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.DataSource = ViewBag.datasource;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2042, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_MapCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.MapCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_MapCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2067, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_MapProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.MapProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_MapProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2086, 760, true);
                WriteLiteral(@"
                        </div>


    <script  id=""template"" type=""application/jsrender"">

             <div  style=""margin-left:17px;margin-top:-45px;"">
                     <div class=""tip"">	
                             <p class=""small"" style=""margin-top:8px"">
                                    <span style=""color:white;font-size:14px;font-weight:normal;"">{{:name}}</span>
                             </p>
                             <p class=""big"">
                                    <span style=""color:white;font-size:11px;font-weight:normal;"">Population : {{:~parseDouble(population)}}</span>
                             </p>
				    </div> 
               </div>  
               </div>             
        </script>           
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2872, 9, true);
                WriteLiteral("\r\n<script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2881, "\"", 2928, 1);
#line 54 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Maps\HeatMap.cshtml"
WriteAttributeValue("", 2887, Url.Content("~/scripts/MapsData/USA.js"), 2887, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2929, 1641, true);
                WriteLiteral(@"></script>
 <script>
     $(""document"").ready(function () {
         var mapObj = $(""#map"").data(""ejMap"");
         mapObj.model.layers[0].shapeData = usMap;
         mapObj.model.layers[0].shapeSettings.colorMappings =
             {rangeColorMapping: [{ from: 10000001, to: 40000000, gradientColors: [""#F1ECD8"", ""#DEE2B9""] },
                     { from: 5000001, to: 10000000, gradientColors: [""#DEE2B9"", ""#CBD89A""] },
                      { from: 1000001, to: 5000000, gradientColors: [""#CBD89A"", ""#B8CE7B""] },
                      { from: 500000, to: 1000000, gradientColors: [""#B8CE7B"", ""#9CBF4E""] }]
             };
         $(""#map"").ejMap(""refresh"");
         if (!window.SVGSVGElement) {
             $(""#map"").css(""min-height"", ""470px"");
             $(""#map"").ejMap(""refresh"");
         }
     });
     $.views.helpers({
         parseDouble: function (amount) {
             var delimiter = "","";
             var i = parseInt(amount);
             if (isNaN(i)) { return ''; }
          ");
                WriteLiteral(@"   var origi = i;  // store original to check sign
             i = Math.abs(i);
             var minus = '';
             if (origi < 0) { minus = '-'; } // sign based on original
             var n = new String(i);
             var a = [];
             while (n.length > 3) {
                 var nn = n.substr(n.length - 3);
                 a.unshift(nn);
                 n = n.substr(0, n.length - 3);
             }
             if (n.length > 0) { a.unshift(n); }
             n = a.join(delimiter);
             amount = minus + n;
             return amount;
         }
     });
</script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(4597, 1603, true);
                WriteLiteral(@"
    <style type=""text/css"">

            .e-interactiveArrow {
                content: ""&#9650"";
                color: #444444;
                font-size: 12px;
                pointer-events: none;
            }

            p.small {line-height:50%;}
            p.big {line-height:110%;}

            .tip {
                    border: 1px solid #4D4D4D;
                    box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
                    border-radius: 7px;
                    margin-right: 25px;
                    min-width: 100px;
                    padding-top: 9px;
                    padding-right: 10px;
                    padding-left: 10px;
                    width: auto;
                    height: auto;
                    background: #4D4D4D;
                }

            .tip:before {
                position: absolute;
                display: inline-block;
                border-top: 7px solid transparent;
                border-right: 7px solid #4D4D4D;
   ");
                WriteLiteral(@"             border-bottom: 7px solid transparent;
                border-right-color: #4D4D4D;
                left: 11px;
                top: -14px;
                content: '';
            }

            .tip:after {
                position: absolute;
                display: inline-block;
                border-top: 6px solid transparent;
                border-right: 6px solid #4D4D4D;
                border-bottom: 6px solid transparent;
                left: 13px;
                top: -13px;
                content: '';
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
