#pragma checksum "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pdf\AdventureCycle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16f58e10eea7b6de2a50fa30bac62cef8895ace0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_AdventureCycle), @"mvc.1.0.view", @"/Views/Pdf/AdventureCycle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/AdventureCycle.cshtml", typeof(AspNetCore.Views_Pdf_AdventureCycle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16f58e10eea7b6de2a50fa30bac62cef8895ace0", @"/Views/Pdf/AdventureCycle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_AdventureCycle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 70, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Tables /Adventure Cycle Works </span>\r\n");
                EndContext();
            }
            );
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(123, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 7 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pdf\AdventureCycle.cshtml"
      Html.BeginForm("AdventureCycle", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(203, 1163, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates creation of simple table report in the PDF document using <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-tables#creating-a-simple-table-using-pdfgrid-in-a-new-document"">PDF Grid.</a>Built-in <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-tables#built-in-table-styles"">table styles</a> is applied to the grid, will appear like Microsoft Office table style and more styling options are available.
                </div>
                <br/>
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div style=""border: solid 1px #EDEDED; padding: 5px 7px 5px 7px;"">
                                <table width=""100%"">
                                    <tr>
                                        <td align=""left"">");
                WriteLiteral("\r\n                                            <label> Choose built-in styles</label>   <br />\r\n                                            ");
                EndContext();
                BeginContext(1367, 44, false);
#line 22 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pdf\AdventureCycle.cshtml"
                                       Write(Html.DropDownList("styleName", "GridTable4"));

#line default
#line hidden
                EndContext();
                BeginContext(1411, 4705, true);
                WriteLiteral(@"
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <div style=""border: solid 1px #EDEDED; padding: 5px 7px 5px 7px; margin-top:8px; margin-bottom:8px"">
                                                <table width=""100%"">
                                                    <tr>
                                                        <td>
                                                            <label for=""Opentype"">
                                                                Built-in style settings
                                                            </label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align=""left"">
        ");
                WriteLiteral(@"                                                    <input id=""header"" type=""checkbox"" name=""Header"" checked=""checked"" value=""header"" />
                                                            <label for=""Hader row"">Header row</label>
                                                        </td>
                                                        <td align=""left"">
                                                            <input id=""bandedrow"" type=""checkbox"" name=""Bandedrow"" checked=""checked"" value=""bandedrow"" />
                                                            <label for=""Banded row""> Banded row</label>
                                                        </td>
                                                        <td align=""left"">
                                                            <input id=""firstcolumn"" type=""checkbox"" name=""Firstcolumn"" value=""firstcolumn"" />
                                                            <label for=""First column"">First column</labe");
                WriteLiteral(@"l>
                                                        </td>


                                                    </tr>
                                                    <tr>
                                                        <td align=""left"">
                                                            <input id=""lastrow"" type=""checkbox"" name=""Lastrow"" value=""lastrow"" />
                                                            <label for=""Last row"">Last row</label>
                                                        </td>

                                                        <td align=""left"">
                                                            <input id=""bandedcolumn"" type=""checkbox"" name=""Bandedcolumn"" value=""bandedcolumn"" />
                                                            <label for=""Banded column"">Banded column</label>
                                                        </td>
                                                        <td align=""left");
                WriteLiteral(@""">
                                                            <input id=""lastcolumn"" type=""checkbox"" name=""Lastcolumn"" value=""lastcolumn"" />
                                                            <label for=""Last column"">Last column</label>
                                                        </td>

                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                                <br />
                                <div class=""tablediv"">
                                    <div class=""rowdiv"">
                                        <div class=""celldiv"">
                                            <div>
                                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
         ");
                WriteLiteral(@"                                   </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
                <br/>
                <div style=""font-size: 17px;font-weight: 400;"">

                    More information about the tables can be found in this documentation<a href=""https://help.syncfusion.com/file-formats/pdf/working-with-tables""> section.</a>
                </div>
            </div>
");
                EndContext();
#line 95 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Pdf\AdventureCycle.cshtml"
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
