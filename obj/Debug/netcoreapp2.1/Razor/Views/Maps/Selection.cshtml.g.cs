#pragma checksum "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce7b9b32dc525c6055da872497de4b80a0a20230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maps_Selection), @"mvc.1.0.view", @"/Views/Maps/Selection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Maps/Selection.cshtml", typeof(AspNetCore.Views_Maps_Selection))]
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
#line 1 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7b9b32dc525c6055da872497de4b80a0a20230", @"/Views/Maps/Selection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Maps_Selection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("stroke", "white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("highlight-stroke", "white", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value-path", "Electors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color-value-path", "Candidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selection-color", "#EFB856", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tooltip-template", "template", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("shape-data-path", "State", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("shape-property-path", "name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("maps"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("shape-selected", "onSelect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.MapProperties __Syncfusion_JavaScript_DataVisualization_Models_MapProperties;
        private global::Syncfusion.JavaScript.MapCollectionTag __Syncfusion_JavaScript_MapCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ShapeLayer __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer;
        private global::Syncfusion.JavaScript.DataVisualization.Models.ShapeSetting __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 53, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">Map / Selection</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(258, 208, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample depicts the results of United States presidential election, 2012 using selection and highlight feature in the Syncfusion ASP.NET Web Forms Maps control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(498, 375, true);
                WriteLiteral(@"
    <div class=""Common"">
   <div style=""background-color: #FAFAF9;border-color: lightgray;border-width: 2px;opacity: 0.7;;height: 60px;width:240px"" >
		<span style=""color:Black;font-size:22px;margin:15px;margin-top:13px;margin-left:20px;margin-right:20px;height:25px;font-weight:Normal;"">USA Election 2012</span>   
   </div>
   <div style=""min-height:435px;"">
       ");
                EndContext();
                BeginContext(873, 841, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-map", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b379eb395de24690a6a1511f53c55cb5", async() => {
                    BeginContext(941, 13, true);
                    WriteLiteral("\r\n           ");
                    EndContext();
                    BeginContext(954, 742, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-layers", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59f5b1f5a2484fe2ba2bbd0ca1258c64", async() => {
                        BeginContext(964, 17, true);
                        WriteLiteral("\r\n               ");
                        EndContext();
                        BeginContext(981, 691, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-layer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6878e8585aa4121bb0b5ce78b0b76ec", async() => {
                            BeginContext(1252, 21, true);
                            WriteLiteral("\r\n                   ");
                            EndContext();
                            BeginContext(1273, 370, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-shape-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d6e03cf52f744c3aae3c16400e43d95", async() => {
                                BeginContext(1581, 43, true);
                                WriteLiteral("                      \r\n                   ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ShapeSetting>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting);
#line 22 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.StrokeThickness = 0.5;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("stroke-thickness", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.StrokeThickness, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.HighlightBorderWidth = 1;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("highlight-border-width", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.HighlightBorderWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.AutoFill = false;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("auto-fill", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.AutoFill, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.Stroke = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.HighlightStroke = (string)__tagHelperAttribute_1.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.ValuePath = (string)__tagHelperAttribute_2.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.ColorValuePath = (string)__tagHelperAttribute_3.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                            __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.SelectionColor = (string)__tagHelperAttribute_4.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 24 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.SelectionStrokeWidth = 2.5;

#line default
#line hidden
                            __tagHelperExecutionContext.AddTagHelperAttribute("selection-stroke-width", __Syncfusion_JavaScript_DataVisualization_Models_ShapeSetting.SelectionStrokeWidth, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1643, 19, true);
                            WriteLiteral("\r\n\r\n               ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.ShapeLayer>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer);
#line 20 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.LayerType = LayerType.Geometry;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("layer-type", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.LayerType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableMouseHover = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("enable-mouse-hover", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableMouseHover, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableSelection = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("enable-selection", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.EnableSelection, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowTooltip = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-tooltip", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowTooltip, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.TooltipTemplate = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShapeDataPath = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShapePropertyPath = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 21 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowMapItems = false;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-map-items", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.ShowMapItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.DataSource = ViewBag.datasource;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_DataVisualization_Models_ShapeLayer.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1672, 13, true);
                        WriteLiteral("\r\n           ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_MapCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.MapCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_MapCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1696, 9, true);
                    WriteLiteral("\r\n       ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_MapProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.MapProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_MapProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_DataVisualization_Models_MapProperties.ShapeSelected = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 18 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_MapProperties.EnableAnimation = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-animation", __Syncfusion_JavaScript_DataVisualization_Models_MapProperties.EnableAnimation, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1714, 2526, true);
                WriteLiteral(@"

                    </div>

            <div class=""popup"" id=""closepopup"" style=""margin-top:-150px;margin-left:75%;""> 
				     <table style=""margin-top:-10px;width:auto"">
                        <tr>
                            <td align=""left"" style=""padding:0.3px"">
                                <span id=""winner"" style=""color:green;font-size:18px;font-weight:bold;""></span>
                            </td>
                        </tr>
                        <tr>
                            <td align=""left"" style=""padding:0.3px"">
                                <span style=""color:Black;font-size:12px;font-weight:normal;"">State</span>
                            </td>
                            <td align=""left"" style=""padding:0.3px"">
                                <span style=""color:Black;font-size:12px;font-weight:normal;margin-left:8px"">:</span>
                            </td>
                            <td align=""left"" style=""padding:0.3px"">
                                <s");
                WriteLiteral(@"pan id=""state"" style=""color:Black;font-size:12px;font-weight:normal;margin-left:8px""></span>
                            </td>
                        </tr>
                        <tr>
                            <td align=""left"" style=""padding:0.3px"">
                                <span style=""color:Black;font-size:12px;font-weight:normal;"">Electoral Votes </span>           
                            </td>
                            <td align=""left"" style=""padding:0.3px"">
                                <span style=""color:Black;font-size:12px;font-weight:normal;margin-left:8px"">:</span>
                            </td>
                            <td align=""left"" style=""padding:0.3px"">
                                <span id=""votes"" style=""color:Black;font-size:12px;font-weight:normal;margin-left:8px""></span>
                            </td>
                        </tr>
                    </table>
				<div class=""close-btn"" id=""closebutton""  style=""margin-left:191px;margin-top:-96px");
                WriteLiteral(@"""><a href=""#"">X</a></div>
            </div>
            </div>

  <script  id=""template"" type=""application/jsrender"">
	<div class=""tip"">				
		<p class=""small"" style=""margin-top:8px"">
            <span style=""color:white;font-size:12px;font-weight:normal;"">State : {{:State}}</span>
        </p>
        <p class=""big"">
			<span style=""color:white;font-size:12px;font-weight:normal;"">Winner : {{:Candidate}}</span>
        </p>
	</div>          
    </script>   
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(4266, 9, true);
                WriteLiteral("\r\n<script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4275, "\"", 4322, 1);
#line 79 "D:\Samples_18.4.0.39\ASPNETCORE\samplebrowser\Views\Maps\Selection.cshtml"
WriteAttributeValue("", 4281, Url.Content("~/scripts/MapsData/USA.js"), 4281, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4323, 1960, true);
                WriteLiteral(@"></script>
 <script>
     $(""document"").ready(function () {
         var mapObj = $(""#maps"").data(""ejMap"");
         mapObj.model.layers[0].shapeData = usMap;
         mapObj.model.layers[0].shapeSettings.colorMappings =
             {equalColorMapping:
                     [{ value: ""Romney"", color: ""#D84444"" },
                         { value: ""Obama"", color: ""#316DB5"" }]
             };
         $(""#maps"").css(""height"", ""470px"");
         $(""#maps"").ejMap(""refresh"");

     });
    
     function onSelect(event) {
	 if (event.originalEvent.length>0) {
         var matched = jQuery.uaMatch(navigator.userAgent);
         var browser = matched.browser.toLowerCase();
		 var isIE11 = !!navigator.userAgent.match(/Trident\/7\./);
         if (isIE11)
			browser = ""msie"";
         var object = event.originalEvent[0].data;
         var popup = document.getElementById(""closepopup"");
         var closebutton = document.getElementById(""closebutton"");
         var winner = document.getElementBy");
                WriteLiteral(@"Id(""winner"");
         var state = document.getElementById(""state"");
         var vote = document.getElementById(""votes"");
         $(popup).css(""display"", ""block"");
		 $(closebutton).css({""display"":""block""});								
         $(closebutton).click(function () {
			var popup = document.getElementById(""closepopup"");
            var closebutton = document.getElementById(""closebutton"");
            $(popup).css(""display"", ""none"");
            $(closebutton).css(""display"", ""none"");
         });		          
         if (browser != ""mozilla"") {
             state.innerText = object.State;
             vote.innerText = object.Electors;
             winner.innerText = object.Candidate;
         }
         else {
             state.textContent = object.State;
             vote.textContent = object.Electors;
             winner.textContent = object.Candidate;
         }
		 }
     }

    
    
</script>
    ");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(6310, 1892, true);
                WriteLiteral(@"
     <style type=""text/css"">	 
            p.small {line-height:50%;}
            p.big {line-height:110%;}

            .tip {
                    border: 1px solid #4D4D4D;
                    box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
                    border-radius: 7px;
                    margin-right: 25px;
                    min-width: 110px;
                    padding-top: 9px;
                    padding-right: 10px;
                    padding-left: 10px;
                    width: auto;
                    height: auto;
                    background: #4D4D4D;
                }

            .popup {
                    border: 1px solid #5B5B5B;
                    box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
                    left:768px;
                    top:362px;                    
                    margin-bottom: 2em;
                    border-radius: 7px;
                    opacity:0.8;
                    display:none;
                    margin-right");
                WriteLiteral(@": 25px;
                    width: 190px;
                    padding: 1em;
                    height: 70px;
                    background: white;
                }

            .close-btn {
                border: 2px solid #5B5B5B;                
                padding: 1px 4px;
                top: 351px;
                opacity:0.8;
                background-color: #605F61;
                left: 975px;
                border-radius: 50%/50%; 
                width: 12px;
                height: 19px;
                display:none;
                z-index:1000;
            }

            .close-btn a {
                font-size: 12px;
                margin-left:2px;
                font-weight: bold;
                color: white;
                text-decoration: none;                
            }
        

	</style>
");
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
