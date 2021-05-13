#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DatePicker\DisplayInline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8853a38c6e9d9117a5b9a3a5306d143efeb00df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatePicker_DisplayInline), @"mvc.1.0.view", @"/Views/DatePicker/DisplayInline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DatePicker/DisplayInline.cshtml", typeof(AspNetCore.Views_DatePicker_DisplayInline))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8853a38c6e9d9117a5b9a3a5306d143efeb00df7", @"/Views/DatePicker/DisplayInline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DatePicker_DisplayInline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DatePick"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tag-name", "div", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("select", "onSelected", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 127, true);
                WriteLiteral("\r\n<meta name=\"description\" content=\"This example demonstrates how to show the DatePicker in the inline mode in ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(182, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 195, "\"", 259, 1);
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DatePicker\DisplayInline.cshtml"
WriteAttributeValue("", 201, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 201, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(260, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(298, 59, true);
                WriteLiteral("<span class=\"sampleName\">DatePicker / DisplayInline </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(385, 35, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        ");
                EndContext();
                BeginContext(420, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-date-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d7b8e092818472f81779f3e06dace4a", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DatePickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DatePickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DatePickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_DatePickerProperties.TagName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 11 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DatePicker\DisplayInline.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.DisplayInline = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("display-inline", __Syncfusion_JavaScript_Models_DatePickerProperties.DisplayInline, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DatePicker\DisplayInline.cshtml"
__Syncfusion_JavaScript_Models_DatePickerProperties.ShowFooter = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-footer", __Syncfusion_JavaScript_Models_DatePickerProperties.ShowFooter, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(545, 63, true);
                WriteLiteral(" \r\n        <div id=\"col-md-3\">Select a date</div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(634, 222, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function onSelected(args) {\r\n            $(\"#col-md-3\").html(\"Selected date : \" + args.value);\r\n        }\r\n        $(\"#sampleProperties\").ejPropertiesPanel();\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(881, 244, true);
                WriteLiteral("\r\n    <style>\r\n        .darktheme .frame, .frame {\r\n            padding: 21px 0px 10px 46px;\r\n            width: 280px;\r\n        }\r\n\r\n        #col-md-3 {\r\n            margin-top: 5px;\r\n            margin-left: 25px;\r\n        }\r\n    </style>\r\n\r\n");
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
