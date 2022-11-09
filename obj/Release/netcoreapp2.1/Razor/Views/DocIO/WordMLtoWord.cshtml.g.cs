#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4975931d57b80a8baa1c184db8b37f548006917e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_WordMLtoWord), @"mvc.1.0.view", @"/Views/DocIO/WordMLtoWord.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/WordMLtoWord.cshtml", typeof(AspNetCore.Views_DocIO_WordMLtoWord))]
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
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4975931d57b80a8baa1c184db8b37f548006917e", @"/Views/DocIO/WordMLtoWord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_WordMLtoWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 63, true);
                WriteLiteral(" <span class=\"sampleName\">Import and Export/WordMLToWord</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(193, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml"
      ViewBag.Title = "Essential DocIO (Word) : Import, Word XML To Word, Conversion : Syncfusion";

#line default
#line hidden
                BeginContext(297, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml"
      Html.BeginForm("WordMLToWord", "DocIO", FormMethod.Post, new { enctype = "multipart/form-data" });
        {

#line default
#line hidden
                BeginContext(414, 832, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to convert the Word processing XML to Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Select Document : 
                                ");
                EndContext();
                BeginContext(1247, 64, false);
#line 19 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml"
                           Write(Html.TextBox("file", "", new { type = "file", accept = ".xml" }));

#line default
#line hidden
                EndContext();
                BeginContext(1311, 1322, true);
                WriteLiteral(@"
                            </div>
                            <div class=""celldiv"" style=""margin-top: 10px"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""m");
                WriteLiteral(@"argin-top: 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Convert to Word"" style=""width:150px;height:27px"" />
                            <br />
                            <div class=""text-danger"">
                                ");
                EndContext();
                BeginContext(2634, 15, false);
#line 34 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml"
                           Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(2649, 706, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO provides support to convert the Word processing 2003 XML and Word processing XML document to Word document.
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about WordML conversion can be found on this
                        <a href=""https://help.syncfusion.com/file-formats/docio/conversion"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 49 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\DocIO\WordMLtoWord.cshtml"

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
