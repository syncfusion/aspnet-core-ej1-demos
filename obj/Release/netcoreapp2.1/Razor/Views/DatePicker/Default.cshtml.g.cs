#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DatePicker\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cccd1605223acbb881e2b3b0fbb811763b7601f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatePicker_Default), @"mvc.1.0.view", @"/Views/DatePicker/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DatePicker/Default.cshtml", typeof(AspNetCore.Views_DatePicker_Default))]
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
#line 5 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cccd1605223acbb881e2b3b0fbb811763b7601f", @"/Views/DatePicker/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DatePicker_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DatePick"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DatePickerProperties __Syncfusion_JavaScript_Models_DatePickerProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 151, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates a simple, mobile-friendly and responsive ASP.NET Core DatePicker to select a date.\">\r\n");
                EndContext();
            }
            );
            BeginContext(172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(206, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 219, "\"", 283, 1);
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DatePicker\Default.cshtml"
WriteAttributeValue("", 225, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 225, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(284, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(322, 53, true);
                WriteLiteral("<span class=\"sampleName\">DatePicker / Default</span> ");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(403, 96, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\" style=\"margin-left:35px;\">\r\n            ");
                EndContext();
                BeginContext(499, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b90df95c161438cadbb9726aa8eb355", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DatePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DatePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DatePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 12 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\DatePicker\Default.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.Value = DateTime.Today;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DatePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(569, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
