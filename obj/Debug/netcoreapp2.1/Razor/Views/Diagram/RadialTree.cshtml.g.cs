#pragma checksum "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429f57ffaa3a5a4d10a14d919bf9fdabac5afb5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagram_RadialTree), @"mvc.1.0.view", @"/Views/Diagram/RadialTree.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Diagram/RadialTree.cshtml", typeof(AspNetCore.Views_Diagram_RadialTree))]
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
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429f57ffaa3a5a4d10a14d919bf9fdabac5afb5e", @"/Views/Diagram/RadialTree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagram_RadialTree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("template-id", "mouseovertoolTipId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("border-color", "transparent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("parent", "ReportingPerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("diagram"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "600px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("node-template", "nodeTemplate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.DiagramProperties __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.SnapSettings __Syncfusion_JavaScript_DataVisualization_Models_Diagram_SnapSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.Layout __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.PageSettings __Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.Tooltip __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Tooltip;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.Alignment __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Alignment;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DefaultSettings __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DefaultSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DiagramNode __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DiagramConnector __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramConnector;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DataSourceSettings __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DataSourceSettings;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(116, 66, true);
                WriteLiteral(" <span class=\"sampleName\">Diagram / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(203, 192, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample illustrates visualizing the organizational structure in the circular style by using ASP.NET CORE diagram\'s radial tree layout algorithm.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(423, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(431, 952, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-diagram", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e36f129f80fe46c6b4cf8aebee72a576", async() => {
                    BeginContext(556, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(566, 69, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-snap-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b057b483b17645e5babe3a2248f51779", async() => {
                        BeginContext(607, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_SnapSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.SnapSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_SnapSettings);
#line 10 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_SnapSettings.SnapConstraints = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.SnapConstraints.None;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("snap-constraints", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_SnapSettings.SnapConstraints, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(635, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(645, 85, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-layout", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56d6c870f5dd45c18f1a96050bae5b68", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.Layout>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout);
#line 12 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout.Type = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.LayoutTypes.RadialTree;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout.HorizontalSpacing = 30;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("horizontal-spacing", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout.HorizontalSpacing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout.VerticalSpacing = 30;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("vertical-spacing", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Layout.VerticalSpacing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(730, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(740, 71, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-page-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ce7fcdecb434536a27e5cc821e5cbe9", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.PageSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings);
#line 13 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings.ScrollLimit = ScrollLimit.Diagram;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("scroll-limit", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings.ScrollLimit, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(811, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(821, 145, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tooltip", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fb20552f1b4912b593c66c8d143f25", async() => {
                        BeginContext(865, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(879, 65, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-alignment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df86691efb14c5c83ed634b8be8d0df", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Alignment = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.Alignment>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Alignment);
#line 15 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Alignment.Horizontal = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.HorizontalAlignment.Center;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("horizontal", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Alignment.Horizontal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Alignment.Vertical = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.VerticalAlignment.Bottom;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("vertical", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Alignment.Vertical, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(944, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Tooltip = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.Tooltip>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_Tooltip);
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_Tooltip.TemplateId = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(966, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(976, 266, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-default-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a240d9e76373442c8b89bccd3694045d", async() => {
                        BeginContext(996, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1010, 141, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-node", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b7f2d21ac741a99b76cd3082ff23e6", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DiagramNode>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode);
#line 18 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Width = 50;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Height = 50;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.BorderColor = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 18 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Type = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.Shapes.Image;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Constraints = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.NodeConstraints.InheritTooltip | NodeConstraints.PointerEvents;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("constraints", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.Constraints, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1151, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1165, 46, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-connector", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "476ef00ee01545c7831467b47ca168ca", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramConnector = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DiagramConnector>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramConnector);
#line 19 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramConnector.Constraints = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.ConnectorConstraints.None;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("constraints", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramConnector.Constraints, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1211, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DefaultSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DefaultSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DefaultSettings);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1242, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1252, 112, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datasource-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "143a62b126d44f53b3dbe2c5316a0fee", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DataSourceSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DataSourceSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DataSourceSettings);
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DataSourceSettings.Id = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DataSourceSettings.Parent = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 21 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DataSourceSettings.DataSource = ViewBag.datasource;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("dataSource", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DataSourceSettings.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1364, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.DiagramProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.Height = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 9 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.EnableContextMenu = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-context-menu", __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.EnableContextMenu, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Diagram\RadialTree.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.Tool = global::Syncfusion.JavaScript.DataVisualization.DiagramEnums.Tool.ZoomPan;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tool", __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.Tool, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.NodeTemplate = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1383, 1632, true);
                WriteLiteral(@"
    <script type=""text/x-jsrender"" id=""mouseovertoolTipId"">
        <svg style=""position: relative; width: 150px; height: 75px;"">
            <g>
                <path fill=""#FFFFFF"" d=""M 147 75 H 3 c -1.7 0 -3 -1.3 -3 -2.8 V 2.8 C 0 1.3 1.3 0 3 0 h 144 c 1.7 0 3 1.3 3 2.8 v 69.4 C 150 73.7 148.7 75 147 75 Z"" />
                <path d=""M 147.2 74 H 2.8 c -1.3 0 -2.3 -0.6 -2.3 -1.4 V 68 h 149 v 4.6 C 149.5 73.3 148.4 74 147.2 74 Z"" fill=""{{:RatingColor}}"" />
                <path style=""fill: none; stroke: #D0D0D0; stroke-miterlimit: 10;"" d=""M 147.2 74.5 H 2.8 c -1.3 0 -2.3 -0.9 -2.3 -2.1 V 2.6 c 0 -1.2 1 -2.1 2.3 -2.1 h 144.5 c 1.3 0 2.3 0.9 2.3 2.1 v 69.8 C 149.5 73.5 148.4 74.5 147.2 74.5 Z"" />
                <text transform=""matrix(1 0 0 1 61.0801 16.0686)"" style=""fill: #2D2D2D; font-family: Segoe UI;font-weight:bold; font-size: 10px;"">{{:Name}}</text>
                <text transform=""matrix(1 0 0 1 61.0801 32.6208)"" style=""font-size: 10px; fill: #2D2D3A; font-family: Segoe UI;font-size: 9px;"">{");
                WriteLiteral(@"{:Designation:}}</text>
                <text transform=""matrix(1 0 0 1 61.0801 44.4484)"" style=""font-size: 10px; fill: #2D2D3A; font-family: 'Segoe UI';font-size: 9px;"">xyz@abc.com</text>
                <text transform=""matrix(1 0 0 1 61.0801 57.987)"" style=""font-size: 10px; fill: #2D2D3A; font-family: 'Segoe UI';font-size: 9px;"">456 789</text>
                <image style=""overflow: visible; enable-background: new;"" width=""116"" height=""121"" xlink:href=""{{:ImageUrl}}"" transform=""matrix(0.3763 0 0 0.3798 6.2543 10.1381)"">
                </image>
            </g>
        </svg>
    </script>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(3041, 290, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        //creating the node template
        function nodeTemplate(diagram, node) {
            node.source = node.ImageUrl;
        }
        $(document).ready(function () { $(""#diagram"").ejDiagram(""instance"").fitToPage() });
    </script>

");
                EndContext();
            }
            );
            BeginContext(3334, 248, true);
            WriteLiteral("<style>\r\n    .svg-rotate-ie:hover {\r\n        cursor: url(\"~/wwwroot/css/content/ej/common-images/rotate.cur\"),default;\r\n    }\r\n\r\n    .svg-rotate {\r\n        cursor: url(\"~/wwwroot/css/content/ej/common-images/rotate.cur\"),default;\r\n    }\r\n</style>\r\n");
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
