#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3c6116bc040cb584575575ba16c7a1f3c9f99b7"
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rotator", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8738d9e26d454dd6b447e4e1a1e4b121", async() => {
                    BeginContext(428, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(442, 1643, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d56655d9a0a43ab9c70c5b46e53cbdc", async() => {
                        BeginContext(459, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(477, 300, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d84b73dfdc340babd396731eb29a0c8", async() => {
                            BeginContext(493, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(515, 227, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e17eda370f344090ac8d3c07c300b69f", async() => {
                                BeginContext(535, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 614, "\"", 663, 1);
#line 12 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
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
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d34c9e83d64767bbcbf0da4cdc6be0", async() => {
                            BeginContext(811, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(833, 225, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "316be9b925ea473f971f20a5c4d946bb", async() => {
                                BeginContext(853, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 932, "\"", 979, 1);
#line 19 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
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
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71200b55fb384ef8888a92e9c8c95a6c", async() => {
                            BeginContext(1127, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1149, 230, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37515ac081e64f7492ede9fc4e40210e", async() => {
                                BeginContext(1169, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1248, "\"", 1300, 1);
#line 26 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
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
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a388514486bd4de9b3431e9dbd620105", async() => {
                            BeginContext(1448, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1470, 228, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aa442791a8c48a6ba6a3481869b2d0b", async() => {
                                BeginContext(1490, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1569, "\"", 1619, 1);
#line 33 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
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
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f39177374942f1b5023b4871be5711", async() => {
                            BeginContext(1767, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1789, 229, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "696aa4c4dbac423d9a1c8f6cd9d2c879", async() => {
                                BeginContext(1809, 79, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1888, "\"", 1939, 1);
#line 40 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
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
#line 7 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Rotator\Default.cshtml"
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
