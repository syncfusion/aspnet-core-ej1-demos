#pragma checksum "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\Menu\ContextMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "555e8ffb5d1d82effd34a9fcc504088684abb798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_ContextMenu), @"mvc.1.0.view", @"/Views/Menu/ContextMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/ContextMenu.cshtml", typeof(AspNetCore.Views_Menu_ContextMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"555e8ffb5d1d82effd34a9fcc504088684abb798", @"/Views/Menu/ContextMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_ContextMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Cut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Copy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Paste", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Links", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Clear Formatting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("docfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("context-menu-target", "#target", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.MenuProperties __Syncfusion_JavaScript_Models_MenuProperties;
        private global::Syncfusion.JavaScript.Models.MenuItem __Syncfusion_JavaScript_Models_MenuItem;
        private global::Syncfusion.JavaScript.Models.MenuBaseItem __Syncfusion_JavaScript_Models_MenuBaseItem;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 57, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Menu / Context-Menu</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(108, 592, true);
                WriteLiteral(@"
    <div id=""target"" class=""textarea"">
        HTML is written in the form of HTML elements consisting of tags enclosed in angle
        brackets (like &lt;html&gt; ),within the web page content. HTML tags most commonly
        come in pairs like and ,although some tags, known as empty elements, are unpaired,
        for example &lt;img&gt;. The purpose of a web browser is to read HTML documents
        and compose them into visible or audible web pages. The browser does not display
        the HTML tags, but uses the tags to interpret the content of the page.
    </div>
    ");
                EndContext();
                BeginContext(700, 538, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e33db052fc8452b8de13b9128ae1c0c", async() => {
                    BeginContext(807, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(817, 409, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90af7c77484942bbb11ccbcf37478495", async() => {
                        BeginContext(832, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(846, 45, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1beab6381cb641698db17ffb809c449b", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_MenuBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuBaseItem);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Text = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(891, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(905, 46, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cd6586125f4f27a1bf8146e39431ea", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_MenuBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuBaseItem);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Text = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(951, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(965, 47, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "758629b9e536436591cf7eb7542e19e1", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_MenuBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuBaseItem);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Text = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1012, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1026, 50, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7770be32071b4ebbbf846db8387d262b", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_MenuBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuBaseItem);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Text = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1076, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1090, 47, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "818087b825e9401fa7422ca5899d7937", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_MenuBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuBaseItem);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Text = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1137, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1151, 58, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e539954533e49148516158e3190cefe", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_MenuBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuBaseItem);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_MenuBaseItem.Text = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1209, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_MenuItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuItem>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuItem);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1226, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_MenuProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.MenuProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MenuProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 12 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\Menu\ContextMenu.cshtml"
__Syncfusion_JavaScript_Models_MenuProperties.MenuType = MenuType.ContextMenu;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("menu-type", __Syncfusion_JavaScript_Models_MenuProperties.MenuType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\Menu\ContextMenu.cshtml"
__Syncfusion_JavaScript_Models_MenuProperties.OpenOnClick = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("open-on-click", __Syncfusion_JavaScript_Models_MenuProperties.OpenOnClick, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_MenuProperties.ContextMenuTarget = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1238, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1271, 255, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        .textarea {\r\n            border: 1px solid;\r\n            padding: 10px;\r\n            position: relative;\r\n            text-align: justify;\r\n            width: 80%;\r\n            color: gray;\r\n        }\r\n    </style>\r\n");
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
