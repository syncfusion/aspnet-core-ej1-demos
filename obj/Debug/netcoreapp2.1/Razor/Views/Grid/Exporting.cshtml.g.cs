#pragma checksum "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c902a5269ff36e8139306459a98a126ad20db9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grid_Exporting), @"mvc.1.0.view", @"/Views/Grid/Exporting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grid/Exporting.cshtml", typeof(AspNetCore.Views_Grid_Exporting))]
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
#line 1 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c902a5269ff36e8139306459a98a126ad20db9d", @"/Views/Grid/Exporting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Grid_Exporting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "OrderID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Order ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "CustomerID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Customer ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "EmployeeID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Employee ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("format", "{0:C2}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "ShipCity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Ship City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FlatGrid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.GridProperties __Syncfusion_JavaScript_Models_GridProperties;
        private global::Syncfusion.JavaScript.Models.ToolbarSettings __Syncfusion_JavaScript_Models_ToolbarSettings;
        private global::Syncfusion.JavaScript.GridCollectionTag __Syncfusion_JavaScript_GridCollectionTag;
        private global::Syncfusion.JavaScript.Models.Column __Syncfusion_JavaScript_Models_Column;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 48, true);
                WriteLiteral("<span class=\"sampleName\">Grid / Exporing</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(92, 185, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo explains how to export the datagrid\'s content to Excel, PDF, and Word documents using the Syncfusion ASP.NET Core DataGrid control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(305, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(311, 815, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3791f09261e84871bab19fd9473c2560", async() => {
                    BeginContext(386, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(396, 162, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-toolbar-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eacc8b4835124d558fde929e6a75c8d0", async() => {
                        BeginContext(514, 23, true);
                        WriteLiteral("\r\n           \r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_ToolbarSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToolbarSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToolbarSettings);
#line 7 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_ToolbarSettings.ShowToolbar = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-toolbar", __Syncfusion_JavaScript_Models_ToolbarSettings.ShowToolbar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_ToolbarSettings.ToolbarItems = (new List<string>() {"excelExport","wordExport","pdfExport" });

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("toolbar-items", __Syncfusion_JavaScript_Models_ToolbarSettings.ToolbarItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(558, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(568, 542, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd99b63d93b84bb8b826b43b00842d2a", async() => {
                        BeginContext(579, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(593, 90, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67642121dfdf4857ba006039aa48e47c", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 11 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 75;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(683, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(697, 77, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98578132b7db4ed68b82aea7ae83afe2", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 12 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 80;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(774, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(788, 95, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0c14b428301451b81a2d7140a6a5b9e", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 13 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Left;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 75;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(883, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(897, 103, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0280dcb2f15844199a04b2b9d41db648", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                        __Syncfusion_JavaScript_Models_Column.Format = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 14 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 75;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1000, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1014, 74, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2937f7ee585c48c7bb7dc17364e74e2a", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#line 15 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 110;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1088, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_GridCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.GridCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_GridCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1110, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_GridProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Grid\Exporting.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.AllowPaging = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-paging", __Syncfusion_JavaScript_Models_GridProperties.AllowPaging, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1126, 2, true);
                WriteLiteral("\r\n");
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
