#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec2fa769ef669e8d69b46a50829d73afaf69589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_Timescale), @"mvc.1.0.view", @"/Views/Schedule/Timescale.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schedule/Timescale.cshtml", typeof(AspNetCore.Views_Schedule_Timescale))]
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
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec2fa769ef669e8d69b46a50829d73afaf69589", @"/Views/Schedule/Timescale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_Timescale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Schedule1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "525px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("majorslot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "110px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("minorslot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "onTimeScaleChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TimeScale __Syncfusion_JavaScript_Models_TimeScale;
        private global::Syncfusion.JavaScript.Models.ScheduleFields __Syncfusion_JavaScript_Models_ScheduleFields;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(56, 49, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">TimeScale</span>\r\n");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(126, 124, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example shows how to customize the timescale in the ASP.NET Core Scheduler.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(278, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(299, 458, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-schedule", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4cca0e92ed74a3fa2b7e133fe23eaf9", async() => {
                    BeginContext(395, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(409, 80, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-time-scale", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11a06ebe1584fcab476637fa5aafabf", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_TimeScale = CreateTagHelper<global::Syncfusion.JavaScript.Models.TimeScale>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TimeScale);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_TimeScale.Enable = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable", __Syncfusion_JavaScript_Models_TimeScale.Enable, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_TimeScale.MajorSlot = 60;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("major-slot", __Syncfusion_JavaScript_Models_TimeScale.MajorSlot, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_TimeScale.MinorSlotCount = 6;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("minor-slot-count", __Syncfusion_JavaScript_Models_TimeScale.MinorSlotCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(489, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(503, 230, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-appointment-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5beb48ab63c74adb8b6c13890b902820", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ScheduleFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleFields);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.DataSource = ViewBag.appointments;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ScheduleFields.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Subject = "Subject";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("subject", __Syncfusion_JavaScript_Models_ScheduleFields.Subject, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.StartTime = "StartTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("start-time", __Syncfusion_JavaScript_Models_ScheduleFields.StartTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.EndTime = "EndTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("end-time", __Syncfusion_JavaScript_Models_ScheduleFields.EndTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.AllDay = "AllDay";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("all-day", __Syncfusion_JavaScript_Models_ScheduleFields.AllDay, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Recurrence = "Recurrence";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("recurrence", __Syncfusion_JavaScript_Models_ScheduleFields.Recurrence, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
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
                    BeginContext(733, 10, true);
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
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
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
                BeginContext(757, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(774, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(803, 215, true);
                WriteLiteral("\r\n    <div id=\"sampleProperties\">\r\n        <div class=\"prop-grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">Major Slot</div>\r\n                <div class=\"col-md-6\">\r\n                    ");
                EndContext();
                BeginContext(1018, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bca5af5dcf54abeaa8655091f6ff73b", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 24 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.DataSource = ViewBag.majorValue;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_DropDownListProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 24 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedIndex = 3;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1138, 193, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">Minor Slot</div>\r\n                <div class=\"col-md-6\">\r\n                    ");
                EndContext();
                BeginContext(1331, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecf7b5cac9bc40b1a62bf60055998923", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 30 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.DataSource = ViewBag.minorValue;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_DropDownListProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 30 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedIndex = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1451, 137, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
                EndContext();
                BeginContext(1588, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22d7663626244a3db3822f10bff6a7b7", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 35 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\Timescale.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Size = ButtonSize.Small;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_Models_ButtonProperties.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1678, 74, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(1755, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(1780, 496, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });

        function onTimeScaleChange(args) {
            $(""#Schedule1"").ejSchedule({
                timeScale: {
                    majorSlot: parseInt($(""#majorslot"").ejDropDownList(""model.value"")),
                    minorSlotCount: parseInt($(""#minorslot"").ejDropDownList(""model.value""))
                }
            });
        }
    </script>
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
