#pragma checksum "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\ColorPicker\CustomPalette.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a796c9b94155a541e1b82f6555dcfb0054aa5c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ColorPicker_CustomPalette), @"mvc.1.0.view", @"/Views/ColorPicker/CustomPalette.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ColorPicker/CustomPalette.cshtml", typeof(AspNetCore.Views_ColorPicker_CustomPalette))]
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
#line 1 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a796c9b94155a541e1b82f6555dcfb0054aa5c9e", @"/Views/ColorPicker/CustomPalette.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ColorPicker_CustomPalette : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#9999ff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(18, 132, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how to specify the custom palatte in a ASP.NET Core ColorPicker\">\r\n");
                EndContext();
            }
            );
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(178, 67, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ColorPicker / Custom Palette </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(273, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\ColorPicker\CustomPalette.cshtml"
      List<String> colors = new List<string>() { "ffffff", "ffccff", "ff99ff", "ff66ff", "ff33ff", "ff00ff", "ccffff", "ccccff",
                         "cc99ff", "cc66ff", "cc33ff", "cc00ff", "99ffff", "99ccff", "9999ff", "9966ff",
                         "9933ff", "9900ff", "ffffcc", "ffcccc" };

#line default
#line hidden
                BeginContext(580, 139, true);
                WriteLiteral("    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            <div class=\"element\">\r\n                Choose a Color\r\n                ");
                EndContext();
                BeginContext(719, 149, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-color-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "190dce466a644d88a8329a188e3cbfe9", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ColorPickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ColorPickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ColorPickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ColorPickerProperties.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 15 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\ColorPicker\CustomPalette.cshtml"
__Syncfusion_JavaScript_Models_ColorPickerProperties.Palette = PaletteType.CustomPalette;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("palette", __Syncfusion_JavaScript_Models_ColorPickerProperties.Palette, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\ColorPicker\CustomPalette.cshtml"
__Syncfusion_JavaScript_Models_ColorPickerProperties.ModelType = ModelType.Palette;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model-type", __Syncfusion_JavaScript_Models_ColorPickerProperties.ModelType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\ColorPicker\CustomPalette.cshtml"
__Syncfusion_JavaScript_Models_ColorPickerProperties.Custom = colors;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("custom", __Syncfusion_JavaScript_Models_ColorPickerProperties.Custom, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(868, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(943, 99, true);
                WriteLiteral("\r\n    <style>\r\n        .frame .control {\r\n            margin-left: 70px;\r\n        }\r\n    </style>\r\n");
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
