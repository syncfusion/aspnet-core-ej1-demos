#pragma checksum "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4daec3ccc90bd821a003c9dccdeb4b085d0cec77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_CollectionObjects), @"mvc.1.0.view", @"/Views/XlsIO/CollectionObjects.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/CollectionObjects.cshtml", typeof(AspNetCore.Views_XlsIO_CollectionObjects))]
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
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4daec3ccc90bd821a003c9dccdeb4b085d0cec77", @"/Views/XlsIO/CollectionObjects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_CollectionObjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("update-url", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("adaptor", "remoteSaveAdaptor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "BrandName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "VehicleType.VehicleName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Vehicle Type", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "VehicleType.Model.ModelName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Model", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Grid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("isVisible", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.GridCollectionTag __Syncfusion_JavaScript_GridCollectionTag;
        private global::Syncfusion.JavaScript.Models.Column __Syncfusion_JavaScript_Models_Column;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(73, 71, true);
                WriteLiteral(" <span class=\"sampleName\">XlsIO/GettingStarted/CollectionObjects</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(172, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : CollectionObjects : Syncfusion";

#line default
#line hidden
                BeginContext(262, 3, true);
                WriteLiteral("   ");
                EndContext();
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
     Html.BeginForm("CollectionObjects", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(334, 1003, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                <label>
                    Essential XlsIO allows you to import/export data from/to Collection Objects. Collection object usually holds a set of instance variables or properties, also known as attributes..
                </label>
				<br />
				<label>
                    This sample demonstrates the usage of Collection objects using Essential XlsIO.
                </label>
                <br />
                <label>
                    Click the 'Import From Excel' button to import data from nested class into the ListView. The 'Export To Excel' button will generate a new Microsoft Excel document by exporting the nested class data from the ListView using Essential XlsIO. Please note that you need to have a MS Excel viewer installed in order to view the generated excel file.
                </label>
            </div>
            <br />
        </div>
    </div>
");
                EndContext();
                BeginContext(1339, 872, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6daf7f2b1e9a483bbaa776695bee078f", async() => {
                    BeginContext(1426, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1432, 112, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ad6005f60ea41d98f6a000e60fa0b65", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
#line 28 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_DataSource.Json = (IEnumerable<object>)ViewBag.datasource;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("json", __Syncfusion_JavaScript_DataSource.Json, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_DataSource.UpdateURL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_DataSource.Adaptor = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1544, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1550, 129, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-edit-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27d5f0356a1e485c85016c357ab5f159", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_EditSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditSettings);
#line 29 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowAdding = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-adding", __Syncfusion_JavaScript_Models_EditSettings.AllowAdding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowEditing = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-editing", __Syncfusion_JavaScript_Models_EditSettings.AllowEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.AllowDeleting = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-deleting", __Syncfusion_JavaScript_Models_EditSettings.AllowDeleting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_EditSettings.EditMode = (EditMode.Normal);

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
                    BeginContext(1679, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1685, 514, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dbcdbd5eee94a5990107b1dc94683a2", async() => {
                        BeginContext(1696, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1706, 117, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7fcd5c5b97f4e90a7740f6e3c22366f", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 31 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 50;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 31 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Left;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.Visible = false;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("visible", __Syncfusion_JavaScript_Models_Column.Visible, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.IsPrimaryKey = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("is-primary-key", __Syncfusion_JavaScript_Models_Column.IsPrimaryKey, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1823, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1833, 111, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02f7d94e3f64707b76d3df33affd095", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 32 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 100;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 32 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Left;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.IsPrimaryKey = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("is-primary-key", __Syncfusion_JavaScript_Models_Column.IsPrimaryKey, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1944, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1954, 110, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23f99cd27328459d9625f392c2d23a25", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 33 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 100;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 33 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
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
                        BeginContext(2064, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(2074, 107, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b390d1b390e49fbae1362174e39935c", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
#line 34 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 100;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 34 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
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
                        BeginContext(2181, 6, true);
                        WriteLiteral("\r\n    ");
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
                    BeginContext(2199, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#line 27 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.AllowScrolling = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-scrolling", __Syncfusion_JavaScript_Models_GridProperties.AllowScrolling, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.Height = 300;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_Models_GridProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.Width = 540;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_GridProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2211, 913, true);
                WriteLiteral(@"
    <br />
    <div class=""rowdiv"">
        <div class=""celldiv"">
            <label>
                <strong> Save As :</strong>
            </label>
            <input id=""rbtnXls"" type=""radio"" name=""SaveOption"" value=""Xls"" />
            <label for=""rbtnXls"">
                XLS
            </label>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            <input id=""rbtnXlsx"" type=""radio"" name=""SaveOption"" value=""Xlsx"" checked=""checked"" />
            <label for=""rbtnXlsx"">
                XLSX
            </label>
        </div>
        <br />
        <div class=""celldiv"">
            <input id=""input"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Input Template"" style=""width:162px;"" />
            <input id=""import"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Import From Excel"" style=""width:162px;"" />
            <input id=""export"" class=""buttonStyle"" ");
                EndContext();
                BeginContext(3125, 25, false);
#line 57 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"
                                              Write(ViewBag.exportButtonState);

#line default
#line hidden
                EndContext();
                BeginContext(3150, 106, true);
                WriteLiteral(" type=\"submit\" name=\"button\" value=\"Export To Excel\" style=\"width:162px;\" />\r\n        </div>\r\n    </div>\r\n");
                EndContext();
                BeginContext(3258, 162, true);
                WriteLiteral("    <script type=\"text/javascript\">\r\n\r\n        function EnableExport()\r\n        {\r\n            $(\'#export\').prop(\"disabled\", false);\r\n\r\n        }\r\n    </script>\r\n");
                EndContext();
#line 69 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\XlsIO\CollectionObjects.cshtml"

 Html.EndForm();
    } 

#line default
#line hidden
                BeginContext(3449, 4, true);
                WriteLiteral("    ");
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