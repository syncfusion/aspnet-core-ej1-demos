#pragma checksum "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968b2531d6441b7513ca1f7f7b8018983e1001b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagram_ShapesGallery), @"mvc.1.0.view", @"/Views/Diagram/ShapesGallery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Diagram/ShapesGallery.cshtml", typeof(AspNetCore.Views_Diagram_ShapesGallery))]
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
#line 1 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968b2531d6441b7513ca1f7f7b8018983e1001b9", @"/Views/Diagram/ShapesGallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagram_ShapesGallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("diagram"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "700px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "600px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.PageSettings __Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DefaultSettings __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DefaultSettings;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DiagramNode __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode;
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
                BeginContext(203, 146, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"ThThis sample demonstrates what are the built-in shapes available in the ASP.NET CORE diagram control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(377, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(383, 439, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-diagram", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "685346c48781482e903c96e0ad622999", async() => {
                    BeginContext(481, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(491, 69, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-snap-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d530fda8021467c9cc304258485b995", async() => {
                        BeginContext(532, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_SnapSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.SnapSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_SnapSettings);
#line 9 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
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
                    BeginContext(560, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(570, 71, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-page-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a43b2dc9f8b14c14a9b2cf5a2e35d6d1", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.PageSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_PageSettings);
#line 11 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
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
                    BeginContext(641, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(651, 152, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-default-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e9f915f6c074245a891739112feafc5", async() => {
                        BeginContext(671, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(685, 87, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-node", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c663a8c97542cc9839ac0376a27b69", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Diagram.DiagramNode>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode);
#line 13 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginLeft = 10;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("margin-left", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginLeft, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginBottom = 10;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("margin-bottom", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginBottom, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginRight = 10;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("margin-right", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginRight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginTop = 10;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("margin-top", __Syncfusion_JavaScript_DataVisualization_Models_Diagram_DiagramNode.MarginTop, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(772, 10, true);
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
                    BeginContext(803, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.DiagramProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.Height = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 8 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Diagram\ShapesGallery.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.EnableContextMenu = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-context-menu", __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.EnableContextMenu, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_DiagramProperties.Create = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(822, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(827, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(856, 774, true);
                WriteLiteral(@"
    <div id=""sampleProperties"">
        <div class=""prop-grid"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <b>Shapes</b>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-3 aligntop"" style=""margin-right:-25px;"">
                    Shapes
                </div>
                <div class=""col-md-3"">
                    <input type=""text"" id=""shapes"" />
                </div>

            </div>

        </div>
    </div>
    <div id=""list"">
        <ul>
            <li value=""basicshapes"">Basic Shapes</li>
            <li value=""flowshapes"">Flow Shapes</li>
            <li value=""bpmnshapes"">BPMN Shapes</li>

        </ul>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1656, 11312, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(""#sampleProperties"").ejPropertiesPanel();
        //Basic Shapes
        function basicShapes() {
            var nodes = [];
            var BasicShapes = ej.datavisualization.Diagram.BasicShapes;
            var offsetx = 90;
            var offsety = 100;
            var count = 0;
            for (var i in BasicShapes) {
                count++;
                basicnode = {
                    width: 40, height: 40, offsetX: offsetx, offsetY: offsety,
                    borderWidth: 1.5,
                    labels: [{
                        text: BasicShapes[i] == ""righttriangle"" ? ""Right Triangle"" :
                        BasicShapes[i].charAt(0).toUpperCase() + BasicShapes[i].substring(1),
                        verticalAlignment: ""top"", offset: { y: 1 }, margin: { top: 10 }
                    }],

                    type: ej.datavisualization.Diagram.Shapes.Basic, shape: BasicShapes[i],
                    pathData: getData(Bas");
                WriteLiteral(@"icShapes[i]), points: getData(BasicShapes[i])
                };


                offsetx = offsetx + 90;
                nodes.push(basicnode);
                if (count % 5 == 0) {
                    offsety = offsety + 100;
                    offsetx = 90;
                }
            }
            return nodes;
        }
        function getData(shape) {
            var value;
            if (shape == ""path"") {
                value = ""M78.631,3.425c-0.699-1.229-2.177-2.653-5.222-2.394c-8.975,0.759-26.612,16.34-30.804,22.411c-0.167-0.79-0.551-2.049-1.377-2.741c1.176-2.069,3.035-5.709,3.813-9.156c0.18-0.044,0.338-0.161,0.385-0.41c0.083-0.423,0.146-0.848,0.23-1.268c0.135-0.706-0.962-0.944-1.086-0.245c-0.078,0.431-0.158,0.852-0.234,1.286c-0.04,0.26,0.076,0.464,0.26,0.569c-0.756,3.361-2.575,6.93-3.737,8.975c-0.2-0.105-0.415-0.189-0.661-0.224c-0.07-0.009-0.132,0.005-0.199,0.003c-0.067,0.002-0.129-0.012-0.199-0.003c-0.246,0.035-0.461,0.119-0.661,0.224c-1.162-2.045-2.981-5.613-3.737-8.975c0.1");
                WriteLiteral(@"85-0.104,0.301-0.309,0.26-0.569c-0.076-0.434-0.156-0.855-0.234-1.286c-0.124-0.699-1.221-0.46-1.086,0.245c0.085,0.42,0.147,0.845,0.23,1.268c0.047,0.249,0.205,0.367,0.385,0.41c0.777,3.446,2.637,7.087,3.813,9.156c-0.826,0.692-1.21,1.951-1.377,2.741C33.203,17.371,15.566,1.789,6.591,1.031C3.546,0.772,2.068,2.196,1.369,3.425c-0.818,1.407-0.185,4.303,0.993,9.321c0.53,2.228,1.075,4.521,1.465,6.779c0.208,1.239,0.404,2.471,0.59,3.65c0.819,5.33,1.503,9.766,3.714,11.187c0.606,0.39,1.313,0.55,2.179,0.442c2.107-0.46,4.627-0.845,7.293-1.12c-2.613,1.77-5.88,4.65-6.953,8.474c-0.827,2.989-0.175,6.031,1.932,9.083c2.482,3.569,5.027,5.915,7.406,7.444c4.756,3.057,8.874,2.843,10.613,2.75c0.179-0.002,0.318-0.014,0.453-0.018c1.324-0.017,2.23-1.868,4.161-6.064c0.948-2.044,2.358-5.088,3.546-6.638c0.249,0.57,0.96,0.972,1.331,1.085c-0.03,0.014-0.067,0.039-0.094,0.049c0.034-0.007,0.074-0.03,0.111-0.042c0.022,0.006,0.055,0.023,0.074,0.027c-0.017-0.006-0.046-0.022-0.066-0.03c0.391-0.131,0.876-0.532,1.119-1.088c1.188,1.549,2.598,4.594,3.546,");
                WriteLiteral(@"6.638c1.931,4.196,2.838,6.047,4.161,6.064c0.135,0.004,0.274,0.016,0.453,0.018c1.739,0.093,5.857,0.307,10.613-2.75c2.379-1.529,4.924-3.875,7.406-7.444c2.106-3.052,2.759-6.094,1.932-9.083c-1.073-3.823-4.34-6.704-6.953-8.474c2.667,0.274,5.186,0.659,7.293,1.12c0.866,0.108,1.573-0.053,2.179-0.442c2.211-1.421,2.895-5.857,3.714-11.187c0.185-1.18,0.382-2.411,0.59-3.65c0.39-2.258,0.935-4.551,1.465-6.779C78.816,7.728,79.448,4.832,78.631,3.425z M41.184,48.732c-0.343,0.551-0.781,0.918-1.082,1.065c-0.324-0.135-0.933-0.497-1.286-1.065c0,0-1.506-19.959-1.349-24.911c0,0,0.509-3.147,2.533-3.169c2.024,0.022,2.533,3.169,2.533,3.169C42.69,28.773,41.184,48.732,41.184,48.732z"";
            }
            else if (shape == ""polygon"") {
                value = [{ x: 50, y: 1 }, { x: 100, y: 50 }, { x: 50, y: 100 }, { x: 1, y: 50 }];
            }
            return value;
        }
        //Flow Shapes
        function flowShapes() {
            var nodes = [];
            var offsetx = 100;
            var offsety = 110;");
                WriteLiteral(@"
            var count = 0;
            var FlowShapes = ej.datavisualization.Diagram.FlowShapes;
            for (var j in FlowShapes) {
                count++;
                var node = {
                    width: 40, height: setNodeSize(FlowShapes[j]), offsetX: offsetx,
                    offsetY: offsety,
                    borderWidth: 1.5,
                    labels: [{
                        text: setText(FlowShapes[j]),
                        offset: { y: 1 },
                        horizontalAlignment: ""center"", verticalAlignment: ""top"",
                        margin: { top: 10 }

                    }],
                    type: ej.datavisualization.Diagram.Shapes.Flow, shape: FlowShapes[j]
                };

                offsetx = offsetx + 100;
                nodes.push(node);
                if (count % 6 == 0) {
                    offsety = offsety + 110;
                    offsetx = 100;
                }
            }

            return nodes;
     ");
                WriteLiteral(@"   }
        function setNodeSize(size) {

            if ((size == ""process"") || (size == ""terminator"")) {
                var height = 20;
            }
            else if (size == ""decision"") {
                height = 35;
            }
            else if ((size == ""document"") || (size == ""papertap"") || (size == ""multidocument"") || (size == ""directdata"") || (size == ""predefinedprocess"")) {
                height = 30;
            }
            else {
                height = 40;
            }
            return height;
        }
        function setText(text) {
            if (text == ""predefinedprocess"") {
                var input = ""Predefined process"";
            }
            else if (text == ""sequentialdata"") {
                input = ""Sequential data"";
            }
            else if (text == ""multidocument"") {
                input = ""Multi document""
            }
            else if (text == ""summingjunction"") {
                input = ""Summing junction"";
        ");
                WriteLiteral(@"    }
            else if (text == ""internalstorage"") {
                input = ""Internal storage""
            }
            else if (text == ""manualoperation"") {
                input = ""Manual operation"";
            }
            else if (text == ""offpagereference"") {
                input = ""Offpage reference"";
            }
            else if (text == ""sequentialaccessstorage"") {
                input = ""Sequential access storage"";
            }

            else {
                input = text.charAt(0).toUpperCase() + text.substring(1);;
            }
            return input;
        }
        function bpmnShapes() {
            var nodes = [];
            var BPMNShapes = ej.datavisualization.Diagram.BPMNShapes;
            var offsetx = 100;
            var offsety = 100;

            //Default BPMN Shapes
            for (var k in BPMNShapes) {
                if (BPMNShapes[k] != ""sequentialflow"" && BPMNShapes[k] != ""associationflow"" && BPMNShapes[k] != ""messageflow"" && ");
                WriteLiteral(@"BPMNShapes[k] != ""group"") {
                    var node = {
                        width: 50, height: BPMNShapes[k] == ""message"" ? 35 : 50,

                        offsetX: offsetx, offsetY: offsety, labels: [{
                            text: BPMNShapes[k].charAt(0).toUpperCase() + BPMNShapes[k].substring(1)
                        }],
                        type: ej.datavisualization.Diagram.Shapes.BPMN, shape: BPMNShapes[k]
                    };
                    nodes.push(node);
                    offsetx = offsetx + 100;
                    if (nodes.length % 4 == 0) {
                        offsety = offsety + 100;
                        offsetx = 100;
                    }
                    if (BPMNShapes[k] == ""event"") {
                        addBPMNShape(""event"", ""noninterruptingstart"", ""NonInterrupting Start Event"", offsetx, offsety, nodes);
                        offsetx += 100;
                        addBPMNShape(""event"", ""intermediate"", ""Intermediate Event"", of");
                WriteLiteral(@"fsetx, offsety, nodes);
                        offsetx += 100;
                        addBPMNShape(""event"", ""end"", ""End Event"", offsetx, offsety, nodes);
                        offsetx = 100;
                        offsety += 100;
                    }
                    else if (BPMNShapes[k] == ""gateway"") {
                        addBPMNShape(""gateway"", ""complex"", ""Complex Gateway"", offsetx, offsety, nodes);
                        offsetx += 100;
                        addBPMNShape(""gateway"", ""inclusive"", ""Inclusive Gateway"", offsetx, offsety, nodes);
                        offsetx += 100;
                    }
                    else if (BPMNShapes[k] == ""activity"") {
                        var task = {
                            offsetX: 400, offsetY: 300, width: 40, height: 40, labels: [{ text: "" Send Task"" }],
                            type: ""bpmn"", shape: ""activity"", activity: ""task"", task: {
                                type: ej.datavisualization.Diagram.BPMNTasks.Send");
                WriteLiteral(@"
                            }
                        };
                        nodes.push(task);
                        offsetx += 100;
                        offsety += 100;
                    }
                }
            }


            return nodes;
        }
        function addBPMNShape(shape, subtype, text, offsetx, offsety, nodes) {
            var node = {
                type: ""bpmn"", shape: shape, offsetX: offsetx, offsetY: offsety,
                width: 50, height: 50, labels: [{ text: text, margin: { top: 15 } }]
            };
            if (shape == ""event"") node.event = subtype;
            else if (shape == ""gateway"") node.gateway = subtype;
            nodes.push(node);
        }
        var objects = basicShapes();
        function Create(args){
            if (!(ej.browserInfo().name === ""msie"" && Number(ej.browserInfo().version) < 9)) {
                $(""#diagram"").ejDiagram({
                    nodes: objects,
                });
            }
   ");
                WriteLiteral(@"         else{
                alert(""Diagram will not be supported in IE Version < 9"");
            }
            var diagram;
            diagram = $(""#diagram"").ejDiagram(""instance"");
        }
        $(""#shapes"").ejDropDownList({
            width: ""130px"",
            text: ""Basic Shapes"",
            targetID: ""list"",
            select: ""changeShape""
        });

        function changeShape(args) {
            if (args.value == ""basicshapes"") {
                var basic = basicShapes();
                $(""#diagram"").ejDiagram({

                    nodes: basic

                });
            }
            else if (args.value == ""flowshapes"") {
                var flow = flowShapes();
                $(""#diagram"").ejDiagram({
                    nodes: flow
                });
            }
            else if (args.value == ""bpmnshapes"") {
                var bpmn = bpmnShapes();
                $(""#diagram"").ejDiagram({
                    nodes: bpmn
              ");
                WriteLiteral("  });\r\n            }\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(12971, 248, true);
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
