#pragma checksum "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Dropdownlist\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2396183169935ff48dc9e19c785fb4ee08cfd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dropdownlist_Keyboard), @"mvc.1.0.view", @"/Views/Dropdownlist/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dropdownlist/Keyboard.cshtml", typeof(AspNetCore.Views_Dropdownlist_Keyboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d2396183169935ff48dc9e19c785fb4ee08cfd8", @"/Views/Dropdownlist/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Dropdownlist_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "font", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "font", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fontnames"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("watermark-text", "Select a font", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        private global::Syncfusion.JavaScript.Models.DropDownListFields __Syncfusion_JavaScript_Models_DropDownListFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 73, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Dropdownlist / Keyboard Interaction</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(124, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(194, 234, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b9ff8f731a453c8e537680f8613a45", async() => {
                    BeginContext(324, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(342, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-drop-down-list-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0098b81052b0424a99ffee049a3ee6d6", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_DropDownListFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListFields);
                    __Syncfusion_JavaScript_Models_DropDownListFields.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_Models_DropDownListFields.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(394, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 6 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Dropdownlist\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.DataSource = (IEnumerable<Fonts>)ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_DropDownListProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.WatermarkText = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(428, 43, true);
                WriteLiteral(" \r\n                    </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(501, 2047, true);
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
            UP
        </div>
        <div class=""col-md-3"">
            Navigates upwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down
        </div>
        <div class=""col-md-3"">
            Navigates downwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Left
        </div>
        <div class=""col-md-3"">
            Navigates upwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Right
        </div>
        <div class=""col-md-3"">
            Navigates downwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Home
        </div>
        <div class=""col-m");
                WriteLiteral(@"d-3"">
            Navigates to the starting item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            End
        </div>
        <div class=""col-md-3"">
            Navigates to the ending item
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
            Alt + Up
        </div>
        <div class=""col-md-3"">
            Closes the popup window
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + Down
        </div>
        <div class=""col-md-3"">
            Opens the popup window
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Esc
        </div>
        <div class=""col-md-3"">
            Closes the popup window
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2574, 416, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var target;
        $(function () {
            //Control focus key
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $(""#fontnames_wrapper"").focus();
                }
            });
            $(""#sampleProperties"").ejPropertiesPanel();
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(2993, 2, true);
            WriteLiteral("\r\n");
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
