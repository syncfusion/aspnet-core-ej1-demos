#pragma checksum "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fa51141ad7d508483ddd7503b3760affc3b3cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pager_Methods), @"mvc.1.0.view", @"/Views/Pager/Methods.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pager/Methods.cshtml", typeof(AspNetCore.Views_Pager_Methods))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa51141ad7d508483ddd7503b3760affc3b3cdd", @"/Views/Pager/Methods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pager_Methods : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pager"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "pagerChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pageCount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "pageChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("currentPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "currentPageChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pageSize"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "pageSizeChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("recordsCount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "recrodsCountChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.PagerProperties __Syncfusion_JavaScript_Models_PagerProperties;
        private global::Syncfusion.JavaScript.Models.EditorProperties __Syncfusion_JavaScript_Models_EditorProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(18, 173, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates the pager various properties like pagesize, pagecount,totalpages and totalrecordscount in a ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            BeginContext(194, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(219, 53, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Pager / Methods</span>");
                EndContext();
            }
            );
            BeginContext(275, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(302, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(372, 128, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7ab17f1b61a480d87ec43f8ec6211ed", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_PagerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PagerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PagerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 11 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.PageCount = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __Syncfusion_JavaScript_Models_PagerProperties.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.PageSize = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __Syncfusion_JavaScript_Models_PagerProperties.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_PagerProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.TotalRecordsCount = 20;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("total-records-count", __Syncfusion_JavaScript_Models_PagerProperties.TotalRecordsCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_PagerProperties.Change = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(500, 31, true);
                WriteLiteral("\r\n         </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(561, 141, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Page Count\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(702, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-numeric-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d839605be8b24e03bb9759613d435ab2", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 21 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.MinValue = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-value", __Syncfusion_JavaScript_Models_EditorProperties.MinValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(798, 148, true);
                WriteLiteral("\r\n         </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">Current Page</div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(946, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-numeric-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f75b49862d5741149784e4a138f8b87b", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 27 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.MinValue = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-value", __Syncfusion_JavaScript_Models_EditorProperties.MinValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1051, 142, true);
                WriteLiteral("\r\n       </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">PageSize</div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(1193, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-numeric-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74a2505956294c5cb03f261fc1feaa37", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 33 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.MinValue = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-value", __Syncfusion_JavaScript_Models_EditorProperties.MinValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.MaxValue = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("max-value", __Syncfusion_JavaScript_Models_EditorProperties.MaxValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 33 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1306, 148, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">Records Count</div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(1454, 108, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-numeric-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e142034cbb2d4f1587feded277ae9063", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#line 39 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.MinValue = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("min-value", __Syncfusion_JavaScript_Models_EditorProperties.MinValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pager\Methods.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 20;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_EditorProperties.Change = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1562, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1618, 2179, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });

        function pagerChange(args) {
            pagerObj = $(""#pager"").ejPager(""instance"");
            currentpageObj = $(""#currentPage"").ejNumericTextbox(""instance"");
            currentpageObj.option(""value"", pagerObj.model.currentPage);
        }
        function pageChange(args) {
            pagerObj = $(""#pager"").ejPager(""instance"");
            pageCountObj = $(""#pageCount"").ejNumericTextbox(""instance"");
            if (args.value < 8) {
                pagerObj.option(""pageCount"", args.value);
            }
            else {
                pagerObj.option(""pageCount"", 8);
                pageCountObj.option(""maxValue"", 8);
            }

        }
        function currentPageChange(args) {
            currentpageObj = $(""#currentPage"").ejNumericTextbox(""instance"");
            pagerObj = $(""#pager"").ejPager(""instance"");
            pageCountObj");
                WriteLiteral(@" = $(""#pageCount"").ejNumericTextbox(""instance"");
            pagerObj.option(""currentPage"", args.value);
            currentpageObj.option(""maxValue"", pagerObj.model.totalPages);

        }

        function pageSizeChange(args) {
            currentpageObj = $(""#currentPage"").ejNumericTextbox(""instance"");
            pagerObj = $(""#pager"").ejPager(""instance"");
            pageCountObj = $(""#pageCount"").ejNumericTextbox(""instance"");
            pagerObj.option(""pageSize"", args.value);
            currentpageObj.option(""maxValue"", pagerObj.model.totalPages);
            pageCountObj.option(""maxValue"", pagerObj.model.totalPages);

        }

        function recrodsCountChange(args) {
            pagerObj = $(""#pager"").ejPager(""instance"");
            pageCountObj = $(""#pageCount"").ejNumericTextbox(""instance"");
            currentpageObj = $(""#currentPage"").ejNumericTextbox(""instance"");
            pagerObj.option(""totalRecordsCount"", args.value);
            currentpageObj.option(""maxValue");
                WriteLiteral("\", pagerObj.model.totalPages);\r\n            pageCountObj.option(\"maxValue\", pagerObj.model.totalPages);\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(3822, 85, true);
                WriteLiteral("\r\n    <style>\r\n        .frame {\r\n            width: 650px;\r\n        }\r\n    </style>\r\n");
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
