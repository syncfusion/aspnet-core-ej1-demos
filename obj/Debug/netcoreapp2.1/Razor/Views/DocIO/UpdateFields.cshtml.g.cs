#pragma checksum "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\UpdateFields.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5b469834a2533a464442a1a3dd692f6cc960455"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_UpdateFields), @"mvc.1.0.view", @"/Views/DocIO/UpdateFields.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/UpdateFields.cshtml", typeof(AspNetCore.Views_DocIO_UpdateFields))]
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
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\UpdateFields.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\UpdateFields.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b469834a2533a464442a1a3dd692f6cc960455", @"/Views/DocIO/UpdateFields.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_UpdateFields : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 62, true);
                WriteLiteral(" <span class=\"sampleName\">Product Showcase/UpdateFields</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(192, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\UpdateFields.cshtml"
       ViewBag.Title = "    Essential DocIO (Word) : Update Fields : Syncfusion";

#line default
#line hidden
                BeginContext(278, 5, true);
                WriteLiteral("     ");
                EndContext();
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\UpdateFields.cshtml"
       Html.BeginForm("UpdateFields", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(355, 3225, true);
                WriteLiteral(@"<div class=""Common"">
    <div class=""tablediv"">
        <div class=""rowdiv"">
            This sample demonstrates how to update the fields available in the Word document using Essential DocIO. Here, in the example, merge fields and formula fields are used together to populate the net profit or loss.
        </div>
        &nbsp;
        <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
            Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
            <div class=""rowdiv"" style=""margin-top: 10px"">
                <div class=""celldiv"">
                    Save As :
                    <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                    <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""S");
                WriteLiteral(@"aves the resultant document as Word Doc format"">DOC</label>
                    &nbsp;
                    <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                    <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                    &nbsp;
                    <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                    <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                </div>
            </div>
            <div class=""rowdiv"" style=""margin-top: 8px"">
                <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: ");
                WriteLiteral(@"27px"" />
                &nbsp;
                <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
            </div>
        </div>
        <br />
        <div class=""rowdiv"">
            Fields in a Word document are like placeholders where the data can be populated or calculated dynamically based on various factors. Most commonly used fields are merge fields, Table of contents (TOC), page number related fields, IF fields, date fields etc.
        </div>
        <div class=""rowdiv"" style=""margin-top: 15px"">
            Another example: IF field compares two values and then inserts the text appropriate to the rest of the comparison. When used in a mail merge, the field can examine information in the merged data records, and populate appropriate text.
        </div>
        <div class=""rowdiv"" style=""margin-top: 15px"">
            More information about the fields and updating fields can be found in this
            <");
                WriteLiteral("a href=\"https://help.syncfusion.com/file-formats/docio/working-with-fields\">documentation</a>\r\n            section.\r\n        </div>\r\n    </div>\r\n</div>\r\n");
                EndContext();
#line 49 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\DocIO\UpdateFields.cshtml"

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
