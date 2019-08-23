#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ScrollBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d67e5e3929cc1ce875898efc72d7d61e2de8f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScrollBar_Default), @"mvc.1.0.view", @"/Views/ScrollBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ScrollBar/Default.cshtml", typeof(AspNetCore.Views_ScrollBar_Default))]
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
#line 5 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d67e5e3929cc1ce875898efc72d7d61e2de8f4", @"/Views/ScrollBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ScrollBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("scrollcontent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(18, 142, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates the default functionalities of the scroller and scrollbar in ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(188, 73, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ScrollBar / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(289, 37, true);
                WriteLiteral("\r\n    <div class=\"control\">\r\n        ");
                EndContext();
                BeginContext(326, 2870, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-Scroller", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04667ce48cb5414592f44ea1bf4114e0", async() => {
                    BeginContext(383, 26, true);
                    WriteLiteral("            \r\n            ");
                    EndContext();
                    BeginContext(409, 2763, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03ff8f8f8d404f81834ddf587cc9f7a9", async() => {
                        BeginContext(429, 2722, true);
                        WriteLiteral(@"
                <div>
                    <div class=""sampleContent"">
                        <h3 style=""font-size: 20px;"">MVC</h3>
                        <div>
                            <p>
                                Model–view–controller (MVC) is a software architecture pattern which separates the
                                representation of information from the user's interaction with it. The model consists
                                of application data, business rules, logic, and functions. A view can be any output
                                representation of data, such as a chart or a diagram. Multiple views of the same
                                data are possible, such as a bar chart for management and a tabular view for accountants.
                                The controller mediates input, converting it to commands for the model or view.The
                                central ideas behind MVC are code reusability and n addition to dividing the applicati");
                        WriteLiteral(@"on
                                into three kinds of components, the MVC design defines the interactions between
                                them.
                            </p>
                            <ul>
                                <li>
                                    <b>A controller </b>can send commands to its associated view to change the view's
                                    presentation of the model (e.g., by scrolling through a document). It can also send
                                    commands to the model to update the model's state (e.g., editing a document).
                                </li>
                                <li>
                                    <b>A model</b> notifies its associated views and controllers when there has been
                                    a change in its state. This notification allows the views to produce updated output,
                                    and the controllers to change the available set of com");
                        WriteLiteral(@"mands. A passive implementation
                                    of MVC omits these notifications, because the application does not require them
                                    or the software platform does not support them.
                                </li>
                                <li>
                                    <b>A view</b> requests from the model the information that it needs to generate
                                    an output representation to the user.
                                </li>
                            </ul>
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
                    BeginContext(3172, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ScrollerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScrollerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScrollerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 9 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ScrollBar\Default.cshtml"
__Syncfusion_JavaScript_Models_ScrollerProperties.Height = 300;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_Models_ScrollerProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ScrollBar\Default.cshtml"
__Syncfusion_JavaScript_Models_ScrollerProperties.Width = 600;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_ScrollerProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3196, 17, true);
                WriteLiteral("\r\n    </div>   \r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(3238, 281, true);
                WriteLiteral(@"
    <style type=""text/css"" class=""cssStyles"">
        .control {
            border: 1px solid #bbbcbb;
            color: gray;
            width: 600px;
        }

        .sampleContent {
            width: 700px;
            padding: 15px;
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
