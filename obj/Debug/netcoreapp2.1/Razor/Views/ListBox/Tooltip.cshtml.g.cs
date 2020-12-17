#pragma checksum "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ListBox\Tooltip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9a09b9864326fa28396afa729abc405814c6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListBox_Tooltip), @"mvc.1.0.view", @"/Views/ListBox/Tooltip.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListBox/Tooltip.cshtml", typeof(AspNetCore.Views_ListBox_Tooltip))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9a09b9864326fa28396afa729abc405814c6d5", @"/Views/ListBox/Tooltip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListBox_Tooltip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tooltip-text", "desig", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "250px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 55, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListBox / ToolTip</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(99, 162, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to display tooltips for the list items in the Syncfusion ASP.NET Core ListBox component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(289, 109, true);
                WriteLiteral("\r\n        <div class=\"control frame\">\r\n            <div class=\"ctrllabel\">Select a person</div>\r\n            ");
                EndContext();
                BeginContext(398, 173, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86843b03224e4e6094d77616550e669d", async() => {
                    BeginContext(471, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(489, 54, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-list-box-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c81ee3a6727e462b9f61b9dde2597e3c", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ListBoxFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxFields);
                    __Syncfusion_JavaScript_Models_ListBoxFields.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_Models_ListBoxFields.TooltipText = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(543, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ListBoxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 9 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ListBox\Tooltip.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ListBoxProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ListBoxProperties.Height = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(571, 29, true);
                WriteLiteral("           \r\n        </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(625, 246, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .ctrllabel {            \r\n            padding: 5px 0px 12px 3px;\r\n            font-weight:500;\r\n        }\r\n\r\n        .e-ddl-popup {\r\n            margin: 0 auto;\r\n        }\r\n\r\n    </style>\r\n");
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
