#pragma checksum "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Accordion\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52e82ff8a8934aceef5701388741d97d91fee40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accordion_Events), @"mvc.1.0.view", @"/Views/Accordion/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accordion/Events.cshtml", typeof(AspNetCore.Views_Accordion_Events))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a52e82ff8a8934aceef5701388741d97d91fee40", @"/Views/Accordion/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Accordion_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET MVC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Javascript", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("eventAccordion"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "onCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-error", "onError", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("before-activate", "onBeforeActivate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("activate", "onActivate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("before-in-activate", "onBeforeInActivate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("in-activate", "onInActivate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-before-load", "onBeforeLoad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-load", "onLoad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-success", "onAjaxSuccess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectControls_input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "dropTarget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "160px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "evtpropscheckedevent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 51, true);
                WriteLiteral(" <span class=\"sampleName\">Accordion / Events</span>");
                EndContext();
            }
            );
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(104, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(112, 2414, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-accordion", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c1c11f651d645d6bd13ee87a255583c", async() => {
                    BeginContext(389, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(399, 2106, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98a39f84d6444d42b5b9fecb34866939", async() => {
                        BeginContext(418, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(432, 578, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbdeb33b12a345cba453898fa610cd07", async() => {
                            BeginContext(465, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(483, 494, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42d56b0ef96d4fe5864572fad7815322", async() => {
                                BeginContext(503, 453, true);
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
                            BeginContext(977, 14, true);
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
                        BeginContext(1010, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1024, 747, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500f74b3f85946d3a5d4f9c6bcfea47e", async() => {
                            BeginContext(1061, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(1079, 659, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f978def1c31244ab86a5c92079d9efe6", async() => {
                                BeginContext(1099, 618, true);
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
                            BeginContext(1738, 14, true);
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
                        BeginContext(1771, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1785, 690, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-accordion-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "081f2ca4d6e54d82a0153cfe32196ed6", async() => {
                            BeginContext(1821, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(1839, 603, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e4a7e08307b42d4a39d32f583240499", async() => {
                                BeginContext(1859, 562, true);
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
                            BeginContext(2442, 14, true);
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
                        BeginContext(2475, 10, true);
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
                    BeginContext(2505, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_AccordionProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AccordionProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AccordionProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_AccordionProperties.Create = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_AccordionProperties.AjaxError = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_AccordionProperties.BeforeActivate = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_AccordionProperties.Activate = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_AccordionProperties.BeforeInActivate = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_AccordionProperties.InActivate = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_AccordionProperties.AjaxBeforeLoad = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_AccordionProperties.AjaxLoad = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_AccordionProperties.AjaxSuccess = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2526, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            BeginContext(2535, 319, true);
            WriteLiteral(@"<div id=""dropTarget"">
    <ul>
        <li>create</li>
        <li>beforeActivate</li>
        <li>activate</li>
        <li>beforeInactivate</li>
        <li>inActivate</li>
        <li>ajaxBeforeLoad</li>
        <li>ajaxLoad</li>
        <li>ajaxSuccess</li>
        <li>ajaxError</li>
    </ul>
</div>
");
            EndContext();
            DefineSection("EventsDropdown", async() => {
                BeginContext(2878, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2886, 172, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36dfdd41b7e74fddbe1e05f4982720fd", async() => {
                    BeginContext(3036, 2, true);
                    WriteLiteral("  ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
#line 53 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Accordion\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-checkbox", __Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
#line 53 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Accordion\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("check-all", __Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_16.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3058, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(3086, 2997, true);
                WriteLiteral(@"
    <script>
        function onCreate(args) {
            jQuery.addEventLog(""Accordion has been <span class='eventTitle'>created</span>."");
        }
        function onBeforeActivate(args) {
            if (!ej.isNullOrUndefined(args.activeIndex))
                jQuery.addEventLog(""<span class='eventTitle'>BeforeActiveClick</span> event is fired for Index "" + args.activeIndex + ""."");
        }
        function onActivate(args) {
            if (!ej.isNullOrUndefined(args.activeIndex))
                jQuery.addEventLog(""<span class='eventTitle'>ActiveClick</span> event is fired for Index "" + args.activeIndex + ""."");
        }
        function onBeforeInActivate(args) {
            if (!ej.isNullOrUndefined(args.inActiveIndex))
                jQuery.addEventLog(""Index "" + args.inActiveIndex + "" is on <span class='eventTitle'>BeforeInActive</span>."");
        }
        function onInActivate(args) {
            if (!ej.isNullOrUndefined(args.inActiveIndex))
                jQuery.addEven");
                WriteLiteral(@"tLog(""Index "" + args.inActiveIndex + "" is on <span class='eventTitle'>inActive</span>."");
        }
        function onBeforeLoad(args) {
            jQuery.addEventLog(""<span class='eventTitle'>BeforeLoad</span> event is fired."");
        }
        function onLoad(args) {
            jQuery.addEventLog(""Ajax content is <span class='eventTitle'>loaded</span>."");
        }
        function onAjaxSuccess(args) {
            jQuery.addEventLog(""Ajax content is loaded <span class='eventTitle'>successfully</span>."");
        }
        function onError(args) {
            jQuery.addEventLog(""Ajax content is loaded with an <span class='eventTitle'>error</span>."");
        }
        function onClear() {
            jQuery.clearEventLog();
        }
        function evtpropscheckedevent(args) {
            acrdnObj = $(""#eventAccordion"").data(""ejAccordion"");
            if (args.isChecked) {
                switch (args.selectedText) {
                    case ""create"": acrdnObj.option(args.select");
                WriteLiteral(@"edText, ""onCreate""); break;
                    case ""beforeActivate"": acrdnObj.option(args.selectedText, ""onBeforeActivate""); break;
                    case ""activate"": acrdnObj.option(args.selectedText, ""onActivate""); break;
                    case ""beforeInactivate"": acrdnObj.option(args.selectedText, ""onBeforeInActivate""); break;
                    case ""inActivate"": acrdnObj.option(args.selectedText, ""onInActivate""); break;
                    case ""ajaxBeforeLoad"": acrdnObj.option(args.selectedText, ""onBeforeLoad""); break;
                    case ""ajaxLoad"": acrdnObj.option(args.selectedText, ""onLoad""); break;
                    case ""ajaxSuccess"": acrdnObj.option(args.selectedText, ""onAjaxSuccess""); break;
                    case ""ajaxError"": acrdnObj.option(args.selectedText, ""onError""); break;
                }
            }
            else acrdnObj.option(args.selectedText, null);
        }
    </script>
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
