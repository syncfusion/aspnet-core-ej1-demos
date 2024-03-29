#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\FormControls.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989981c8fda95fb9a7faf4f8fff274e54eaa8435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_FormControls), @"mvc.1.0.view", @"/Views/XlsIO/FormControls.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/FormControls.cshtml", typeof(AspNetCore.Views_XlsIO_FormControls))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\FormControls.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989981c8fda95fb9a7faf4f8fff274e54eaa8435", @"/Views/XlsIO/FormControls.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_FormControls : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 52, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / FormControls</span>");
                EndContext();
            }
            );
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(158, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\FormControls.cshtml"
           ViewBag.Title = "    Essential XlsIO (Excel) : Form Controls, Checkbox, Textbox, Combobox, Option Button    : Syncfusion";

#line default
#line hidden
                BeginContext(325, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\FormControls.cshtml"
  Html.BeginForm("FormControls", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(391, 1315, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                <label>
                    Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                    note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        <strong>  Save As :</strong>
                    </label>
                    <input id=""rbtnXls"" type=""radio"" name=""SaveOption"" value=""Xls"" />
                    <label for=""rbtnXls"">
                        XLS
                    </label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <input id=""rbtnXlsx"" type=""radio"" name=""SaveOption"" value=""Xlsx"" checked=""checked"" />
                    <label for=""rbtnXlsx"">
                        XLSX
        ");
                WriteLiteral(@"            </label>
                </div>
                <br />
                <div class=""celldiv"">
                    <input class=""buttonStyle"" type=""submit"" value=""Create Document"" style=""width:200px;"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 42 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Views\XlsIO\FormControls.cshtml"
    Html.EndForm();
} 

#line default
#line hidden
                BeginContext(1748, 14, true);
                WriteLiteral("              ");
                EndContext();
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
