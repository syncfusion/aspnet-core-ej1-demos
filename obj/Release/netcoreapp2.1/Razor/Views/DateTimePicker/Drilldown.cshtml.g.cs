#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DateTimePicker\Drilldown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c048c4355839cf350f93e2abbc85bbc4912c998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DateTimePicker_Drilldown), @"mvc.1.0.view", @"/Views/DateTimePicker/Drilldown.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DateTimePicker/Drilldown.cshtml", typeof(AspNetCore.Views_DateTimePicker_Drilldown))]
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
#line 5 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c048c4355839cf350f93e2abbc85bbc4912c998", @"/Views/DateTimePicker/Drilldown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DateTimePicker_Drilldown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DateTime"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DateTimePickerProperties __Syncfusion_JavaScript_Models_DateTimePickerProperties;
        private global::Syncfusion.JavaScript.Models.TimeDrillDown __Syncfusion_JavaScript_Models_TimeDrillDown;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 184, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates the drill down navigaiton in DateTimPicker and its properties like interval, meridian and enable in a ASP.NET Core \">\r\n");
                EndContext();
            }
            );
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(239, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 252, "\"", 316, 1);
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DateTimePicker\Drilldown.cshtml"
WriteAttributeValue("", 258, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 258, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(317, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(355, 59, true);
                WriteLiteral("<span class=\"sampleName\">DateTimePicker / Drilldown</span> ");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(442, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(512, 182, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac3919a7ed545b8be00f8807261a077", async() => {
                    BeginContext(569, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(587, 71, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-time-drill-down", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30fb6237be124dff9b5f89ca7c33ffda", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_TimeDrillDown = CreateTagHelper<global::Syncfusion.JavaScript.Models.TimeDrillDown>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TimeDrillDown);
#line 13 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DateTimePicker\Drilldown.cshtml"
__Syncfusion_JavaScript_Models_TimeDrillDown.Enabled = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enabled", __Syncfusion_JavaScript_Models_TimeDrillDown.Enabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DateTimePicker\Drilldown.cshtml"
__Syncfusion_JavaScript_Models_TimeDrillDown.Interval = 5;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("interval", __Syncfusion_JavaScript_Models_TimeDrillDown.Interval, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DateTimePicker\Drilldown.cshtml"
__Syncfusion_JavaScript_Models_TimeDrillDown.ShowMeridian = false;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-meridian", __Syncfusion_JavaScript_Models_TimeDrillDown.ShowMeridian, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(658, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_DateTimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateTimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateTimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 12 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\DateTimePicker\Drilldown.cshtml"
__Syncfusion_JavaScript_Models_DateTimePickerProperties.Value = DateTime.Now;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DateTimePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(694, 32, true);
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(751, 164, true);
                WriteLiteral("\r\n    <style>\r\n        .control {\r\n            width: 210px;\r\n        }\r\n\r\n        .control .e-datetime-wrap {\r\n            width: 175px;\r\n        }\r\n    </style>\r\n");
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
