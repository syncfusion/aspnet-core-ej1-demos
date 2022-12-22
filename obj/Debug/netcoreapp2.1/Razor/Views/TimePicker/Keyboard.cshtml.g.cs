#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bec048e36d6d05f821740b7216076a69fa19a98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimePicker_Keyboard), @"mvc.1.0.view", @"/Views/TimePicker/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TimePicker/Keyboard.cshtml", typeof(AspNetCore.Views_TimePicker_Keyboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bec048e36d6d05f821740b7216076a69fa19a98", @"/Views/TimePicker/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TimePicker_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TimePick"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 159, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how the timepicker supports the keyboard navigation (Keyboard shortcuts) in a ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(180, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(216, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 229, "\"", 293, 1);
#line 7 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\Keyboard.cshtml"
WriteAttributeValue("", 235, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 235, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(294, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(309, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(334, 54, true);
                WriteLiteral("<span class=\"sampleName\">TimePicker / Keyboard </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(416, 96, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\" style=\"margin-left:30px;\">\r\n            ");
                EndContext();
                BeginContext(512, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9520b46471b4ea581cffc91f10a6ed8", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_TimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(544, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(577, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(606, 1802, true);
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
            Right / Left
        </div>
        <div class=""col-md-3"">
            Moves to the adjacent part
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Up
        </div>
        <div class=""col-md-3"">
            Increments the value
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down
        </div>
        <div class=""col-md-3"">
            Decrements the value
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            After popup opened");
                WriteLiteral(@":
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Up
        </div>
        <div class=""col-md-3"">
            Selects the previous time
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down
        </div>
        <div class=""col-md-3"">
            Selects the next time
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Home / End
        </div>
        <div class=""col-md-3"">
            Moves to the first / last item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Esc
        </div>
        <div class=""col-md-3"">
            Closes the popup
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2434, 353, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $(""#TimePick"").focus();
                }
            });
        });
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
