#pragma checksum "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed27b736c106aa4a44825b7eb6843a5e9a4b099b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListBox_Icons), @"mvc.1.0.view", @"/Views/ListBox/Icons.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListBox/Icons.cshtml", typeof(AspNetCore.Views_ListBox_Icons))]
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
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed27b736c106aa4a44825b7eb6843a5e9a4b099b", @"/Views/ListBox/Icons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListBox_Icons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectmailtools"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "mailtoolslist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "220px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 53, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListBox / Icons</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(97, 159, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to pair an image with list items using the Syncfusion ASP.NET Core ListBox component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(284, 120, true);
                WriteLiteral("\r\n    <div class=\"control frame\">\r\n        <div class=\"ctrllabel\">\r\n            Select an item\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(404, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc59a0befc8426abdf1f8dc0f6a768c", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ListBoxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ListBoxProperties.TargetID = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ListBoxProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(493, 108, true);
                WriteLiteral("        \r\n        <div>\r\n            <ul id=\"mailtoolslist\">\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 601, "\"", 654, 1);
#line 15 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 607, Url.Content("~/images/listbox/Categorize.png"), 607, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(655, 114, true);
                WriteLiteral(" alt=\"Categorize\" />\r\n                    Categorize and Move</li>\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 769, "\"", 816, 1);
#line 18 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 775, Url.Content("~/images/listbox/Done.png"), 775, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(817, 93, true);
                WriteLiteral(" alt=\"Done\" />\r\n                    Done</li>\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 910, "\"", 957, 1);
#line 21 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 916, Url.Content("~/images/listbox/Flag.png"), 916, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(958, 100, true);
                WriteLiteral(" alt=\"Flag\" />\r\n                    Flag & Move</li>\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1058, "\"", 1108, 1);
#line 24 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 1064, Url.Content("~/images/listbox/Forward.png"), 1064, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1109, 99, true);
                WriteLiteral(" alt=\"Forward\" />\r\n                    Forward</li>\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1208, "\"", 1255, 1);
#line 27 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 1214, Url.Content("~/images/listbox/Move.png"), 1214, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1256, 103, true);
                WriteLiteral(" alt=\"Move\" />\r\n                    Move to Folder</li>\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1359, "\"", 1407, 1);
#line 30 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 1365, Url.Content("~/images/listbox/Email.png"), 1365, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1408, 101, true);
                WriteLiteral(" alt=\"E-mail\" />\r\n                    New E-mail</li>\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1509, "\"", 1559, 1);
#line 33 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 1515, Url.Content("~/images/listbox/Meeting.png"), 1515, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1560, 103, true);
                WriteLiteral(" alt=\"Meeting\" />\r\n                    New Meeting</li>\r\n                <li>\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1663, "\"", 1711, 1);
#line 36 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\ListBox\Icons.cshtml"
WriteAttributeValue("", 1669, Url.Content("~/images/listbox/Reply.png"), 1669, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1712, 105, true);
                WriteLiteral(" alt=\"Reply\" />\r\n                    Reply & Delete</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1842, 363, true);
                WriteLiteral(@"
    <style type=""text/css"">

        .ctrllabel {
            padding: 0px 0px 12px 3px;
            font-weight: 600;
        }

        .e-ddl-popup {
            margin: 0 auto;
        }

        img {
            padding-right: 10px;
            padding-top: 3px;
            width: 18px;
            height: 15px;
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