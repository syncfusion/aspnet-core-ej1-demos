#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\ScrollBar\VirtualScrolling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9429ede0ec9bfc66f11266ea808481fe7360ee0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScrollBar_VirtualScrolling), @"mvc.1.0.view", @"/Views/ScrollBar/VirtualScrolling.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ScrollBar/VirtualScrolling.cshtml", typeof(AspNetCore.Views_ScrollBar_VirtualScrolling))]
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
#line 5 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9429ede0ec9bfc66f11266ea808481fe7360ee0e", @"/Views/ScrollBar/VirtualScrolling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ScrollBar_VirtualScrolling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("scrollcontent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("scroll", "onScroll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ScrollerProperties __Syncfusion_JavaScript_Models_ScrollerProperties;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 157, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how to achieve the virtual scrolling(loads content dynamically) in ASP.NET Core Scroller\">\r\n");
                EndContext();
            }
            );
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(203, 67, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ScrollBar / Virtual Scrolling</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(298, 37, true);
                WriteLiteral("\r\n    <div class=\"control\">\r\n        ");
                EndContext();
                BeginContext(335, 2086, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-scroller", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0e67b9a70444510b641284870c87065", async() => {
                    BeginContext(410, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(424, 1973, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc9f3105b6744505af1ea09270841641", async() => {
                        BeginContext(444, 1932, true);
                        WriteLiteral(@"
                <div>
                    <div class=""sampleContent"" unselectable=""on"">
                        <p><b>Scroll to see various contents loading virtually</b></p>
                        <h3 style=""font-size: 20px;"">Syncfusion</h3>
                        <div>
                            <p>
                                Founded by industry experts in 2001, Syncfusion, Inc. provides the broadest range of enterprise-class software components and tools for the Microsoft .NET platform.
                            </p>
                            <br />
                            <p>
                                With Syncfusion, developers can move beyond simply coding applications to delivering real business innovation—the elegant user interfaces, business intelligence dashboards, and sophisticated reporting that today's business users need, in the formats they demand.
                                Our award-winning components and controls are designed to meet your evolving deve");
                        WriteLiteral(@"lopment needs, whether you're working in ASP.NET, ASP.NET MVC, Windows Forms, WPF, Windows Phone, WinRT, JavaScript, Silverlight, or Xamarin.
                            </p>
                            <br />
                            <p><b>More than 650 stunning controls and frameworks</b></p>
                            <p>
                                The most comprehensive suite of components available for .NET and JavaScript, including charts, grids, diagrams, schedulers, Gantt controls, maps, gauges, docking, ribbons and much more.
                                The Syncfusion Big Data Platform is the first and the only complete Hadoop distribution designed for Windows. Develop on Windows using tools that you are familiar with. Deploy on Windows.
                            </p>
                        </div>
                    </div>
                </div> 
            ");
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
                    BeginContext(2397, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ScrollerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScrollerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScrollerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 9 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\ScrollBar\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ScrollerProperties.Height = 400;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_Models_ScrollerProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\ScrollBar\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ScrollerProperties.Width = 700;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_ScrollerProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ScrollerProperties.Scroll = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2421, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2461, 1701, true);
                WriteLiteral(@"
    <script>
        var scrollerObj, contentLoaded = false; var list = 0; var newItem, newItemHeading;
        var content = [""mvccontent"", ""gridcontent"", ""twitter"", ""wpfcontent"", ""javascript"", ""lightswitch"", ""orubase"", ""bigdata""];
        $(function () {
            scrollerObj = $(""#scrollcontent"").data(""ejScroller"");
        });
        function onScroll(e) {
            if (scrollerObj) {
                scrollerPositon = e.scrollTop;
                if (!contentLoaded && document.querySelectorAll("".sampleContent"")[0].scrollHeight - (e.scrollTop) <= scrollerObj.option(""height"")) {
                    $.ajax({
                        url: ""../css/samplecontent/"" + content[list] + "".html"",
                        success: function (result) {
                            newItem = $(""<div unselectable='on'></div>"").addClass(""e-newItem"").attr({ ""id"": ""e-newItem"" + list });
                            newItemHeading = $(""<h2>NewContent "" + (list + 1) + "" loaded</h2>"");
                        ");
                WriteLiteral(@"    newItem.appendTo("".sampleContent"");
                            newItem.html(result);
                            newItemHeading.prependTo(newItem);
                            //refresh the scroller to adjust the scroller position automatically based on new content
                            scrollerObj.refresh();
                            scrollerObj.option(""scrollTop"", scrollerPositon);
                            list++;
                            if (list == content.length)
                                contentLoaded = true;
                        }
                    });
                }
            }
        }
        
    </script>
");
                EndContext();
            }
            );
            BeginContext(4165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("StyleSection", async() => {
                BeginContext(4189, 746, true);
                WriteLiteral(@"
    <style type=""text/css"" class=""cssStyles"">
        .control {
            border: 1px solid #bbbcbb;
            color: gray;
            width: 700px;
        }

        .sampleContent {
            width: 650px;
            padding: 15px;
            text-align: justify;
            -webkit-touch-callout: none;
            -webkit-user-select: none;
            -khtml-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        #e-newItem0 {
            height: 400px;
        }

        #e-newItem1 {
            height: 250px;
        }

        #e-newItem3, #e-newItem2 {
            height: 340px;
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
