#pragma checksum "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pdf\DrawingShapes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddab17f28e3b160f2d61f9970bf2b4d580110ddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_DrawingShapes), @"mvc.1.0.view", @"/Views/Pdf/DrawingShapes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/DrawingShapes.cshtml", typeof(AspNetCore.Views_Pdf_DrawingShapes))]
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
#line 1 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddab17f28e3b160f2d61f9970bf2b4d580110ddc", @"/Views/Pdf/DrawingShapes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_DrawingShapes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 72, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Graphics / Drawing Shapes Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(125, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pdf\DrawingShapes.cshtml"
      Html.BeginForm("DrawingShapes", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(202, 935, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates drawing of <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-shapes"">shapes</a>
                    such as Ellipse, Arcs, Polygon, Pie, and Rectangle in the PDF document with gradient and <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-colorspace"">color spaces.</a>
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
                EndContext();
#line 24 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pdf\DrawingShapes.cshtml"
            Html.EndForm();
        }
    

#line default
#line hidden
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