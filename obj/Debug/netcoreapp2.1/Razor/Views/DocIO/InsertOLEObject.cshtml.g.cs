#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\InsertOLEObject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d4f78589651834d1bba67e7fd455a28db539e99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_InsertOLEObject), @"mvc.1.0.view", @"/Views/DocIO/InsertOLEObject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/InsertOLEObject.cshtml", typeof(AspNetCore.Views_DocIO_InsertOLEObject))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\InsertOLEObject.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\InsertOLEObject.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4f78589651834d1bba67e7fd455a28db539e99", @"/Views/DocIO/InsertOLEObject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_InsertOLEObject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 63, true);
                WriteLiteral(" <span class=\"sampleName\">Insert Content/InsertOLEObject</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(193, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\InsertOLEObject.cshtml"
      ViewBag.Title = "Essential DocIO (Word) : OLE Object : Syncfusion";

#line default
#line hidden
                BeginContext(271, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\InsertOLEObject.cshtml"
      Html.BeginForm("InsertOLEObject", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(350, 2974, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to insert OLE Object into the Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:matc");
                WriteLiteral(@"h-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top:");
                WriteLiteral(@" 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        With DocIO, you can insert an OLE Object as either link or embed into the Word document. You can extract the OLE Object data from the Word document and save as native file.
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the OLE Objects can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-paragraph#appending-ole-objects"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 44 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\InsertOLEObject.cshtml"

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
