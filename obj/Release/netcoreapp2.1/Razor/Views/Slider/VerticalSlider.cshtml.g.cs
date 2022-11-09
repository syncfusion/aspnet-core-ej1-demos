#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7b2d691a6fc99923ea6555d18ec8561e2b87e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slider_VerticalSlider), @"mvc.1.0.view", @"/Views/Slider/VerticalSlider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Slider/VerticalSlider.cshtml", typeof(AspNetCore.Views_Slider_VerticalSlider))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7b2d691a6fc99923ea6555d18ec8561e2b87e7", @"/Views/Slider/VerticalSlider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Slider_VerticalSlider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("normalSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "30", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "200", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("minSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "70", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rangeSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("values", "30,70", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 56, true);
                WriteLiteral(" <span class=\"sampleName\">Slider / VerticalSlider</span>");
                EndContext();
            }
            );
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(109, 72, true);
                WriteLiteral("\r\n\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(181, 124, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad4c4e43d714472989538ef90ac2509d", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 7 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.Orientation = Orientation.Vertical;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("orientation", __Syncfusion_JavaScript_Models_SliderProperties.Orientation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SliderType = SlideType.Default;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("slider-type", __Syncfusion_JavaScript_Models_SliderProperties.SliderType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_SliderProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(305, 95, true);
                WriteLiteral("\r\n            <span>Default</span>\r\n        </div>\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(400, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "257e17ddc4de41e1a56e51ba6861a47b", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.Orientation = Orientation.Vertical;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("orientation", __Syncfusion_JavaScript_Models_SliderProperties.Orientation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SliderType = SlideType.MinRange;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("slider-type", __Syncfusion_JavaScript_Models_SliderProperties.SliderType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_SliderProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(522, 97, true);
                WriteLiteral("\r\n            <span>Min-Range</span>\r\n        </div>\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(619, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f57db385ba03448a986d8be770e679c3", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 15 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.Orientation = Orientation.Vertical;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("orientation", __Syncfusion_JavaScript_Models_SliderProperties.Orientation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.SliderType = SlideType.Range;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("slider-type", __Syncfusion_JavaScript_Models_SliderProperties.SliderType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Values = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 15 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.EnableRTL = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-rtl", __Syncfusion_JavaScript_Models_SliderProperties.EnableRTL, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(762, 62, true);
                WriteLiteral("\r\n            <span>Range</span>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(849, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 860, "\"", 915, 1);
#line 21 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Slider\VerticalSlider.cshtml"
WriteAttributeValue("", 867, Url.Content("~/css/samples/verticalslider.css"), 867, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(916, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
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
