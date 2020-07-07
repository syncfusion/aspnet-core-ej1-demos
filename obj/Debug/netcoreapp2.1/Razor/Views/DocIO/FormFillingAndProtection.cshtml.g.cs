#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\FormFillingAndProtection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3ddd72afbdeec54776ac0607c4d56e58c5554d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_FormFillingAndProtection), @"mvc.1.0.view", @"/Views/DocIO/FormFillingAndProtection.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/FormFillingAndProtection.cshtml", typeof(AspNetCore.Views_DocIO_FormFillingAndProtection))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\FormFillingAndProtection.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\FormFillingAndProtection.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ddd72afbdeec54776ac0607c4d56e58c5554d4", @"/Views/DocIO/FormFillingAndProtection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_FormFillingAndProtection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 66, true);
                WriteLiteral(" <span class=\"sampleName\">DocIO/Form Filling and Protection</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(196, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\FormFillingAndProtection.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Form Filling and Protection : Syncfusion";

#line default
#line hidden
                BeginContext(295, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\FormFillingAndProtection.cshtml"
      Html.BeginForm("FormFillingAndProtection", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(383, 2731, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to fill a form and protect the content controls in an existing Word document using Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: 27px"" />
                            &nbsp;
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""G");
                WriteLiteral(@"enerate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO allows you to create and edit content controls in the Word Open XML Format document (DOCX, DOTX, DOCM, DOTM). With the content control support, you can create a more functional form which gives built-in form filling experience.
                        <ul>
                            <li>
                                Content controls has several types plain text, rich text, picture, check box, combo box, drop down list, date picker, etc.
                            </li>
                            <li>
                                You can lock/unlock the content controls from deleting or content editing by the users. It helps in creating fillable form without using document protection functionality.
                            </li>
                            <li>
                  ");
                WriteLiteral(@"              You can also set editing restriction that does not allow the users to edit the Word document, except filling the content controls and form fields in the Word document.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the content controls can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-content-controls#form-filling"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 44 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\FormFillingAndProtection.cshtml"

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
