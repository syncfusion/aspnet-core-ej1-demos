#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\TreeGrid\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c26ab28713f13c1de8040047c0ee3347255b594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeGrid_Default), @"mvc.1.0.view", @"/Views/TreeGrid/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeGrid/Default.cshtml", typeof(AspNetCore.Views_TreeGrid_Default))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\TreeGrid\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c26ab28713f13c1de8040047c0ee3347255b594", @"/Views/TreeGrid/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeGrid_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "TaskId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Task Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "TaskName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Task Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "StartDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Start Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "EndDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "End Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Duration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Duration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "350px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TreeGridContainer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("child-mapping", "Children", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TreeGridProperties __Syncfusion_JavaScript_Models_TreeGridProperties;
        private global::Syncfusion.JavaScript.TreeGridCollectionTag __Syncfusion_JavaScript_TreeGridCollectionTag;
        private global::Syncfusion.JavaScript.Models.TreeGridColumn __Syncfusion_JavaScript_Models_TreeGridColumn;
        private global::Syncfusion.JavaScript.Models.TreeGridSizeSettings __Syncfusion_JavaScript_Models_TreeGridSizeSettings;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(49, 141, true);
                WriteLiteral("\r\n  <meta name=\"description\" content=\"This example visualizes hierarchical data using a Syncfusion tree grid with basic features enabled.\">\r\n");
                EndContext();
            }
            );
            BeginContext(193, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(218, 49, true);
                WriteLiteral("<span class=\"sampleName\"> TreeGrid/Default</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(295, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(301, 713, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "132afbf2582742ecb30cafde50b19530", async() => {
                    BeginContext(438, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(444, 490, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe3ac006e7c44408b1e0fdbbda2e5e47", async() => {
                        BeginContext(465, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(475, 68, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4764ef7453a4ade95bbf68b6975352f", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 10 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\TreeGrid\Default.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.Width = 45;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_TreeGridColumn.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(543, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(553, 63, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e36a2d0788334cdc8ab7ddd2548ba011", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(616, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(626, 65, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "520e0ee3d0e94ec29ea280f8cef4222b", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(691, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(701, 61, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3cf53f2140cd4ea2b5aee6ecc18ee88a", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(762, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(772, 62, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91a83c0ce97c47c6b732bb5151afb201", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(834, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(844, 62, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11814448113b4b1d880b767c6f77b2e1", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_11.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(906, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_TreeGridCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.TreeGridCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TreeGridCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(934, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(940, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-size-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "99fc65def9e746b8ab0b725dbad47e54", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_TreeGridSizeSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridSizeSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridSizeSettings);
                    __Syncfusion_JavaScript_Models_TreeGridSizeSettings.Width = (string)__tagHelperAttribute_12.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                    __Syncfusion_JavaScript_Models_TreeGridSizeSettings.Height = (string)__tagHelperAttribute_13.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(997, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_TreeGridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
#line 8 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\TreeGrid\Default.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_TreeGridProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_TreeGridProperties.ChildMapping = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
#line 8 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\TreeGrid\Default.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.TreeColumnIndex = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tree-column-index", __Syncfusion_JavaScript_Models_TreeGridProperties.TreeColumnIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\TreeGrid\Default.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_TreeGridProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1014, 2, true);
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
