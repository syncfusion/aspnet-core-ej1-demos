#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d958c0cd1b1b5dffda6a5220af777994883755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Button_Default), @"mvc.1.0.view", @"/Views/Button/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Button/Default.cshtml", typeof(AspNetCore.Views_Button_Default))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d958c0cd1b1b5dffda6a5220af777994883755", @"/Views/Button/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Button_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("prefix-icon", "e-icon e-handup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button21"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button31"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button41"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button51"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 201, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates the default functionalities of the Button control and its properties like size, contenttype and showroundedcorner in a ASP.NET Core.\">\r\n");
                EndContext();
            }
            );
            BeginContext(222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(247, 70, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Button / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(345, 258, true);
                WriteLiteral(@"
    <div class=""frame"">
        <div class=""control"">
            <table>
                <tr>
                    <td>
                        Button Normal
                    </td>
                    <td class=""btnsht"">
                        ");
                EndContext();
                BeginContext(603, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ea230bb66b94aa680be77e3556e2078", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 16 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Size = ButtonSize.Normal;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_Models_ButtonProperties.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-rounded-corner", __Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.ContentType = ContentType.ImageOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("content-type", __Syncfusion_JavaScript_Models_ButtonProperties.ContentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ButtonProperties.PrefixIcon = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(764, 229, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Button Mini\r\n                    </td>\r\n                    <td class=\"btnsht\">\r\n                        ");
                EndContext();
                BeginContext(993, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b7ebff686da45579649092803a19b79", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 24 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Size = ButtonSize.Mini;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_Models_ButtonProperties.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-rounded-corner", __Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1084, 230, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Button Small\r\n                    </td>\r\n                    <td class=\"btnsht\">\r\n                        ");
                EndContext();
                BeginContext(1314, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea948932339a411faab4b97d74f69eda", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 32 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Size = ButtonSize.Small;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_Models_ButtonProperties.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-rounded-corner", __Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1406, 231, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Button Medium\r\n                    </td>\r\n                    <td class=\"btnsht\">\r\n                        ");
                EndContext();
                BeginContext(1637, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3ae1f7825b1476f80708026accdbd61", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 40 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-rounded-corner", __Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Size = ButtonSize.Medium;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_Models_ButtonProperties.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1729, 230, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Button Large\r\n                    </td>\r\n                    <td class=\"btnsht\">\r\n                        ");
                EndContext();
                BeginContext(1959, 163, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "049d958fccdf40f9b26a3ee68e6515f3", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 48 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-rounded-corner", __Syncfusion_JavaScript_Models_ButtonProperties.ShowRoundedCorner, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Size = ButtonSize.Large;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("size", __Syncfusion_JavaScript_Models_ButtonProperties.Size, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Button\Default.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.ContentType = ContentType.TextAndImage;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("content-type", __Syncfusion_JavaScript_Models_ButtonProperties.ContentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ButtonProperties.PrefixIcon = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2122, 102, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2249, 83, true);
                WriteLiteral("\r\n    <style>\r\n        .frame {\r\n            width: 30%;\r\n        }\r\n    </style>\r\n");
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
