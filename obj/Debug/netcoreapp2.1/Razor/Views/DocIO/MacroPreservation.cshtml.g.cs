#pragma checksum "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\MacroPreservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1af0e3024614343ecdd50bb78a348801bfeaae0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_MacroPreservation), @"mvc.1.0.view", @"/Views/DocIO/MacroPreservation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/MacroPreservation.cshtml", typeof(AspNetCore.Views_DocIO_MacroPreservation))]
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
#line 1 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\MacroPreservation.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\MacroPreservation.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0e3024614343ecdd50bb78a348801bfeaae0f", @"/Views/DocIO/MacroPreservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_MacroPreservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(102, 55, true);
                WriteLiteral(" <span class=\"sampleName\">View/MacroPreservation</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(185, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\MacroPreservation.cshtml"
      ViewBag.Title = "   Essential DocIO (Word) : Macro Preservation : Syncfusion";

#line default
#line hidden
                BeginContext(274, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\MacroPreservation.cshtml"
      Html.BeginForm("MacroPreservation", "DocIO", FormMethod.Post);
 {

#line default
#line hidden
                BeginContext(348, 1726, true);
                WriteLiteral(@"<div class=""Common"">
    <div class=""tablediv"">
        <div class=""rowdiv"">
            This sample demonstrates preservation of macros in macro-enabled documents (DOCM and DOTM) using Essential DocIO.
        </div>
        &nbsp;
        <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
            Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.           
            <div class=""rowdiv"" style=""margin-top: 8px"">
                <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: 27px"" />
                &nbsp;
                <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
            </div>
        </div>
        <br />
        <div class=""rowdiv"">
            ");
                WriteLiteral(@"DocIO supports to preserve and remove the macros present in the Word Open XML macro-enabled document (DOCM and DOTM).            
        <ul>
            <li>
                You can generate forms, invoice and other reports with functional commands and controls in a Word Open XML macro-enabled document, starting from Word Open XML macro-enabled template.
            </li>
        </ul>
        </div>
        <div class=""rowdiv"" style=""margin-top: 15px"">
            More information about the macros can be found in this
            <a href=""https://help.syncfusion.com/file-formats/docio/working-with-macros"">documentation</a>
            section.
        </div>
    </div>
</div>
");
                EndContext();
#line 38 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\DocIO\MacroPreservation.cshtml"

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
