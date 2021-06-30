#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Accordion\OpenOnHover.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4eddaf3d51bb542c2ddf52eb963e3be7c8b1078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accordion_OpenOnHover), @"mvc.1.0.view", @"/Views/Accordion/OpenOnHover.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accordion/OpenOnHover.cshtml", typeof(AspNetCore.Views_Accordion_OpenOnHover))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4eddaf3d51bb542c2ddf52eb963e3be7c8b1078", @"/Views/Accordion/OpenOnHover.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Accordion_OpenOnHover : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET MVC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Javascript", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hoverAccordion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("events", "mouseover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.AccordionProperties __Syncfusion_JavaScript_Models_AccordionProperties;
        private global::Syncfusion.JavaScript.AccordionBase __Syncfusion_JavaScript_AccordionBase;
        private global::Syncfusion.JavaScript.AccordionBaseItem __Syncfusion_JavaScript_AccordionBaseItem;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 58, true);
                WriteLiteral(" <span class=\"sampleName\">Accordion / open on Hover</span>");
                EndContext();
            }
            );
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(111, 42, true);
                WriteLiteral("\r\n    <div style=\"width: 500px\">\r\n        ");
                EndContext();
                BeginContext(153, 2310, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-accordion", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f172584b6bf54e9487e19cec9fd2bc60", async() => {
                    BeginContext(206, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(220, 2218, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47ae8390ffc4daeafdccad31269b76f", async() => {
                        BeginContext(239, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(257, 610, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9dfd80fe4dd45ae9de5a3005cfcfe01", async() => {
                            BeginContext(290, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(312, 518, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d2e7f7959bb4c199ee31501e315a710", async() => {
                                BeginContext(332, 477, true);
                                WriteLiteral(@"
                        <div>
                            Essential Chart for ASP.NET MVC is a visually stunning, high-performance charting component that is easy to use.
                            It includes 35 chart types ranging from simple column charts to specialized financial charts.
                            The charts are highly customizable and have a powerful data model that makes data binding simple.
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
                            BeginContext(830, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_AccordionBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.AccordionBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_AccordionBaseItem);
                        __Syncfusion_JavaScript_AccordionBaseItem.Text = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(867, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(885, 775, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a30ee54c263c4c76a98784e445ae91cc", async() => {
                            BeginContext(922, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(944, 679, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a460245923843ac88aef3187da1bb43", async() => {
                                BeginContext(964, 638, true);
                                WriteLiteral(@"
                        <div>
                            The Model-View-Controller (MVC) architectural pattern separates an application into three main components:
                            the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication.

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
                            BeginContext(1623, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_AccordionBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.AccordionBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_AccordionBaseItem);
                        __Syncfusion_JavaScript_AccordionBaseItem.Text = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1660, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1678, 726, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17d63274a7494727ab4d16a1d8cfd45d", async() => {
                            BeginContext(1714, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1736, 631, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8818b72b8b16459da22f95f0cb095de8", async() => {
                                BeginContext(1756, 590, true);
                                WriteLiteral(@"
                        <div>
                            JavaScript (JS) is an interpreted computer programming language.
                            It was originally implemented as part of web browsers so that client-side scripts could interact with the user, control the browser,
                            communicate asynchronously, and alter the document content that was displayed. More recently, however,
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
                            BeginContext(2367, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_AccordionBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.AccordionBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_AccordionBaseItem);
                        __Syncfusion_JavaScript_AccordionBaseItem.Text = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2404, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_AccordionBase = CreateTagHelper<global::Syncfusion.JavaScript.AccordionBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_AccordionBase);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2438, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_AccordionProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AccordionProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AccordionProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_AccordionProperties.Events = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2463, 22, true);
                WriteLiteral("\r\n      \r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(2488, 2, true);
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
