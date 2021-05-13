#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\XlsIO\EditMacro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f35bdf919efc96245a53ae2f45b169f3fb1c0dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_EditMacro), @"mvc.1.0.view", @"/Views/XlsIO/EditMacro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/EditMacro.cshtml", typeof(AspNetCore.Views_XlsIO_EditMacro))]
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
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\XlsIO\EditMacro.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35bdf919efc96245a53ae2f45b169f3fb1c0dc9", @"/Views/XlsIO/EditMacro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_EditMacro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(73, 55, true);
                WriteLiteral(" <span class=\"sampleName\">XlsIO/Macros/EditMacro</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(156, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\XlsIO\EditMacro.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : EditMacro : Syncfusion";

#line default
#line hidden
                BeginContext(238, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\XlsIO\EditMacro.cshtml"
      Html.BeginForm("EditMacro", "XlsIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(311, 2769, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        Essential XlsIO supports creating macro files from scratch and edit the macro code programmatically.This sample demonstrates editing macro code  and saves the final document in different formats like Excel 97-2003, macro-enabled Excel template and macro-enabled Excel workbook.
                        <br />
                        <br />
                        <b>Features:</b>
                        <br />
                        <br />
                        <ul>
                            <li>Open existing macro-enabled Excel template.</li>
                            <li>Modify the macro code to change the chart type.</li>
                            <li>Save the edited macro-enabled file in various file formats (XLS, XLSM, XLTM).</li>
                        </ul>
                        <br />
                        <br />
                        <l");
                WriteLiteral(@"abel>
                            Click the button to view the Excel spreadsheet generated by Essential XlsIO. Please
                            note that Microsoft Excel Viewer or Excel is required to view the resultant document.
                        </label>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <label>
                                <strong>  Save As :</strong>
                            </label>
                            <input id=""rbtnxls"" type=""radio"" name=""SaveOption"" value=""ExcelXls"" />
                            <label for=""rbtnxls"">
                                XLS
                            </label>
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            <input id=""rbtnxltm"" type=""radio"" name=""SaveOption"" value=""ExcelXltm"" />
                            <label for=""rbtnxltm"">
                             ");
                WriteLiteral(@"   XLTM
                            </label>
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            <input id=""rbtnxlsm"" type=""radio"" name=""SaveOption"" value=""ExcelXlsm"" checked=""checked"" />
                            <label for=""rbtnxlsm"">
                                XLSM
                            </label>
                        </div>
                        <br />
                        <div class=""celldiv"">
                            <input class=""buttonStyle"" type=""submit"" value=""Create Document"" style="" width:200px;"" />
                        </div>
                    </div>
                    <br />
                </div>
            </div>
");
                EndContext();
#line 58 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\XlsIO\EditMacro.cshtml"
            Html.EndForm();
        }

#line default
#line hidden
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(3148, 4, true);
                WriteLiteral("\r\n\r\n");
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
