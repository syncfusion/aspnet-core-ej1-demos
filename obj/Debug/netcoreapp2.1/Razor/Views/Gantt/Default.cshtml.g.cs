#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8e1bd7ad3b475b79d57dd750bea806e487e9b1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gantt_Default), @"mvc.1.0.view", @"/Views/Gantt/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gantt/Default.cshtml", typeof(AspNetCore.Views_Gantt_Default))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e1bd7ad3b475b79d57dd750bea806e487e9b1b", @"/Views/Gantt/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Gantt_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "450px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ganttSample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("task-id-mapping", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("task-name-mapping", "Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("start-date-mapping", "StartDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("duration-mapping", "Duration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("progress-mapping", "PercentDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("schedule-start-date", "02/20/2017", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("schedule-end-date", "04/10/2017", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("child-mapping", "Children", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.SizeSettings __Syncfusion_JavaScript_Models_SizeSettings;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("MetaTags", async() => {
                BeginContext(49, 156, true);
                WriteLiteral("\r\n  <meta name=\"description\" content=\"This example visualizes a project schedule using the Syncfusion Gantt chart with the basic Gantt features enabled.\">\r\n");
                EndContext();
            }
            );
            BeginContext(208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(233, 61, true);
                WriteLiteral("<span class=\"sampleName\">Gantt/Default Functionalities</span>");
                EndContext();
            }
            );
            BeginContext(297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(324, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(330, 778, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-gantt", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36c880804d4e4c1f99dd4bac7144db17", async() => {
                    BeginContext(1028, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1038, 53, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-gantt-size-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f58edb6875c489385c1db994b3693e3", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_SizeSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.SizeSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_SizeSettings);
                    __Syncfusion_JavaScript_Models_SizeSettings.Height = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_Models_SizeSettings.Width = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1091, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GanttProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GanttProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GanttProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 9 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_GanttProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_GanttProperties.TaskIdMapping = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_GanttProperties.TaskNameMapping = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_GanttProperties.StartDateMapping = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_GanttProperties.DurationMapping = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_GanttProperties.ProgressMapping = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_GanttProperties.ScheduleStartDate = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_GanttProperties.ScheduleEndDate = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 17 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.HighlightWeekends = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("highlight-weekends", __Syncfusion_JavaScript_Models_GanttProperties.HighlightWeekends, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.IncludeWeekend = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("include-weekend", __Syncfusion_JavaScript_Models_GanttProperties.IncludeWeekend, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.AllowColumnResize = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-column-resize", __Syncfusion_JavaScript_Models_GanttProperties.AllowColumnResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.TreeColumnIndex = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tree-column-index", __Syncfusion_JavaScript_Models_GanttProperties.TreeColumnIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_GanttProperties.ChildMapping = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#line 22 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.AllowSelection = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-selection", __Syncfusion_JavaScript_Models_GanttProperties.AllowSelection, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
__Syncfusion_JavaScript_Models_GanttProperties.AllowGanttChartEditing = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-gantt-chart-editing", __Syncfusion_JavaScript_Models_GanttProperties.AllowGanttChartEditing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Gantt\Default.cshtml"
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
                BeginContext(1108, 10, true);
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
