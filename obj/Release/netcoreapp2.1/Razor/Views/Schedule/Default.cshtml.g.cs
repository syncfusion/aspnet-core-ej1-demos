#pragma checksum "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bb3574f47e6abe23a12bb7eec484a6ad660f8e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_Default), @"mvc.1.0.view", @"/Views/Schedule/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schedule/Default.cshtml", typeof(AspNetCore.Views_Schedule_Default))]
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
#line 1 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb3574f47e6abe23a12bb7eec484a6ad660f8e5", @"/Views/Schedule/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Schedule1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "525px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ScheduleProperties __Syncfusion_JavaScript_Models_ScheduleProperties;
        private global::Syncfusion.JavaScript.Models.ScheduleFields __Syncfusion_JavaScript_Models_ScheduleFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(56, 63, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Default Functionalities</span>\r\n");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(140, 131, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example shows how the ASP.NET Core Scheduler looks with its default configuration.\">\r\n");
                EndContext();
            }
            );
            BeginContext(274, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(301, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(322, 364, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-schedule", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135ad16ad0664378bf7d4ba3cc8374b0", async() => {
                    BeginContext(418, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(432, 230, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-appointment-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99aa03d9215a400e99714266e1695440", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ScheduleFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleFields);
#line 13 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.DataSource = ViewBag.appointments;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ScheduleFields.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Subject = "Subject";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("subject", __Syncfusion_JavaScript_Models_ScheduleFields.Subject, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.StartTime = "StartTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("start-time", __Syncfusion_JavaScript_Models_ScheduleFields.StartTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.EndTime = "EndTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("end-time", __Syncfusion_JavaScript_Models_ScheduleFields.EndTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.AllDay = "AllDay";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("all-day", __Syncfusion_JavaScript_Models_ScheduleFields.AllDay, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Recurrence = "Recurrence";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("recurrence", __Syncfusion_JavaScript_Models_ScheduleFields.Recurrence, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.RecurrenceRule = "RecurrenceRule";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("recurrence-rule", __Syncfusion_JavaScript_Models_ScheduleFields.RecurrenceRule, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(662, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ScheduleProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ScheduleProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ScheduleProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 12 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Schedule\Default.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate = new DateTime(2017, 6, 5);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("current-date", __Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(686, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
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
