#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Autocomplete\MultipleValues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5684d18432ba86284fbf0ed3bc7f60689bbfd20e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autocomplete_MultipleValues), @"mvc.1.0.view", @"/Views/Autocomplete/MultipleValues.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autocomplete/MultipleValues.cshtml", typeof(AspNetCore.Views_Autocomplete_MultipleValues))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5684d18432ba86284fbf0ed3bc7f60689bbfd20e", @"/Views/Autocomplete/MultipleValues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Autocomplete_MultipleValues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("delimit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("visualmode"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 68, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Autocomplete / Multiple Values</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(112, 178, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates using the Syncfusion ASP.NET Core Autocomplete component to select multiple values from the suggestion list.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(318, 165, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"row\">\r\n            <div class=\"control\">\r\n                <span class=\"txt\">Using Delimiter</span>\r\n\r\n                ");
                EndContext();
                BeginContext(483, 170, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-autocomplete", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c4a5355fab40128f717fb31a25febc", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_AutocompleteProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AutocompleteProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AutocompleteProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 12 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Autocomplete\MultipleValues.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 12 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Autocomplete\MultipleValues.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.MultiSelectMode = MultiSelectModeTypes.Delimiter;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("multi-select-mode", __Syncfusion_JavaScript_Models_AutocompleteProperties.MultiSelectMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Autocomplete\MultipleValues.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.ShowPopupButton = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-popup-button", __Syncfusion_JavaScript_Models_AutocompleteProperties.ShowPopupButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(653, 150, true);
                WriteLiteral("\r\n                \r\n            </div>\r\n            <div class=\"control\">\r\n                <span class=\"txt\">Using VisualMode</span>\r\n                ");
                EndContext();
                BeginContext(803, 174, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-autocomplete", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50889ddf18346f1b6ad80748ec619d8", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_AutocompleteProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AutocompleteProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AutocompleteProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Autocomplete\MultipleValues.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Autocomplete\MultipleValues.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.MultiSelectMode = MultiSelectModeTypes.VisualMode;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("multi-select-mode", __Syncfusion_JavaScript_Models_AutocompleteProperties.MultiSelectMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\Autocomplete\MultipleValues.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.ShowPopupButton = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-popup-button", __Syncfusion_JavaScript_Models_AutocompleteProperties.ShowPopupButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(977, 67, true);
                WriteLiteral("\r\n               \r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1069, 479, true);
                WriteLiteral(@"
    <style type=""text/css"">
        .frame
        {
            height: 150px;
            width: 40%;
        }
        
        .control
        {
            width: 100%;
            display: inline-block;
            float: left;
        }
        
        .control:first-child
        {
            margin-bottom: 15px;
        }
        
        .txt
        {
            display: block;
            margin-bottom: 12px;
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
