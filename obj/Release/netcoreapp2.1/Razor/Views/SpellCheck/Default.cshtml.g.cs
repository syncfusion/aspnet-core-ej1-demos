#pragma checksum "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\SpellCheck\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2da78e2452a7d03e4ce66678e0667806d57cd977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpellCheck_Default), @"mvc.1.0.view", @"/Views/SpellCheck/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SpellCheck/Default.cshtml", typeof(AspNetCore.Views_SpellCheck_Default))]
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
#line 1 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da78e2452a7d03e4ce66678e0667806d57cd977", @"/Views/SpellCheck/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_SpellCheck_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("custom-dictionary-url", "//js.syncfusion.com/ejServices/api/SpellCheck/AddToDictionary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dictionary-url", "//js.syncfusion.com/ejServices/api/SpellCheck/CheckWords", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SpellCheckDialog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("controls-to-validate", "#TextArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SpellCheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "200px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "25px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Spell check using dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "showDialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.SpellCheckProperties __Syncfusion_JavaScript_Models_SpellCheckProperties;
        private global::Syncfusion.JavaScript.Models.SpellCheckDictionarySettings __Syncfusion_JavaScript_Models_SpellCheckDictionarySettings;
        private global::Syncfusion.JavaScript.Models.SpellContextSettings __Syncfusion_JavaScript_Models_SpellContextSettings;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 77, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">SpellCheck / Default Functionalities </span>\r\n");
                EndContext();
            }
            );
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(130, 619, true);
                WriteLiteral(@"
    <div id=""TextArea"" contenteditable=""true"">
        Facebook is a social networking service headquartered in Menlo Park, California. Its website was launched on February 4, 2004, by Mark Zuckerberg with his Harvard College roommates and fellow students Eduardo, Andrew McCollum, Dustin and Chris Hughes.
        The fouders had initially limited the websites membrship to Harvard students, but later expanded it to collges in the Boston area, the Ivy League, and Stanford Univrsity. It graually added support for students at various other universities and later to high-school students.
    </div><br />

    ");
                EndContext();
                BeginContext(749, 423, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-spell-check", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17f192e00d144acd9e77cdea879a42dc", async() => {
                    BeginContext(845, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(855, 217, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-dictionary-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "396fc0aea6be4b21a25619a0fd116449", async() => {
                        BeginContext(1038, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_SpellCheckDictionarySettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpellCheckDictionarySettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpellCheckDictionarySettings);
                    __Syncfusion_JavaScript_Models_SpellCheckDictionarySettings.CustomDictionaryUrl = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_Models_SpellCheckDictionarySettings.DictionaryUrl = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1072, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1082, 67, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-context-menu-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcd02256745d4e458e737fed9bfdf4c2", async() => {
                        BeginContext(1122, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_SpellContextSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpellContextSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpellContextSettings);
#line 14 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\SpellCheck\Default.cshtml"
__Syncfusion_JavaScript_Models_SpellContextSettings.Enable = false;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable", __Syncfusion_JavaScript_Models_SpellContextSettings.Enable, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1149, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_SpellCheckProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpellCheckProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpellCheckProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_SpellCheckProperties.ControlsToValidate = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 11 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\SpellCheck\Default.cshtml"
__Syncfusion_JavaScript_Models_SpellCheckProperties.MaxSuggestionCount = 2;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("max-suggestion-count", __Syncfusion_JavaScript_Models_SpellCheckProperties.MaxSuggestionCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1172, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1178, 108, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "152663a02f174a139339e409bd91c45a", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_ButtonProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_ButtonProperties.Height = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1286, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1291, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(1316, 209, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function showDialog() {\r\n            var spellObj = $(\"#SpellCheckDialog\").data(\"ejSpellCheck\");\r\n            spellObj.showInDialog();\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1528, 4, true);
            WriteLiteral("\r\n\r\n");
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
