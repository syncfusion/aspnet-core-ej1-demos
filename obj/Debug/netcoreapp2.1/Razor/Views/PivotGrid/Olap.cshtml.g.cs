#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\PivotGrid\Olap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5a4ca99e93ab55e9825984636b691df1a6dbd0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PivotGrid_Olap), @"mvc.1.0.view", @"/Views/PivotGrid/Olap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PivotGrid/Olap.cshtml", typeof(AspNetCore.Views_PivotGrid_Olap))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\PivotGrid\Olap.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a4ca99e93ab55e9825984636b691df1a6dbd0c", @"/Views/PivotGrid/Olap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_PivotGrid_Olap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Customer].[Customer Geography]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Product].[Product Categories]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Measures].[Internet Sales Amount]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "[Measures].[Growth in Customer Base Trend]", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("catalog", "Adventure Works DW 2008 SE", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cube", "Adventure Works", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data", "//bi.syncfusion.com/olap/msmdpump.dll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PivotGrid1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.PivotGridProperties __Syncfusion_JavaScript_Models_PivotGridProperties;
        private global::Syncfusion.JavaScript.Models.PivotDataSource __Syncfusion_JavaScript_Models_PivotDataSource;
        private global::Syncfusion.JavaScript.PivotGridTagHelperMocks __Syncfusion_JavaScript_PivotGridTagHelperMocks;
        private global::Syncfusion.JavaScript.Models.Field __Syncfusion_JavaScript_Models_Field;
        private global::Syncfusion.JavaScript.Models.MeasuresItems __Syncfusion_JavaScript_Models_MeasuresItems;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(54, 49, true);
                WriteLiteral("<span class=\"sampleName\">PivotGrid / Olap</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(124, 170, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo for Syncfusion Essential JS1 for ASP.NET Core Pivot Grid control shows how to bind OLAP Cube data from SSAS (XML/A).\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(322, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(324, 904, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pivot-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6bb57ec5374ef4bd4ab7b85e8fe863", async() => {
                    BeginContext(376, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(382, 828, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-data-source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b800b004cd624cb98258d44bb5d05f91", async() => {
                        BeginContext(502, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(512, 125, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-rows", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "745a6fed98e14729ac4ba5638cc2b517", async() => {
                            BeginContext(526, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(540, 72, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-row-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd34357949d450eaf759ac75d5d9053", async() => {
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
                            BeginContext(612, 10, true);
                            WriteLiteral("\r\n        ");
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
                        BeginContext(637, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(647, 136, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0780e96eaf64812ae24761a88521c16", async() => {
                            BeginContext(664, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(678, 77, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bc74d9671c848299073071e686b20e7", async() => {
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
                            BeginContext(755, 10, true);
                            WriteLiteral("\r\n        ");
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
                        BeginContext(783, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(793, 395, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-values", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e451d94ae78411e9bfe85ff904b0429", async() => {
                            BeginContext(809, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(823, 338, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-value-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8aaf24416d44b3fba3c448024af40a1", async() => {
                                BeginContext(852, 18, true);
                                WriteLiteral("\r\n                ");
                                EndContext();
                                BeginContext(870, 261, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measures", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3695af33e1a34a53afd4b7ff2f927988", async() => {
                                    BeginContext(882, 22, true);
                                    WriteLiteral("\r\n                    ");
                                    EndContext();
                                    BeginContext(904, 83, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measure-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31e090b6120b4135aa45cedceb71719c", async() => {
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
                                    BeginContext(987, 22, true);
                                    WriteLiteral("\r\n                    ");
                                    EndContext();
                                    BeginContext(1009, 91, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-measure-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b9fc4774f14bac919ce308af0ba133", async() => {
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_MeasuresItems = CreateTagHelper<global::Syncfusion.JavaScript.Models.MeasuresItems>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_MeasuresItems);
                                    __Syncfusion_JavaScript_Models_MeasuresItems.FieldName = (string)__tagHelperAttribute_3.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1100, 18, true);
                                    WriteLiteral("\r\n                ");
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
                                BeginContext(1131, 14, true);
                                WriteLiteral("\r\n            ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
#line 16 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\PivotGrid\Olap.cshtml"
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
                            BeginContext(1161, 10, true);
                            WriteLiteral("\r\n        ");
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
                        BeginContext(1188, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_PivotDataSource = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotDataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotDataSource);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Catalog = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Cube = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Syncfusion_JavaScript_Models_PivotDataSource.Data = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1210, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_PivotGridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotGridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotGridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 7 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\PivotGrid\Olap.cshtml"
__Syncfusion_JavaScript_Models_PivotGridProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_PivotGridProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1228, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1255, 223, true);
                WriteLiteral("\r\n    <style>\r\n        #PivotGrid1 {\r\n            width: 100%;\r\n            height: 350px;\r\n            overflow: auto;\r\n        }\r\n        .cols-sample-area {\r\n            width: 100% !important;\r\n        }\r\n    </style>\r\n");
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
