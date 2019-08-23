#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DocIO\EmployeeReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18445c790df83bb2289ceb32f2bd6948f91cf989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_EmployeeReport), @"mvc.1.0.view", @"/Views/DocIO/EmployeeReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/EmployeeReport.cshtml", typeof(AspNetCore.Views_DocIO_EmployeeReport))]
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
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DocIO\EmployeeReport.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DocIO\EmployeeReport.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18445c790df83bb2289ceb32f2bd6948f91cf989", @"/Views/DocIO/EmployeeReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_EmployeeReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 58, true);
                WriteLiteral(" <span class=\"sampleName\">Mail Merge/EmployeeReport</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(188, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DocIO\EmployeeReport.cshtml"
       ViewBag.Title = "    Essential DocIO (Word) : Mail merge, Report : Syncfusion";

#line default
#line hidden
                BeginContext(279, 5, true);
                WriteLiteral("     ");
                EndContext();
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DocIO\EmployeeReport.cshtml"
       Html.BeginForm("EmployeeReport", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(358, 3153, true);
                WriteLiteral(@"<div class=""Common"">
    <div class=""tablediv"">
        <div class=""rowdiv"">
            This sample demonstrates how to generate an employee report using Mail merge functionality of Essential DocIO.
        </div>
        &nbsp;
        <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
            Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
            <div class=""rowdiv"" style=""margin-top: 10px"">
                <div class=""celldiv"">
                    Save As :
                    <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                    <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                    &nbsp;
            ");
                WriteLiteral(@"        <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                    <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                    &nbsp;
                    <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                    <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                </div>
            </div>
            <div class=""rowdiv"" style=""margin-top: 8px"">
                <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: 27px"" />
                &nbsp;
                <input id=""generate"" name=""Button"" class=""buttonSty");
                WriteLiteral(@"le"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
            </div>
        </div>
        <br />
        <div class=""rowdiv"">
            With the mail merge support of DocIO, you can create a batch of personalized document or report very easily and fast.          
            <ul>
                <li>
                    You can design templates in Microsoft Word and allow DocIO to populate documents with data from various data sources such as business objects, ADO.NET objects, arrays, XML, dynamic objects, and relational objects.
                </li>
                <li>
                    Simple text, numeric data and image from data sources can be populated in Word documents using mail merge.
                </li>
            </ul>
        </div>
        <div class=""rowdiv"" style=""margin-top: 15px"">
            More information about the Mail merge can be found in this
            <a href=""https://help.syncfusion.com/file-formats/docio/working-with-mailmer");
                WriteLiteral("ge\">documentation</a>\r\n            section.\r\n        </div>\r\n    </div>\r\n</div>\r\n");
                EndContext();
#line 54 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\DocIO\EmployeeReport.cshtml"

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
