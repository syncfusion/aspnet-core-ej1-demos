#pragma checksum "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17162a47fec9687fdd0c625f5bb40ba6b2129474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gantt_GanttEditing), @"mvc.1.0.view", @"/Views/Gantt/GanttEditing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gantt/GanttEditing.cshtml", typeof(AspNetCore.Views_Gantt_GanttEditing))]
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
#line 1 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17162a47fec9687fdd0c625f5bb40ba6b2129474", @"/Views/Gantt/GanttEditing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Gantt_GanttEditing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("edit-mode", "cellEditing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "450px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ganttSample3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("task-id-mapping", "TaskID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("task-name-mapping", "TaskName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("start-date-mapping", "StartDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("duration-mapping", "Duration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("progress-mapping", "Progress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("schedule-start-date", "02/01/2017", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("schedule-end-date", "03/14/2017", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("predecessor-mapping", "Predecessors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("child-mapping", "SubTasks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.GanttProperties __Syncfusion_JavaScript_Models_GanttProperties;
        private global::Syncfusion.JavaScript.Models.GanttEditOptions __Syncfusion_JavaScript_Models_GanttEditOptions;
        private global::Syncfusion.JavaScript.Models.SizeSettings __Syncfusion_JavaScript_Models_SizeSettings;
        private global::Syncfusion.JavaScript.Models.ToolBarOptions __Syncfusion_JavaScript_Models_ToolBarOptions;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(49, 155, true);
                WriteLiteral("\r\n  <meta name=\"description\" content=\"This example illustrates the taskbar, cell, and dialog editing options available in the Syncfusion Gantt control.\">\r\n");
                EndContext();
            }
            );
            BeginContext(207, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(232, 45, true);
                WriteLiteral("<span class=\"sampleName\">Gantt/Editing</span>");
                EndContext();
            }
            );
            BeginContext(280, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(307, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(309, 1013, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-gantt", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10afa68c11dd4f85889f2a1d13e8e4f0", async() => {
                    BeginContext(1021, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1027, 132, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-gantt-edit-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6c3e36d24704e99a06a433c68d86110", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_GanttEditOptions = CreateTagHelper<global::Syncfusion.JavaScript.Models.GanttEditOptions>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GanttEditOptions);
#line 27 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttEditOptions.AllowAdding = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-adding", __Syncfusion_JavaScript_Models_GanttEditOptions.AllowAdding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttEditOptions.AllowDeleting = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-deleting", __Syncfusion_JavaScript_Models_GanttEditOptions.AllowDeleting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttEditOptions.AllowEditing = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-editing", __Syncfusion_JavaScript_Models_GanttEditOptions.AllowEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_Models_GanttEditOptions.EditMode = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 27 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttEditOptions.AllowIndent = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("allow-indent", __Syncfusion_JavaScript_Models_GanttEditOptions.AllowIndent, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1159, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1165, 53, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-gantt-size-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d5c2464eb8c4bfeac21337e4d54348c", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_SizeSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SizeSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SizeSettings);
                    __Syncfusion_JavaScript_Models_SizeSettings.Height = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_JavaScript_Models_SizeSettings.Width = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1218, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(1224, 85, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-gantt-toolbar-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4278b92c2a8148acb30133e26c3cf6f7", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ToolBarOptions = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToolBarOptions>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToolBarOptions);
#line 29 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_ToolBarOptions.ShowToolbar = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-toolbar", __Syncfusion_JavaScript_Models_ToolBarOptions.ShowToolbar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_ToolBarOptions.ToolbarItems = ViewBag.toolbarItems;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("toolbar-items", __Syncfusion_JavaScript_Models_ToolBarOptions.ToolbarItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1309, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GanttProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GanttProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GanttProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 9 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_GanttProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_GanttProperties.TaskIdMapping = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_GanttProperties.TaskNameMapping = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_GanttProperties.StartDateMapping = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_GanttProperties.DurationMapping = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_GanttProperties.ProgressMapping = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_GanttProperties.ScheduleStartDate = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_GanttProperties.ScheduleEndDate = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#line 17 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.HighlightWeekends = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("highlight-weekends", __Syncfusion_JavaScript_Models_GanttProperties.HighlightWeekends, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.IncludeWeekend = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("include-weekend", __Syncfusion_JavaScript_Models_GanttProperties.IncludeWeekend, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.AllowColumnResize = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-column-resize", __Syncfusion_JavaScript_Models_GanttProperties.AllowColumnResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_GanttProperties.PredecessorMapping = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 21 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.EnableContextMenu = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-context-menu", __Syncfusion_JavaScript_Models_GanttProperties.EnableContextMenu, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.TreeColumnIndex = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tree-column-index", __Syncfusion_JavaScript_Models_GanttProperties.TreeColumnIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_GanttProperties.ChildMapping = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#line 24 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.AllowSelection = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-selection", __Syncfusion_JavaScript_Models_GanttProperties.AllowSelection, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 25 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.AllowGanttChartEditing = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-gantt-chart-editing", __Syncfusion_JavaScript_Models_GanttProperties.AllowGanttChartEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Gantt\GanttEditing.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_GanttProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1322, 10, true);
                WriteLiteral("        \r\n");
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
