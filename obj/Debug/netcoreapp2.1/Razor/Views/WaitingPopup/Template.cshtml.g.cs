#pragma checksum "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\WaitingPopup\Template.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3d1a12b5d54dccdadf232cc56596326e924fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WaitingPopup_Template), @"mvc.1.0.view", @"/Views/WaitingPopup/Template.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WaitingPopup/Template.cshtml", typeof(AspNetCore.Views_WaitingPopup_Template))]
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
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3d1a12b5d54dccdadf232cc56596326e924fb3", @"/Views/WaitingPopup/Template.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_WaitingPopup_Template : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("target"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("template", "#content", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("append-to", ".cols-sample-area", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.WaitingPopupProperties __Syncfusion_JavaScript_Models_WaitingPopupProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 56, true);
                WriteLiteral("<span class=\"sampleName\">WaitingPopup / Template</span> ");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(107, 35, true);
                WriteLiteral("\r\n    <div id=\"target\"></div>\r\n    ");
                EndContext();
                BeginContext(142, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-waiting-popup", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90e007d1b23e4d8097e7363ef7d82a5d", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_WaitingPopupProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.WaitingPopupProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_WaitingPopupProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 4 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\WaitingPopup\Template.cshtml"
__Syncfusion_JavaScript_Models_WaitingPopupProperties.ShowOnInit = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-on-init", __Syncfusion_JavaScript_Models_WaitingPopupProperties.ShowOnInit, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_WaitingPopupProperties.Template = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_WaitingPopupProperties.AppendTo = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(243, 343, true);
                WriteLiteral(@"
    <div id=""content"">
        <div class=""block"">
            <div class=""logo""></div>
            <div class=""txt"">
                <p>Create cutting-edge </p>
                <p><b>HTML5</b> web applications </p>
                <p>with ease </p>
            </div>
        </div>
        <div class=""loader""></div>
    </div>
");
                EndContext();
            }
            );
            BeginContext(589, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("StyleSection", async() => {
                BeginContext(617, 130, true);
                WriteLiteral("\r\n  <style type=\"text/css\" class=\"cssStyles\">       \r\n\t\t\t.cols-sample-area{\r\n\t\t\t\tposition:relative;\r\n\t\t\t}\r\n    </style>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 747, "\"", 808, 1);
#line 26 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\WaitingPopup\Template.cshtml"
WriteAttributeValue("", 754, Url.Content("~/css/Samples/WaitingPopupTemplate.css"), 754, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(809, 22, true);
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
