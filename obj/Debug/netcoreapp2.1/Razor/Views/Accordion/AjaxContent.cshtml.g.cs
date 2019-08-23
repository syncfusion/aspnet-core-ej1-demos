#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Accordion\AjaxContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4147ce2fbd70d119b2d28722a40eb65effa79b4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accordion_AjaxContent), @"mvc.1.0.view", @"/Views/Accordion/AjaxContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accordion/AjaxContent.cshtml", typeof(AspNetCore.Views_Accordion_AjaxContent))]
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
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4147ce2fbd70d119b2d28722a40eb65effa79b4b", @"/Views/Accordion/AjaxContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Accordion_AjaxContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Model–view–controller (MVC)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "WPF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "WCF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ajaxAccordion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 62, true);
                WriteLiteral(" <span class=\"sampleName\">Accordion / Ajax Content Load</span>");
                EndContext();
            }
            );
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(115, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(123, 2016, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-accordion", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac6bb29d3ff4d18b53d3849785eb39d", async() => {
                    BeginContext(156, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(166, 1952, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be385ff8af4445e9a5fbf753e7be28f0", async() => {
                        BeginContext(185, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(199, 331, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3478354f5f274be5af8c3a784caa7810", async() => {
                            BeginContext(252, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(270, 227, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7743c776642f47f0b1b6591da2db8df4", async() => {
                                BeginContext(290, 59, true);
                                WriteLiteral("\r\n                    <div>\r\n                        <h3><a");
                                EndContext();
                                BeginWriteAttribute("href", " href=\"", 349, "\"", 419, 1);
#line 10 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Accordion\AjaxContent.cshtml"
WriteAttributeValue("", 356, Url.Content("~/Views/Accordion/samplecontent/mvccontent.html"), 356, 63, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(420, 56, true);
                                WriteLiteral("></a></h3>\r\n                    </div>\r\n                ");
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
                            BeginContext(497, 14, true);
                            WriteLiteral("\r\n            ");
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
                        BeginContext(530, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(544, 307, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573e783e6d1f4d648c5de96a8ad56865", async() => {
                            BeginContext(573, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(591, 227, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae4f24556114519971aa334c8c4f5f6", async() => {
                                BeginContext(611, 59, true);
                                WriteLiteral("\r\n                    <div>\r\n                        <h3><a");
                                EndContext();
                                BeginWriteAttribute("href", " href=\"", 670, "\"", 740, 1);
#line 17 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Accordion\AjaxContent.cshtml"
WriteAttributeValue("", 677, Url.Content("~/Views/Accordion/samplecontent/wpfcontent.html"), 677, 63, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(741, 56, true);
                                WriteLiteral("></a></h3>\r\n                    </div>\r\n                ");
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
                            BeginContext(818, 14, true);
                            WriteLiteral("\r\n            ");
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
                        BeginContext(851, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(865, 1223, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d63a6f7cc0747949d6655447541883f", async() => {
                            BeginContext(894, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(912, 1143, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23daa16ad95a4b7d9cb29d4d2c9baff9", async() => {
                                BeginContext(932, 1102, true);
                                WriteLiteral(@"
                    <div>
                        <p>
                            WCF is a tool often used to implement and deploy a service-oriented architecture (SOA).
                            It is designed using service-oriented architecture principles to support distributed computing where services have remote consumers.
                            Clients can consume multiple services; services can be consumed by multiple clients. Services are loosely coupled to each other.
                            Services typically have a WSDL interface (Web Services Description Language) that any WCF client can use to consume the service, regardless of which platform the service is hosted on.
                            WCF implements many advanced Web services (WS) standards such as WS-Addressing, WS-ReliableMessaging and WS-Security.
                            With the release of .NET Framework 4.0, WCF also provides RSS Syndication Services, WS-Discovery, routing and better support for REST service");
                                WriteLiteral("s.\r\n                        </p>\r\n                    </div>\r\n                ");
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
                            BeginContext(2055, 14, true);
                            WriteLiteral("\r\n            ");
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
                        BeginContext(2088, 10, true);
                        WriteLiteral("\r\n        ");
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
                    BeginContext(2118, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_AccordionProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AccordionProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AccordionProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2139, 4, true);
                WriteLiteral("\r\n\r\n");
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
