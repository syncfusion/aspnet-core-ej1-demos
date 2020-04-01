#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dde1df0aad5b4fa70b111957f319a81c4ce49e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_AppointmentTemplate), @"mvc.1.0.view", @"/Views/Schedule/AppointmentTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schedule/AppointmentTemplate.cshtml", typeof(AspNetCore.Views_Schedule_AppointmentTemplate))]
namespace AspNetCore
{
    #line hidden
    using System;
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
using System.Collections.Generic;

#line default
#line hidden
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
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dde1df0aad5b4fa70b111957f319a81c4ce49e4", @"/Views/Schedule/AppointmentTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_AppointmentTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Schedule1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "525px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("appointment-template-id", "#apptemplate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(92, 60, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Appointment Template</span>\r\n");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(173, 121, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example shows how the ASP.NET Core Scheduler can customize appointments.\">\r\n");
                EndContext();
            }
            );
#line 10 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
  
    List<string> scheduleView = new List<string>() { "Day", "Week", "WorkWeek", "Month" };

#line default
#line hidden
            BeginContext(396, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(423, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(444, 445, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-schedule", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "475f32290f7b47cab9e1a3eefa005996", async() => {
                    BeginContext(621, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(635, 230, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-appointment-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e96abf6892f0482784265ccdba8b867b", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ScheduleFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleFields);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.DataSource = ViewBag.appointments;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ScheduleFields.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Subject = "Subject";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("subject", __Syncfusion_JavaScript_Models_ScheduleFields.Subject, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.StartTime = "StartTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("start-time", __Syncfusion_JavaScript_Models_ScheduleFields.StartTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.EndTime = "EndTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("end-time", __Syncfusion_JavaScript_Models_ScheduleFields.EndTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.AllDay = "AllDay";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("all-day", __Syncfusion_JavaScript_Models_ScheduleFields.AllDay, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Recurrence = "Recurrence";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("recurrence", __Syncfusion_JavaScript_Models_ScheduleFields.Recurrence, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
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
                    BeginContext(865, 10, true);
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
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate = new DateTime(2017, 6, 5);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("current-date", __Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ScheduleProperties.AppointmentTemplateId = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.Views = scheduleView;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("views", __Syncfusion_JavaScript_Models_ScheduleProperties.Views, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Schedule\AppointmentTemplate.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.CurrentView = global::Syncfusion.JavaScript.CurrentView.Month;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("current-view", __Syncfusion_JavaScript_Models_ScheduleProperties.CurrentView, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(889, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(906, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(931, 1249, true);
                WriteLiteral(@"
    <script id=""apptemplate"" type=""text/x-jsrender"">
        <div style=""height:100%"">
            <div style='float:left; width:50px;'>{{:~format(StartTime)}}</div>
            <div>
                <div>{{:Subject}}</div>
            </div>
        </div>
    </script>

    <script type=""text/javascript"">
        function _getImages(date) {
            switch (new Date(date).getDay()) {
                case 0:
                    return ""<img src='../images/schedule/cake.png'/>"";
                case 1:
                    return ""<img src='../images/schedule/basketball.png'/>"";
                case 2:
                    return ""<img src='../images/schedule/rugby.png'/>"";
                case 3:
                    return ""<img src='../images/schedule/guitar.png'/>"";
                case 4:
                    return ""<img src='../images/schedule/music.png'/>"";
                case 5:
                    return ""<img src='../images/schedule/doctor.png'/>"";
                case 6:");
                WriteLiteral("\n                    return \"<img src=\'../images/schedule/beach.png\'/>\";\r\n                default:\r\n                    return null;\r\n            }\r\n        }\r\n        $.views.helpers({ format: _getImages });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(2183, 2, true);
            WriteLiteral("\r\n");
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
