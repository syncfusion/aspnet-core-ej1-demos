#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a1f7a804c41b7096c5e4e6e09b5880baa40d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CircularGauge_Default), @"mvc.1.0.view", @"/Views/CircularGauge/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CircularGauge/Default.cshtml", typeof(AspNetCore.Views_CircularGauge_Default))]
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
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a1f7a804c41b7096c5e4e6e09b5880baa40d10", @"/Views/CircularGauge/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_CircularGauge_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("background-color", "red", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("background-color", "yellow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("circulargauge1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load", "loadGaugeTheme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("background-color", "transparent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.CircularGaugeProperties __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties;
        private global::Syncfusion.JavaScript.CircularGaugeCollectionTag __Syncfusion_JavaScript_CircularGaugeCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.CircularScales __Syncfusion_JavaScript_DataVisualization_Models_CircularScales;
        private global::Syncfusion.JavaScript.DataVisualization.Models.CircularPointerCap __Syncfusion_JavaScript_DataVisualization_Models_CircularPointerCap;
        private global::Syncfusion.JavaScript.DataVisualization.Models.CircularRanges __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Pointers __Syncfusion_JavaScript_DataVisualization_Models_Pointers;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(114, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 127, "\"", 174, 1);
#line 5 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
WriteAttributeValue("", 133, Url.Content("~/scripts/excanvas.min.js"), 133, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(175, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(213, 63, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Default Functionalities</span>\r\n");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(297, 146, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates default rendering of the Syncfusion ASP.NET Web Forms Circular gauge control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(471, 47, true);
                WriteLiteral("\r\n    <div class=\"Common\">\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(518, 1400, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-circular-gauge", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52aa4b2f91824dcdb9f31d13a97b88b7", async() => {
                    BeginContext(669, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(683, 1205, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-circular-scale-collections", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774026cd575f4bf9a3360fe24a6f573d", async() => {
                        BeginContext(713, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(731, 1112, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-circular-scales", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "577f7931c3b34764ba72718c6c17bce0", async() => {
                            BeginContext(891, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(913, 43, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pointer-cap", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a1ccaf8d62491a88b4ae509abbae5b", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_DataVisualization_Models_CircularPointerCap = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CircularPointerCap>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CircularPointerCap);
#line 19 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularPointerCap.Radius = 10;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("radius", __Syncfusion_JavaScript_DataVisualization_Models_CircularPointerCap.Radius, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(956, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(978, 582, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-circular-range-collections", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cd7ff52d58a4165ba2f510a982c55ce", async() => {
                                BeginContext(1008, 26, true);
                                WriteLiteral("\r\n                        ");
                                EndContext();
                                BeginContext(1034, 105, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-circular-ranges", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2fa72f62ff44192a70c090c523052cc", async() => {
                                }
                                );
                                __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CircularRanges>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges);
#line 21 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.Size = 5;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.DistanceFromScale = -30;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("distance-from-scale", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.DistanceFromScale, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.StartValue = 0;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("start-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.StartValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.EndValue = 70;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("end-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.EndValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1139, 26, true);
                                WriteLiteral("\r\n                        ");
                                EndContext();
                                BeginContext(1165, 156, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-circular-ranges", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98ef4b8065444856a73ce063a7e3150f", async() => {
                                    BeginContext(1275, 26, true);
                                    WriteLiteral("\r\n                        ");
                                    EndContext();
                                }
                                );
                                __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CircularRanges>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges);
#line 22 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.Size = 5;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.DistanceFromScale = -30;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("distance-from-scale", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.DistanceFromScale, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.StartValue = 70;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("start-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.StartValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.EndValue = 110;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("end-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.EndValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                                __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.BackgroundColor = (string)__tagHelperAttribute_0.Value;
                                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1321, 26, true);
                                WriteLiteral("\r\n                        ");
                                EndContext();
                                BeginContext(1347, 160, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-circular-ranges", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048e763218e41a7af25f7569b964b87", async() => {
                                    BeginContext(1461, 26, true);
                                    WriteLiteral("\r\n                        ");
                                    EndContext();
                                }
                                );
                                __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CircularRanges>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges);
#line 24 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.Size = 5;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.DistanceFromScale = -30;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("distance-from-scale", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.DistanceFromScale, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.StartValue = 110;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("start-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.StartValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.EndValue = 120;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("end-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.EndValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                                __Syncfusion_JavaScript_DataVisualization_Models_CircularRanges.BackgroundColor = (string)__tagHelperAttribute_1.Value;
                                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1507, 22, true);
                                WriteLiteral("\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_CircularGaugeCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.CircularGaugeCollectionTag>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_CircularGaugeCollectionTag);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1560, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1582, 201, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pointer-collections", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5e4b40494cb49ad95008785238d236e", async() => {
                                BeginContext(1605, 26, true);
                                WriteLiteral("\r\n                        ");
                                EndContext();
                                BeginContext(1631, 106, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pointers", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "129625c67ee04447b3a1a285e025d8e0", async() => {
                                }
                                );
                                __Syncfusion_JavaScript_DataVisualization_Models_Pointers = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Pointers>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Pointers);
#line 28 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Pointers.Value = 60;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_DataVisualization_Models_Pointers.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Pointers.Length = 90;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("length", __Syncfusion_JavaScript_DataVisualization_Models_Pointers.Length, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Pointers.Width = 8;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_Pointers.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Pointers.ShowBackNeedle = true;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("show-back-needle", __Syncfusion_JavaScript_DataVisualization_Models_Pointers.ShowBackNeedle, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Pointers.BackNeedleLength = 15;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("back-needle-length", __Syncfusion_JavaScript_DataVisualization_Models_Pointers.BackNeedleLength, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1737, 22, true);
                                WriteLiteral("\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_CircularGaugeCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.CircularGaugeCollectionTag>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_CircularGaugeCollectionTag);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1783, 40, true);
                            WriteLiteral("\r\n                    \r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_CircularScales = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CircularScales>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CircularScales);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Radius = 130;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("radius", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Radius, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Minimum = 0;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("minimum", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Minimum, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Maximum = 120;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("maximum", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Maximum, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.MajorIntervalValue = 20;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("major-interval-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.MajorIntervalValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.MinorIntervalValue = 10;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("minor-interval-value", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.MinorIntervalValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.ShowScaleBar = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-scale-bar", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.ShowScaleBar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Size = 1;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularScales.ShowRanges = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-ranges", __Syncfusion_JavaScript_DataVisualization_Models_CircularScales.ShowRanges, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1843, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_CircularGaugeCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.CircularGaugeCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_CircularGaugeCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1888, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CircularGaugeProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.Load = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.BackgroundColor = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.Radius = 140;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("radius", __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.Radius, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.Width = 500;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\CircularGauge\Default.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.Height = 360;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_DataVisualization_Models_CircularGaugeProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1918, 22, true);
                WriteLiteral("\r\n</div>\r\n</div>\r\n    ");
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
