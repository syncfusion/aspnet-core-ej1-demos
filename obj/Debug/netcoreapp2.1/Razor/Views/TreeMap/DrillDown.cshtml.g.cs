#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91342603bed994e25a467e03d8cbfa5e9d55a79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeMap_DrillDown), @"mvc.1.0.view", @"/Views/TreeMap/DrillDown.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeMap/DrillDown.cshtml", typeof(AspNetCore.Views_TreeMap_DrillDown))]
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
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b91342603bed994e25a467e03d8cbfa5e9d55a79", @"/Views/TreeMap/DrillDown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeMap_DrillDown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-path", "Continent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-path", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-path", "Name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("treemap1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("drill-down-selection-color", "#199DAF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("weight-value-path", "Population", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapProperties __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties;
        private global::Syncfusion.JavaScript.TreeMapCollectionTag __Syncfusion_JavaScript_TreeMapCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 61, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">TreeMap / Customization</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(270, 180, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates drill down feature based on the countries in the continent in the Syncfusion ASP.NET Web Forms Treemap control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(478, 83, true);
                WriteLiteral("\r\n   <div class=\"Common\">\r\n    <div id=\"treemap2\" style=\"height: 405px;\">\r\n        ");
                EndContext();
                BeginContext(561, 756, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-map", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b9b429558294661afa1478ac702de54", async() => {
                    BeginContext(738, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(752, 541, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-levels", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3944143aa78149468686d5e3281939a3", async() => {
                        BeginContext(762, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(780, 153, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1c1675221954a1697eb69e8dd9689b4", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupPath = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 18 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight = 25;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("header-height", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowHeader = false;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-header", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowHeader, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap = 5;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("group-gap", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.LabelPosition = DockPosition.TopLeft;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("label-position", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.LabelPosition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-labels", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(933, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(951, 151, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c96535dc24444596c6a3e5da47556e", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupPath = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 19 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight = 25;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("header-height", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowHeader = false;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-header", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowHeader, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap = 0;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("group-gap", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.LabelPosition = DockPosition.TopLeft;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("label-position", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.LabelPosition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-labels", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1102, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1120, 148, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdf6c9d0af2b42f89ee40d9371e1f847", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupPath = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 20 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight = 25;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("header-height", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowHeader = false;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-header", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowHeader, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap = 0;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("group-gap", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupGap, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.LabelPosition = DockPosition.TopLeft;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("label-position", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.LabelPosition, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-labels", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1268, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_TreeMapCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.TreeMapCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TreeMapCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1293, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 15 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource = ViewBag.drillDownData;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\TreeMap\DrillDown.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.EnableDrillDown = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-drill-down", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.EnableDrillDown, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DrillDownSelectionColor = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.WeightValuePath = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1317, 33, true);
                WriteLiteral("\r\n        </div>\r\n   </div>\r\n    ");
                EndContext();
            }
            );
            BeginContext(1353, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
