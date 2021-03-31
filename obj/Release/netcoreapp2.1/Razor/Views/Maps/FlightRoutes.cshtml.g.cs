#pragma checksum "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\Maps\FlightRoutes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cafa73c7fea7ecce632e29e3760ce5e97b0eac8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maps_FlightRoutes), @"mvc.1.0.view", @"/Views/Maps/FlightRoutes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Maps/FlightRoutes.cshtml", typeof(AspNetCore.Views_Maps_FlightRoutes))]
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
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\Maps\FlightRoutes.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\Maps\FlightRoutes.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\Maps\FlightRoutes.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\Maps\FlightRoutes.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cafa73c7fea7ecce632e29e3760ce5e97b0eac8e", @"/Views/Maps/FlightRoutes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Maps_FlightRoutes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 57, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">Map / Flight Routes</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(262, 162, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates the tooltip feature based on USA population in the Syncfusion ASP.NET Web Forms Maps control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(452, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\Maps\FlightRoutes.cshtml"
      
        var airports = ViewData["airports"];
        var intermediatestops1 = ViewData["intermediatestops1"];
        var intermediatestops2 = ViewData["intermediatestops2"];
        var mapData = ViewData["mapdata"];
        var flightRoutes = ViewData["flightRoutes"];
        var flightRoutesdata = ViewData["flightRoutes_data"];
        var airportsdata = ViewData["airports_data"];
        var intermediatestops1Data = ViewData["intermediatestops1_data"];
        var intermediatestops2Data = ViewData["intermediatestops2_data"];
     

#line default
#line hidden
                BeginContext(1014, 391, true);
                WriteLiteral(@"     <div class=""Common"">
	   <div style=""background-color: #FAFAF9;border-color: lightgray;border-width: 2px;opacity: 0.7;height: 60px;width:350px"" >
			<span style=""color:Black;font-size:22px;margin:15px;margin-top:13px;margin-left:20px;margin-right:20px;height:25px;font-weight:Normal;"">Chennai - Raleigh Flight Routes</span>   
       </div>	 
	   <div style=""min-height:435px;"">		
");
                EndContext();
#line 29 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\Maps\FlightRoutes.cshtml"
          Html.EJ().Map("map")

                            .EnableAnimation(true)
                            .EnableResize(false)
                            .NavigationControl(nc =>
                            {
                                nc.EnableNavigation(true)
                          .Orientation(Orientation.Vertical)
                          .AbsolutePosition(new ShapePoint(5, 10))
                          .DockPosition(DockPosition.None);
                            })
                            .Layers(lr =>
                            {
                                lr.LayerType(LayerType.Geometry)
                                  .EnableMouseHover(false)
                                  .EnableSelection(false)
                                  .ShowMapItems(false)
                              .ShapeSettings(ss =>
                              {
                                  ss.Fill("#C6C35C")
                              .AutoFill(false)
                              .HighlightStroke("white")
                              .Stroke("white")
                              .StrokeThickness(0.5)
                              .HighlightBorderWidth(1)
                              .HighlightColor("#BFBFBF");
                              })
                               .SubLayers(sl =>
                               {
                                   sl.LayerType(LayerType.Geometry)
                               .ShapePropertyPath("name")
                               .EnableMouseHover(true)
                               .EnableSelection(false)
                               .ShowTooltip(true)
                               .TooltipTemplate("flightroute_template")
                               .ShapeDataPath("Name")
                               .ShowMapItems(false)
                               .DataSource(flightRoutesdata)
                          .ShapeSettings(ssp =>
                                          {
                                              ssp.HighlightBorderWidth(2)
                                          .Fill("#BC0C0C")
                                          .Stroke("#BC0C0C")
                                          .SelectionColor("transparent")
                                          .HighlightColor("transparent")
                                          .HighlightStroke("#4E1493")
                                          .ValuePath("Departure")
                                      .StrokeThickness(1);
                                          })
                          .ShapeData(flightRoutes).Add();
                                   sl.LayerType(LayerType.Geometry)
                              .ShapePropertyPath("name")
                              .EnableMouseHover(true)
                              .EnableSelection(false)
                              .ShowTooltip(true)
                              .ShowMapItems(false)
                               .TooltipTemplate("airport_template")
                               .ShapeDataPath("Name")
                               .DataSource(airportsdata)
                         .ShapeSettings(ssp1 =>
                                         {
                                             ssp1.Fill("#BC0C0C")
                                               .Stroke("white")
                                               .SelectionColor("transparent")
                                               .HighlightColor("transparent")
                                               .HighlightStroke("white")
                                                .ValuePath("Departure")
                                           .StrokeThickness(0.1);
                                         })
                         .ShapeData(airports).Add();
                                   sl.LayerType(LayerType.Geometry)
                               .ShapePropertyPath("name")
                               .EnableMouseHover(true)
                               .EnableSelection(false)
                               .ShowTooltip(true)
                               .ShowMapItems(false)
                               .TooltipTemplate("intermediatestop1_template")
                               .ShapeDataPath("Name")
                               .DataSource(intermediatestops1Data)
                          .ShapeSettings(ssp2 =>
                                          {
                                              ssp2.Fill("#4E1493")
                                                .Stroke("white")
                                                .SelectionColor("transparent")
                                                .HighlightColor("transparent")
                                                .HighlightStroke("white")
                                                 .ValuePath("Departure")
                                            .StrokeThickness(0.1);
                                          })
                          .ShapeData(intermediatestops1).Add();
                                   sl.LayerType(LayerType.Geometry)
                             .ShapePropertyPath("name")
                             .EnableMouseHover(true)
                             .EnableSelection(false)
                             .ShowMapItems(false)
                             .ShowTooltip(true)
                             .TooltipTemplate("intermediatestop2_template")
                             .ShapeDataPath("Name")
                             .DataSource(intermediatestops2Data)
                        .ShapeSettings(ssp3 =>
                                        {
                                            ssp3.Fill("#4E1493")
                                              .Stroke("white")
                                              .SelectionColor("transparent")
                                              .HighlightColor("transparent")
                                              .HighlightStroke("white")
                                               .ValuePath("Departure")
                                          .StrokeThickness(0.1);
                                        })
                        .ShapeData(intermediatestops2).Add();
                               })

                              .ShapeData(mapData).Add();
                            }).Render();

           

#line default
#line hidden
                BeginContext(7934, 12666, true);
                WriteLiteral(@"                        </div>

                    <script  id=""airport_template"" type=""application/jsrender"">
                        <div class=""popup"" id=""closepopup""> 
                        <table align=""Left"">
                               <tr>
                                   <td align=""left"" >
                                       <span style=""color:#333333;font-size:14px;font-weight:bold;"">{{:Name}}</span>
                                   </td>
                               </tr>
                            <tr>
                                   <td align=""left"" >
                                       <span style=""color:green;font-size:14px;font-weight:bold;"">Flight Routes  </span>
                                   </td>
                               </tr>
                         </table>
				        <table align=""Left"" style=""margin-top:0px;width:auto"">
                        <tr id=""info1"">
                            <td align=""left"" style=""padding-right:5px;paddin");
                WriteLiteral(@"g-top:7px"" >
                                <p class=""small"" id=""Departure1"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Departure}} - </p>           
                            </td>
                            <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""route1_stop1"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route1_Stop1}} - </p>
                            </td>
                            <td align=""left"" id=""route1"" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""route1_stop2"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route1_Stop2}} - </p>
                            </td>
                            <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""Arrival1"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Arrival}}</p>
        ");
                WriteLiteral(@"                    </td>
                        </tr>
                        <tr id=""info2"" class=""divider1"">
                            <td align=""left"" style=""padding-right:5px;padding-top:7px"" >       
                                <p class=""small"" id=""Departure2"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Departure}} - </p>           
                            </td>
                            <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""route2_stop1"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route2_Stop1}} - </p>
                            </td>
                            <td align=""left"" id=""route2"" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""route2_stop2"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route2_Stop2}} - </p>
                            </td>
                            <td align=""left""");
                WriteLiteral(@" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""Arrival2"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Arrival}}</p>
                            </td>
                        </tr>
                         <tr id=""info3"" class=""divider1"">
                            <td align=""left"" style=""padding-right:5px;padding-top:7px"" >       
                                <p class=""small"" id=""Departure3"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Departure}} - </p>           
                            </td>
                            <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""route3_stop1"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route3_Stop1}} - </p>
                            </td>
                            <td align=""left"" id=""route3"" style=""padding-left:8px;padding-top:7px"" >        
                             ");
                WriteLiteral(@"   <p class=""small"" id=""route3_stop2"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route3_Stop2}} - </p>
                            </td>
                            <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                <p class=""small"" id=""Arrival3"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Arrival}}</p>
                            </td>
                        </tr>
                    </table>
                        </div>
                    </script>

                    <script  id=""intermediatestop1_template"" type=""application/jsrender"">  
                        <div class=""popup"" style=""height:75px""> 
                            <table align=""Left"">
                                   <tr>
                                       <td align=""left"" >
                                           <span style=""color:#333333;font-size:14px;font-weight:bold;"">{{:Name}}</span>
                                       </");
                WriteLiteral(@"td>
                                   </tr>
                                <tr>
                                       <td align=""left"" >
                                           <span style=""color:green;font-size:14px;font-weight:bold;"">Flight Route  </span>
                                       </td>
                                   </tr>
                             </table>
				             <table align=""Left"" style=""margin-top:0px;width:auto"">
                                <tr id=""Tr1"">
                                    <td align=""left"" style=""padding-right:5px;padding-top:7px"" >
                                        <p class=""small"" id=""P1"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Departure}} - </p>           
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P2"" style=""color:#4E1493;font-size:14px;font-");
                WriteLiteral(@"weight:Bold;"">{{:Route1_Stop1}} - </p>
                                    </td>
                                    <td align=""left"" id=""Td1"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P3"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route1_Stop2}} - </p>
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P4"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Arrival}}</p>
                                    </td>
                                </tr>                        
                            </table>
                        </div>
                    </script>

                    <script  id=""intermediatestop2_template"" type=""application/jsrender"">  
                        <div class=""popup"" style=""height:100px""> 
                      ");
                WriteLiteral(@"      <table align=""Left"">
                                   <tr>
                                       <td align=""left"" >
                                           <span style=""color:#333333;font-size:14px;font-weight:bold;"">{{:Name}}</span>
                                       </td>
                                   </tr>
                                <tr>
                                       <td align=""left"" >
                                           <span style=""color:green;font-size:14px;font-weight:bold;"">Flight Route  </span>
                                       </td>
                                   </tr>
                             </table>
				             <table align=""Left"" style=""margin-top:0px;width:auto"">
                                <tr id=""Tr3"">
                                    <td align=""left"" style=""padding-right:5px;padding-top:7px"" >
                                        <p class=""small"" id=""P9"" style=""color:#333333;font-size:14px;font-weight:normal");
                WriteLiteral(@";"">{{:Departure}} - </p>           
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P10"" style=""color:#4E1493;font-size:14px;font-weight:Bold;"">{{:Route1_Stop1}} - </p>
                                    </td>
                                    <td align=""left"" id=""Td3"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P11"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route1_Stop2}} - </p>
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P12"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Arrival}}</p>
                                    </td>
                                </tr>        
       ");
                WriteLiteral(@"                         <tr id=""Tr4"">
                                    <td align=""left"" style=""padding-right:5px;padding-top:7px"" >       
                                        <p class=""small"" id=""P13"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Departure}} - </p>           
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P14"" style=""color:#4E1493;font-size:14px;font-weight:Bold;"">{{:Route2_Stop1}} - </p>
                                    </td>
                                    <td align=""left"" id=""Td4"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P15"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route2_Stop2}} - </p>
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;p");
                WriteLiteral(@"adding-top:7px"" >        
                                        <p class=""small"" id=""P16"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Arrival}}</p>
                                    </td>
                                </tr>                 
                            </table>
                        </div>
                    </script>

                    <script  id=""flightroute_template"" type=""application/jsrender"">  
                        <div class=""popup"" style=""height:50px""> 
                            <table align=""Left"">
                                <tr>
                                       <td align=""left"" >
                                           <span style=""color:green;font-size:14px;font-weight:bold;"">Flight Route  </span>
                                       </td>
                                   </tr>
                             </table>
				             <table align=""Left"" style=""margin-top:0px;width:auto"">
                             ");
                WriteLiteral(@"   <tr id=""Tr2"">
                                    <td align=""left"" style=""padding-right:5px;padding-top:7px"" >
                                        <p class=""small"" id=""P5"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Departure}} - </p>           
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P6"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route1_Stop1}} - </p>
                                    </td>
                                    <td align=""left"" id=""Td2"" style=""padding-left:8px;padding-top:7px"" >        
                                        <p class=""small"" id=""P7"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Route1_Stop2}} - </p>
                                    </td>
                                    <td align=""left"" style=""padding-left:8px;padding-top:7px"" >        
   ");
                WriteLiteral(@"                                     <p class=""small"" id=""P8"" style=""color:#333333;font-size:14px;font-weight:normal;"">{{:Arrival}}</p>
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
            DefineSection("StyleSection", async() => {
                BeginContext(20627, 613, true);
                WriteLiteral(@"
	<style type=""text/css"">
.e-map{
	background-color:white;
	}

            p.small {line-height:50%;}
            p.big {line-height:110%;}

            .divider1 { border-top: 0.1px solid #DDDDDD; }
            
            .popup {
                    border: 1px solid #5B5B5B;
                    box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
                    border-radius: 7px;
                    opacity:0.8;
                    width: 190px;
                    padding: 8px;
                    height: 125px;
                    background: white;
                }

			</style>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(21266, 224, true);
                WriteLiteral("\r\n <script>\r\n     $(\"document\").ready(function () {\r\n         if (!window.SVGSVGElement) {\r\n             $(\"#map\").css(\"min-height\", \"470px\");\r\n             $(\"#map\").ejMap(\"refresh\");\r\n         }\r\n     });\r\n\t\r\n\r\n</script>\r\n");
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
