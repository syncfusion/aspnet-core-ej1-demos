#pragma checksum "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\DateTimePicker\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df5bb895e3be7b96d6612abccd83a12d2fae635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DateTimePicker_Events), @"mvc.1.0.view", @"/Views/DateTimePicker/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DateTimePicker/Events.cshtml", typeof(AspNetCore.Views_DateTimePicker_Events))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df5bb895e3be7b96d6612abccd83a12d2fae635", @"/Views/DateTimePicker/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DateTimePicker_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("datetime"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "oncreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "timeValChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("open", "onOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("close", "onClose", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectControls_input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "target", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("css-class", "metroblue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "evtpropscheckedevent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 156, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates the various events like create, change, open and close in a ASP.NET Core DateTimePicker\">\r\n");
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
#line 6 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\DateTimePicker\Events.cshtml"
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
                BeginContext(327, 56, true);
                WriteLiteral("<span class=\"sampleName\">DateTimePicker / Events </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(411, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(481, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d0a141b11040b9be1ef4e565a51830", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DateTimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateTimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateTimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 12 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\DateTimePicker\Events.cshtml"
__Syncfusion_JavaScript_Models_DateTimePickerProperties.Value = DateTime.Now;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DateTimePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DateTimePickerProperties.Create = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_DateTimePickerProperties.Change = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_DateTimePickerProperties.Open = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DateTimePickerProperties.Close = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(631, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(664, 120, true);
            WriteLiteral("<div id=\"target\">\r\n    <ul>\r\n        <li>open</li>\r\n        <li>close</li>\r\n        <li>change</li>\r\n    </ul>\r\n</div>\r\n");
            EndContext();
            DefineSection("EventsDropdown", async() => {
                BeginContext(808, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(810, 174, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c384f714d7fd4daeb35222831ffb5525", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_DropDownListProperties.CssClass = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 24 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\DateTimePicker\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-checkbox", __Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\DateTimePicker\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("check-all", __Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(984, 5, true);
                WriteLiteral("   \r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1015, 1377, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function evtpropscheckedevent(args) {
            var dateTimeObj = $(""#dateTime"").data(""ejDateTimePicker"");
            if (args.isChecked) {
                switch (args.selectedText) {
                    case ""change"": dateTimeObj.option(args.selectedText, ""timeValChange""); break;
                    case ""open"": dateTimeObj.option(args.selectedText, ""onOpen""); break;
                    case ""close"": dateTimeObj.option(args.selectedText, ""onClose""); break;
                }
            }
            else dateTimeObj.option(args.selectedText, null);
        }
        // Client side Events
        function oncreate(args) {
            jQuery.addEventLog(""Date TimePicker has been <span class='eventTitle'> created</span>."");
        }
        function timeValChange(args) {
            jQuery.addEventLog(""Date TimePicker value has been <span class='eventTitle'> changed</span> to "" + args.value + "".</br>"");
        }
        function onOpen(args)");
                WriteLiteral(@" {
            jQuery.addEventLog(""Date TimePicker is in <span class='eventTitle'> Opened</span>"");
        }
        function onClose(args) {
            jQuery.addEventLog(""Date TimePicker is out of <span class='eventTitle'> Closed</span>"");
        }
        function onClear() {
            jQuery.clearEventLog();
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2417, 164, true);
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
