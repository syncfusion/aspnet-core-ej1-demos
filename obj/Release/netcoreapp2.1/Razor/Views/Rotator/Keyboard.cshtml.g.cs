#pragma checksum "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Rotator\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bccde14d14e08d4349ee4bf80e3a05a2a5917aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rotator_Keyboard), @"mvc.1.0.view", @"/Views/Rotator/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rotator/Keyboard.cshtml", typeof(AspNetCore.Views_Rotator_Keyboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bccde14d14e08d4349ee4bf80e3a05a2a5917aa", @"/Views/Rotator/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Rotator_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "url", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sliderContent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-height", "350px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RotatorProperties __Syncfusion_JavaScript_Models_RotatorProperties;
        private global::Syncfusion.JavaScript.Models.RotatorFields __Syncfusion_JavaScript_Models_RotatorFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 51, true);
                WriteLiteral("<span class=\"sampleName\">Rotator / Keyboard </span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(95, 174, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to access the Syncfusion ASP.NET Core Rotator component functionalities using keyboard interactions.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(297, 35, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        ");
                EndContext();
                BeginContext(332, 301, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rotator", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "282e27973a3147a686aefb7d5d1b8cfa", async() => {
                    BeginContext(554, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(568, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c422781d6a634bef80e1fe0295f3ce26", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_RotatorFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorFields);
                    __Syncfusion_JavaScript_Models_RotatorFields.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_Models_RotatorFields.Url = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(610, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_RotatorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 7 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Rotator\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_RotatorProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideWidth = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideHeight = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 7 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Rotator\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowPager = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-pager", __Syncfusion_JavaScript_Models_RotatorProperties.ShowPager, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Rotator\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.AllowKeyboardNavigation = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-keyboard-navigation", __Syncfusion_JavaScript_Models_RotatorProperties.AllowKeyboardNavigation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Rotator\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-play-button", __Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Rotator\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowThumbnail = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-thumbnail", __Syncfusion_JavaScript_Models_RotatorProperties.ShowThumbnail, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Rotator\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(633, 23, true);
                WriteLiteral("\r\n       \r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(659, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(688, 1382, true);
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
            Move to next slide
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
           Down / Left
        </div>
        <div class=""col-md-3"">
            Move to previous slide
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
           Space 
        </div>
        <div class=""col-md-3"">
            Play/Pause slide
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
           Alt+Right
        </div>
        <div class=""col-md-3"">
            Move thumbnail item to left and select item
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
    ");
                WriteLiteral(@"       Alt+left
        </div>
        <div class=""col-md-3"">
            Move thumbnail item to right and select item
        </div>
    </div>
    <br />
    <div class=""row"">
        <div class=""col-md-3"">
           Enter
        </div>
        <div class=""col-md-3"">
            Move to selected thumbnail item 
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2096, 396, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {

            //Control focus key
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $(""#sliderContent"")[0].focus();
                }
            });
            $(""#sampleProperties"").ejPropertiesPanel();
        });
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2517, 263, true);
                WriteLiteral(@"
    <style type=""text/css"" class=""cssStyles"">
        .frame {
            width: 100%;
            box-sizing: border-box;
        }
        #sliderContent > li img {
            width: 100%;
            height: 350px;
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
