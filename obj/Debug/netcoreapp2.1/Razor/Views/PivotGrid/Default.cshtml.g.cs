#pragma checksum "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\PivotGrid\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0168b29921f92620a749d010853c7c2a09a543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PivotGrid_Default), @"mvc.1.0.view", @"/Views/PivotGrid/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PivotGrid/Default.cshtml", typeof(AspNetCore.Views_PivotGrid_Default))]
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
#line 1 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\PivotGrid\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0168b29921f92620a749d010853c7c2a09a543", @"/Views/PivotGrid/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_PivotGrid_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-caption", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-caption", "Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-name", "Amount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field-caption", "Amount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("format", "currency", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PivotGrid1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load", "onload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(54, 52, true);
                WriteLiteral("<span class=\"sampleName\">PivotGrid / Default</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(127, 186, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo for Syncfusion Essential JS1 for ASP.NET Core Pivot Grid control shows how to bind pivot data which is in JSON format at script-side\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(341, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(343, 625, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pivot-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ba4831173f42b8b4037aced844542f", async() => {
                    BeginContext(472, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(478, 472, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-data-source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1da813284f4fcd831bb47b1c622e81", async() => {
                        BeginContext(493, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(503, 125, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-rows", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b821925ea94baebb8643747670feac", async() => {
                            BeginContext(517, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(531, 72, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-row-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da80a93be0ae4fffaf03d42d5b25b099", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            __Syncfusion_JavaScript_Models_Field.FieldCaption = (string)__tagHelperAttribute_1.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(603, 10, true);
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
                        BeginContext(628, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(638, 131, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddd59c7095bf49dfbd9b1ebce5a4c483", async() => {
                            BeginContext(655, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(669, 72, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e2ef6da15a45ea80d2462903a80821", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_2.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                            __Syncfusion_JavaScript_Models_Field.FieldCaption = (string)__tagHelperAttribute_3.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(741, 10, true);
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
                        BeginContext(769, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(779, 149, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-values", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a765a5a4e44442bbee0bfb6727e566b", async() => {
                            BeginContext(795, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(809, 92, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-value-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00a117abcdc4d93b46c986f25f7b4c7", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_4.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                            __Syncfusion_JavaScript_Models_Field.FieldCaption = (string)__tagHelperAttribute_5.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                            __Syncfusion_JavaScript_Models_Field.Format = (string)__tagHelperAttribute_6.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(901, 10, true);
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
                        BeginContext(928, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_PivotDataSource = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotDataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotDataSource);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(950, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_PivotGridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotGridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotGridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 7 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\PivotGrid\Default.cshtml"
__Syncfusion_JavaScript_Models_PivotGridProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_PivotGridProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_PivotGridProperties.Load = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 7 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\PivotGrid\Default.cshtml"
__Syncfusion_JavaScript_Models_PivotGridProperties.EnableGroupingBar = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-grouping-bar", __Syncfusion_JavaScript_Models_PivotGridProperties.EnableGroupingBar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\PivotGrid\Default.cshtml"
__Syncfusion_JavaScript_Models_PivotGridProperties.EnableMemberEditorSorting = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-member-editor-sorting", __Syncfusion_JavaScript_Models_PivotGridProperties.EnableMemberEditorSorting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(968, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(996, 3675, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function onload(args) {
            args.model.dataSource.data = [
                                        { Amount: 100, Country: ""Canada"", Date: ""FY 2005"", Product: ""Bike"", Quantity: 2, State: ""Alberta"" },
                                        { Amount: 200, Country: ""Canada"", Date: ""FY 2006"", Product: ""Van"", Quantity: 3, State: ""British Columbia"" },
                                        { Amount: 300, Country: ""Canada"", Date: ""FY 2007"", Product: ""Car"", Quantity: 4, State: ""Brunswick"" },
                                        { Amount: 150, Country: ""Canada"", Date: ""FY 2008"", Product: ""Bike"", Quantity: 3, State: ""Manitoba"" },
                                        { Amount: 200, Country: ""Canada"", Date: ""FY 2006"", Product: ""Car"", Quantity: 4, State: ""Ontario"" },
                                        { Amount: 100, Country: ""Canada"", Date: ""FY 2007"", Product: ""Van"", Quantity: 1, State: ""Quebec"" },
                                        { Amount:");
                WriteLiteral(@" 200, Country: ""France"", Date: ""FY 2005"", Product: ""Bike"", Quantity: 2, State: ""Charente-Maritime"" },
                                        { Amount: 250, Country: ""France"", Date: ""FY 2006"", Product: ""Van"", Quantity: 4, State: ""Essonne"" },
                                        { Amount: 300, Country: ""France"", Date: ""FY 2007"", Product: ""Car"", Quantity: 3, State: ""Garonne (Haute)"" },
                                        { Amount: 150, Country: ""France"", Date: ""FY 2008"", Product: ""Van"", Quantity: 2, State: ""Gers"" },
                                        { Amount: 200, Country: ""Germany"", Date: ""FY 2006"", Product: ""Van"", Quantity: 3, State: ""Bayern"" },
                                        { Amount: 250, Country: ""Germany"", Date: ""FY 2007"", Product: ""Car"", Quantity: 3, State: ""Brandenburg"" },
                                        { Amount: 150, Country: ""Germany"", Date: ""FY 2008"", Product: ""Car"", Quantity: 4, State: ""Hamburg"" },
                                        { Amount: 200, Country: ");
                WriteLiteral(@"""Germany"", Date: ""FY 2008"", Product: ""Bike"", Quantity: 4, State: ""Hessen"" },
                                        { Amount: 150, Country: ""Germany"", Date: ""FY 2007"", Product: ""Van"", Quantity: 3, State: ""Nordrhein-Westfalen"" },
                                        { Amount: 100, Country: ""Germany"", Date: ""FY 2005"", Product: ""Bike"", Quantity: 2, State: ""Saarland"" },
                                        { Amount: 150, Country: ""United Kingdom"", Date: ""FY 2008"", Product: ""Bike"", Quantity: 5, State: ""England"" },
                                        { Amount: 250, Country: ""United States"", Date: ""FY 2007"", Product: ""Car"", Quantity: 4, State: ""Alabama"" },
                                        { Amount: 200, Country: ""United States"", Date: ""FY 2005"", Product: ""Van"", Quantity: 4, State: ""California"" },
                                        { Amount: 100, Country: ""United States"", Date: ""FY 2006"", Product: ""Bike"", Quantity: 2, State: ""Colorado"" },
                                        { Amount:");
                WriteLiteral(@" 150, Country: ""United States"", Date: ""FY 2008"", Product: ""Car"", Quantity: 3, State: ""New Mexico"" },
                                        { Amount: 200, Country: ""United States"", Date: ""FY 2005"", Product: ""Bike"", Quantity: 4, State: ""New York"" },
                                        { Amount: 250, Country: ""United States"", Date: ""FY 2008"", Product: ""Car"", Quantity: 3, State: ""North Carolina"" },
                                        { Amount: 300, Country: ""United States"", Date: ""FY 2007"", Product: ""Van"", Quantity: 4, State: ""South Carolina"" }
            ];
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(4696, 223, true);
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
