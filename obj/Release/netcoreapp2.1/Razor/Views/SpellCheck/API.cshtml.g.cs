#pragma checksum "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\SpellCheck\API.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d45393eb29addee51890ee6ddb15803b10c9696d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpellCheck_API), @"mvc.1.0.view", @"/Views/SpellCheck/API.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SpellCheck/API.cshtml", typeof(AspNetCore.Views_SpellCheck_API))]
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
#line 1 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45393eb29addee51890ee6ddb15803b10c9696d", @"/Views/SpellCheck/API.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_SpellCheck_API : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("custom-dictionary-url", "//js.syncfusion.com/ejServices/api/SpellCheck/AddToDictionary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dictionary-url", "//js.syncfusion.com/ejServices/api/SpellCheck/CheckWords", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SpellCheckDialog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("controls-to-validate", "#TextArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SpellCheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "25px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Spell check", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "showInContextMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "errorword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "highlighter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "e-errorword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 58, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">SpellCheck / API\'s</span>\r\n");
                EndContext();
            }
            );
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(111, 1136, true);
                WriteLiteral(@"
    <div id=""TextArea"" contenteditable=""true"">
        Amazon.com, Inc., often refered to as simply Amazon, is an American electronic commerce and cloud computing company with headquarters in Seattle, Washington. It is the largest web-based retailer in the United States. Amazon.com started as bookstore on the web, later diversifying to sell DVDs, Blu-rays, CDs, video downloads/streaming, MP3 downloads/streaming, audiobook downloads/streaming, software, video games, electronics, apparel, furniture, food, toys and jewelry. The company also produces consumer electronics—notably, Amazon Kindle e-book readers, Fire tablets, Fire TV and Fire Phone—and is the world's largest provider of cloud infrastructure services (IaaS). Amazon also sells certain low-end products like USB cables under its in-house brand AmazonBasics.
        Amazon has separate retail websites for United States, United Kingdom and Ireland, France, Canada, Germany, Italy, Spain, Netherlands, Australia, Brazil, Japan, China, India and Mexico. A");
                WriteLiteral("mazon also offers international shipping to cetain other countries for some of its products.\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(1247, 412, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-spell-check", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "affc06d5705d4e83822d9759b5c9bb6d", async() => {
                    BeginContext(1343, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1353, 207, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-dictionary-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38e22bf00f5f44bba0f942318435743c", async() => {
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
                    BeginContext(1560, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1570, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-context-menu-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ffbecd15ac84b039692677e1186bb72", async() => {
                        BeginContext(1609, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_SpellContextSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpellContextSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpellContextSettings);
#line 13 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\SpellCheck\API.cshtml"
__Syncfusion_JavaScript_Models_SpellContextSettings.Enable = true;

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
                    BeginContext(1636, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_SpellCheckProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.SpellCheckProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SpellCheckProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_SpellCheckProperties.ControlsToValidate = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 11 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\SpellCheck\API.cshtml"
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
                BeginContext(1659, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1665, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f019a9e2daf94512bb076d6c5c1406ba", async() => {
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
                BeginContext(1767, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1772, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(1801, 317, true);
                WriteLiteral(@"
    <div id=""sampleProperties"">
        <div class=""prop-grid"">
            <div class=""row"">
                <div class=""col-md-3 aligntop"">MisspellWordCss</div>
                <div class=""col-md-3"">
                    <select name=""selectIndex"" class=""e-ddl"" id=""misspellWordCss"">
                        ");
                EndContext();
                BeginContext(2118, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1c5525c6da4cbcbfe5ef80483309d1", async() => {
                    BeginContext(2144, 10, true);
                    WriteLiteral("Highlight1");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2163, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2189, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "639e0410d41f4079953eea3b73dfe05d", async() => {
                    BeginContext(2217, 10, true);
                    WriteLiteral("Highlight2");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2236, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2262, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d6374c5097a44eb8117b0f583cd58e1", async() => {
                    BeginContext(2290, 10, true);
                    WriteLiteral("Highlight3");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2309, 2273, true);
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3"">Ignore AlphaNumeric Words</div>
                <div class=""col-md-3"">
                    <input type=""checkbox"" class=""nodetext"" id=""ignoreAlphaNumericWords"" />
                </div>
            </div>
            <br />
            <div class=""row"">
                <div class=""col-md-3"">Ignore UpperCase</div>
                <div class=""col-md-3"">
                    <input type=""checkbox"" class=""nodetext"" id=""ignoreUpperCase"" />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3"">Ignore MixedCase Words</div>
                <div class=""col-md-3"">
                    <input type=""checkbox"" class=""nodetext"" id=""ignoreMixedCaseWords"" />
                </div>
            </div><br />
            <div class=""row"">
                <div class=""col-md-3"">Ignore Url</div>
                <div");
                WriteLiteral(@" class=""col-md-3"">
                    <input type=""checkbox"" class=""nodetext"" id=""ignoreUrl"" />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3"">Ignore FileNames</div>
                <div class=""col-md-3"">
                    <input type=""checkbox"" class=""nodetext"" id=""ignoreFileNames"" />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3"">Ignore Email Address</div>
                <div class=""col-md-3"">
                    <input type=""checkbox"" class=""nodetext"" id=""ignoreEmailAddress"" />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3"">Maximum Suggestion Count</div>
                <div class=""col-md-3"">
                    <input type=""text"" id=""maxSuggestionCount"" value=""maxSuggestionCount"" />
                </div>
            </div><br />
            <div class=""row"">
                <div class=""col-md");
                WriteLiteral("-3\">Ignore Words</div>\r\n                <div class=\"col-md-12\">\r\n                    <input type=\"text\" id=\"ignoreWordsDropDown\" class=\"e-togglebtn\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(4607, 219, true);
                WriteLiteral("\r\n    <style>\r\n        .errorword {\r\n            color: red;\r\n        }\r\n\r\n        .highlighter {\r\n            color: blue;\r\n        }\r\n\r\n        #TextArea {\r\n            padding-bottom: 15px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(4829, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(4854, 3286, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        var target;
        var ignoreWordsData = [
                { word: ""audiobook"" }, { word: ""Blu"" }, { word: ""DVDs"" }
        ];
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
            var spellObj = $(""#SpellCheckDialog"").data(""ejSpellCheck"");
            spellObj.validate();
        });

        $(""#misspellWordCss"").ejDropDownList({ selectedItemIndex: 2, select: ""changeErrorHighlight"", change: ""showInContextMenu"", width: ""110px"" });
        $(""#ignoreAlphaNumericWords"").ejCheckBox({ change: ""ignoreAlphaNumericWords"", checked: true });
        $(""#ignoreUpperCase"").ejCheckBox({ change: ""ignoreUpperCase"", checked: true });
        $(""#ignoreUrl"").ejCheckBox({ change: ""ignoreUrl"", checked: true });
        $(""#ignoreMixedCaseWords"").ejCheckBox({ change: ""ignoreMixedCaseWords"", checked: true });
        $(""#ignoreFileNames"").ejCheckBox({ change: ""ignoreFileNames"", checked: true });
        $(""#ignoreEmailAddress");
                WriteLiteral(@""").ejCheckBox({ change: ""ignoreEmailAddress"", checked: true });
        $(""#maxSuggestionCount"").ejNumericTextbox({ name: ""maxSuggestionCount"", value: 6, width: 110, change: ""maxSuggestionChange"" });
        $(""#ignoreWordsDropDown"").ejDropDownList({
            dataSource: ignoreWordsData,
            fields: { text: ""word"" },
            watermarkText: ""Select your ignore words"",
            showCheckbox: true,
            width: ""100%"",
            change: ""addIgnoreWords""
        });
        
        if (ej.browserInfo().name === ""msie"")
            document.execCommand(""AutoUrlDetect"", false, false);

        function changeErrorHighlight(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ misspellWordCss: args.value });
        }
        function ignoreAlphaNumericWords(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ ignoreSettings: { ignoreAlphaNumericWords: args.isChecked } });
        }
        function ignoreUrl(args) {
            $(""#SpellCheckDialog"").ejSpellC");
                WriteLiteral(@"heck({ ignoreSettings: { ignoreUrl: args.isChecked } });
        }
        function ignoreUpperCase(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ ignoreSettings: { ignoreUpperCase: args.isChecked } });
        }
        function ignoreMixedCaseWords(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ ignoreSettings: { ignoreMixedCaseWords: args.isChecked } });
        }
        function ignoreFileNames(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ ignoreSettings: { ignoreFileNames: args.isChecked } });
        }
        function ignoreEmailAddress(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ ignoreSettings: { ignoreEmailAddress: args.isChecked } });
        }
        function addIgnoreWords(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ ignoreWords: !ej.isNullOrUndefined(args.model.value) ? args.model.value.split("","") : [] });
        }
        function maxSuggestionChange(args) {
            $(""#SpellCheckDialog"").ejSpellCheck({ maxSugge");
                WriteLiteral("stionCount: args.value });\r\n        }\r\n        function showInContextMenu() {\r\n            var spellObj = $(\"#SpellCheckDialog\").data(\"ejSpellCheck\");\r\n            spellObj.validate();\r\n        }\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(8143, 2, true);
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
