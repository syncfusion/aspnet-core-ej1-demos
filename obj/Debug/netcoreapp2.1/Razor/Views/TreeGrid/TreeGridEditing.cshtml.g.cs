#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f1121f1ea0654582a196373e543c6d131043072"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeGrid_TreeGridEditing), @"mvc.1.0.view", @"/Views/TreeGrid/TreeGridEditing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeGrid/TreeGridEditing.cshtml", typeof(AspNetCore.Views_TreeGrid_TreeGridEditing))]
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
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1121f1ea0654582a196373e543c6d131043072", @"/Views/TreeGrid/TreeGridEditing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeGrid_TreeGridEditing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Syncfusion.JavaScript.Models.TreeGridEditOptions __Syncfusion_JavaScript_Models_TreeGridEditOptions;
        private global::Syncfusion.JavaScript.Models.TreeGridToolBarOptions __Syncfusion_JavaScript_Models_TreeGridToolBarOptions;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(49, 150, true);
                WriteLiteral("\r\n  <meta name=\"description\" content=\"This example illustrates editing records in the tree grid control using inline cell and row editing options.\">\r\n");
                EndContext();
            }
            );
            BeginContext(202, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(227, 49, true);
                WriteLiteral("<span class=\"sampleName\"> TreeGrid/Default</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(304, 103, true);
                WriteLiteral("\r\n\r\n\r\n    <style>\r\n        .cols-sample-area {\r\n            height: 440px;\r\n        }\r\n    </style>\r\n\r\n");
                EndContext();
                BeginContext(407, 1184, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e9a3f38515b49b695c0e89f788b4d02", async() => {
                    BeginContext(560, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(566, 649, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9916505975a45daa0298c9d4971e69d", async() => {
                        BeginContext(587, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(597, 112, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dfbd9fe829f24d9fb1ceadb30d6f8f74", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 19 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.AllowFiltering = false;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("allow-filtering", __Syncfusion_JavaScript_Models_TreeGridColumn.AllowFiltering, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.EditType = global::Syncfusion.JavaScript.TreeGridEditingType.Numeric;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_TreeGridColumn.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
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
                        BeginContext(709, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(719, 82, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7047a01c370742f1a5aeeeba56aca447", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 20 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.EditType = global::Syncfusion.JavaScript.TreeGridEditingType.String;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_TreeGridColumn.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(801, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(811, 89, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dcbebe20ab164fd1926fce8fc46d1efe", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 21 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.EditType = global::Syncfusion.JavaScript.TreeGridEditingType.Datepicker;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_TreeGridColumn.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(900, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(910, 85, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e68efed4ffe46099773e8c09a5ad1f2", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 22 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.EditType = global::Syncfusion.JavaScript.TreeGridEditingType.Datepicker;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_TreeGridColumn.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(995, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1005, 82, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a016165cc6c45d788f636a78b58c94d", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 23 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.EditType = global::Syncfusion.JavaScript.TreeGridEditingType.Numeric;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_TreeGridColumn.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1087, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(1097, 82, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4133fc5fada2462e88fc1f635d85770a", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_11.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 24 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridColumn.EditType = global::Syncfusion.JavaScript.TreeGridEditingType.Numeric;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("edit-type", __Syncfusion_JavaScript_Models_TreeGridColumn.EditType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1179, 14, true);
                        WriteLiteral("        \r\n    ");
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
                    BeginContext(1215, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1221, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-size-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5cf071e3b634c5698946fadd7d58fcc", async() => {
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
                    BeginContext(1278, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1284, 162, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-edit-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e23e3d0733ba4ba69b9a155fe0db7e26", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_TreeGridEditOptions = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridEditOptions>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridEditOptions);
#line 27 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridEditOptions.AllowDeleting = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-deleting", __Syncfusion_JavaScript_Models_TreeGridEditOptions.AllowDeleting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridEditOptions.AllowAdding = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-adding", __Syncfusion_JavaScript_Models_TreeGridEditOptions.AllowAdding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridEditOptions.AllowEditing = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-editing", __Syncfusion_JavaScript_Models_TreeGridEditOptions.AllowEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridEditOptions.RowPosition = global::Syncfusion.JavaScript.TreeGridRowPosition.AboveSelectedRow;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("row-position", __Syncfusion_JavaScript_Models_TreeGridEditOptions.RowPosition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridEditOptions.EditMode = global::Syncfusion.JavaScript.TreeGridEditMode.CellEditing;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("edit-mode", __Syncfusion_JavaScript_Models_TreeGridEditOptions.EditMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1446, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1452, 118, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-toolbar-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c565970a1b949dd8a36276cdfcdf3ab", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_TreeGridToolBarOptions = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridToolBarOptions>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridToolBarOptions);
#line 29 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridToolBarOptions.ShowToolbar = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-toolbar", __Syncfusion_JavaScript_Models_TreeGridToolBarOptions.ShowToolbar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridToolBarOptions.ToolbarItems = ViewBag.toolbarItems;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("toolbar-items", __Syncfusion_JavaScript_Models_TreeGridToolBarOptions.ToolbarItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1570, 6, true);
                    WriteLiteral("    \r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_TreeGridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
#line 16 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_TreeGridProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_TreeGridProperties.ChildMapping = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
#line 16 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.TreeColumnIndex = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tree-column-index", __Syncfusion_JavaScript_Models_TreeGridProperties.TreeColumnIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridEditing.cshtml"
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
                BeginContext(1591, 2, true);
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
