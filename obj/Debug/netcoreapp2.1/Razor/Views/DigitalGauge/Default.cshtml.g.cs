#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc0b138f5e956796938e062fdc32f34c39c25d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DigitalGauge_Default), @"mvc.1.0.view", @"/Views/DigitalGauge/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DigitalGauge/Default.cshtml", typeof(AspNetCore.Views_DigitalGauge_Default))]
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
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc0b138f5e956796938e062fdc32f34c39c25d3", @"/Views/DigitalGauge/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DigitalGauge_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "#8c8c8c", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "123456789", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ScaleGauge"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label-color", new global::Microsoft.AspNetCore.Html.HtmlString("#8c8c8c"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load", "loadGaugeTheme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.DigitalGaugeProperties __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties;
        private global::Syncfusion.JavaScript.DigitalGaugeCollectionTag __Syncfusion_JavaScript_DigitalGaugeCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.DigitalGaugeItems __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeItems;
        private global::Syncfusion.JavaScript.DataVisualization.Models.SegmentSettings __Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.CharacterSettings __Syncfusion_JavaScript_DataVisualization_Models_CharacterSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.DigitalGaugeLocation __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeLocation;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(112, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 125, "\"", 172, 1);
#line 4 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
WriteAttributeValue("", 131, Url.Content("~/scripts/excanvas.min.js"), 131, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(173, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(215, 61, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">Default Functionalities</span>\r\n\t");
                EndContext();
            }
            );
            BeginContext(279, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("MetaTags", async() => {
                BeginContext(299, 149, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates the default rendering of the Syncfusion ASP.NET Web Forms Digital Gauge control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(476, 54, true);
                WriteLiteral("\r\n<div class=\"Common\">\r\n<div id=\"linearframe\">\r\n\r\n    ");
                EndContext();
                BeginContext(530, 540, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-digital-gauge", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "554ef754be3b42b697840edcf8bc778d", async() => {
                    BeginContext(654, 20, true);
                    WriteLiteral("\r\n        \r\n        ");
                    EndContext();
                    BeginContext(674, 369, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "610556fe17644eb0ac9b4d18d990e5c1", async() => {
                        BeginContext(683, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(697, 326, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-digital-gauge-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a77e9028a454a30bb31a49cad366e79", async() => {
                            BeginContext(738, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(756, 79, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-segment-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55b2f7ec254149468da2acd22d581da4", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.SegmentSettings>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings);
#line 21 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings.Width = 1;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings.Spacing = 0;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("spacing", __Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings.Spacing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            __Syncfusion_JavaScript_DataVisualization_Models_SegmentSettings.Color = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(835, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(853, 59, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-character-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8990928e24c43c5825198f81614b4cd", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_DataVisualization_Models_CharacterSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CharacterSettings>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CharacterSettings);
#line 22 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CharacterSettings.Opacity = 0.8;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("opacity", __Syncfusion_JavaScript_DataVisualization_Models_CharacterSettings.Opacity, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(912, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(930, 55, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-digital-position", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0c63d145be3485fae12adf0df7f262d", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeLocation = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.DigitalGaugeLocation>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeLocation);
#line 23 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeLocation.X = 52;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("x", __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeLocation.X, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeLocation.Y = 52;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("y", __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeLocation.Y, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(985, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeItems = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.DigitalGaugeItems>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeItems);
                        __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeItems.Value = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1023, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DigitalGaugeCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.DigitalGaugeCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DigitalGaugeCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1043, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.DigitalGaugeProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties.Width = 525;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DigitalGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties.Height = 305;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_DigitalGaugeProperties.Load = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1070, 31, true);
                WriteLiteral("           \r\n\r\n</div>\r\n</div>\r\n");
                EndContext();
            }
            );
            BeginContext(1104, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
