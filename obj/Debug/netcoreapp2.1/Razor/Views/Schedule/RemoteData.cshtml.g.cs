#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5b559b4e4ab5d7f4dc026772d0ca59263626704"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_RemoteData), @"mvc.1.0.view", @"/Views/Schedule/RemoteData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schedule/RemoteData.cshtml", typeof(AspNetCore.Views_Schedule_RemoteData))]
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
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b559b4e4ab5d7f4dc026772d0ca59263626704", @"/Views/Schedule/RemoteData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_RemoteData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/demos/ejServices/api/Schedule/LoadData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Schedule1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "525px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("time-zone", "UTC -05:00", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(56, 51, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Remote Data</span>\r\n");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(128, 149, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example shows the binding of remote services by using the DataManager in the ASP.NET Core Scheduler.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(305, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(326, 517, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-schedule", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0938ff90846848b69b4f3647395b6aa3", async() => {
                    BeginContext(462, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(476, 343, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-appointment-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b742d1c7714f4a9484b8372babd59494", async() => {
                        BeginContext(646, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(664, 116, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a3f174da3a04e439efa55664c0d6a93", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                        __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_DataSource.CrossDomain = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("cross-domain", __Syncfusion_JavaScript_DataSource.CrossDomain, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(780, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_ScheduleFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleFields);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Subject = "Subject";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("subject", __Syncfusion_JavaScript_Models_ScheduleFields.Subject, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.StartTime = "StartTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("start-time", __Syncfusion_JavaScript_Models_ScheduleFields.StartTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.EndTime = "EndTime";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("end-time", __Syncfusion_JavaScript_Models_ScheduleFields.EndTime, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.AllDay = "AllDay";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("all-day", __Syncfusion_JavaScript_Models_ScheduleFields.AllDay, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_Models_ScheduleFields.Recurrence = "Recurrence";

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("recurrence", __Syncfusion_JavaScript_Models_ScheduleFields.Recurrence, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
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
                    BeginContext(819, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ScheduleProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ScheduleProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ScheduleProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ScheduleProperties.Width = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_ScheduleProperties.Height = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate = new DateTime(2017, 6, 5);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("current-date", __Syncfusion_JavaScript_Models_ScheduleProperties.CurrentDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ScheduleProperties.TimeZone = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Schedule\RemoteData.cshtml"
__Syncfusion_JavaScript_Models_ScheduleProperties.ReadOnly = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("read-only", __Syncfusion_JavaScript_Models_ScheduleProperties.ReadOnly, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(843, 14, true);
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
