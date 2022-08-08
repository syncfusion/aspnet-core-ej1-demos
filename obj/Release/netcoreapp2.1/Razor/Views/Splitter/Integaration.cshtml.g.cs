#pragma checksum "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Splitter\Integaration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a560f67256c71f01b8cbd04739beedaa4cef0b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Splitter_Integaration), @"mvc.1.0.view", @"/Views/Splitter/Integaration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Splitter/Integaration.cshtml", typeof(AspNetCore.Views_Splitter_Integaration))]
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
#line 1 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a560f67256c71f01b8cbd04739beedaa4cef0b8", @"/Views/Splitter/Integaration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Splitter_Integaration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("paneSize", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("pane-size", "200", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("outterSplitter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "250", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "485", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 61, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Splitter / Integaration</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(105, 182, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates the integration of other Syncfusion ASP.NET Core components with the Syncfusion ASP.NET Core Splitter component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(315, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(321, 2549, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-splitter", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13be65dff10d49da80c2c080ec09f7ed", async() => {
                    BeginContext(426, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(436, 2414, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-panes", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab7a150daf314df78b825c80d2ae43ac", async() => {
                        BeginContext(451, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(465, 1157, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19705e9fc56e45ea82d997345ae47053", async() => {
                            BeginContext(494, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(512, 1081, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3068daf067f42328a75353d58e5f936", async() => {
                                BeginContext(532, 1040, true);
                                WriteLiteral(@"
                    <div class=""cont"">
                        <h3>FRENCH CITIES</h3>
                        <ul id=""treeView"" class=""visibleHide"">
                            <li>
                                PARIS
                                <ul>
                                    <li id=""tools"" class=""_child"">Speciality</li>
                                </ul>
                            </li>
                            <li>
                                CAMEMBERT
                                <ul>
                                    <li id=""chart"" class=""_child"">Speciality </li>
                                </ul>
                            </li>
                            <li>
                                GRENOBLE
                                <ul>
                                    <li id=""grid"" class=""_child"">Speciality</li>
                                </ul>
                            </li>
                        </ul>
                    </div>
");
                                WriteLiteral("                ");
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
                            BeginContext(1593, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_PaneProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PaneProperties>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PaneProperties);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1622, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1636, 1188, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-split-pane", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e49f53eafc89423c90d73934251159a0", async() => {
                            BeginContext(1666, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(1684, 1111, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-Template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871898b6cb694d6ea3bddf587ea9dabd", async() => {
                                BeginContext(1704, 1070, true);
                                WriteLiteral(@"
                    <div class=""cont"">
                        <div class=""_content"">
                            Select any city from the tree to show the description.
                        </div>
                        <div class=""tools des"">
                            <h3>PARIS</h3>
                            Paris, the city of lights and love - this short guide is full of ideas for how to make the most of the romanticism...
                        </div>
                        <div class=""chart des"">
                            <h3>CAMEMBERT</h3>
                            The village in the Orne département of Normandy where the famous French cheese is originated from.
                        </div>
                        <div class=""grid des"">
                            <h3>GRENOBLE</h3>
                            The capital city of the French Alps and a major scientific center surrounded by many ski resorts, host of the Winter Olympics in 1968.
                        </div>");
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
                            BeginContext(2795, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_PaneProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PaneProperties>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PaneProperties);
                        __Syncfusion_JavaScript_Models_PaneProperties.PaneSize = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2824, 10, true);
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
                    BeginContext(2850, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_SplitterProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SplitterProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SplitterProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 7 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Splitter\Integaration.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_SplitterProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Splitter\Integaration.cshtml"
__Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-auto-resize", __Syncfusion_JavaScript_Models_SplitterProperties.EnableAutoResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SplitterProperties.Height = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_SplitterProperties.Width = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2870, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2898, 419, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""#treeView"").ejTreeView({ nodeSelect: ""treeClicked"" });
        });
        function treeClicked(sender, args) {
            if (sender.currentElement.hasClass('_child')) {
                var content = $('.' + sender.currentElement[0].id).html();
                $('._content').html(content);
            }
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(3342, 405, true);
                WriteLiteral(@"
    <style type=""text/css"">
        .cont {
            padding: 20px;
            min-width: 50px;
        }

            .cont #treeView_Container {
                margin-bottom: 0;
                border: none;
            }

       .cont>h3 {
            font-size: 14px;
            font-weight: 600;
        }

        .des {
            display: none;
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
