#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\Styles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daf57cfc6d2970c9dc666d356f0077434fdb7596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_Styles), @"mvc.1.0.view", @"/Views/DocIO/Styles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/Styles.cshtml", typeof(AspNetCore.Views_DocIO_Styles))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\Styles.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\Styles.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daf57cfc6d2970c9dc666d356f0077434fdb7596", @"/Views/DocIO/Styles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_Styles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 50, true);
                WriteLiteral(" <span class=\"sampleName\">Formatting/Styles</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(180, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\Styles.cshtml"
      ViewBag.Title = "   Essential DocIO (Word) : Styles : Syncfusion";

#line default
#line hidden
                BeginContext(257, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\Styles.cshtml"
      Html.BeginForm("Styles", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(327, 4406, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to apply built-in and custom styles to the contents of the Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                <input type=""radio"" id=""Radio1"" name=""Group1"" value=""Built-in"" checked=""checked"" />
                                <label for=""Radio1"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip");
                WriteLiteral(@""">Built-In Styles</label>
                                &nbsp;
                                <input type=""radio"" id=""Radio2"" name=""Group1"" value=""custom"" />
                                <label for=""Radio2"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"">Custom Styles</label>
                            </div>
                            <div class=""celldiv"" style=""margin-top: 10px"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Group2"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group2"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
            ");
                WriteLiteral(@"                    <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group2"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
    ");
                WriteLiteral(@"                    DocIO supports various built-in styles and provides ability to create custom styles. These styles include both text and paragraph formatting options.                                         
                        <ul>
                            <li>
                                Using styles, you can quickly format a Word document and reuse the formatting for multiple parts of the document. 
                            </li>
                            <li>
                                The file size and code length can be reduced by referring styles, instead of formatting each element in the document.
                            </li>
                            <li>
                                You can also modify the formatting of an existing style in the Word document.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More informatio");
                WriteLiteral(@"n about the paragraph styles can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-paragraph#applying-paragraph-formatting"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 62 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\Styles.cshtml"

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
