#pragma checksum "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c22e90bfe7e50a855fd8585298fca9a05caa2be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_Formulas), @"mvc.1.0.view", @"/Views/XlsIO/Formulas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/Formulas.cshtml", typeof(AspNetCore.Views_XlsIO_Formulas))]
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
#line 5 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22e90bfe7e50a855fd8585298fca9a05caa2be5", @"/Views/XlsIO/Formulas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_Formulas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 48, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / Formulas</span>");
                EndContext();
            }
            );
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(154, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
           ViewBag.Title = "    Essential XlsIO (Excel) : Formula : Syncfusion";

#line default
#line hidden
                BeginContext(268, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
  Html.BeginForm("Formulas", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(330, 744, true);
                WriteLiteral(@"        <style type=""text/css"">
            .nonemptylabel
            {
                border-style:groove;
                width:80px;
            }
        </style>
    <div class=""Common1"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
		<label>
                 Click the button to view an Excel spreadsheet generated by Essential XlsIO. Please
                 Read Formula from the template document.
		</label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        Computed Value
                    </label>
                    &nbsp;&nbsp;
                    <label id=""computedvalue"" ");
                EndContext();
#line 33 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
                                                 if (ViewBag.computedValue.ToString() != string.Empty){ 

#line default
#line hidden
                BeginContext(1138, 21, true);
                WriteLiteral("class=\"nonemptylabel\"");
                EndContext();
#line 33 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
                                                                                                                                           } 

#line default
#line hidden
                BeginContext(1170, 27, true);
                WriteLiteral(">\r\n                        ");
                EndContext();
                BeginContext(1198, 21, false);
#line 34 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
                   Write(ViewBag.computedValue);

#line default
#line hidden
                EndContext();
                BeginContext(1219, 425, true);
                WriteLiteral(@"
                    </label>
                </div>
                <div class=""celldiv"">

                </div>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        Formula String
                    </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <label id=""formulastring"" ");
                EndContext();
#line 48 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
                                                 if (ViewBag.computedValue.ToString() != string.Empty){ 

#line default
#line hidden
                BeginContext(1708, 21, true);
                WriteLiteral("class=\"nonemptylabel\"");
                EndContext();
#line 48 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
                                                                                                                                           } 

#line default
#line hidden
                BeginContext(1740, 27, true);
                WriteLiteral(">\r\n                        ");
                EndContext();
                BeginContext(1768, 21, false);
#line 49 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
                   Write(ViewBag.formulaString);

#line default
#line hidden
                EndContext();
                BeginContext(1789, 584, true);
                WriteLiteral(@"
                    </label>

                </div>
                <div class=""celldiv"">
                </div>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <input id=""readformula"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Read Formula"" style=""width:150px;"" />
                    <input id=""writeformula"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Write Formula"" style=""width:150px;"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 65 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\Formulas.cshtml"
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
