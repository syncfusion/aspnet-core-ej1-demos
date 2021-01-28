#pragma checksum "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\ColorPicker\DisplayInline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108493212d2abfc49d7df8503ab240f2ce342662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ColorPicker_DisplayInline), @"mvc.1.0.view", @"/Views/ColorPicker/DisplayInline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ColorPicker/DisplayInline.cshtml", typeof(AspNetCore.Views_ColorPicker_DisplayInline))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108493212d2abfc49d7df8503ab240f2ce342662", @"/Views/ColorPicker/DisplayInline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ColorPicker_DisplayInline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inlinePicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#278787", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tag-name", "div", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ColorPickerProperties __Syncfusion_JavaScript_Models_ColorPickerProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 131, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how to show the ColorPicker in the inline mode in ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(177, 60, true);
                WriteLiteral("<span class=\"sampleName\">ColorPicker / DisplayInline </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(265, 84, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div id=\"col-md-3\">Select a Color</div>\r\n        ");
                EndContext();
                BeginContext(349, 158, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-color-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "096c3cc654d146c19071f29da300a648", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ColorPickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ColorPickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ColorPickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ColorPickerProperties.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ColorPickerProperties.TagName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 9 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\ColorPicker\DisplayInline.cshtml"
__Syncfusion_JavaScript_Models_ColorPickerProperties.ModelType = ModelType.Picker;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model-type", __Syncfusion_JavaScript_Models_ColorPickerProperties.ModelType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\ColorPicker\DisplayInline.cshtml"
__Syncfusion_JavaScript_Models_ColorPickerProperties.DisplayInline = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("display-inline", __Syncfusion_JavaScript_Models_ColorPickerProperties.DisplayInline, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ColorPickerProperties.Change = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(507, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(547, 232, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function onChange(args) {\r\n            $(\"#col-md-3\").html(\"Color Value \" + args.value + \" is choosen\");\r\n        }\r\n        $(\"#sampleProperties\").ejPropertiesPanel();\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(804, 125, true);
                WriteLiteral("\r\n    <style>\r\n        #col-md-3 {\r\n            margin-top: 5px;\r\n            margin-bottom: 10px;\r\n        }\r\n    </style>\r\n");
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