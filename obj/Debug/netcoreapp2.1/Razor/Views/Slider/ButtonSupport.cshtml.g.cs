#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98b2987b322bb159312839fa07182b209f1ba745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slider_ButtonSupport), @"mvc.1.0.view", @"/Views/Slider/ButtonSupport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Slider/ButtonSupport.cshtml", typeof(AspNetCore.Views_Slider_ButtonSupport))]
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
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98b2987b322bb159312839fa07182b209f1ba745", @"/Views/Slider/ButtonSupport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Slider_ButtonSupport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rangeSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("values", "30,60", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("minSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "40", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 55, true);
                WriteLiteral(" <span class=\"sampleName\">Slider / ButtonSupport</span>");
                EndContext();
            }
            );
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(108, 80, true);
                WriteLiteral("\r\n\r\n    <div class=\"frame\">\r\n        <div class=\"rangetxt\">Range</div>\r\n        ");
                EndContext();
                BeginContext(188, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20a2c17694844af894cb2f587dccf523", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 7 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SliderType = SlideType.Range;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("slider-type", __Syncfusion_JavaScript_Models_SliderProperties.SliderType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Values = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 7 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.ShowButtons = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-buttons", __Syncfusion_JavaScript_Models_SliderProperties.ShowButtons, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(283, 92, true);
                WriteLiteral("\r\n        <br />\r\n        <br />\r\n        <div class=\"minrangetxt\">Min-Range</div>\r\n        ");
                EndContext();
                BeginContext(375, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "855f42a739fb402d8e94b000dadc2447", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SliderType = SlideType.MinRange;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("slider-type", __Syncfusion_JavaScript_Models_SliderProperties.SliderType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.ShowButtons = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-buttons", __Syncfusion_JavaScript_Models_SliderProperties.ShowButtons, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.ShowScale = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-scale", __Syncfusion_JavaScript_Models_SliderProperties.ShowScale, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.LargeStep = 20;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("large-step", __Syncfusion_JavaScript_Models_SliderProperties.LargeStep, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SmallStep = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("small-step", __Syncfusion_JavaScript_Models_SliderProperties.SmallStep, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\ButtonSupport.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.IncrementStep = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("increment-step", __Syncfusion_JavaScript_Models_SliderProperties.IncrementStep, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(536, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(575, 316, true);
                WriteLiteral(@"
    <style type=""text/css"" class=""cssStyles"">
        .frame {
            width: 50%;
        }

        .minrangetxt {
            font-size: 15px;
            margin-bottom: 24px;
        }

        .rangetxt {
            font-size: 15px;
            margin-bottom: 20px;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
