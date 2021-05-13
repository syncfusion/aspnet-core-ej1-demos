#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DocIO\PieChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0229e33195e0e6dc9761a5fdb1af4ddae42e4c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_PieChart), @"mvc.1.0.view", @"/Views/DocIO/PieChart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/PieChart.cshtml", typeof(AspNetCore.Views_DocIO_PieChart))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DocIO\PieChart.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DocIO\PieChart.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0229e33195e0e6dc9761a5fdb1af4ddae42e4c82", @"/Views/DocIO/PieChart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_PieChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 47, true);
                WriteLiteral(" <span class=\"sampleName\">Chart/PieChart</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(177, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DocIO\PieChart.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : PieChart : Syncfusion";

#line default
#line hidden
                BeginContext(257, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DocIO\PieChart.cshtml"
      Html.BeginForm("PieChart", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(329, 2949, true);
                WriteLiteral(@"<div class=""Common"">
    <div class=""tablediv"">
        <div class=""rowdiv"">
            This sample demonstrates how to insert a pie chart into the Word document using Essential DocIO.
        </div>
        &nbsp;
        <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
            Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
            <div class=""rowdiv"" style=""margin-top: 10px"">
                <div class=""celldiv"">
                    Save As :
                    <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                    <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                    &nbsp;
   ");
                WriteLiteral(@"                 <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                    <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                    &nbsp;
                    <input type=""radio"" id=""rdButtonPDF"" name=""Group1"" value=""PDF"" style=""margin-left: 7px"" />
                    <label for=""rdButtonPDF"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as PDF"">PDF</label>
                </div>
            </div>
            <div class=""rowdiv"" style=""margin-top: 8px"">
                <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
            </div>
        </div>
        <br />
        <div class=""rowdiv"">
            With DocIO, you can create bus");
                WriteLiteral(@"iness or survey reports with intuitive graphical data visualization using chart in Word document and export as PDF.
            <ul>
                <li>
                    You can modify chart data in the existing Word document and refresh the visualization of chart.
                </li>
                <li>
                    You can customize the appearance of the chart by chart axis, series, data labels, and 3D formats.
                </li>
                <li>
                    You can save the chart in Word document as image.
                </li>
            </ul>
        </div>
        <div class=""rowdiv"" style=""margin-top: 15px"">
            More information about the charts can be found in this
            <a href=""https://help.syncfusion.com/file-formats/docio/working-with-charts"">documentation</a>
            section.
        </div>
    </div>
</div>
");
                EndContext();
#line 55 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\DocIO\PieChart.cshtml"
            Html.EndForm();
        }

#line default
#line hidden
            }
            );
            BeginContext(3322, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
