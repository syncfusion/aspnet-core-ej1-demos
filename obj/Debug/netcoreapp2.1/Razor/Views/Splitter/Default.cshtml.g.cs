#pragma checksum "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Splitter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "425f16adaf658e89b9f96dbeb37adc0a5fe29829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Splitter_Default), @"mvc.1.0.view", @"/Views/Splitter/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Splitter/Default.cshtml", typeof(AspNetCore.Views_Splitter_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425f16adaf658e89b9f96dbeb37adc0a5fe29829", @"/Views/Splitter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Splitter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "398", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("pane-size", "80", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("outer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "250", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "400", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.SplitterProperties __Syncfusion_JavaScript_Models_SplitterProperties;
        private global::Syncfusion.JavaScript.Models.SplitterCollection __Syncfusion_JavaScript_Models_SplitterCollection;
        private global::Syncfusion.JavaScript.Models.PaneProperties __Syncfusion_JavaScript_Models_PaneProperties;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 72, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Splitter / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(116, 193, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates using the Syncfusion ASP.NET Core Splitter component to divide a web page into distinct areas by inserting resizable panes.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(337, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(345, 1630, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-Splitter", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a81777e7a8704c14bfad45054bf8c4a8", async() => {
                    BeginContext(477, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(487, 1468, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-panes", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec20b02a30764adf890a54c8806134af", async() => {
                        BeginContext(502, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(516, 1164, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b9d45fbfebd4c3d8b8f4800a12b0074", async() => {
                            BeginContext(530, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(548, 1103, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1dee76dbc2c42bea0d970dbabc06fba", async() => {
                                BeginContext(568, 25, true);
                                WriteLiteral("\r\n                       ");
                                EndContext();
                                BeginContext(593, 1019, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-Splitter", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b082bd3cdd645078c36773567e653cc", async() => {
                                    BeginContext(714, 29, true);
                                    WriteLiteral("\r\n                           ");
                                    EndContext();
                                    BeginContext(743, 830, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-panes", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6236533d664c9ab5835b6daaa8e514", async() => {
                                        BeginContext(758, 33, true);
                                        WriteLiteral("\r\n                               ");
                                        EndContext();
                                        BeginContext(791, 369, false);
                                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "875313e6bc2c407fb5719c421a25f6bb", async() => {
                                            BeginContext(805, 72, true);
                                            WriteLiteral("                                   \r\n                                   ");
                                            EndContext();
                                            BeginContext(877, 235, false);
                                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1be30b8d5e5b4f718a97c7d24a2939b2", async() => {
                                                BeginContext(897, 194, true);
                                                WriteLiteral("\r\n                                       <div class=\"cont\">\r\n                                           Pane 1\r\n                                       </div>\r\n                                   ");
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
                                            BeginContext(1112, 33, true);
                                            WriteLiteral("\r\n                               ");
                                            EndContext();
                                        }
                                        );
                                        __Syncfusion_JavaScript_Models_PaneProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PaneProperties>();
                                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PaneProperties);
                                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                                        {
                                            await __tagHelperExecutionContext.SetOutputContentAsync();
                                        }
                                        Write(__tagHelperExecutionContext.Output);
                                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                        EndContext();
                                        BeginContext(1160, 34, true);
                                        WriteLiteral("\r\n                                ");
                                        EndContext();
                                        BeginContext(1194, 334, false);
                                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cf37b2acb4a416ca952e26a9acdb1f0", async() => {
                                            BeginContext(1208, 37, true);
                                            WriteLiteral("\r\n                                   ");
                                            EndContext();
                                            BeginContext(1245, 235, false);
                                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "865b39768cf345bc967950bd0beb7271", async() => {
                                                BeginContext(1265, 194, true);
                                                WriteLiteral("\r\n                                       <div class=\"cont\">\r\n                                           Pane 2\r\n                                       </div>\r\n                                   ");
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
                                            BeginContext(1480, 33, true);
                                            WriteLiteral("\r\n                               ");
                                            EndContext();
                                        }
                                        );
                                        __Syncfusion_JavaScript_Models_PaneProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PaneProperties>();
                                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PaneProperties);
                                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                                        {
                                            await __tagHelperExecutionContext.SetOutputContentAsync();
                                        }
                                        Write(__tagHelperExecutionContext.Output);
                                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                        EndContext();
                                        BeginContext(1528, 29, true);
                                        WriteLiteral("\r\n                           ");
                                        EndContext();
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_SplitterCollection = CreateTagHelper<global::Syncfusion.JavaScript.Models.SplitterCollection>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SplitterCollection);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1573, 25, true);
                                    WriteLiteral("\r\n                       ");
                                    EndContext();
                                }
                                );
                                __Syncfusion_JavaScript_Models_SplitterProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SplitterProperties>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SplitterProperties);
                                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                                __Syncfusion_JavaScript_Models_SplitterProperties.Width = (string)__tagHelperAttribute_1.Value;
                                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 12 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Splitter\Default.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive = true;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Splitter\Default.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize = true;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("enable-auto-resize", __Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Splitter\Default.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.Orientation = Orientation.Horizontal;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("orientation", __Syncfusion_JavaScript_Models_SplitterProperties.Orientation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1612, 18, true);
                                WriteLiteral("\r\n                ");
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
                            BeginContext(1651, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_PaneProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PaneProperties>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PaneProperties);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1680, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1694, 235, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcc94a06a012486cafafa1b31d59e6c3", async() => {
                            BeginContext(1723, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(1741, 159, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d65b229e78d453d974a4e692881ad14", async() => {
                                BeginContext(1761, 118, true);
                                WriteLiteral("\r\n                    <div class=\"cont\">\r\n                        Pane 3\r\n                    </div>\r\n                ");
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
                            BeginContext(1900, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_PaneProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PaneProperties>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PaneProperties);
                        __Syncfusion_JavaScript_Models_PaneProperties.PaneSize = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1929, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_SplitterCollection = CreateTagHelper<global::Syncfusion.JavaScript.Models.SplitterCollection>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SplitterCollection);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1955, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_SplitterProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SplitterProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SplitterProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_SplitterProperties.Height = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_SplitterProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 8 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Splitter\Default.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Splitter\Default.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-auto-resize", __Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Splitter\Default.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.Orientation = Orientation.Vertical;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("orientation", __Syncfusion_JavaScript_Models_SplitterProperties.Orientation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1975, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2002, 221, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .cont {\r\n            padding: 10px 0 0 10px;\r\n            text-align: center;\r\n        }\r\n\r\n        #inner {\r\n            border: 0 none;\r\n        }\r\n    </style>\r\n");
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
