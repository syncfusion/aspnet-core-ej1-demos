#pragma checksum "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32819e32ba68f38ccb9396dfea50745760bb443e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RadialSlider_API), @"mvc.1.0.view", @"/Views/RadialSlider/API.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RadialSlider/API.cshtml", typeof(AspNetCore.Views_RadialSlider_API))]
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
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32819e32ba68f38ccb9396dfea50745760bb443e", @"/Views/RadialSlider/API.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_RadialSlider_API : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("apiradialSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("startAngleSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "16", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "225", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onStartchange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("endAngleSlider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "360", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onEndchange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("numeric"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "numeric", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "108", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "valueChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("radialshow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "107", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "radialshowChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("default-text", "Hide", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("active-text", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RadialSliderProperties __Syncfusion_JavaScript_Models_RadialSliderProperties;
        private global::Syncfusion.JavaScript.Models.SliderProperties __Syncfusion_JavaScript_Models_SliderProperties;
        private global::Syncfusion.JavaScript.Models.EditorProperties __Syncfusion_JavaScript_Models_EditorProperties;
        private global::Syncfusion.JavaScript.Models.ToggleButtonProperties __Syncfusion_JavaScript_Models_ToggleButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 71, true);
                WriteLiteral(" <span class=\"sampleName\">RadialSlider / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(115, 194, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to change the stroke width, color, start angle, and ending angle of the Syncfusion ASP.NET Core Radial Slider component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(337, 6, true);
                WriteLiteral("    \r\n");
                EndContext();
                BeginContext(343, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-radial-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c165b1f0c92485a9517f6823ca2b932", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_RadialSliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RadialSliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RadialSliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
                                                   WriteLiteral(Url.Content("~/images/radialslider/chevron-right.png"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Syncfusion_JavaScript_Models_RadialSliderProperties.InnerCircleImageUrl = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("inner-circle-image-url", __Syncfusion_JavaScript_Models_RadialSliderProperties.InnerCircleImageUrl, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(465, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(501, 343, true);
                WriteLiteral(@"
    <div class=""prop-grid"">
        <div class=""row-fluid"">
            <div class=""row"">
                <div class=""col-md-12"" style=""text-align: left"">
                    Start Angle (0-360)
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3"">  
                ");
                EndContext();
                BeginContext(844, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb5098df1b974ea5be711b2b10f82cbb", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_SliderProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_SliderProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_SliderProperties.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 19 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.MinValue = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-value", __Syncfusion_JavaScript_Models_SliderProperties.MinValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.MaxValue = 360;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("max-value", __Syncfusion_JavaScript_Models_SliderProperties.MaxValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.IncrementStep = 10;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("increment-step", __Syncfusion_JavaScript_Models_SliderProperties.IncrementStep, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Change = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(987, 368, true);
                WriteLiteral(@"                      
            </div>
        </div>
        <div class=""row-fluid"">
            <div class=""row"">
                <div class=""col-md-12"" style=""text-align: left"">
                    End Angle (360-0)
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3"">
                ");
                EndContext();
                BeginContext(1355, 140, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-slider", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "266e5bdca45a45ee83cf2093d18f1bd5", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_SliderProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SliderProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SliderProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_SliderProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_SliderProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_SliderProperties.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 31 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.MinValue = 360;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-value", __Syncfusion_JavaScript_Models_SliderProperties.MinValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.MaxValue = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("max-value", __Syncfusion_JavaScript_Models_SliderProperties.MaxValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_SliderProperties.IncrementStep = 10;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("increment-step", __Syncfusion_JavaScript_Models_SliderProperties.IncrementStep, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_SliderProperties.Change = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1495, 219, true);
                WriteLiteral("                \r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                Stroke width\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                ");
                EndContext();
                BeginContext(1714, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-numeric-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bf93a56afac4c8db2119ce0067fd15b", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_EditorProperties.Name = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#line 39 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.MinValue = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-value", __Syncfusion_JavaScript_Models_EditorProperties.MinValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.MaxValue = 10;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("max-value", __Syncfusion_JavaScript_Models_EditorProperties.MaxValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\RadialSlider\API.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 2;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1837, 211, true);
                WriteLiteral("                \r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                Show\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                ");
                EndContext();
                BeginContext(2048, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7f4fef9161b40ebb4f464293c4bdff4", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ToggleButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToggleButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToggleButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Width = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Change = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.DefaultText = (string)__tagHelperAttribute_16.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.ActiveText = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2161, 66, true);
                WriteLiteral("                \r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(2230, 1356, true);
            WriteLiteral(@"<script>
    $(function () {
        $(""#sampleProperties"").ejPropertiesPanel();
    });
    function onStartchange(args) {
        var instance = $(""#apiradialSlider"").data(""ejRadialSlider"");
        var value1 = instance.model.endAngle;
        if (args.value > value1)
            alert(""Value must be less than end angle"");
        else
            $(""#apiradialSlider"").ejRadialSlider({ startAngle: args.value })
    }
    function onEndchange(args) {
        var instance = $(""#apiradialSlider"").data(""ejRadialSlider"");
        var value2 = instance.model.startAngle;
        if (args.value < value2)
            alert(""Value must be greater than start angle"");
        else
            $(""#apiradialSlider"").ejRadialSlider({ endAngle: args.value })
    }
    function onShowHideReset(args) {
        var roundUpp = args.isChecked ? false : true;
        $(""#apiradialSlider"").ejRadialSlider({ enableRoundOff: roundUpp })
    }
    function valueChange(args) {
    if(!ej.isNullOrUndefined(arg");
            WriteLiteral(@"s.value))
        $(""#apiradialSlider"").ejRadialSlider({ strokeWidth: args.value })
    }
    function radialshowChange(args) {
        $(""#apiradialSlider"").ejRadialSlider(args.isChecked ? ""hide"" : ""show"");

    }
</script>
<style>
   .cols-sample-area {
			overflow-x:auto;
			overflow-y: hidden;
        }  
</style>");
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
