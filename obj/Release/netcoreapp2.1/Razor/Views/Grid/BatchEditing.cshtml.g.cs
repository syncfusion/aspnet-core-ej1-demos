#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e381131f954a93fbd2e7fb1a597758cc42cae8cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grid_BatchEditing), @"mvc.1.0.view", @"/Views/Grid/BatchEditing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grid/BatchEditing.cshtml", typeof(AspNetCore.Views_Grid_BatchEditing))]
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
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e381131f954a93fbd2e7fb1a597758cc42cae8cb", @"/Views/Grid/BatchEditing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Grid_BatchEditing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "DataSource", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("batch-url", "BatchUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("adaptor", "UrlAdaptor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "orderID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Order ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "customerID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Customer ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "employeeID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Employee ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("format", "{0:C}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "shipCity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Ship City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FlatGrid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        private global::Syncfusion.JavaScript.Models.EditSettings __Syncfusion_JavaScript_Models_EditSettings;
        private global::Syncfusion.JavaScript.Models.ToolbarSettings __Syncfusion_JavaScript_Models_ToolbarSettings;
        private global::Syncfusion.JavaScript.GridCollectionTag __Syncfusion_JavaScript_GridCollectionTag;
        private global::Syncfusion.JavaScript.Models.Column __Syncfusion_JavaScript_Models_Column;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 52, true);
                WriteLiteral("<span class=\"sampleName\">Grid / BatchEditing</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(96, 176, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo explains how to update bulk data changes to data source using Batch Edit mode in Syncfusion ASP.NET Core DataGrid control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(300, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(306, 1501, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffe1a4575ec94e40b53865ede44cc014", async() => {
                    BeginContext(349, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(359, 79, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21d001f12bde42fb88fb20bbf9d46dd0", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                    __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_DataSource.BatchURL = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_JavaScript_DataSource.Adaptor = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(438, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(448, 128, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-edit-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cf76f28659348b081cadf0cf04aacf0", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_EditSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditSettings);
#line 8 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowAdding = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-adding", __Syncfusion_JavaScript_Models_EditSettings.AllowAdding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowEditing = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-editing", __Syncfusion_JavaScript_Models_EditSettings.AllowEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowDeleting = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-deleting", __Syncfusion_JavaScript_Models_EditSettings.AllowDeleting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.EditMode = (EditMode.Batch);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("edit-mode", __Syncfusion_JavaScript_Models_EditSettings.EditMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(576, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(586, 142, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-toolbar-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b789570672a543d987338ad90b21323b", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ToolbarSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToolbarSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToolbarSettings);
#line 9 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_ToolbarSettings.ShowToolbar = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-toolbar", __Syncfusion_JavaScript_Models_ToolbarSettings.ShowToolbar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_ToolbarSettings.ToolbarItems = (new List<string>() {"add","edit","delete","update","cancel" });

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
                    BeginContext(728, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(738, 1053, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b49a33a4b69643c68da357936dae7f48", async() => {
                        BeginContext(749, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(763, 203, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29dc98a22f364e4181d3a55e149d519a", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 11 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.IsPrimaryKey = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("is-primary-key", __Syncfusion_JavaScript_Models_Column.IsPrimaryKey, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.ValidationRules = new Dictionary<string, object>() { {"required",true}, {"number",true} };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("validation-rules", __Syncfusion_JavaScript_Models_Column.ValidationRules, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 11 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
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
                        BeginContext(966, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(980, 168, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6526c24b131741488241e226288f15de", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 12 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.ValidationRules = new Dictionary<string, object>() { {"required",true}, {"minlength",3} };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("validation-rules", __Syncfusion_JavaScript_Models_Column.ValidationRules, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
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
                        BeginContext(1148, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1162, 183, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f205b61e48f4f0e87fe3dc1771ff6a3", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 13 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.DataSource = (IEnumerable<object>)ViewBag.data;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_Column.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.EditType = (EditingType.DropdownEdit);

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_Column.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
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
                        BeginContext(1345, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1359, 304, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12b01100223d4a149d2843c630f22d06", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                        __Syncfusion_JavaScript_Models_Column.Format = (string)__tagHelperAttribute_11.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 14 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.NumericEditOptions = new EditorProperties(){ DecimalPlaces = 2};

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("numeric-edit-options", __Syncfusion_JavaScript_Models_Column.NumericEditOptions, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.ValidationRules = new Dictionary<string, object>() { {"required",true}, {"range","[0,1000]"} };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("validation-rules", __Syncfusion_JavaScript_Models_Column.ValidationRules, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 14 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.EditType = (EditingType.NumericEdit);

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_Column.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
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
                        BeginContext(1663, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1677, 92, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e57f74c43aa47e3bf19b37849e26a9d", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_12.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_13.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#line 15 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 110;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Left;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1769, 10, true);
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
                    BeginContext(1791, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\BatchEditing.cshtml"
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
                BeginContext(1807, 2, true);
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
