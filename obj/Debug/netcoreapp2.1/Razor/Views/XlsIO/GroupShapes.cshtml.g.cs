#pragma checksum "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\GroupShapes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52247ff50fafdd893a16cc09d5ab24b439d5ec33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_GroupShapes), @"mvc.1.0.view", @"/Views/XlsIO/GroupShapes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/GroupShapes.cshtml", typeof(AspNetCore.Views_XlsIO_GroupShapes))]
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
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\GroupShapes.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52247ff50fafdd893a16cc09d5ab24b439d5ec33", @"/Views/XlsIO/GroupShapes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_GroupShapes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 51, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / GroupShapes</span>");
                EndContext();
            }
            );
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(157, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\GroupShapes.cshtml"
            ViewBag.Title = "    Essential XlsIO (Excel) : Shapes : Syncfusion";

#line default
#line hidden
                BeginContext(271, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\GroupShapes.cshtml"
  Html.BeginForm("GroupShapes", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(336, 2406, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
		    <div class=""rowdiv"">
                Essential XlsIO allows to group multiple shapes and ungroup the shapes in worksheet. The <b>IGroupShape</b> interface is the in-memory representation of the
                group shapes in an Excel workbook.
                <br />
                <br />
                <b>Features:</b>
                <br />
                <br />
                This sample demonstrates following features:
                <br />
                <br />
                <ul>
                    <li>Grouping multiple shapes into a single group shape.</li>
                    <li>Ungroup the group shape and all its inner shapes.</li>
                </ul>
                <br />
                <label>
                    Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                    note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant docume");
                WriteLiteral(@"nt.
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <input type=""radio"" id=""rdButtonGroup"" name=""Group1"" value=""Group"" checked=""checked"" />
                    <label for=""rdButtonGroup"">
                        Group
                    </label>
                    &nbsp;&nbsp;&nbsp;
                    <input type=""radio"" id=""rdButtonUngroup"" name=""Group1"" value=""Ungroup"" />
                    <label for=""rdButtonUngroup"">
                        Ungroup
                    </label>
                    &nbsp;&nbsp;&nbsp;
                    <input type=""radio"" id=""rdButtonUngroupAll"" name=""Group1"" value=""UngroupAll"" />
                    <label for=""rdButtonUngroupAll"">
                        Ungroup All
                    </label>
                </div>
                <br />                
            </div>
            <div class=""rowdiv"">                                
");
                WriteLiteral(@"                <div class=""celldiv"">
                    <input class=""buttonStyle"" type=""submit"" name=""button"" value=""Input Document"" style=""width:120px;"" />
                    <input class=""buttonStyle"" type=""submit"" name=""button"" value=""Create Document"" style=""width:120px;"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 62 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\XlsIO\GroupShapes.cshtml"
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
