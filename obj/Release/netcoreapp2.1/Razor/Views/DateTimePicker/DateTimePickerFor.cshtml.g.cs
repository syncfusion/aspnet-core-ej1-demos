#pragma checksum "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63afbd4e5238b46091d25154615e454177cd72f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DateTimePicker_DateTimePickerFor), @"mvc.1.0.view", @"/Views/DateTimePicker/DateTimePickerFor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DateTimePicker/DateTimePickerFor.cshtml", typeof(AspNetCore.Views_DateTimePicker_DateTimePickerFor))]
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
#line 1 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63afbd4e5238b46091d25154615e454177cd72f7", @"/Views/DateTimePicker/DateTimePickerFor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DateTimePicker_DateTimePickerFor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<samplebrowser.Controllers.DateTimePickerController.datetimemodel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("datetimepick"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DateTimePickerProperties __Syncfusion_JavaScript_Models_DateTimePickerProperties;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 188, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"DateTimePicker for ASP.NET Core with the strongly typed extension support. Value is set from the code behind by invoking DateTimePickerFor helper\">\r\n");
                EndContext();
            }
            );
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(243, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 256, "\"", 320, 1);
#line 6 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
WriteAttributeValue("", 262, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 262, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(321, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(359, 67, true);
                WriteLiteral("<span class=\"sampleName\">DateTimePicker / DateTimePickerFor</span> ");
                EndContext();
            }
            );
            BeginContext(429, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(504, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(531, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
                BeginContext(568, 28, false);
#line 15 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
                BeginContext(598, 68, true);
                WriteLiteral("    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(666, 270, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-time-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e64c6b2f20434aab8a42b72a8f5f3ec9", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DateTimePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DateTimePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DateTimePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 18 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_DateTimePickerProperties.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Value);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("ej-for", __Syncfusion_JavaScript_Models_DateTimePickerProperties.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_DateTimePickerProperties.ValidationRules = new Dictionary<string, object>() { { "required",true} };

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("validation-rules", __Syncfusion_JavaScript_Models_DateTimePickerProperties.ValidationRules, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 20 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_DateTimePickerProperties.ValidationMessages = new Dictionary<string, object>() { { "required","Datetime value is required"} };

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("validation-messages", __Syncfusion_JavaScript_Models_DateTimePickerProperties.ValidationMessages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(936, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(951, 47, false);
#line 21 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
       Write(Html.ValidationMessageFor(model => model.Value));

#line default
#line hidden
                EndContext();
                BeginContext(998, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1012, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85e776b0875f4643b8779c32995181f2", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 22 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Type = global::Syncfusion.JavaScript.ButtonType.Submit;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_Models_ButtonProperties.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1063, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 25 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\DateTimePicker\DateTimePickerFor.cshtml"
}

#line default
#line hidden
                BeginContext(1096, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1125, 259, true);
                WriteLiteral(@"
    <style>
        .control {
            width: 210px;
        }

        .control .e-datetime-wrap {
            width: 175px;
        }
          #button {
            margin-left: 30px;
            margin-top: 20px;
        }
    </style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<samplebrowser.Controllers.DateTimePickerController.datetimemodel> Html { get; private set; }
    }
}
#pragma warning restore 1591
