#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b0f0b7e3d880ffef51b48e067f514dea4efb99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_ZoomingAndPanning), @"mvc.1.0.view", @"/Views/Chart/ZoomingAndPanning.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chart/ZoomingAndPanning.cshtml", typeof(AspNetCore.Views_Chart_ZoomingAndPanning))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b0f0b7e3d880ffef51b48e067f514dea4efb99", @"/Views/Chart/ZoomingAndPanning.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_ZoomingAndPanning : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Server CPU Load", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", "600", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Server", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label-format", "{value}%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("load", "onchartload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.ChartProperties __Syncfusion_JavaScript_DataVisualization_Models_ChartProperties;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ChartTitle __Syncfusion_JavaScript_DataVisualization_Models_ChartTitle;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ModelSize __Syncfusion_JavaScript_DataVisualization_Models_ModelSize;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Legend __Syncfusion_JavaScript_DataVisualization_Models_Legend;
        private global::Syncfusion.JavaScript.DataVisualization.Models.CommonSeriesOptions __Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Zooming __Syncfusion_JavaScript_DataVisualization_Models_Zooming;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Axis __Syncfusion_JavaScript_DataVisualization_Models_Axis;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Title __Syncfusion_JavaScript_DataVisualization_Models_Title;
        private global::Syncfusion.JavaScript.ChartCollectionTag __Syncfusion_JavaScript_ChartCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.Series __Syncfusion_JavaScript_DataVisualization_Models_Series;
        private global::Syncfusion.JavaScript.YAxis __Syncfusion_JavaScript_YAxis;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(105, 77, true);
                WriteLiteral("<span class=\"sampleName\">Chart / User Interaction/ Zooming and Panning</span>");
                EndContext();
            }
            );
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(212, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(233, 805, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-chart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c32dc919daa485885ca8cf4c8aac287", async() => {
                    BeginContext(296, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(310, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-title", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ad16d4f6ea1432d82880726a2e95ac8", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_ChartTitle = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ChartTitle>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ChartTitle);
                    __Syncfusion_JavaScript_DataVisualization_Models_ChartTitle.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(352, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(366, 30, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-size", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ea553a89ff44d3f9a50b1ad5c25271c", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_ModelSize = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ModelSize>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ModelSize);
                    __Syncfusion_JavaScript_DataVisualization_Models_ModelSize.Height = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(396, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(410, 37, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-legend", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fe47855539d439a93fb0af2f087946a", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Legend = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Legend>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Legend);
#line 11 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Legend.Visible = false;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("visible", __Syncfusion_JavaScript_DataVisualization_Models_Legend.Visible, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(447, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(461, 75, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-common-series-options", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8c7ab265ef42d1b4fac6b08d7adc52", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.CommonSeriesOptions>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions);
#line 12 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions.EnableAnimation = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable-animation", __Syncfusion_JavaScript_DataVisualization_Models_CommonSeriesOptions.EnableAnimation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(536, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(550, 64, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-zooming", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803ddf54a3fe43d6a1f1cf37c06b00bf", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Zooming = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Zooming>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Zooming);
#line 13 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Zooming.Enable = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable", __Syncfusion_JavaScript_DataVisualization_Models_Zooming.Enable, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Zooming.EnableMouseWheel = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("enable-mouse-wheel", __Syncfusion_JavaScript_DataVisualization_Models_Zooming.EnableMouseWheel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(614, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(628, 100, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-primary-x-axis", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa2b1bcd37f4f208288789d4816c2e4", async() => {
                        BeginContext(646, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(664, 31, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-title", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c286f94194984672bb19d3a1b8ebb51b", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Title = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Title>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Title);
                        __Syncfusion_JavaScript_DataVisualization_Models_Title.Text = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(695, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_Axis = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Axis>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Axis);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(728, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(742, 154, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-chart-series", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecdf70140bbc4e7186632aba6b602106", async() => {
                        BeginContext(758, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(776, 89, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-series", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb9a0990aa044eeb7b0ecd873d27c34", async() => {
                            BeginContext(834, 20, true);
                            WriteLiteral("\r\n\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_Series = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.Series>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_Series);
#line 18 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Series.Type = SeriesType.Line;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_DataVisualization_Models_Series.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_Series.Name = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 18 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_Series.Width = 2;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_DataVisualization_Models_Series.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(865, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_ChartCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.ChartCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ChartCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(896, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(910, 107, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-primary-y-axis", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dba3856ec97421abb0511b4149af4cc", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_YAxis = CreateTagHelper<global::Syncfusion.JavaScript.YAxis>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_YAxis);
                    __Syncfusion_JavaScript_YAxis.LabelFormat = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 22 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_YAxis.RangePadding = ChartRangePadding.Additional;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("range-padding", __Syncfusion_JavaScript_YAxis.RangePadding, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1017, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_ChartProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ChartProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ChartProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 8 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Chart\ZoomingAndPanning.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ChartProperties.CanResize = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("can-resize", __Syncfusion_JavaScript_DataVisualization_Models_ChartProperties.CanResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_ChartProperties.Load = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1038, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            BeginContext(1051, 826, true);
            WriteLiteral(@"<script type=""text/javascript"">
    function onchartload(sender) {
        loadTheme(sender);
        var data = GetData();
        sender.model.series[0].dataSource = data.Open;
        sender.model.series[0].xName = ""XValue"";
        sender.model.series[0].yName = ""YValue"";
    }
    function GetData() {
        var series1 = [];
        var value = 100;
        for (var i = 1; i < 250; i++) {
            if (Math.random() > .5) {
                value += Math.random();
            } else {
                value -= Math.random();
            }
            var point = { XValue: new Date(1970, i + 2, i), YValue: value };
            series1.push(point);
        }
        var data = { Open: series1 };
        return data;
    }
    $(""#controlarea"").css(""visibility"", ""visible"");
</script>

");
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
