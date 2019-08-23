#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DateRangePicker\Ranges.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3fa87bb48b3a4ce9e3fa83520cbd69ed91efa0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DateRangePicker_Ranges), @"mvc.1.0.view", @"/Views/DateRangePicker/Ranges.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DateRangePicker/Ranges.cshtml", typeof(AspNetCore.Views_DateRangePicker_Ranges))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3fa87bb48b3a4ce9e3fa83520cbd69ed91efa0f", @"/Views/DateRangePicker/Ranges.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DateRangePicker_Ranges : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", "Last 1 Month", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", "Last 2 Months", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", "Last Week", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DateRange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DateRangePickerProperties __Syncfusion_JavaScript_Models_DateRangePickerProperties;
        private global::Syncfusion.JavaScript.Models.DateRangepicker __Syncfusion_JavaScript_Models_DateRangepicker;
        private global::Syncfusion.JavaScript.Models.DateRanges __Syncfusion_JavaScript_Models_DateRanges;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 217, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how to specify the predefined custom date ranges (presets range) like last month, last year and current week in the dropdown popup in a ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(261, 57, true);
                WriteLiteral("<span class=\"sampleName\">DateRangePicker / Ranges</span> ");
                EndContext();
            }
            );
#line 5 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DateRangePicker\Ranges.cshtml"
   DateTime Today = DateTime.Now;

#line default
#line hidden
            DefineSection("ControlsSection", async() => {
                BeginContext(382, 65, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n       ");
                EndContext();
                BeginContext(447, 507, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-range-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4411f7e43b234de5878cc0e08460ec58", async() => {
                    BeginContext(497, 12, true);
                    WriteLiteral("\r\n          ");
                    EndContext();
                    BeginContext(509, 413, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-ranges", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f702c1278bf421aa5d769d61b80c9e9", async() => {
                        BeginContext(519, 16, true);
                        WriteLiteral("\r\n              ");
                        EndContext();
                        BeginContext(535, 112, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3985b4782ed4eebac1970a04e335232", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_DateRanges = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateRanges>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateRanges);
                        __Syncfusion_JavaScript_Models_DateRanges.Label = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 11 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DateRangePicker\Ranges.cshtml"
__Syncfusion_JavaScript_Models_DateRanges.Range = new List<Object>() { Today.AddMonths(-1).ToString(), Today.ToString() };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("range", __Syncfusion_JavaScript_Models_DateRanges.Range, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(647, 16, true);
                        WriteLiteral("\r\n              ");
                        EndContext();
                        BeginContext(663, 113, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d273d6e4e9904235a521535638f2b6eb", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_DateRanges = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateRanges>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateRanges);
                        __Syncfusion_JavaScript_Models_DateRanges.Label = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 12 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DateRangePicker\Ranges.cshtml"
__Syncfusion_JavaScript_Models_DateRanges.Range = new List<Object>() { Today.AddMonths(-2).ToString(), Today.ToString() };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("range", __Syncfusion_JavaScript_Models_DateRanges.Range, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(776, 16, true);
                        WriteLiteral("\r\n              ");
                        EndContext();
                        BeginContext(792, 107, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-range", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b602fca1cb9f4456b146cc35471475e3", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_DateRanges = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateRanges>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateRanges);
                        __Syncfusion_JavaScript_Models_DateRanges.Label = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 13 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DateRangePicker\Ranges.cshtml"
__Syncfusion_JavaScript_Models_DateRanges.Range = new List<Object>() { Today.AddDays(-7).ToString(), Today.ToString() };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("range", __Syncfusion_JavaScript_Models_DateRanges.Range, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(899, 12, true);
                        WriteLiteral("\r\n          ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_DateRangepicker = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateRangepicker>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateRangepicker);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(922, 9, true);
                    WriteLiteral("\r\n       ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_DateRangePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateRangePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateRangePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DateRangePickerProperties.Width = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(954, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1009, 248, true);
                WriteLiteral("\r\n    <style>\r\n        .control {\r\n            width: 100%;\r\n        }\r\n\r\n        .frame {\r\n            width: 75%;\r\n        }\r\n\r\n        .control .e-daterangewidget {\r\n            width: 225px;\r\n            margin: auto;\r\n        }\r\n    </style>\r\n");
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
