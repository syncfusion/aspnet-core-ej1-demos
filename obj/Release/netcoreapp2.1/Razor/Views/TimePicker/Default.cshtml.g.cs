#pragma checksum "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TimePicker\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9948aea680fbe3bc8d47900ffa056b63c4327c2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimePicker_Default), @"mvc.1.0.view", @"/Views/TimePicker/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TimePicker/Default.cshtml", typeof(AspNetCore.Views_TimePicker_Default))]
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
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9948aea680fbe3bc8d47900ffa056b63c4327c2f", @"/Views/TimePicker/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TimePicker_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TimePick"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TimePickerProperties __Syncfusion_JavaScript_Models_TimePickerProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 151, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates a simple, mobile-friendly and responsive ASP.NET Core TimepIcker to select a time.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(204, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 217, "\"", 281, 1);
#line 5 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TimePicker\Default.cshtml"
WriteAttributeValue("", 223, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 223, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(282, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(322, 67, true);
                WriteLiteral("\r\n    \r\n    <span class=\"sampleName\">TimePicker / Default </span>\r\n");
                EndContext();
            }
            );
            BeginContext(392, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(419, 96, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\" style=\"margin-left:30px;\">\r\n            ");
                EndContext();
                BeginContext(515, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e627ac094e84a1496cbd1b82c8c25f1", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_TimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(547, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(580, 4, true);
            WriteLiteral("\r\n\r\n");
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
