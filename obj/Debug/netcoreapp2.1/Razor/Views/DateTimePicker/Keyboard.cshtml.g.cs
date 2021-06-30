#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DateTimePicker\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0cec4a910ccdbc4d9eb393dd0ae83951ab3979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DateTimePicker_Keyboard), @"mvc.1.0.view", @"/Views/DateTimePicker/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DateTimePicker/Keyboard.cshtml", typeof(AspNetCore.Views_DateTimePicker_Keyboard))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0cec4a910ccdbc4d9eb393dd0ae83951ab3979", @"/Views/DateTimePicker/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DateTimePicker_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DateTime"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "180px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 162, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how the datetimepicker supports the keyboard navigation(keyboard shortcuts) in a ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(183, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(217, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 230, "\"", 294, 1);
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DateTimePicker\Keyboard.cshtml"
WriteAttributeValue("", 236, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 236, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(295, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(333, 58, true);
                WriteLiteral("<span class=\"sampleName\">DateTimePicker / Keyboard </span>");
                EndContext();
            }
            );
            BeginContext(394, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(421, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(491, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "369f00a3c1e24b00ba909750ec1d9dd4", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DateTimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateTimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateTimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DateTimePicker\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_DateTimePickerProperties.Value = DateTime.Now;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_DateTimePickerProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DateTimePickerProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(584, 32, true);
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(646, 1567, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + j 
        </div>
        <div class=""col-md-3"">
            Focuses the control
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + Down
        </div>
        <div class=""col-md-3"">
            Opens/Hides the popup
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            After popup opened:
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + Left
        </div>
        <div class=""col-md-3"">
            Focus through out the popup container in forward direction
        </div>
        <div class=""col-md-3""></div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + Right
        </div>
        <div class=""col-md-3"">
            Focus through out the popup container in backward direction
        </div>
        <div class=""col-");
                WriteLiteral(@"md-3""></div>
    </div>
    <br />
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Enter
        </div>
        <div class=""col-md-3"">
            select the focused control/selects the focused element
        </div>
        <div class=""col-md-3""></div>
    </div>
    <br />
    <div class=""row"">
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Esc
        </div>
        <div class=""col-md-3"">
            Closes the popup
        </div>
    </div>
    <br />
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2239, 353, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $(""#DateTime"").focus();
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2617, 164, true);
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
