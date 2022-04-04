#pragma checksum "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Splitter\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83826c1b5643dd81fee4492397bb2b8817756219"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Splitter_Keyboard), @"mvc.1.0.view", @"/Views/Splitter/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Splitter/Keyboard.cshtml", typeof(AspNetCore.Views_Splitter_Keyboard))]
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
#line 5 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83826c1b5643dd81fee4492397bb2b8817756219", @"/Views/Splitter/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Splitter_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "398", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("paneSize", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("outer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "350", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 55, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Splitter / Events</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(99, 175, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to access the Syncfusion ASP.NET Core Splitter component functionalities using keyboard interactions.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(302, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(308, 1688, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-splitter", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9170b9854d1246dc83fafe97f62cf7c4", async() => {
                    BeginContext(440, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(450, 1526, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-panes", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4404dd8928884b6faca6208dbcd20093", async() => {
                        BeginContext(465, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(479, 1223, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3825b938031c4d819dbd2936a5552b41", async() => {
                            BeginContext(493, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(511, 1162, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d323ee964a34809ba366ea6bfa521ff", async() => {
                                BeginContext(531, 74, true);
                                WriteLiteral("\r\n                    <div style=\"height: 100%\">\r\n                        ");
                                EndContext();
                                BeginContext(605, 1001, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-Splitter", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05de73f011864bc1b1a48855bc3ceb0c", async() => {
                                    BeginContext(726, 30, true);
                                    WriteLiteral("\r\n                            ");
                                    EndContext();
                                    BeginContext(756, 810, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-panes", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18a609533cf64a198fae6f42f043099f", async() => {
                                        BeginContext(771, 34, true);
                                        WriteLiteral("\r\n                                ");
                                        EndContext();
                                        BeginContext(805, 341, false);
                                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4bd74a0706b4d1287357c4cad5f1134", async() => {
                                            BeginContext(819, 38, true);
                                            WriteLiteral("\r\n                                    ");
                                            EndContext();
                                            BeginContext(857, 240, false);
                                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20b8250620e4492a4911064d88d9a70", async() => {
                                                BeginContext(877, 199, true);
                                                WriteLiteral("\r\n                                        <div class=\"cont\">\r\n                                            Pane 1\r\n                                        </div> \r\n                                    ");
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
                                            BeginContext(1097, 34, true);
                                            WriteLiteral("\r\n                                ");
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
                                        BeginContext(1146, 34, true);
                                        WriteLiteral("\r\n                                ");
                                        EndContext();
                                        BeginContext(1180, 340, false);
                                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b93061cf387a4ebcb1e833d5d186a51d", async() => {
                                            BeginContext(1194, 38, true);
                                            WriteLiteral("\r\n                                    ");
                                            EndContext();
                                            BeginContext(1232, 239, false);
                                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7fca59c24b94bd682374afdd7d2b003", async() => {
                                                BeginContext(1252, 198, true);
                                                WriteLiteral("\r\n                                        <div class=\"cont\">\r\n                                            Pane 2\r\n                                        </div>\r\n                                    ");
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
                                            BeginContext(1471, 34, true);
                                            WriteLiteral("\r\n                                ");
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
                                        BeginContext(1520, 30, true);
                                        WriteLiteral("\r\n                            ");
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
                                    BeginContext(1566, 26, true);
                                    WriteLiteral("\r\n                        ");
                                    EndContext();
                                }
                                );
                                __Syncfusion_JavaScript_Models_SplitterProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SplitterProperties>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SplitterProperties);
                                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                                __Syncfusion_JavaScript_Models_SplitterProperties.Width = (string)__tagHelperAttribute_1.Value;
                                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 12 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Splitter\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive = true;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Splitter\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize = true;

#line default
#line hidden
                                __tagHelperExecutionContext.AddTagHelperAttribute("enable-auto-resize", __Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Splitter\Keyboard.cshtml"
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
                                BeginContext(1606, 46, true);
                                WriteLiteral("\r\n                    </div>\r\n                ");
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
                            BeginContext(1673, 14, true);
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
                        BeginContext(1702, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1716, 234, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5504d291ea244bf89204e50ccd682fd", async() => {
                            BeginContext(1744, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(1762, 159, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3c292f896cf411b9ea9b841a7e676d4", async() => {
                                BeginContext(1782, 118, true);
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
                            BeginContext(1921, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_PaneProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PaneProperties>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PaneProperties);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1950, 10, true);
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
                    BeginContext(1976, 6, true);
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
#line 7 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Splitter\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.Orientation = Orientation.Vertical;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("orientation", __Syncfusion_JavaScript_Models_SplitterProperties.Orientation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Splitter\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Splitter\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-auto-resize", __Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1996, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(2028, 2798, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + j
        </div>
        <div class=""col-md-3"">
            Focuses the first Splitbar
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Tab
        </div>
        <div class=""col-md-3"">
            Focuses the next Splitbar
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Shift + Tab
        </div>
        <div class=""col-md-3"">
            Focuses the previous Splitbar
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Enter
        </div>
        <div class=""col-md-3"">
            Resize the Pane to the current Splitbar position.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <br />
            Esc
        </div>
        <div class=""col-md-3"">
            <br />
            Focuses out from the Splitbar
        </div>
    </div>
");
                WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-3"">
            <br />
            For Horizontal:
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Left
        </div>
        <div class=""col-md-3"">
            Moves the Splitbar in Left
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Right
        </div>
        <div class=""col-md-3"">
            Moves the Splitbar in Right
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Left
        </div>
        <div class=""col-md-3"">
            Collapses the left Pane
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Right
        </div>
        <div class=""col-md-3"">
            Collapses the right Pane
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            For Vertical:
        </div>
    </div>
    <div class");
                WriteLiteral(@"=""row"">
        <div class=""col-md-3"">
            Up
        </div>
        <div class=""col-md-3"">
            Moves the Splitbar in Bottom
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down
        </div>
        <div class=""col-md-3"">
            Moves the Splitbar in Right
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Up
        </div>
        <div class=""col-md-3"">
            Collapses the top Pane
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Down
        </div>
        <div class=""col-md-3"">
            Collapses the bottom Pane
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(4852, 398, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            //Control focus key
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $(""#outer .e-splitbar"")[0].focus();
                }
            });
            $(""#sampleProperties"").ejPropertiesPanel();
        });
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(5275, 221, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .cont {\r\n            text-align: center;\r\n            padding: 10px 0 0 10px;\r\n        }\r\n\r\n        #inner {\r\n            border: 0 none;\r\n        }\r\n    </style>\r\n");
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
