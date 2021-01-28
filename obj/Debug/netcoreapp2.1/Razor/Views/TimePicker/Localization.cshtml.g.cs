#pragma checksum "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\TimePicker\Localization.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429addba9f7386d2b042639eaa1f9f60fc6d68ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimePicker_Localization), @"mvc.1.0.view", @"/Views/TimePicker/Localization.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TimePicker/Localization.cshtml", typeof(AspNetCore.Views_TimePicker_Localization))]
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
#line 1 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429addba9f7386d2b042639eaa1f9f60fc6d68ea", @"/Views/TimePicker/Localization.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TimePicker_Localization : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TimePick"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("locale", "zh-CN", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("time-format", "h:mm tt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("drop"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "droplist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onchange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TimePickerProperties __Syncfusion_JavaScript_Models_TimePickerProperties;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 117, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how to localize the timepicker in a ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(172, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 185, "\"", 249, 1);
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\TimePicker\Localization.cshtml"
WriteAttributeValue("", 191, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 191, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(250, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 273, "\"", 337, 1);
#line 7 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\TimePicker\Localization.cshtml"
WriteAttributeValue("", 279, Url.Content("~/Scripts/cultures/ej.culture.de-DE.min.js"), 279, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(338, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 361, "\"", 425, 1);
#line 8 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\TimePicker\Localization.cshtml"
WriteAttributeValue("", 367, Url.Content("~/Scripts/cultures/ej.culture.fr-FR.min.js"), 367, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(426, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 449, "\"", 513, 1);
#line 9 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\TimePicker\Localization.cshtml"
WriteAttributeValue("", 455, Url.Content("~/Scripts/cultures/ej.culture.vi-VN.min.js"), 455, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(514, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 537, "\"", 601, 1);
#line 10 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\TimePicker\Localization.cshtml"
WriteAttributeValue("", 543, Url.Content("~/Scripts/cultures/ej.culture.zh-CN.min.js"), 543, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(602, 18, true);
                WriteLiteral("></script>\r\n    \r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(646, 58, true);
                WriteLiteral("<span class=\"sampleName\">TimePicker / Localization </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(732, 96, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\" style=\"margin-left:30px;\">\r\n            ");
                EndContext();
                BeginContext(828, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c35a944001f042b1900f9701aed80e18", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_TimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_TimePickerProperties.Locale = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_TimePickerProperties.TimeFormat = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(897, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(930, 122, true);
            WriteLiteral("<div id=\"droplist\">\r\n    <ul>\r\n        <li>en-US</li>\r\n        <li>vi-VN</li>\r\n        <li>zh-CN</li>\r\n    </ul>\r\n</div>\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(1079, 143, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Select Culture\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n          ");
                EndContext();
                BeginContext(1222, 139, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54ae3393eb2342419b0ff98c4903aeb6", async() => {
                    BeginContext(1329, 12, true);
                    WriteLiteral("\r\n          ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 34 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\TimePicker\Localization.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex = 2;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-item-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1361, 34, true);
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1421, 325, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function onchange(args) {
            var timeobject = $(""#TimePick"").data(""ejTimePicker"");
            timeobject.option({ ""locale"": args.text }); timeobject.option({ ""timeFormat"": ""h:mm tt"" });
        }
        $(""#sampleProperties"").ejPropertiesPanel();
    </script>
");
                EndContext();
            }
            );
            BeginContext(1749, 2, true);
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
