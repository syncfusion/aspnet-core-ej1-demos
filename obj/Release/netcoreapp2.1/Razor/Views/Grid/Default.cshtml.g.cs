#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3586a1d332623b9c7e8b9a761f5c9e721b955e71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grid_Default), @"mvc.1.0.view", @"/Views/Grid/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grid/Default.cshtml", typeof(AspNetCore.Views_Grid_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3586a1d332623b9c7e8b9a761f5c9e721b955e71", @"/Views/Grid/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Grid_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/Orders/?$top=45", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "OrderID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Order ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "CustomerID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Customer ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "EmployeeID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Employee ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("format", "{0:C2}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "OrderDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Order Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("format", "{0:MM/dd/yyyy}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "ShipCity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Ship City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FlatGrid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.GridCollectionTag __Syncfusion_JavaScript_GridCollectionTag;
        private global::Syncfusion.JavaScript.Models.Column __Syncfusion_JavaScript_Models_Column;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 47, true);
                WriteLiteral("<span class=\"sampleName\">Grid / Default</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(91, 155, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo explains how to render grid view for tabular data using the Syncfusion ASP.NET Core DataGrid control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(274, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(280, 915, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "063da8358d8c46f2900b54dcdfa3d21e", async() => {
                    BeginContext(344, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(354, 143, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f704ca9dc5804b389ebfb33d18bf1476", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                    __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
__Syncfusion_JavaScript_DataSource.Offline = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("offline", __Syncfusion_JavaScript_DataSource.Offline, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
__Syncfusion_JavaScript_DataSource.CrossDomain = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("cross-domain", __Syncfusion_JavaScript_DataSource.CrossDomain, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(497, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(507, 672, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6961760644b04861a8268373768dd87e", async() => {
                        BeginContext(518, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(532, 90, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23c28123e04a45c4a887c880a4aea47c", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 9 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
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
                        BeginContext(622, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(636, 77, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80ca2be78d9743e3afffd72e6485ab0c", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 10 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
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
                        BeginContext(713, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(727, 95, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33f655cd3ae04f4c94bc9a7fb3120010", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 11 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Left;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
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
                        BeginContext(822, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(836, 103, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca42ab6486d24f70b1f02ef420d9e10b", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        __Syncfusion_JavaScript_Models_Column.Format = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 12 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
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
                        BeginContext(939, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(953, 116, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0b87068f5ca4ecd96361e3e35de5b98", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_11.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                        __Syncfusion_JavaScript_Models_Column.Format = (string)__tagHelperAttribute_12.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#line 13 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
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
                        BeginContext(1069, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1083, 74, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc381986a798494b897a30848de5ca2a", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_13.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_14.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
#line 14 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
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
                        BeginContext(1157, 10, true);
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
                    BeginContext(1179, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.AllowSorting = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-sorting", __Syncfusion_JavaScript_Models_GridProperties.AllowSorting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Grid\Default.cshtml"
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
                BeginContext(1195, 2, true);
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
