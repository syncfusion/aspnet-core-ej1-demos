#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Maps\DrillDown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8fe98f9f05e3539eff78a79266c592120fb4c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maps_DrillDown), @"mvc.1.0.view", @"/Views/Maps/DrillDown.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Maps/DrillDown.cshtml", typeof(AspNetCore.Views_Maps_DrillDown))]
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
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Maps\DrillDown.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Maps\DrillDown.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Maps\DrillDown.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Maps\DrillDown.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8fe98f9f05e3539eff78a79266c592120fb4c6", @"/Views/Maps/DrillDown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Maps_DrillDown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 54, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">Map / Drill Down</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(263, 154, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates the sales data by using the bubbles in the Syncfusion ASP.NET Web Forms Maps control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(445, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Maps\DrillDown.cshtml"
      
        var datasource = ViewData["datasource"];
        var mapSalesData = ViewData["mapSalesData"];
        var randomcountriesData = ViewData["randomcountriesData"];
        var continentMapData = ViewData["continentMapdata"];
        var continentSalesMapData = ViewData["continentSalesMapdata"];
        var countriesRandomData = ViewData["countriesRandomData"];
        var africaMapData = ViewData["africaMapdata"];
        var asiaMapdata = ViewData["asiaMapdata"];
        var europeMapdata = ViewData["europeMapdata"];
        var northAmericaMapdata = ViewData["northAmericaMapdata"];
        var oceaniaMapdata = ViewData["oceaniaMapdata"];
        var southAmericaMapdata = ViewData["southAmericaMapdata"];


     

#line default
#line hidden
                BeginContext(1199, 654, true);
                WriteLiteral(@"     <div class=""Common"">
	   <div  id=""title"" style=""background-color: #FAFAF9;border-color: lightgray;border-width: 2px;opacity: 0.7;height: 60px;width:150px"" >
			<span style=""color:Black;font-size:22px;margin:15px;margin-top:13px;margin-left:20px;margin-right:20px;height:25px;font-weight:Normal;"">Sales Data</span>   
       </div>
	   <div id=""button1"" class=""backLabel"" onclick=""ClickFunction()"" style=""left:350px;top:290px;width:85px;height:28px;border-radius: 16px;background-color:#0F77B7;"">	   		
			<img style=""margin-left:15px;margin-top:6px;"" src=""../Images/map/backtext.png""/>			
	   </div>	
       <div style=""min-height:465px;"">
");
                EndContext();
#line 37 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Maps\DrillDown.cshtml"
            Html.EJ().Map("maps")

                      .ClientSideEvents(eve =>
                      {
                          eve.OnRenderComplete("onLoad");
                          eve.ShapeSelected("OnDrilled");
                      })



                        .CenterPosition(new ShapePoint(38.5000, -98))
                       .ZoomSettings(zm =>
                       {
                           zm.EnableZoom(false);
                       })
                        .EnableAnimation(true)
                        .Background("white")
                        .Layers(lr =>
                        {
                            lr.LayerType(LayerType.Geometry)
                     .EnableMouseHover(true)
                     .ShapeSettings(sp =>
                     {
                         sp.Stroke("black")
                        .Fill("#C3E6ED")
                        .HighlightColor("#63B7B7")
                        .SelectionColor("#207BB2")
                        .StrokeThickness(0.5);
                     })
                     .ShapeData(africaMapData).Add();
                            lr.LayerType(LayerType.Geometry)
                       .EnableSelection(true)
                       .ShapeDataPath("name")
                       .EnableMouseHover(true)
                       .ShapePropertyPath("name")
                       .ShowMapItems(false)
                       .DataSource(datasource)
                       .ShapeSettings(sp =>
                       {
                           sp.Fill("#C3E6ED")
                         .StrokeThickness(0.5)
                         .AutoFill(false)
                         .Stroke("white")
                         .HighlightColor("#63B7B7")
                         .HighlightStroke("white")
                         .ValuePath("name");
                       })

                       .ShapeData(continentMapData)
                       .SubLayers(ssl =>
                       {
                           ssl.ShapeDataPath("country")
                            .ShapePropertyPath("name")
                            .MapItemsTemplate("labeltemplate")
                            .ShowMapItems(true)
                            .EnableMouseHover(true)
                            .DataSource(countriesRandomData)
                            .ShapeSettings(ss =>
                                          {
                                              ss.Fill("#9FD0D3")
                                                .StrokeThickness(0.2)
                                                .Stroke("white")
                                                .HighlightColor("#63B7B7");
                                          })
                            .BubbleSettings(bs =>
                                          {
                                              bs.ValuePath("Sales")
                                              .ShowBubble(true)
                                              .MinValue(20)
                                              .MaxValue(30)
                                              .Color("#379F64");
                                          })
                            .ShapeData(continentSalesMapData).Add();
                       }).Add();

                            lr.LayerType(LayerType.Geometry)
                      .EnableMouseHover(true)
                      .ShapeSettings(sp =>
                      {
                          sp.Stroke("black")
                         .Fill("#C3E6ED")
                         .HighlightColor("#63B7B7")
                         .SelectionColor("#207BB2")
                         .StrokeThickness(0.5);
                      })
                      .ShapeData(asiaMapdata).Add();
                            lr.LayerType(LayerType.Geometry)
                        .EnableMouseHover(true)
                        .ShapeSettings(sp =>
                        {
                            sp.Stroke("black")
                          .Fill("#C3E6ED")
                          .HighlightColor("#63B7B7")
                          .SelectionColor("#207BB2")
                          .StrokeThickness(0.5);
                        })
                        .ShapeData(europeMapdata).Add();

                            lr.LayerType(LayerType.Geometry)
                        .EnableMouseHover(true)
                        .ShapeSettings(sp =>
                        {
                            sp.Stroke("black")
                          .Fill("#C3E6ED")
                          .HighlightColor("#63B7B7")
                          .SelectionColor("#207BB2")
                          .StrokeThickness(0.5);
                        })
                        .ShapeData(northAmericaMapdata).Add();


                            lr.LayerType(LayerType.Geometry)
                        .EnableMouseHover(true)
                        .ShapeSettings(sp =>
                        {
                            sp.Stroke("black")
                          .Fill("#C3E6ED")
                          .HighlightColor("#63B7B7")
                          .SelectionColor("#207BB2")
                          .StrokeThickness(0.5);
                        })
                        .ShapeData(oceaniaMapdata).Add();

                            lr.LayerType(LayerType.Geometry)
                        .EnableMouseHover(true)
                        .ShapeSettings(sp =>
                        {
                            sp.Stroke("black")
                          .Fill("#C3E6ED")
                          .HighlightColor("#63B7B7")
                          .SelectionColor("#207BB2")
                          .StrokeThickness(0.5);
                        })
                        .ShapeData(southAmericaMapdata).Add();



                        }).Render();
   

#line default
#line hidden
                BeginContext(7871, 398, true);
                WriteLiteral(@"              </div>


     <script  id=""labeltemplate"" type=""application/jsrender"">

    <div style=""margin-top:-10px;margin-left:-1px;"">
    <table style=""width:40px;"">
    <tr>
    <td>
   <span style=""color:Black;font-size:14px;width:40px;text-wrap:normal;font-weight:normal;text-align:center;"">{{:country}}</span>
   </td>
   </tr>
   </table>
   </div>
   </div>
   </script>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(8295, 2299, true);
                WriteLiteral(@"
 <script>
     $(""document"").ready(function () {
         if (!window.SVGSVGElement) {
             $(""#maps"").css(""min-height"", ""500px"");
             $(""#maps"").ejMap(""refresh"");
         }
     });
     
     function ClickFunction(event) {
         var button = document.getElementById(""button1"");
         $(button).css('background-color', '#028DC4');
         var mapObj = $(""#maps"").data(""ejMap"");
         mapObj.model.enableAnimation = false;
         mapObj.option(""baseMapIndex"", 1);
         $(button).fadeOut(500);
         var title = document.getElementById(""title"");
         $(title).css(""display"", ""block"");

     }
     function onLoad() {
         var button = document.getElementById(""button1"");
         $(button).css(""display"", ""none"");
         var title = document.getElementById(""title"");
         $(title).css(""display"", ""block"");
     }
     function OnDrilled(event) {
         if (event.model.baseMapIndex == 1) {
             var mapObj = $(""#maps"").data(""ejMap"");");
                WriteLiteral(@"
             mapObj.model.enableAnimation = true;
             if (event.originalEvent[0].data.continent == ""Africa"") {
                 mapObj.option(""baseMapIndex"", 0);
             }
             else if (event.originalEvent[0].data.continent == ""Asia"") {
                 mapObj.option(""baseMapIndex"", 2);
             }
             else if (event.originalEvent[0].data.continent == ""Europe"") {
                 mapObj.option(""baseMapIndex"", 3);
             }
             else if (event.originalEvent[0].data.continent == ""North America"") {
                 mapObj.option(""baseMapIndex"", 4);
             }
             else if (event.originalEvent[0].data.continent == ""Oceania"") {
                 mapObj.option(""baseMapIndex"", 5);
             }
             else if (event.originalEvent[0].data.continent == ""South America"") {
                 mapObj.option(""baseMapIndex"", 6);
             }
             var button = document.getElementById(""button1"");
             $(button).css('backgrou");
                WriteLiteral("nd-color\', \'#0F77B7\');\r\n             // $(button).css(\"display\", \"block\");\r\n             $(button).fadeIn(500);\r\n             var title = document.getElementById(\"title\");\r\n             $(title).css(\"display\", \"none\");\r\n         }\r\n     }\r\n</script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(10621, 106, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n    .backLabel:hover {\r\n        cursor:pointer;\r\n\t\t\r\n     }\r\n    </style>\r\n");
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
