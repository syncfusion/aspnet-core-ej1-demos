#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\ListBox\KeyboardInteraction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05145ad2ac3eecad9b3aed2d52e4596714d9420c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListBox_KeyboardInteraction), @"mvc.1.0.view", @"/Views/ListBox/KeyboardInteraction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListBox/KeyboardInteraction.cshtml", typeof(AspNetCore.Views_ListBox_KeyboardInteraction))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05145ad2ac3eecad9b3aed2d52e4596714d9420c", @"/Views/ListBox/KeyboardInteraction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListBox_KeyboardInteraction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "font", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "font", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fontnames"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 68, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListBox / Keyboard Interaction</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(112, 174, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to access the Syncfusion ASP.NET Core ListBox component functionalities using keyboard interactions.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(314, 131, true);
                WriteLiteral("\r\n        <div class=\"control frame\">\r\n            <div class=\"ctrllabel\">\r\n                Select a font style</div>\r\n            ");
                EndContext();
                BeginContext(445, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45fed5599f5849e08e6eb881c217b8b1", async() => {
                    BeginContext(505, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(523, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-list-box-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d5ed7114b3f410d8db3e3e8b96bc822", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ListBoxFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxFields);
                    __Syncfusion_JavaScript_Models_ListBoxFields.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_Models_ListBoxFields.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(569, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ListBoxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 10 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\ListBox\KeyboardInteraction.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ListBoxProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(597, 30, true);
                WriteLiteral("            \r\n        </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(657, 1457, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3"">
         Alt + J
        </div>
        <div class=""col-md-3"">
            Focuses the control
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
         Up
        </div>
        <div class=""col-md-3"">
            Navigates upwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
         Down
        </div>
        <div class=""col-md-3"">
            Navigates downwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
         Left
        </div>
        <div class=""col-md-3"">
            Navigates upwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
         Right
        </div>
        <div class=""col-md-3"">
            Navigates downwards
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
         Home
        </div>
        <div class=""col-md-3"">
           ");
                WriteLiteral(@" Navigates to the starting item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
         End
        </div>
        <div class=""col-md-3"">
            Navigates to the ending item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
         Enter
        </div>
        <div class=""col-md-3"">
            Selects the focused item
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2140, 537, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var target;
        $(function () {
            //Control focus key
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    var target = $('#fontnames').data(""ejListBox"");
                    target.selectItemByIndex(0);
                    $(""#fontnames_container"").focus();
                }
            });
            $(""#sampleProperties"").ejPropertiesPanel();
        });
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2702, 235, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .ctrllabel {\r\n            padding: 5px 0px 12px 3px;\r\n            font-weight: 600;\r\n        }\r\n\r\n        .e-ddl-popup {\r\n            margin: 0 auto;\r\n        }\r\n\r\n    </style>\r\n");
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
