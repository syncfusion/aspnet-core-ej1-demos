#pragma checksum "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridSorting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f167c3a2f96defe2919df36d8615f1b7f58c8620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeGrid_TreeGridSorting), @"mvc.1.0.view", @"/Views/TreeGrid/TreeGridSorting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeGrid/TreeGridSorting.cshtml", typeof(AspNetCore.Views_TreeGrid_TreeGridSorting))]
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
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridSorting.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f167c3a2f96defe2919df36d8615f1b7f58c8620", @"/Views/TreeGrid/TreeGridSorting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeGrid_TreeGridSorting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
                BeginContext(49, 159, true);
                WriteLiteral("\r\n  <meta name=\"description\" content=\"This example illustrates sorting columns in either ascending or descending order in the Syncfusion tree grid control.\">\r\n");
                EndContext();
            }
            );
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(236, 49, true);
                WriteLiteral("<span class=\"sampleName\"> TreeGrid/Sorting</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(313, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(315, 744, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54a1d3285f3e4894af361235c96c4a84", async() => {
                    BeginContext(473, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(479, 490, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea2c58eb672d49f1ba53e4442e927f69", async() => {
                        BeginContext(500, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(510, 68, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25ac67570e4b417cbd5e0f7312b7b1cc", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeGridColumn = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridColumn>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridColumn);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.Field = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_TreeGridColumn.HeaderText = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 10 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridSorting.cshtml"
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
                        BeginContext(578, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(588, 63, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9907fcd91a748979ccc223455872c65", async() => {
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
                        BeginContext(651, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(661, 65, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55d427d687a4492ba9bf92049de2bc7c", async() => {
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
                        BeginContext(726, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(736, 61, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7b28556c2114672a699686fb8878d33", async() => {
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
                        BeginContext(797, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(807, 62, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c4f10ce01df4cc69c5ec9636bd874f7", async() => {
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
                        BeginContext(869, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(879, 62, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97714b024daa468ba0e0c9df28446e15", async() => {
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
                        BeginContext(941, 6, true);
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
                    BeginContext(969, 12, true);
                    WriteLiteral("\r\n    \r\n    ");
                    EndContext();
                    BeginContext(981, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-grid-size-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d99366d6e74a40c4b8746dddc6b08a9c", async() => {
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
                    BeginContext(1038, 6, true);
                    WriteLiteral("    \r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_TreeGridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeGridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeGridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
#line 8 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridSorting.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_TreeGridProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridSorting.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.AllowSorting = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-sorting", __Syncfusion_JavaScript_Models_TreeGridProperties.AllowSorting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_TreeGridProperties.ChildMapping = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
#line 8 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridSorting.cshtml"
__Syncfusion_JavaScript_Models_TreeGridProperties.TreeColumnIndex = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tree-column-index", __Syncfusion_JavaScript_Models_TreeGridProperties.TreeColumnIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\TreeGrid\TreeGridSorting.cshtml"
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
                BeginContext(1059, 5, true);
                WriteLiteral("   \r\n");
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
