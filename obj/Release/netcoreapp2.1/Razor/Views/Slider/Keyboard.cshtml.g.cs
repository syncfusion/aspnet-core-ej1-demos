#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Slider\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e537b5b2926aede50caa604375c77a64ad4a5cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slider_Keyboard), @"mvc.1.0.view", @"/Views/Slider/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Slider/Keyboard.cshtml", typeof(AspNetCore.Views_Slider_Keyboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e537b5b2926aede50caa604375c77a64ad4a5cc", @"/Views/Slider/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Slider_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("minSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rangeSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("values", "40,80", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.SliderProperties __Syncfusion_JavaScript_Models_SliderProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 50, true);
                WriteLiteral(" <span class=\"sampleName\">Slider / Keyboard</span>");
                EndContext();
            }
            );
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(103, 41, true);
                WriteLiteral("\r\n    \r\n    <div class=\"frame\">\r\n        ");
                EndContext();
                BeginContext(144, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "684dc70d2c444b78afe03e49367dbb3b", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Slider\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SliderType = SlideType.MinRange;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("slider-type", __Syncfusion_JavaScript_Models_SliderProperties.SliderType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(217, 42, true);
                WriteLiteral("\r\n        <br />\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(259, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8b30d43ad5447008a7fa684bd74d9a8", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 9 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Slider\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SliderType = SlideType.Range;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("slider-type", __Syncfusion_JavaScript_Models_SliderProperties.SliderType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Values = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(335, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(379, 1142, true);
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
            Up / Right
        </div>
        <div class=""col-md-3"">
            Increments the slider value
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down / Left
        </div>
        <div class=""col-md-3"">
            Decrements the slider value
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Home
        </div>
        <div class=""col-md-3"">
            Moves to the start value
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            End
        </div>
        <div class=""col-md-3"">
            Moves to the end value
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Esc");
                WriteLiteral("\n        </div>\r\n        <div class=\"col-md-3\">\r\n            Focuses out from the handle\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1547, 334, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });
        $(document).on(""keydown"", function (e) {
            if (e.altKey && e.keyCode === 74) { // j- key code.
                $(""#minSlider a"")[0].focus();
            }
        });

    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1906, 101, true);
                WriteLiteral("\r\n    <style>\r\n        .cols-sample-area .frame {\r\n            width: 50%;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(2010, 4, true);
            WriteLiteral("\r\n\r\n");
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
