#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\ListBox\Checkbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c02e00a7935c9477167ecdf8440c00201dd2104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListBox_Checkbox), @"mvc.1.0.view", @"/Views/ListBox/Checkbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListBox/Checkbox.cshtml", typeof(AspNetCore.Views_ListBox_Checkbox))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c02e00a7935c9477167ecdf8440c00201dd2104", @"/Views/ListBox/Checkbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListBox_Checkbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("skillsets"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "220px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnchkunchk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("default-text", "Check All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("active-text", "Uncheck All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "130px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onCheckUncheckAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Get Values", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "GetcheckedIndices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bthshowhide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("default-text", "Hide CheckBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("active-text", "Show CheckBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onShowHide", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ListBoxProperties __Syncfusion_JavaScript_Models_ListBoxProperties;
        private global::Syncfusion.JavaScript.Models.ListBoxFields __Syncfusion_JavaScript_Models_ListBoxFields;
        private global::Syncfusion.JavaScript.Models.ToggleButtonProperties __Syncfusion_JavaScript_Models_ToggleButtonProperties;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 58, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListBox / Checkboxes</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(102, 190, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to select multiple items at a time and display their check-boxes with the Syncfusion ASP.NET Core ListBox component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(320, 130, true);
                WriteLiteral("\r\n        <div class=\"control frame\">\r\n            <div class=\"ctrllabel\">\r\n                Select your skills</div>\r\n            ");
                EndContext();
                BeginContext(450, 175, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4910b2acb494c7f90285e3dde5f58e4", async() => {
                    BeginContext(546, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(564, 33, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-list-box-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d887dc1ef9c40e4b256430fc3f72233", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ListBoxFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxFields);
                    __Syncfusion_JavaScript_Models_ListBoxFields.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(597, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ListBoxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 10 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\ListBox\Checkbox.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ListBoxProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ListBoxProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 10 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\ListBox\Checkbox.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.ShowCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-checkbox", __Syncfusion_JavaScript_Models_ListBoxProperties.ShowCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(625, 31, true);
                WriteLiteral("           \r\n\r\n        </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(686, 70, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(756, 129, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eeef1d0b0e65435fa7b1826c905eeca4", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ToggleButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToggleButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToggleButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.DefaultText = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.ActiveText = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Change = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(885, 111, true);
                WriteLiteral("            \r\n        </div>\r\n    </div>\r\n     <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(996, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3721d29647a3482bbee2847e520c143e", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_ButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1076, 110, true);
                WriteLiteral("            \r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(1186, 128, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28bfc30f94bc4c02ab9185a317a24b62", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ToggleButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToggleButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToggleButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.DefaultText = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.ActiveText = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Width = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Change = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1314, 230, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div id=\"resultarea\">\r\n    <span>CheckedItems</span>\r\n    <table id=\"resultdata\">\r\n        <tr>\r\n            <th>Index</></th>\r\n            <th>Text</th>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1570, 1840, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var target;
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });
        function onCheckUncheckAll(args) {
            target = $('#skillsets').data(""ejListBox"");
            if (args.isChecked)
                target.checkAll();
            else
                target.uncheckAll();
        }
        function onShowHide(args) {
            target = $('#skillsets').data(""ejListBox"");
            ButtonObj = $(""#get"").data(""ejButton"");
            ToggleButtonObj = $(""#btnchkunchk"").data(""ejToggleButton"");
            if (args.isChecked) {
                target.option(""showCheckbox"", false);
                ButtonObj.disable();
                ToggleButtonObj.disable();
            }
            else {
                target.option(""showCheckbox"", true);
                ButtonObj.enable();
               ToggleButtonObj.enable();
            }
        }
        function GetcheckedIndices(e) {
     ");
                WriteLiteral(@"        target = $('#skillsets').data(""ejListBox"");
             var alertMsg = """";
             var checkedItems = target.getCheckedItems();
             if (checkedItems.length) {
                 $(checkedItems).each(function (index, ele) {
                     alertMsg += ""<tr class='checkedItems'><td>"" + ele.index + ""</td><td>"" + ele.value + ""</td></tr>"";
                     $("".checkedItems"").remove();
                     $(""#resultdata"").append(alertMsg);
                 });                 
             }
             else {
                 $("".checkedItems"").remove();
                 $(""#resultarea br"").remove();
                 $(""#resultarea"").append(""<br /><span class='checkedItems'>No items are checked</span>"");
             }                 
        }

    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(3435, 348, true);
                WriteLiteral(@"
    <style type=""text/css"" class=""cssStyles"">
        .ctrllabel {
            padding: 0px 0px 12px 3px;
            font-weight: 600;
        }

        .e-ddl-popup {
            margin: 0 auto;
        }
        #resultdata{
            width:100%;
        }
        th{
            width:50%;
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
