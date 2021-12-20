#pragma checksum "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964bb48b632333d23757fba72232acecf4a56aee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_ExcelToPDF), @"mvc.1.0.view", @"/Views/XlsIO/ExcelToPDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/ExcelToPDF.cshtml", typeof(AspNetCore.Views_XlsIO_ExcelToPDF))]
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
#line 5 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToPDF.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"964bb48b632333d23757fba72232acecf4a56aee", @"/Views/XlsIO/ExcelToPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_ExcelToPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 50, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / ExcelToPDF</span>");
                EndContext();
            }
            );
            BeginContext(128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(156, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToPDF.cshtml"
            ViewBag.Title = "    Essential XlsIO (Excel) :Excel To PDF Conversion : Syncfusion";

#line default
#line hidden
                BeginContext(286, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToPDF.cshtml"
       Html.BeginForm("ExcelToPDF", "XlsIO", FormMethod.Post, new { enctype = "multipart/form-data" });
        {

#line default
#line hidden
                BeginContext(404, 4167, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample illustrates the conversion of Microsoft Excel document to PDF.
                        <br />Essential XlsIO allows to export Excel document to PDF by using the <b>Convert</b> method of <b>ExcelToPDFConverter</b> class.
                        <br />
                        <br /><b>Features:</b>
                        <br />
                        <ul>
                            <li>Supports conversion of Excel document to PDF document with cell values, cell styles, tables, charts, autoshapes, pictures, etc.</li>
                        </ul>
                        <br />
                        <b>Note:</b> Installation of Essential PDF and ExcelChartToImageConverter is necessary to run this sample
                        <br />
                        <br />
                        <label>Select Document</label>
                        <br ");
                WriteLiteral(@"/>
                        <input type=""file"" name=""file"" />
                        <br />
                    </div>
                    <div class=""rowdiv"">
                        Clicking the 'Convert to PDF' button will convert the Excel document to PDF. PDF viewer is needed to view the converted PDF document.
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <label>
                            PDF Page Setup options
                        </label>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            &nbsp; &nbsp; &nbsp;
                            <input type=""radio"" id=""noScaleRadioBtn"" name=""Group1"" value=""NoScaling"" />
                            <label for=""noScaleRadioBtn"">
                                NoScaling
                            </label>
                            &nbsp; &nbsp; &");
                WriteLiteral(@"nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                            <input type=""radio"" id=""allRowsRadioBtn"" name=""Group1"" value=""FitAllRowsOnOnePage"" />
                            <label for=""allRowsRadioBtn"">
                                FitAllRowsOnOnePage
                            </label>
                        </div>
                        <br />
                        <div class=""celldiv"">
                            &nbsp; &nbsp; &nbsp;
                            <input type=""radio"" id=""allColumnRadioBtn"" name=""Group1"" value=""FitAllColumnsOnOnePage"" />
                            <label for=""allColumnRadioBtn"">
                                FitAllColumnsOnOnePage
                            </label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <input type=""radio"" id=""fitSheetRadioBtn"" name=""Group1"" value=""FitSheetOnOnePage"" checked=""checked"" />
          ");
                WriteLiteral(@"                  <label for=""fitSheetRadioBtn"">
                                FitSheetOnOnePage
                            </label>
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <input type=""checkbox"" id=""checkfontStream"" name=""checkboxStream"" value=""Font Stream"" />
                            <label for=""checkfontStream"">
                                Font Stream
                            </label>
                            <br />
                            <h6>Missing fonts in the device will be substituted from embedded resource.</h6>
                        </div>
                        <br />
                        <div class=""celldiv"">
                            <input class=""buttonStyle"" type=""submit"" value=""Convert to PDF"" name=""button"" style=""width:150px"" />
                        </div>
                    </div>
 ");
                WriteLiteral("                   <br />\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 86 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToPDF.cshtml"
            Html.EndForm();
        }
    

#line default
#line hidden
            }
            );
            BeginContext(4621, 2, true);
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
