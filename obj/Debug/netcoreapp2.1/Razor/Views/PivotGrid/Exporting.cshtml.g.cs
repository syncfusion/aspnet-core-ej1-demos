#pragma checksum "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "842853637d8df73b4b5dcc27670aa8e4f3a2fd27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PivotGrid_Exporting), @"mvc.1.0.view", @"/Views/PivotGrid/Exporting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PivotGrid/Exporting.cshtml", typeof(AspNetCore.Views_PivotGrid_Exporting))]
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
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842853637d8df73b4b5dcc27670aa8e4f3a2fd27", @"/Views/PivotGrid/Exporting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_PivotGrid_Exporting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("GridExporting"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "Exporting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ExportBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "30px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "exportPivotGrid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(54, 54, true);
                WriteLiteral("<span class=\"sampleName\">PivotGrid / Exporting</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(129, 165, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo for Syncfusion Essential JS1 for ASP.NET Core Pivot Grid control demos on export to Excel, CSV and PDF formats.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(322, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(324, 639, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pivot-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67db6fe8cfa64976b671129cf50c2f1a", async() => {
                    BeginContext(421, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(427, 518, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-data-source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b16cfa764b4b5a9a8d0cbc3b744eca", async() => {
                        BeginContext(442, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(452, 148, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-rows", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8023202288dd405198eb377f3212d47e", async() => {
                            BeginContext(466, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(480, 95, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-row-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "324dd459cfd64450a11841db1483a1de", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            __Syncfusion_JavaScript_Models_Field.FieldCaption = (string)__tagHelperAttribute_1.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 10 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Field.ShowSubTotal = false;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("show-sub-total", __Syncfusion_JavaScript_Models_Field.ShowSubTotal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(575, 10, true);
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
                        BeginContext(600, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(610, 154, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b9998e4f11845919a9242ad34868b23", async() => {
                            BeginContext(627, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(641, 95, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6f4b8b6a7f24bb2a9e3aa71bfeb5b8d", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_Field = CreateTagHelper<global::Syncfusion.JavaScript.Models.Field>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Field);
                            __Syncfusion_JavaScript_Models_Field.FieldName = (string)__tagHelperAttribute_2.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                            __Syncfusion_JavaScript_Models_Field.FieldCaption = (string)__tagHelperAttribute_3.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Field.ShowSubTotal = false;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("show-sub-total", __Syncfusion_JavaScript_Models_Field.ShowSubTotal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(736, 10, true);
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
                        BeginContext(764, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(774, 149, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-pivot-values", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5dc3df717ac45f6881ce81b1add7d53", async() => {
                            BeginContext(790, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(804, 92, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-value-field", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "553ee2a95fd14c6981b2a415cb987114", async() => {
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
                            BeginContext(896, 10, true);
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
                        BeginContext(923, 6, true);
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
                    BeginContext(945, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_PivotGridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PivotGridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PivotGridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 7 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_PivotGridProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_PivotGridProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_PivotGridProperties.Load = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 7 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_PivotGridProperties.EnableRowGrandTotal = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-row-grand-total", __Syncfusion_JavaScript_Models_PivotGridProperties.EnableRowGrandTotal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(963, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(991, 4400, true);
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
		function exportPivotGrid(args) {
                    var dropDownObj = $('#GridExporting').data(""ejDropDownList"");
					var pGridObj = $('#PivotGrid1').data(""ejPivotGrid"");
                    var exportOption = dropDownObj.model.value;
                    if (exportOption == ""Excel"")
                        pGridObj.exportPivotGrid(""ExcelExport"", ""Sample"");
                    else if (exportOption == ""Word"")
             ");
                WriteLiteral(@"           pGridObj.exportPivotGrid(""WordExport"", ""Sample"");
                    else if (exportOption == ""PDF"")
                        pGridObj.exportPivotGrid(""PDFExport"", ""Sample"");
        }
		$(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(5416, 478, true);
                WriteLiteral(@"
    <style>
        #PivotGrid1 {
            width: 100%;
            height: 350px;
            overflow: auto;
        }
        #ExportBtn {
            margin-left: 80px;
        }
        .cols-prop-area {
            width: 300px !important;
            min-height: 93px !important;
        }

        .col-md-3 {
            height: 45px !important;
        }
        .cols-sample-area {
            width: 100% !important;
        }
    </style>
");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(5924, 421, true);
                WriteLiteral(@"
    <ul id=""Exporting"">
        <li>Excel</li>
        <li>PDF</li>
        <li>Word</li>
    </ul>
    <br />
<div id=""sampleProperties"">
    <div class=""prop-grid"">
        <div class=""row"" style=""float:left;margin-left:30px !important; padding-top: 8px;"">
            Export Option :
        </div>
        <div class=""row"" style=""margin-right:20px;"">
            <div class=""col-md-3"">
                ");
                EndContext();
                BeginContext(6345, 118, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e64d8086de4a05aa65b3981f1d1494", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 104 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-item-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6463, 69, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(6532, 108, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "782362b69a994ac1a154fb9c8851121d", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __Syncfusion_JavaScript_Models_ButtonProperties.Width = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_ButtonProperties.Height = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#line 109 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\PivotGrid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_ButtonProperties.Type = global::Syncfusion.JavaScript.ButtonType.Button;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_Models_ButtonProperties.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6640, 22, true);
                WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
