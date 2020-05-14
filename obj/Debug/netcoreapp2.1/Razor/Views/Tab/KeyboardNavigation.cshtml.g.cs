#pragma checksum "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\Tab\KeyboardNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a79e7c944133de94635f898c76e6e4a1c19b44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tab_KeyboardNavigation), @"mvc.1.0.view", @"/Views/Tab/KeyboardNavigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tab/KeyboardNavigation.cshtml", typeof(AspNetCore.Views_Tab_KeyboardNavigation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a79e7c944133de94635f898c76e6e4a1c19b44", @"/Views/Tab/KeyboardNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Tab_KeyboardNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "ASP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "MVC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET MVC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "Mobile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Javascript", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tabSample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TabProperties __Syncfusion_JavaScript_Models_TabProperties;
        private global::Syncfusion.JavaScript.Models.TabBase __Syncfusion_JavaScript_Models_TabBase;
        private global::Syncfusion.JavaScript.Models.TabBaseItem __Syncfusion_JavaScript_Models_TabBaseItem;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 57, true);
                WriteLiteral(" <span class=\"sampleName\">Tab / KeyboardNavigation</span>");
                EndContext();
            }
            );
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(110, 44, true);
                WriteLiteral("\r\n\r\n    <div style=\"width: 550px\">\r\n        ");
                EndContext();
                BeginContext(154, 2274, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tab", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9b1e86e52584c0c848c071b3b5ae73a", async() => {
                    BeginContext(177, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(191, 2218, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0d8da988ee4421dba69d20255b4453c", async() => {
                        BeginContext(204, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(222, 653, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fe4d74c2d484265a01761da629dc807", async() => {
                            BeginContext(258, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(280, 564, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d4b3bb2ed6443298fa216e5e7d1a3c", async() => {
                                BeginContext(300, 523, true);
                                WriteLiteral(@"
                        <div>
                            Microsoft ASP.NET is a set of technologies in the Microsoft .NET Framework for building Web applications and XML Web services. ASP.NET pages execute on the server and generate markup such as HTML, WML, or XML that is sent to a desktop or mobile browser. ASP.NET pages use a compiled, event-driven programming model that improves performance and enables the separation of application logic and user interface.
                        </div>
                    ");
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
                            BeginContext(844, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_TabBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBaseItem);
                        __Syncfusion_JavaScript_Models_TabBaseItem.ID = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_TabBaseItem.Text = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(875, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(893, 741, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90eec1dcb9744a83b032eb854cec0034", async() => {
                            BeginContext(933, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(955, 648, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbfd2a9b00f54250981a976cc42bde3d", async() => {
                                BeginContext(975, 607, true);
                                WriteLiteral(@"
                        <div>
                            The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication.
                        </div>
                    ");
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
                            BeginContext(1603, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_TabBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBaseItem);
                        __Syncfusion_JavaScript_Models_TabBaseItem.ID = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_TabBaseItem.Text = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1634, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1652, 729, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b356b3ddf80480bb103190ee7f723d0", async() => {
                            BeginContext(1694, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1716, 634, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d8ea239ed64ec48458571bd402fffe", async() => {
                                BeginContext(1736, 593, true);
                                WriteLiteral(@"
                        <div>
                            JavaScript (JS) is an interpreted computer programming language.
                            It was originally implemented as part of web browsers so that client-side scripts could interact with the user, control the browser,
                            communicate asynchronously, and alter the document content that was displayed.[5] More recently, however,
                            it has become common in both game development and the creation of desktop applications.
                        </div>
                    ");
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
                            BeginContext(2350, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_TabBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBaseItem);
                        __Syncfusion_JavaScript_Models_TabBaseItem.ID = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_Models_TabBaseItem.Text = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2381, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_TabBase = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBase);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2409, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_TabProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2428, 16, true);
                WriteLiteral("\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(2474, 933, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + j
        </div>
        <div class=""col-md-3"">
            Focuses the control.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Up / Left
        </div>
        <div class=""col-md-3"">
            Selected previous item.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down / Right
        </div>
        <div class=""col-md-3"">
            Selected next item.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Home
        </div>
        <div class=""col-md-3"">
            Selected first item.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            End
        </div>
        <div class=""col-md-3"">
            Selected last item.
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(3433, 310, true);
                WriteLiteral(@"
    <script>
        $(document).on(""keydown"", function (e) {
            if (e.altKey && e.keyCode === 74) { // j- key code.
                $(""#tabSample ul a"").focus();
            }
        });
        $(document).ready(function () { $(""#sampleProperties"").ejPropertiesPanel(); });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3746, 2, true);
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
