#pragma checksum "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Button\groupbuttons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e9e3a9960973dc3e386ce68e21e91259a108ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Button_groupbuttons), @"mvc.1.0.view", @"/Views/Button/groupbuttons.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Button/groupbuttons.cshtml", typeof(AspNetCore.Views_Button_groupbuttons))]
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
#line 1 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e9e3a9960973dc3e386ce68e21e91259a108ed", @"/Views/Button/groupbuttons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Button_groupbuttons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Day", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Week", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Month", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("GroupButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "40px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.GroupButtonProperties __Syncfusion_JavaScript_Models_GroupButtonProperties;
        private global::Syncfusion.JavaScript.Models.GroupButtonBase __Syncfusion_JavaScript_Models_GroupButtonBase;
        private global::Syncfusion.JavaScript.Models.GroupButtonBaseItem __Syncfusion_JavaScript_Models_GroupButtonBaseItem;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 213, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates the default functionalities of the GroupButton and its various property like height, width, showroundedcorner, groupbuttonmode in a ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(259, 60, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Button / Group Buttons</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(347, 58, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n");
                EndContext();
                BeginContext(454, 51, true);
                WriteLiteral("            <div class=\"element\">\r\n                ");
                EndContext();
                BeginContext(505, 506, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-group-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "400388f52a8742a5887633c308196ce3", async() => {
                    BeginContext(643, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(665, 310, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-group-button-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bbf70629eed405085127c7f88e04e67", async() => {
                        BeginContext(687, 26, true);
                        WriteLiteral("\r\n                        ");
                        EndContext();
                        BeginContext(713, 54, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-group-button-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6a63600d984459b91036e1e5a61af09", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_GroupButtonBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.GroupButtonBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GroupButtonBaseItem);
                        __Syncfusion_JavaScript_Models_GroupButtonBaseItem.Text = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(767, 26, true);
                        WriteLiteral("\r\n                        ");
                        EndContext();
                        BeginContext(793, 55, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-group-button-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e2bd0ff1d54ef5b7eeecbf60eff596", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_GroupButtonBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.GroupButtonBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GroupButtonBaseItem);
                        __Syncfusion_JavaScript_Models_GroupButtonBaseItem.Text = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(848, 26, true);
                        WriteLiteral("\r\n                        ");
                        EndContext();
                        BeginContext(874, 56, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-group-button-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a18e58c2792b417782215fa188069487", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_GroupButtonBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.GroupButtonBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GroupButtonBaseItem);
                        __Syncfusion_JavaScript_Models_GroupButtonBaseItem.Text = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(930, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_GroupButtonBase = CreateTagHelper<global::Syncfusion.JavaScript.Models.GroupButtonBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GroupButtonBase);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(975, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GroupButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GroupButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GroupButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_GroupButtonProperties.Width = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 12 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Button\groupbuttons.cshtml"
__Syncfusion_JavaScript_Models_GroupButtonProperties.GroupButtonMode = GroupButtonMode.RadioButton;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("group-button-mode", __Syncfusion_JavaScript_Models_GroupButtonProperties.GroupButtonMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_GroupButtonProperties.Height = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 12 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Button\groupbuttons.cshtml"
__Syncfusion_JavaScript_Models_GroupButtonProperties.ShowRoundedCorner = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-rounded-corner", __Syncfusion_JavaScript_Models_GroupButtonProperties.ShowRoundedCorner, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1011, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(1064, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("StyleSection", async() => {
                BeginContext(1088, 273, true);
                WriteLiteral(@"
    <style>
        .frame, .control {
            width: 50%;
        }

            .frame .control, label {
                display: table;
                margin: 0 auto;
            }

        .element {
            width: 100%;
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
