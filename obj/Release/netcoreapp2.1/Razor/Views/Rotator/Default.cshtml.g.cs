#pragma checksum "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3c6116bc040cb584575575ba16c7a1f3c9f99b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rotator_Default), @"mvc.1.0.view", @"/Views/Rotator/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rotator/Default.cshtml", typeof(AspNetCore.Views_Rotator_Default))]
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
#line 1 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3c6116bc040cb584575575ba16c7a1f3c9f99b7", @"/Views/Rotator/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Rotator_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-height", "350px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RotatorProperties __Syncfusion_JavaScript_Models_RotatorProperties;
        private global::Syncfusion.JavaScript.Models.RotatorBase __Syncfusion_JavaScript_Models_RotatorBase;
        private global::Syncfusion.JavaScript.Models.RotatorBaseItem __Syncfusion_JavaScript_Models_RotatorBaseItem;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 50, true);
                WriteLiteral("<span class=\"sampleName\">Rotator / Default </span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(94, 161, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to create a Syncfusion ASP.NET Core Rotator component where each slide contains images.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(283, 35, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        ");
                EndContext();
                BeginContext(318, 1790, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rotator", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf601fba2d04090b732bd0b5398e7e7", async() => {
                    BeginContext(428, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(442, 1643, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79fb43a63594458ebb481213c2c6cfec", async() => {
                        BeginContext(459, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(477, 300, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acb1359afee045c18791cf178e60eef2", async() => {
                            BeginContext(493, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(515, 227, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cacae4b72f49599d7753a1ae04cd99", async() => {
                                BeginContext(535, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 614, "\"", 663, 1);
#line 12 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
WriteAttributeValue("", 620, Url.Content("~/Images/rotator/nature.jpg"), 620, 43, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(664, 57, true);
                                WriteLiteral(" />\r\n                        </div>\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(742, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(777, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(795, 298, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b267ccb550d4111a0d66db730b2f678", async() => {
                            BeginContext(811, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(833, 225, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0e51dbf0d3455f89853490abeaa211", async() => {
                                BeginContext(853, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 932, "\"", 979, 1);
#line 19 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
WriteAttributeValue("", 938, Url.Content("~/Images/rotator/bird.jpg"), 938, 41, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(980, 57, true);
                                WriteLiteral(" />\r\n                        </div>\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1058, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1093, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1111, 303, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c32da080080f4b0e8c138a48a812d621", async() => {
                            BeginContext(1127, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1149, 230, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f618f3cd1cf46e4b96e05f3257834e7", async() => {
                                BeginContext(1169, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1248, "\"", 1300, 1);
#line 26 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
WriteAttributeValue("", 1254, Url.Content("~/Images/rotator/sculpture.jpg"), 1254, 46, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(1301, 57, true);
                                WriteLiteral(" />\r\n                        </div>\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1379, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1414, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1432, 301, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e8c8520f25481f8d53d9143d3b4782", async() => {
                            BeginContext(1448, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1470, 228, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de533d9ba0a43a1892753684731f585", async() => {
                                BeginContext(1490, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1569, "\"", 1619, 1);
#line 33 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
WriteAttributeValue("", 1575, Url.Content("~/Images/rotator/seaview.jpg"), 1575, 44, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(1620, 57, true);
                                WriteLiteral(" />\r\n                        </div>\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1698, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1733, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1751, 302, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7ce080cc474d41bab3648205186bad", async() => {
                            BeginContext(1767, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1789, 229, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c9b0bed5ad54cf5b7bed4858a38e15f", async() => {
                                BeginContext(1809, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1888, "\"", 1939, 1);
#line 40 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
WriteAttributeValue("", 1894, Url.Content("~/Images/rotator/snowfall.jpg"), 1894, 45, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(1940, 57, true);
                                WriteLiteral(" />\r\n                        </div>\r\n                    ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(2018, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2053, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_RotatorBase = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBase);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2085, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_RotatorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideWidth = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideHeight = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 7 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-play-button", __Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2108, 24, true);
                WriteLiteral("\r\n        \r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2157, 254, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .frame {\r\n            width: 100%;\r\n            box-sizing: border-box;\r\n        }\r\n\r\n        #content > li .image {\r\n            width: 100%;\r\n            height: 350px;\r\n        }\r\n    </style>\r\n");
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
