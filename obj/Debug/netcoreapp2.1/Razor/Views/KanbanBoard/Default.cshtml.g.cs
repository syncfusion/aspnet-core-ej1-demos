#pragma checksum "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75cb2041124d986041134ccb6df04c318de175ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KanbanBoard_Default), @"mvc.1.0.view", @"/Views/KanbanBoard/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KanbanBoard/Default.cshtml", typeof(AspNetCore.Views_KanbanBoard_Default))]
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
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75cb2041124d986041134ccb6df04c318de175ec", @"/Views/KanbanBoard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_KanbanBoard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/Tasks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Backlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "In Progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Testing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Done", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("content", "Summary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("primary-key", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("swimlane-key", "Assignee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("KanbanBoard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("key-field", "Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.KanbanProperties __Syncfusion_JavaScript_Models_KanbanProperties;
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        private global::Syncfusion.JavaScript.KanbanCollectionTag __Syncfusion_JavaScript_KanbanCollectionTag;
        private global::Syncfusion.JavaScript.Models.KanbanColumn __Syncfusion_JavaScript_Models_KanbanColumn;
        private global::Syncfusion.JavaScript.Models.CardFields __Syncfusion_JavaScript_Models_CardFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(54, 56, true);
                WriteLiteral("<span class=\"sampleName\">Default Functionalities</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(131, 188, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates using the Syncfusion ASP.NET Core Kanban component to visualize a workflow at each stage along its path to completion.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(347, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(349, 811, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-kanban", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e23e9f13254177aeb4477ec107f2ff", async() => {
                    BeginContext(438, 7, true);
                    WriteLiteral("\r\n     ");
                    EndContext();
                    BeginContext(445, 118, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1fad5c4d5841f1a90f1aec2c39f8f9", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                    __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
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
                    BeginContext(563, 8, true);
                    WriteLiteral(" \r\n     ");
                    EndContext();
                    BeginContext(571, 471, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-kanbancolumns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe1e111e289a42ee8a7794a77d835ece", async() => {
                        BeginContext(588, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(598, 107, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-kanbancolumn", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af3f7fc0b36c451584a2a23f488d3b27", async() => {
                            BeginContext(670, 18, true);
                            WriteLiteral("        \r\n        ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_KanbanColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.KanbanColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_KanbanColumn);
                        __Syncfusion_JavaScript_Models_KanbanColumn.HeaderText = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 10 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
__Syncfusion_JavaScript_Models_KanbanColumn.Key = (new List<string>(){"Open"});

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("key", __Syncfusion_JavaScript_Models_KanbanColumn.Key, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(705, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(715, 100, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-kanbancolumn", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11bf715dff6a435c857c8b6c23d3223f", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_KanbanColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.KanbanColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_KanbanColumn);
                        __Syncfusion_JavaScript_Models_KanbanColumn.HeaderText = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 12 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
__Syncfusion_JavaScript_Models_KanbanColumn.Key = (new List<string>() {"InProgress"});

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("key", __Syncfusion_JavaScript_Models_KanbanColumn.Key, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(815, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(825, 93, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-kanbancolumn", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c2d5638225040f1b844e224a24cbcf8", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_KanbanColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.KanbanColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_KanbanColumn);
                        __Syncfusion_JavaScript_Models_KanbanColumn.HeaderText = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
__Syncfusion_JavaScript_Models_KanbanColumn.Key = (new List<string>() {"Testing"});

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("key", __Syncfusion_JavaScript_Models_KanbanColumn.Key, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(918, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(928, 89, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-kanbancolumn", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d46cee013234d429cb938c88f3f3195", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_KanbanColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.KanbanColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_KanbanColumn);
                        __Syncfusion_JavaScript_Models_KanbanColumn.HeaderText = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 14 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
__Syncfusion_JavaScript_Models_KanbanColumn.Key = (new List<string>() {"Close"});

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("key", __Syncfusion_JavaScript_Models_KanbanColumn.Key, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1017, 7, true);
                        WriteLiteral("\r\n     ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_KanbanCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.KanbanCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_KanbanCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1042, 7, true);
                    WriteLiteral("\r\n     ");
                    EndContext();
                    BeginContext(1049, 97, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-kanbanfield", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcd6e2a238fb4ad79c56ec40ad3fbdfa", async() => {
                        BeginContext(1123, 7, true);
                        WriteLiteral("\r\n     ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_CardFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.CardFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_CardFields);
                    __Syncfusion_JavaScript_Models_CardFields.Content = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Syncfusion_JavaScript_Models_CardFields.PrimaryKey = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __Syncfusion_JavaScript_Models_CardFields.SwimlaneKey = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1146, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_KanbanProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.KanbanProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_KanbanProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#line 7 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
__Syncfusion_JavaScript_Models_KanbanProperties.AllowSelection = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-selection", __Syncfusion_JavaScript_Models_KanbanProperties.AllowSelection, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 7 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\KanbanBoard\Default.cshtml"
__Syncfusion_JavaScript_Models_KanbanProperties.AllowTitle = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-title", __Syncfusion_JavaScript_Models_KanbanProperties.AllowTitle, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_KanbanProperties.KeyField = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1160, 2, true);
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
