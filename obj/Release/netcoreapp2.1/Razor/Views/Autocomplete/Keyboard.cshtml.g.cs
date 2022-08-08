#pragma checksum "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Autocomplete\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46ff9686a98f43f1eff441f680f06338ae2413b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autocomplete_Keyboard), @"mvc.1.0.view", @"/Views/Autocomplete/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autocomplete/Keyboard.cshtml", typeof(AspNetCore.Views_Autocomplete_Keyboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ff9686a98f43f1eff441f680f06338ae2413b1", @"/Views/Autocomplete/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Autocomplete_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("keyboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("watermark-text", "Choose skills", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.AutocompleteProperties __Syncfusion_JavaScript_Models_AutocompleteProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 73, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Autocomplete / Keyboard Interaction</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(117, 177, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to access the Syncfusion ASP.NET Core Autocomplete control functionalities using keyboard interactions.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(322, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(392, 177, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-autocomplete", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "255147ffa1a54e86bdf2739407de2690", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_AutocompleteProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AutocompleteProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AutocompleteProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 9 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Autocomplete\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.WatermarkText = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 9 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Autocomplete\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.MultiSelectMode = MultiSelectModeTypes.Delimiter;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("multi-select-mode", __Syncfusion_JavaScript_Models_AutocompleteProperties.MultiSelectMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(569, 32, true);
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(631, 917, true);
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
            Up
        </div>
        <div class=""col-md-3"">
            Moves to previous item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down
        </div>
        <div class=""col-md-3"">
            Moves to next item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Enter
        </div>
        <div class=""col-md-3"">
            Selects the focused item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Esc
        </div>
        <div class=""col-md-3"">
            Closes the popup
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1574, 370, true);
                WriteLiteral(@"
    <script type=""text/javascript"" class=""jsScript"">
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $(""#keyboard"").focus();
                }
            });
        });
    </script>
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
