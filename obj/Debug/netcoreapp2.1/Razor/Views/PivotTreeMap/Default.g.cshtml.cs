#pragma checksum "D:\Work\GitHub\aspnet-core-ej1-demos\Views\PivotTreeMap\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e50e7e3fb8e3de4557d57d9cc73eb3f39360873f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PivotTreeMap_Default), @"mvc.1.0.view", @"/Views/PivotTreeMap/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PivotTreeMap/Default.cshtml", typeof(AspNetCore.Views_PivotTreeMap_Default))]
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
#line 1 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\PivotTreeMap\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50e7e3fb8e3de4557d57d9cc73eb3f39360873f", @"/Views/PivotTreeMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_PivotTreeMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Customer].[Customer Geography]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Date].[Fiscal]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Measures].[Customer Count]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("catalog", "Adventure Works DW 2008 SE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cube", "Adventure Works", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data", "//bi.syncfusion.com/olap/msmdpump.dll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PivotTreeMap1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.PivotTreeMapProperties __Syncfusion_JavaScript_Models_PivotTreeMapProperties;
        private global::Syncfusion.JavaScript.Models.PivotDataSource __Syncfusion_JavaScript_Models_PivotDataSource;
        private global::Syncfusion.JavaScript.PivotGridTagHelperMocks __Syncfusion_JavaScript_PivotGridTagHelperMocks;
        private global::Syncfusion.JavaScript.Models.Field __Syncfusion_JavaScript_Models_Field;
        private global::Syncfusion.JavaScript.Models.MeasuresItems __Syncfusion_JavaScript_Models_MeasuresItems;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(54, 55, true);
                WriteLiteral("<span class=\"sampleName\">PivotTreeMap / Default</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(130, 182, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo for Syncfusion Essential JS1 for ASP.NET Core pivot tree map control describes how to bind the OLAP cube data from SSAS (XML/A).\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(340, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(346, 821, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pivot-treemap", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccbcc7c1e91b4408bf1f69468523c733", async() => {
                    BeginContext(383, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(393, 749, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-data-source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a94f4a70b854dbfac9e8ebbb0ccfc42", async() => {
                        BeginContext(513, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(527, 133, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-rows", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c112ca61144adb98f309cf94a5f4f3", async() => {
                            BeginContext(541, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(559, 72, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-row-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c50cd0374bed48abba6d9bd758506539", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(631, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(660, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(674, 129, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "245083f20752434d986ecf42ace7cb61", async() => {
                            BeginContext(691, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(709, 62, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1933b9d25ceb44e89f63759e02e73a09", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_1.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(771, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(803, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(817, 299, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-values", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b88527babb149878a51ad3e7766e4a3", async() => {
                            BeginContext(833, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(851, 234, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-value-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94d3078790054d4bbb783072b75e7e18", async() => {
                                BeginContext(880, 22, true);
                                WriteLiteral("\r\n                    ");
                                EndContext();
                                BeginContext(902, 149, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measures", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975108b33d41463b96b4fbe33c24209e", async() => {
                                    BeginContext(914, 26, true);
                                    WriteLiteral("\r\n                        ");
                                    EndContext();
                                    BeginContext(940, 76, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measure-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a27ddb32b5c4a79b9ff5c9ed2996a1a", async() => {
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_MeasuresItems = CreateTagHelper<global::Syncfusion.JavaScript.Models.MeasuresItems>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MeasuresItems);
                                    __Syncfusion_JavaScript_Models_MeasuresItems.FieldName = (string)__tagHelperAttribute_2.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1016, 22, true);
                                    WriteLiteral("\r\n                    ");
                                    EndContext();
                                }
                                );
                                __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1051, 18, true);
                                WriteLiteral("\r\n                ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
#line 16 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\PivotTreeMap\Default.cshtml"
__Syncfusion_JavaScript_Models_Field.Axis = global::Syncfusion.JavaScript.AxisName.Column;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("axis", __Syncfusion_JavaScript_Models_Field.Axis, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1085, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_PivotGridTagHelperMocks = CreateTagHelper<global::Syncfusion.JavaScript.PivotGridTagHelperMocks>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_PivotGridTagHelperMocks);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1116, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_PivotDataSource = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotDataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotDataSource);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Catalog = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Cube = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Data = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1142, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_PivotTreeMapProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotTreeMapProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotTreeMapProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1167, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1195, 582, true);
                WriteLiteral(@"
        <!--Tooltip labels can be localized here-->
<script id=""tooltipTemplate"" type=""application/jsrender"">
    <div style=""background:White; color:black; font-size:12px; font-weight:normal; border: 1px solid #4D4D4D; white-space: nowrap;border-radius: 2px; margin-right: 25px; min-width: 110px;padding-right: 5px; padding-left: 5px; padding-bottom: 2px ;width: auto; height: auto;"">
        <div>Measure(s) : {{:~Measures(#data)}}</div><div>Row : {{:~Row(#data)}}</div><div>Column : {{:~Column(#data)}}</div><div>Value : {{:~Value(#data)}}</div>
    </div>
</script>
    ");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1802, 184, true);
                WriteLiteral("\r\n    <style>\r\n        #PivotTreeMap1 {\r\n            width: 100%;\r\n            height: 450px;\r\n            min-height: 275px; \r\n            min-width: 525px;\r\n        }\r\n    </style>\r\n");
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
