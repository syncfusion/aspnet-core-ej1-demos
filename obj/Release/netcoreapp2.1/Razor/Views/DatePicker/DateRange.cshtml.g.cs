#pragma checksum "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f042de47f7a13eb45a893bdb83e2d45ab379fea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatePicker_DateRange), @"mvc.1.0.view", @"/Views/DatePicker/DateRange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DatePicker/DateRange.cshtml", typeof(AspNetCore.Views_DatePicker_DateRange))]
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
#line 1 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f042de47f7a13eb45a893bdb83e2d45ab379fea", @"/Views/DatePicker/DateRange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DatePicker_DateRange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("daterange1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("date-format", "MM/dd/yyyy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("select", "selectedDate1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("daterange2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("select", "selectedDate2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/samples/datepickerdaterange.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 156, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how to disables the specific range of dates (min and max) in a ASP.NET Core DatePicker.\">\r\n");
                EndContext();
            }
            );
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(211, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 224, "\"", 288, 1);
#line 6 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml"
WriteAttributeValue("", 230, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 230, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(289, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(327, 61, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">DatePicker / DateRange</span> ");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(416, 160, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <span class=\"acc\">\r\n            \r\n        </span><span class=\"firstdp\">\r\n            <span class=\"innerdp\">\r\n                ");
                EndContext();
                BeginContext(576, 263, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627e70ca87d04938b64c0bd4260f29fe", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DatePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DatePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DatePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_DatePickerProperties.DateFormat = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 16 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.MinDate = DateTime.Now.AddDays(-7).GetDateTimeFormats()[3];

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-date", __Syncfusion_JavaScript_Models_DatePickerProperties.MinDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.MaxDate = DateTime.Now.AddMonths(3).GetDateTimeFormats()[3];

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("max-date", __Syncfusion_JavaScript_Models_DatePickerProperties.MaxDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.Value = DateTime.Now.GetDateTimeFormats()[3];

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DatePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DatePickerProperties.Select = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(839, 117, true);
                WriteLiteral("\r\n            </span>\r\n\r\n        </span><span class=\"seconddp\">\r\n            <span class=\"innerdp\">\r\n                ");
                EndContext();
                BeginContext(956, 262, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a39bb23242f84b53a127321165b5e40b", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DatePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DatePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DatePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DatePickerProperties.DateFormat = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 21 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.MinDate = DateTime.Now.GetDateTimeFormats()[3];

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-date", __Syncfusion_JavaScript_Models_DatePickerProperties.MinDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.MaxDate = DateTime.Now.AddMonths(3).GetDateTimeFormats()[3];

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("max-date", __Syncfusion_JavaScript_Models_DatePickerProperties.MaxDate, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\DatePicker\DateRange.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.Value = DateTime.Now.AddDays(7).GetDateTimeFormats()[3];

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DatePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DatePickerProperties.Select = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1218, 52, true);
                WriteLiteral("\r\n            </span>\r\n        </span>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1296, 1086, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var maxDatepicker = null;
        var minDatepicker = null;
        $(function () {
            // declaration
            maxDatepicker = $(""daterange1"").data(""ejDatePicker"");
            minDatepicker = $(""daterange2"").data(""ejDatePicker"");
        });
        function selectedDate1(sender) {
            $(function () {
                maxDatepicker = $(""#daterange2"").data(""ejDatePicker"");
                minDatepicker1 = $(""#daterange1"").data(""ejDatePicker"");
                maxDatepicker.setModel({ ""minDate"": new Date(sender.value) });
                var curDate = new Date(sender.value);
                maxDatepicker.setModel({ value: new Date(curDate.getFullYear(), curDate.getMonth(), curDate.getDate() + 7) });
            });

        }
        function selectedDate2(sender) {
            $(function () {
                minDatepicker = $(""#daterange1"").data(""ejDatePicker"");
                minDatepicker.setModel({ ""maxDate"": new Date(se");
                WriteLiteral("nder.value) });\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2407, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2409, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "286cebce40dd4b1da6f27334c3c90d3e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2479, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(2484, 2, true);
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
