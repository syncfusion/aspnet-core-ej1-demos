#pragma checksum "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\RTE\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b288e6fcf2f9fa92ed31eb2ce7960e4ee9c32d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RTE_Default), @"mvc.1.0.view", @"/Views/RTE/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RTE/Default.cshtml", typeof(AspNetCore.Views_RTE_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b288e6fcf2f9fa92ed31eb2ce7960e4ee9c32d6", @"/Views/RTE/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_RTE_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RteTaghelper"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RTEproperties __Syncfusion_JavaScript_Models_RTEproperties;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(32, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 45, "\"", 109, 1);
#line 2 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\RTE\Default.cshtml"
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
                BeginContext(148, 78, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">RichTextEditor / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(254, 14, true);
                WriteLiteral(" \r\n     \r\n    ");
                EndContext();
                BeginContext(268, 1297, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rte", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fab1a06ad5d4729bd5a28328d05aaa5", async() => {
                    BeginContext(315, 11, true);
                    WriteLiteral(" \r\n        ");
                    EndContext();
                    BeginContext(326, 1222, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e08d50793c7d42de8fef8d507af2d529", async() => {
                        BeginContext(346, 1181, true);
                        WriteLiteral(@"<div>
    &lt;p&gt;&lt;b&gt;Description:&lt;/b&gt;&lt;/p&gt;
    &lt;p&gt;The Rich Text Editor (RTE) control is an easy to render in
    client side. Customer easy to edit the contents and get the HTML content for
    the displayed content. A rich text editor control provides users with a toolbar
    that helps them to apply rich text formats to the text entered in the text
    area. &lt;/p&gt;
    &lt;p&gt;&lt;b&gt;Functional
    Specifications/Requirements:&lt;/b&gt;&lt;/p&gt;
    &lt;ol&gt;&lt;li&gt;&lt;p&gt;Provide
    the tool bar support, it’s also customizable.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Options
    to get the HTML elements with styles.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Support
    to insert image from a defined path.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Footer
    elements and styles(tag / Element information , Action button (Upload, Cancel))&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Re-size
    the editor support. &lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Provide
    effi");
                        WriteLiteral("cient public methods and client side events.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Keyboard\r\n    navigation support.&lt;/p&gt;&lt;/li&gt;&lt;/ol&gt;\r\n</div>");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1548, 8, true);
                    WriteLiteral("  \r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_RTEproperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RTEproperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RTEproperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 8 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\RTE\Default.cshtml"
__Syncfusion_JavaScript_Models_RTEproperties.AllowEditing = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-editing", __Syncfusion_JavaScript_Models_RTEproperties.AllowEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1565, 9, true);
                WriteLiteral("\r\n   \r\n\r\n");
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
