#pragma checksum "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fdd2d23360f8c1cd605dac77a31a8da3d7b9e4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimePicker_TimePickerFor), @"mvc.1.0.view", @"/Views/TimePicker/TimePickerFor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TimePicker/TimePickerFor.cshtml", typeof(AspNetCore.Views_TimePicker_TimePickerFor))]
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
#line 1 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdd2d23360f8c1cd605dac77a31a8da3d7b9e4e", @"/Views/TimePicker/TimePickerFor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TimePicker_TimePickerFor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<samplebrowser.Controllers.TimePickerController.timemodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TimePick"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 180, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"TimePicker for ASP.NET Core with the strongly typed extension support. Value is set from the code behind by invoking TimePickerFor helper\">\r\n");
                EndContext();
            }
            );
            BeginContext(201, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(235, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 248, "\"", 312, 1);
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
WriteAttributeValue("", 254, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 254, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(313, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            BeginContext(393, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(418, 73, true);
                WriteLiteral("\r\n    \r\n    <span class=\"sampleName\">TimePicker / TimePickerFor </span>\r\n");
                EndContext();
            }
            );
            BeginContext(494, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(521, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
                BeginContext(558, 28, false);
#line 18 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
                BeginContext(588, 68, true);
                WriteLiteral("    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(656, 256, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a39f90b84db94bffac077506e61a2047", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_TimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 21 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_TimePickerProperties.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Value);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("ej-for", __Syncfusion_JavaScript_Models_TimePickerProperties.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_TimePickerProperties.ValidationRules = new Dictionary<string, object>() { { "required",true} };

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("validation-rules", __Syncfusion_JavaScript_Models_TimePickerProperties.ValidationRules, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 23 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_TimePickerProperties.ValidationMessages = new Dictionary<string, object>() { { "required","Time value is required"} };

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("validation-messages", __Syncfusion_JavaScript_Models_TimePickerProperties.ValidationMessages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(912, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(927, 47, false);
#line 24 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
       Write(Html.ValidationMessageFor(model => model.Value));

#line default
#line hidden
                EndContext();
                BeginContext(974, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(988, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e387593d14a4468fa4c6aee1e31c0e68", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 25 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Type = global::Syncfusion.JavaScript.ButtonType.Submit;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_Models_ButtonProperties.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1039, 31, true);
                WriteLiteral("\r\n         </div>\r\n    </div>\r\n");
                EndContext();
#line 28 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\TimePicker\TimePickerFor.cshtml"
}

#line default
#line hidden
                BeginContext(1073, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1102, 122, true);
                WriteLiteral("\r\n    <style>\r\n        #button {\r\n            margin-left: 30px;\r\n            margin-top: 20px;\r\n        }\r\n    </style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<samplebrowser.Controllers.TimePickerController.timemodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
