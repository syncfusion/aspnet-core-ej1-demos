#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd03251fc16605246c5f869b4a336265bb5997eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_CustomView), @"mvc.1.0.view", @"/Views/Schedule/CustomView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schedule/CustomView.cshtml", typeof(AspNetCore.Views_Schedule_CustomView))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd03251fc16605246c5f869b4a336265bb5997eb", @"/Views/Schedule/CustomView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_CustomView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("start", "6/5/2017", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("end", "6/8/2017", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Schedule1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "525px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("currentview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "viewname", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "110px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onViewChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("startDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("endDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "onCustomViewChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ScheduleRenderDates __Syncfusion_JavaScript_Models_ScheduleRenderDates;
        private global::Syncfusion.JavaScript.Models.ScheduleFields __Syncfusion_JavaScript_Models_ScheduleFields;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        private global::Syncfusion.JavaScript.Models.DatePickerProperties __Syncfusion_JavaScript_Models_DatePickerProperties;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(56, 51, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Custom View</span>\r\n");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(128, 145, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example shows how to display user-provided continuous date ranges in the ASP.NET Core Scheduler.\">\r\n");
                EndContext();
            }
            );
#line 9 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
  
    List<string> viewList = new List<string>() { "CustomView" };

#line default
#line hidden
            BeginContext(349, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(376, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(397, 512, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-schedule", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa24caa2ef144ed190c9c01c937c298a", async() => {
                    BeginContext(536, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(550, 65, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-render-dates", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f94ac8a4ac4f1293c1fd696d8f6f68", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ScheduleRenderDates = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleRenderDates>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleRenderDates);
                    __Syncfusion_JavaScript_Models_ScheduleRenderDates.Start = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_Models_ScheduleRenderDates.End = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(615, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(629, 256, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-appointment-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a4cf70123df49efaf029de63057655a", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ScheduleFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleFields);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.DataSource = ViewBag.appointments;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ScheduleFields.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Subject = "Subject";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("subject", __Syncfusion_JavaScript_Models_ScheduleFields.Subject, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.StartTime = "StartTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("start-time", __Syncfusion_JavaScript_Models_ScheduleFields.StartTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.EndTime = "EndTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("end-time", __Syncfusion_JavaScript_Models_ScheduleFields.EndTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.AllDay = "AllDay";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("all-day", __Syncfusion_JavaScript_Models_ScheduleFields.AllDay, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Recurrence = "Recurrence";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("recurrence", __Syncfusion_JavaScript_Models_ScheduleFields.Recurrence, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.RecurrenceRule = "RecurrenceRule";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("recurrence-rule", __Syncfusion_JavaScript_Models_ScheduleFields.RecurrenceRule, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Categorize = "Categorize";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("categorize", __Syncfusion_JavaScript_Models_ScheduleFields.Categorize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(885, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ScheduleProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_ScheduleProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_ScheduleProperties.Height = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 15 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate = new DateTime(2017, 6, 5);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("current-date", __Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.Views = viewList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("views", __Syncfusion_JavaScript_Models_ScheduleProperties.Views, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.CurrentView = global::Syncfusion.JavaScript.CurrentView.CustomView;

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
                BeginContext(909, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(926, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(955, 216, true);
                WriteLiteral("\r\n    <div id=\"sampleProperties\">\r\n        <div class=\"prop-grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">Orientation</div>\r\n                <div class=\"col-md-6\">\r\n                    ");
                EndContext();
                BeginContext(1171, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "860a57399d4349c198985c6d93d2329d", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 28 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedIndex = 4;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1303, 623, true);
                WriteLiteral(@"
                    <div id=""viewname"">
                        <ul>
                            <li value=""Day"">Day</li>
                            <li value=""Week"">Week</li>
                            <li value=""WorkWeek"">WorkWeek</li>
                            <li value=""Month"">Month</li>
                            <li value=""CustomView"">CustomView</li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">Start Date</div>
                <div class=""col-md-6"">
                    ");
                EndContext();
                BeginContext(1926, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e13eb9bfa349519e84796b1842cadc", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DatePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DatePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DatePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#line 43 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.Value = new DateTime(2017, 6, 5);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DatePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DatePickerProperties.Width = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2021, 193, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">Start Date</div>\r\n                <div class=\"col-md-6\">\r\n                    ");
                EndContext();
                BeginContext(2214, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4603ca6fede476592a88fe3eae18046", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DatePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DatePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DatePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#line 49 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.Value = new DateTime(2017, 6, 8);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DatePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DatePickerProperties.Width = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2307, 137, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
                EndContext();
                BeginContext(2444, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c1a9bad631e4202afe4d2782f6a2b7e", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#line 54 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Schedule\CustomView.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Size = ButtonSize.Small;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_Models_ButtonProperties.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2535, 74, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(2612, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(2637, 1255, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });

        function onViewChange(args) {
            $(""#Schedule1"").ejSchedule({ views: [args.value], currentView: args.value.toLowerCase() });
        }

        function onCustomViewChange(args) {
            var startDate = $(""#startDate"").ejDatePicker(""option"", ""value"");
            startDate = new Date(startDate.getFullYear(), startDate.getMonth(), startDate.getDate());
            var endDate = $(""#endDate"").ejDatePicker(""option"", ""value"");
            endDate = new Date(endDate.getFullYear(), endDate.getMonth(), endDate.getDate());
            if (startDate <= endDate) {
                $('#currentview').ejDropDownList({ select: ""onViewChange"", selectedItemIndex: 4 });
                $(""#Schedule1"").ejSchedule({
                    renderDates: {
                        start: new Date(startDate),
                        end: new Date(endDate)
           ");
                WriteLiteral("         },\r\n                    currentDate: new Date(startDate)\r\n                });\r\n            }\r\n            else {\r\n                alert(\"Start date must be lesser than end date\");\r\n            }\r\n        }\r\n    </script>\r\n");
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
