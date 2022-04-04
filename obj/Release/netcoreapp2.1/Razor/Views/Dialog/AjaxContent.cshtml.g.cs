#pragma checksum "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Dialog\AjaxContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d8e0e4d6a876cc9c66e3df554addfe911b17c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dialog_AjaxContent), @"mvc.1.0.view", @"/Views/Dialog/AjaxContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dialog/AjaxContent.cshtml", typeof(AspNetCore.Views_Dialog_AjaxContent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d8e0e4d6a876cc9c66e3df554addfe911b17c9", @"/Views/Dialog/AjaxContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Dialog_AjaxContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnOpen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Click to open dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "onclick", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ajaxDialog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("content-type", "ajax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "Twitter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("containment", ".control", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("close", "onDialogClose", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        private global::Syncfusion.JavaScript.Models.DialogProperties __Syncfusion_JavaScript_Models_DialogProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 53, true);
                WriteLiteral(" <span class=\"sampleName\">Dialog / AjaxContent</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(97, 169, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates loading the Syncfusion ASP.NET Core Dialog content from another page’s content using Ajax requests.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(294, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(302, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7017d85687974edab0dd1a22fc3fcc23", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(372, 42, true);
                WriteLiteral("\r\n   \r\n    <div class=\"control\">\r\n        ");
                EndContext();
                BeginContext(414, 211, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d71463260d244b6bbf3cb205eebd385", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DialogProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DialogProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DialogProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DialogProperties.ContentType = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_DialogProperties.Title = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 10 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Dialog\AjaxContent.cshtml"
__Syncfusion_JavaScript_Models_DialogProperties.Width = 500;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_DialogProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DialogProperties.Containment = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
#line 10 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Dialog\AjaxContent.cshtml"
                                                                                                           WriteLiteral(Url.Content("~/dialog/twitter").ToString());

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Syncfusion_JavaScript_Models_DialogProperties.ContentUrl = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("content-url", __Syncfusion_JavaScript_Models_DialogProperties.ContentUrl, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DialogProperties.Close = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 10 "D:\Samples_20.1.0.47\ASPNETCORE\samplebrowser\Views\Dialog\AjaxContent.cshtml"
__Syncfusion_JavaScript_Models_DialogProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_DialogProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(625, 22, true);
                WriteLiteral("        \r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(673, 272, true);
                WriteLiteral(@"
    <script>
        $(""#btnOpen"").hide();
        function onclick() {
            $(""#ajaxDialog"").ejDialog(""open"");
            $(""#btnOpen"").hide();
        }
        function onDialogClose(args) {
            $(""#btnOpen"").show();
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(970, 203, true);
                WriteLiteral("\r\n    <style class=\"cssStyles\">\r\n        .control {\r\n            height: 500px;\r\n            position: relative;\r\n        }\r\n\r\n        #ajaxDialog {\r\n            padding: 10px;\r\n        }\r\n    </style>\r\n");
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
