#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ColorPicker\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df3af42ce262817301eba4c2ee99786f1e202268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ColorPicker_Keyboard), @"mvc.1.0.view", @"/Views/ColorPicker/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ColorPicker/Keyboard.cshtml", typeof(AspNetCore.Views_ColorPicker_Keyboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df3af42ce262817301eba4c2ee99786f1e202268", @"/Views/ColorPicker/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ColorPicker_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("colorPicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#278787", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tool-icon", "e-icon e-font", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(18, 160, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates how the colorpicker supports the keyboard navigation (keyboard shortcuts) in a ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(206, 55, true);
                WriteLiteral("<span class=\"sampleName\">ColorPicker / Keyboard</span> ");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(289, 109, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            <div class=\"element\">\r\n                ");
                EndContext();
                BeginContext(398, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-color-picker", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55421ae0514c407f835e22c728da4a0a", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ColorPickerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ColorPickerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ColorPickerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ColorPickerProperties.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ColorPickerProperties.ToolIcon = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(492, 67, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <b></b>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(589, 3065, true);
                WriteLiteral(@"
    
        <center>KeyBoard Support</center>
   
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Alt+J
        </div>
        <div class=""col-md-3"">
            Focus the Control
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Enter
        </div>
        <div class=""col-md-3"">
            Open or Close the Popup / Choose the current color
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Esc
        </div>
        <div class=""col-md-3"">
            Close the popup
        </div>
    </div>
    <div class=""row"">
       
            <center>Color Picker</center>
        
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Tab
        </div>
        <div class=""col-md-3"">
            Choose the next element
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
           ");
                WriteLiteral(@" Down
        </div>
        <div class=""col-md-3"">
            Decrease the brightness
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Up
        </div>
        <div class=""col-md-3"">
            Increase the brightness
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Left
        </div>
        <div class=""col-md-3"">
            Decrease the staturation
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Right
        </div>
        <div class=""col-md-3"">
            Increase the staturation
        </div>
    </div>
    <br />
    <div class=""row"">
       
            <center>Color Palette</center>
        
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Down
        </div>
        <div class=""col-md-3"">
            Move to downwards cell
        </div>
    </div>
    <br />
  ");
                WriteLiteral(@"  <div class=""row"">
        <div class=""col-md-3"">
            Up
        </div>
        <div class=""col-md-3"">
            Move to upwards cell
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Left
        </div>
        <div class=""col-md-3"">
            Move to previous cell
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Right
        </div>
        <div class=""col-md-3"">
            Move to next cell
        </div>
    </div>
    <div class=""row"">
      
            <center>Slider Only</center>
      
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
            Home
        </div>
        <div class=""col-md-3"">
            Downwards to value 0
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            End
        </div>
        <div class=""col-md-3"">
            Upwards to value  100
        </div>
    </div>

");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(3680, 331, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(function () {
        $(""#sampleProperties"").ejPropertiesPanel();
        $(document).on(""keydown"", function (e) {
            if (e.altKey && e.keyCode === 74) { // j- key code.
                $(""#colorPickerWrapper"").focus();
            }
        });
    });
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(4036, 230, true);
                WriteLiteral("\r\n    <style>\r\n        .e-colorwidget .e-tool .e-fontcolor-icon:before {\r\n            content: \"\\e632\";\r\n            font-size: 15px;\r\n        }\r\n        .frame .control {\r\n            margin-left: 70px;\r\n        }\r\n    </style>\r\n");
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
