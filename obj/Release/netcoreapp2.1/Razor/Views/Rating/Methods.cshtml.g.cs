#pragma checksum "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Rating\Methods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea3696af3ae69f83bf0396f72617fd63b7f82bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rating_Methods), @"mvc.1.0.view", @"/Views/Rating/Methods.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rating/Methods.cshtml", typeof(AspNetCore.Views_Rating_Methods))]
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
#line 1 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea3696af3ae69f83bf0396f72617fd63b7f82bf", @"/Views/Rating/Methods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Rating_Methods : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("apiRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "ratingTarget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "80px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "setRatingValue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnGetValue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "81px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Get Value", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "onGetValueClck", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnReset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Reset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "onResetClick", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chkResetbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("default-text", "Hide", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("active-text", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onShowHideReset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chkShowHideRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onShowHideRating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("chkDestroyRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_19 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("default-text", "Destroy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_20 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("active-text", "Restore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_21 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onDestroyRestore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RatingProperties __Syncfusion_JavaScript_Models_RatingProperties;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        private global::Syncfusion.JavaScript.Models.ToggleButtonProperties __Syncfusion_JavaScript_Models_ToggleButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 49, true);
                WriteLiteral(" <span class=\"sampleName\">Rating / Methods</span>");
                EndContext();
            }
            );
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(102, 47, true);
                WriteLiteral("\r\n\r\n    <div class=\"frame\">\r\n        \r\n        ");
                EndContext();
                BeginContext(149, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rating", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e81243f1f39446b39b3a7bbce88ec735", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_RatingProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RatingProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RatingProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(176, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(193, 174, true);
            WriteLiteral("<div id=\"ratingTarget\">\r\n    <ul>\r\n        <li>0</li>\r\n        <li>1</li>\r\n        <li>2</li>\r\n        <li>3</li>\r\n        <li>4</li>\r\n        <li>5</li>\r\n    </ul>\r\n</div>\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(394, 154, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Set Value\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            \r\n            ");
                EndContext();
                BeginContext(548, 121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "24b5b033435a4425b171fd459afd6335", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 27 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Rating\Methods.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-item-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(669, 188, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Get Current Value\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n          \r\n            ");
                EndContext();
                BeginContext(857, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48c6c2899f1b4b76a5abdb05ec95e6e0", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_ButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
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
                BeginContext(940, 180, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Reset\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            \r\n            ");
                EndContext();
                BeginContext(1120, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4246248ac3642b9aff40227cace3d7d", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_ButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1194, 171, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Reset Button\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(1365, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e595ea56f01140a691853bf7641065b1", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ToggleButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToggleButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToggleButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.DefaultText = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.ActiveText = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Change = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1478, 195, true);
                WriteLiteral("\r\n            \r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Rating\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            \r\n            ");
                EndContext();
                BeginContext(1673, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8fca4aa9db2a44cb8b6257f67b9c3d3a", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ToggleButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToggleButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToggleButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.DefaultText = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.ActiveText = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Change = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1793, 166, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Destroy\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(1959, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36fc82d0e9734f62b6779711280ad3e0", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ToggleButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToggleButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToggleButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_18);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.DefaultText = (string)__tagHelperAttribute_19.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_19);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.ActiveText = (string)__tagHelperAttribute_20.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_20);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Change = (string)__tagHelperAttribute_21.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_21);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2084, 44, true);
                WriteLiteral("\r\n            \r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2154, 2625, true);
                WriteLiteral(@"
    <script>
        var ratingObj, ddlObj;
        $(function () {
            ratingObj = $(""#apiRating"").data(""ejRating"");
            ddlObj = $(""#ddlRating"").data(""ejDropDownList"");
        });
        ratingObj = $(""#apiRating"").data(""ejRating"");
        function onGetValueClck(args) {
            if (ratingObj) {
                var val = ratingObj.getValue();
                alert(""Current Value : "" + val);
            }
        }
        function setRatingValue(args) {
            ratingObj = $(""#apiRating"").data(""ejRating"");
            if (ratingObj) {
                ratingObj = $(""#apiRating"").data(""ejRating"");
                ratingObj.setValue(args.selectedText);
            }
        }
        function onResetClick() {
            if (ratingObj)
                ratingObj.reset();
            ddlObj.option(""selectedItemIndex"", 0);
        }
        function onShowHideRating(args) {
            if (ratingObj) {
                if (args.isChecked)
                   ");
                WriteLiteral(@" ratingObj.hide();
                else
                    ratingObj.show();
            }
        }
        function onShowHideReset(args) {
            if (ratingObj) {
                if (args.isChecked)
                    ratingObj.option({ allowReset: false });
                else
                    ratingObj.option({ allowReset: true });
            }
        }
        function onDestroyRestore(args) {
            ratingObj = $(""#apiRating"").data(""ejRating"");
            ddlObj = $(""#ddlRating"").data(""ejDropDownList"");
            hideButtonObj = $(""#chkShowHideRating"").data(""ejToggleButton"");
            resetButtonObj = $(""#chkResetbtn"").data(""ejToggleButton"");
            resetObj = $(""#btnReset"").data(""ejButton"");
            valButtonObj = $(""#btnGetValue"").data(""ejButton"");
            if(args.isChecked){
                ratingObj.destroy();
                ddlObj.disable();
                hideButtonObj.disable();
                resetButtonObj.disable();
            ");
                WriteLiteral(@"    resetObj.disable();
                valButtonObj.disable();
            }
            else {
                $(""#apiRating"").ejRating();
                ratingObj = $(""#apiRating"").data(""ejRating"");
                ddlObj.option('value', """");
                ddlObj.enable();
                hideButtonObj.enable();
                resetButtonObj.enable();
                resetObj.enable();
                valButtonObj.enable();
            }
        }
        $(document).ready(function () { $(""#sampleProperties"").ejPropertiesPanel(); });
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