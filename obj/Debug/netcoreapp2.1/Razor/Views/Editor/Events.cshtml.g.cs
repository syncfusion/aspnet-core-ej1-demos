#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8edc073c9a6e46bd5d95fe5c716fe5bc62bfae6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editor_Events), @"mvc.1.0.view", @"/Views/Editor/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Editor/Events.cshtml", typeof(AspNetCore.Views_Editor_Events))]
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
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8edc073c9a6e46bd5d95fe5c716fe5bc62bfae6c", @"/Views/Editor/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Editor_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("numeric"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "onNumericCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "numericValChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-in", "numericFocusIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-out", "numericFocusOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("percent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "onPercentageCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "percentValChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-in", "percentFocusIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-out", "percentFocusOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("currency"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "onCurrencyCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "currencyValChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-in", "currencyFocusIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-out", "currencyFocusOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("maskedit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("mask-format", "99-999-99999", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "onMaskCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_19 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "maskValueChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_20 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-in", "maskFocusIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_21 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("focus-out", "maskFocusOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_22 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("watermark-text", "99-999-99999", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_23 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectControls_input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_24 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "target", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_25 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "evtpropscheckedevent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.EditorProperties __Syncfusion_JavaScript_Models_EditorProperties;
        private global::Syncfusion.JavaScript.Models.MaskEditProperties __Syncfusion_JavaScript_Models_MaskEditProperties;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(32, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 45, "\"", 109, 1);
#line 2 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml"
WriteAttributeValue("", 51, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 51, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(110, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(148, 48, true);
                WriteLiteral("<span class=\"sampleName\">Editor / Events</span> ");
                EndContext();
            }
            );
            BeginContext(199, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(226, 204, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"row\">\r\n            <div class=\"column\">\r\n                <span>Numeric Textbox</span>\r\n            </div>\r\n            <div class=\"column\">\r\n                ");
                EndContext();
                BeginContext(430, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-numeric-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3fdb6712f8549f2a8609744ef1070d3", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 1001;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Create = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_EditorProperties.FocusIn = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_EditorProperties.FocusOut = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(596, 218, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"column\">\r\n                <span>Percentage Textbox</span>\r\n            </div>\r\n            <div class=\"column\">\r\n                ");
                EndContext();
                BeginContext(814, 171, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-percentage-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6a2e2256d9049e3ae2a664cdb27348e", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 21 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 25;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Create = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_EditorProperties.FocusIn = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_EditorProperties.FocusOut = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(985, 216, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"column\">\r\n                <span>Currency Textbox</span>\r\n            </div>\r\n            <div class=\"column\">\r\n                ");
                EndContext();
                BeginContext(1201, 171, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-currency-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "868267ddd23344a1a10ff7ac4d7eb6e3", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
#line 29 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 32;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Create = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_EditorProperties.FocusIn = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Syncfusion_JavaScript_Models_EditorProperties.FocusOut = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1372, 216, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"column\">\r\n                <span>MaskEdit Textbox</span>\r\n            </div>\r\n            <div class=\"column\">\r\n                ");
                EndContext();
                BeginContext(1588, 223, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-mask-edit", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ff7c9bf957149b49c1493844c33b3bf", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_MaskEditProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.MaskEditProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MaskEditProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
#line 37 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml"
__Syncfusion_JavaScript_Models_MaskEditProperties.InputMode = InputMode.Text;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("input-mode", __Syncfusion_JavaScript_Models_MaskEditProperties.InputMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_MaskEditProperties.MaskFormat = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                __Syncfusion_JavaScript_Models_MaskEditProperties.Create = (string)__tagHelperAttribute_18.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_18);
                __Syncfusion_JavaScript_Models_MaskEditProperties.Change = (string)__tagHelperAttribute_19.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_19);
                __Syncfusion_JavaScript_Models_MaskEditProperties.FocusIn = (string)__tagHelperAttribute_20.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_20);
                __Syncfusion_JavaScript_Models_MaskEditProperties.FocusOut = (string)__tagHelperAttribute_21.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_21);
                __Syncfusion_JavaScript_Models_MaskEditProperties.WatermarkText = (string)__tagHelperAttribute_22.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_22);
                __Syncfusion_JavaScript_Models_MaskEditProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1811, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(1864, 126, true);
            WriteLiteral("<div id=\"target\">\r\n    <ul>\r\n        <li>focusIn</li>\r\n        <li>focusOut</li>\r\n        <li>change</li>\r\n    </ul>\r\n</div>\r\n");
            EndContext();
            DefineSection("EventsDropdown", async() => {
                BeginContext(2014, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2020, 134, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46703cdd110143a5ab9b10ab6eb9f4aa", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_23);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_24.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_24);
#line 50 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-checkbox", __Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 50 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Editor\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("check-all", __Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_25.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_25);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2154, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2182, 4513, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        function onNumericCreate(args) {
            jQuery.addEventLog(""NumericTextbox has been <span class='eventTitle'>created</span>"");
        }
        function onPercentageCreate(args) {
            jQuery.addEventLog(""PercentageTextbox has been <span class='eventTitle'>created</span>"");
        }
        function onCurrencyCreate(args) {
            jQuery.addEventLog(""CurrencyTextbox has been <span class='eventTitle'>created</span>"");
        }
        function onMaskCreate(args) {
            jQuery.addEventLog(""MaskEditTextbox has been <span class='eventTitle'>created</span>"");
        }
        function numericValChange(args) {
            jQuery.addEventLog(""NumericTextbox value has been <span class='eventTitle'>changed</span> to "" + args.value + "".<br/>"");
        }
        function percentValChange(args) {
            jQuery.addEventLog(""PercentageTextbox value has been <span class='eventTitle'>changed</span> to "" + args.value + "".<br/>"")");
                WriteLiteral(@";
        }
        function currencyValChange(args) {
            jQuery.addEventLog(""CurrencyTextbox value has been <span class='eventTitle'>changed</span> to "" + args.value + "".<br/>"");
        }
        function maskValueChange(args) {
            jQuery.addEventLog(""MaskEditTextbox value has been <span class='eventTitle'>changed</span> to "" + args.value + "".<br/>"");
        }
        function numericFocusIn(args) {
            jQuery.addEventLog(""NumericTextbox is in <span class='eventTitle'>Focus</span>"");
        }
        function numericFocusOut(args) {
            jQuery.addEventLog(""NumericTextbox is out of <span class='eventTitle'>Focus</span>"");
        }
        function percentFocusIn(args) {
            jQuery.addEventLog(""PercentTextbox is in <span class='eventTitle'>Focus</span>"");
        }
        function percentFocusOut(args) {
            jQuery.addEventLog(""PercentTextbox is out of <span class='eventTitle'>Focus</span>"");
        }
        function currencyFocusIn(a");
                WriteLiteral(@"rgs) {
            jQuery.addEventLog(""CurrencyTextbox is in <span class='eventTitle'>Focus</span>"");
        }
        function currencyFocusOut(args) {
            jQuery.addEventLog(""CurrencyTextbox is out of <span class='eventTitle'>Focus</span>"");
        }
        function maskFocusIn(args) {
            jQuery.addEventLog(""MaskEditTextbox is in <span class='eventTitle'>Focus</span>"");
        }
        function maskFocusOut(args) {
            jQuery.addEventLog(""MaskEditTextbox is out of <span class='eventTitle'>Focus</span>"");
        }
        function onClear() {
            jQuery.clearEventLog();
        }
        function evtpropscheckedevent(args) {
            var numericObj, percentObj, currencyObj, maskObj;
            numericObj = $(""#numeric"").data(""ejNumericTextbox"");
            percentObj = $(""#percent"").data(""ejPercentageTextbox"");
            currencyObj = $(""#currency"").data(""ejCurrencyTextbox"");
            maskObj = $(""#maskedit"").data(""ejMaskEdit"");
          ");
                WriteLiteral(@"  if (args.isChecked) {
                switch (args.selectedText) {
                    case ""change"": numericObj.option(args.selectedText, ""numericValChange"");
                        percentObj.option(args.selectedText, ""percentValChange"");
                        currencyObj.option(args.selectedText, ""currencyValChange"");
                        maskObj.option(args.selectedText, ""maskValueChange""); break;
                    case ""focusIn"": numericObj.option(args.selectedText, ""numericFocusIn"");
                        percentObj.option(args.selectedText, ""percentFocusIn"");
                        currencyObj.option(args.selectedText, ""currencyFocusIn"");
                        maskObj.option(args.selectedText, ""maskFocusIn""); break;
                    case ""focusOut"": numericObj.option(args.selectedText, ""numericFocusOut"");
                        percentObj.option(args.selectedText, ""percentFocusOut"");
                        currencyObj.option(args.selectedText, ""currencyFocusOut"");
     ");
                WriteLiteral(@"                   maskObj.option(args.selectedText, ""maskFocusOut""); break;
                }

            }
            else {
                numericObj.option(args.selectedText, null);
                percentObj.option(args.selectedText, null);
                currencyObj.option(args.selectedText, null);
                maskObj.option(args.selectedText, null);
            }
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(6720, 175, true);
                WriteLiteral("\r\n\r\n    <style>\r\n        .frame {\r\n            width: 38%;\r\n            padding: 30px;\r\n        }\r\n\r\n        .column {\r\n              padding: 5px; \r\n        }\r\n    </style>\r\n");
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
