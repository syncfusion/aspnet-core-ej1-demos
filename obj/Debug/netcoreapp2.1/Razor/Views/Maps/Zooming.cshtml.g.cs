#pragma checksum "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0638d7271a3f77cc7bc98a9cd6097cf08324d261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maps_Zooming), @"mvc.1.0.view", @"/Views/Maps/Zooming.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Maps/Zooming.cshtml", typeof(AspNetCore.Views_Maps_Zooming))]
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
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0638d7271a3f77cc7bc98a9cd6097cf08324d261", @"/Views/Maps/Zooming.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Maps_Zooming : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 51, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">Map / Zooming</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(268, 144, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates the zooming functionality in the Syncfusion ASP.NET Web Forms Maps control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(440, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml"
           
             var mapData = ViewData["mapdata"];
             var latLongPoints = ViewData["latLongPoints"];

         

#line default
#line hidden
                BeginContext(579, 421, true);
                WriteLiteral(@"   <div class=""Common"">
   <div style=""background-color: white;border-color: lightgray;border-width: 2px;opacity: 0.7;height: 60px;margin-left:80%;"" >
		<select size=""1"" style=""margin: 10px;width: 180px;margin-top: 15px; border-width: 1px;border-color: lightgray;margin-left: 15px;height: 30px"" id=""countriesCombo""
			onchange=""buttonClick(this)"">
        </select>
   </div>
   <div style=""min-height:435px;"">   
");
                EndContext();
#line 28 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml"
      Html.EJ().Map("map")
                                 .ClientSideEvents(eve =>
                                 {
                                     eve.OnRenderComplete("onLoad");
                                 })
                                  .EnableAnimation(true)
                                 .CenterPosition(new ShapePoint(38.5000, -98))
                                 .NavigationControl(nc =>
                                 {
                                     nc.EnableNavigation(true)
                           .Orientation(Orientation.Vertical)
                           .AbsolutePosition(new ShapePoint(5, 10))
                           .DockPosition(DockPosition.None);
                                 })
                                .ZoomSettings(zm =>
                                {
                                    zm.EnableZoomOnSelection(true);
                                })
                                .Layers(lr =>
                                {
                                    lr.ShowTooltip(false)
                          .EnableSelection(true)
                          .LayerType(LayerType.Geometry)
                          .EnableMouseHover(true)
                          .ShapeDataPath("Name")
                          .ShowMapItems(false)
                          .ShapePropertyPath("name")
                          .ShapeSettings(sp =>
                          {
                              sp.Fill("Grey")
                    .StrokeThickness(0.5)
                    .Stroke("White")
                    .HighlightColor("#F7CD1C")
                    .HighlightStroke("white")
                    .HighlightBorderWidth(1)
                    .ValuePath("Name")
                    .SelectionColor("#F96C0D")
                    .SelectionStroke("white")
                    .SelectionStrokeWidth(2)
                    .AutoFill(true);

                          })
                          .DataSource(latLongPoints)
                          .Add();
                                }).Render();

        

#line default
#line hidden
                BeginContext(3148, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(3204, 16, true);
                WriteLiteral("   \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3220, "\"", 3263, 1);
#line 79 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Maps\Zooming.cshtml"
WriteAttributeValue("", 3226, Url.Content("~/Scripts/WorldMap.js"), 3226, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3264, 1314, true);
                WriteLiteral(@"></script>
   <script>
       $(""document"").ready(function () {
           var mapObj = $(""#map"").data(""ejMap"");
           mapObj.model.layers[0].shapeData = world_map;
           $(""#map"").css(""height"", ""470px"");
           $(""#map"").ejMap(""refresh"");
           var htmlSelect = document.getElementById(""countriesCombo"");
           for (var i = 0; i < mapObj.model.layers[0].dataSource.length; i++) {
               var item = mapObj.model.layers[0].dataSource[i];
               var selectBoxOption = document.createElement(""option"");
               selectBoxOption.value = item.Name;
               selectBoxOption.text = item.Name;
               htmlSelect.add(selectBoxOption, null);
           }
       });
    
     function onLoad() {
         
        
     }

     function buttonClick() {
         var mapObj = $(""#map"").data(""ejMap"");
         var combo = $(""#countriesCombo"");
         var index = combo[0].selectedIndex;
         var lat = mapObj.model.layers[0].dataSource[index]");
                WriteLiteral(@".latitude;
         var lon = mapObj.model.layers[0].dataSource[index].longitude;
         var level = 4;
         $(""#map"").ejMap(""navigateTo"", lat, lon, level);
         $(""#map"").ejMap(""selectShape"", mapObj.model.layers[0].dataSource[index].Name, null, false);
     }

</script>
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
