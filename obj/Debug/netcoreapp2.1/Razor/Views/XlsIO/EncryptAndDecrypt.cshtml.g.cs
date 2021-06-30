#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\XlsIO\EncryptAndDecrypt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c833e6494ad51ef576db9aff7c0a361145f930cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_EncryptAndDecrypt), @"mvc.1.0.view", @"/Views/XlsIO/EncryptAndDecrypt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/EncryptAndDecrypt.cshtml", typeof(AspNetCore.Views_XlsIO_EncryptAndDecrypt))]
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
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\XlsIO\EncryptAndDecrypt.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c833e6494ad51ef576db9aff7c0a361145f930cf", @"/Views/XlsIO/EncryptAndDecrypt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_EncryptAndDecrypt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 70, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO/GettingStarted/EncryptAndDecrypt</span>");
                EndContext();
            }
            );
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(176, 34, true);
                WriteLiteral("                                \r\n");
                EndContext();
#line 7 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\XlsIO\EncryptAndDecrypt.cshtml"
            ViewBag.Title = "    Essential XlsIO (Excel) : Encryption, Decryption, Excel 2007 : Syncfusion";

#line default
#line hidden
                BeginContext(318, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\XlsIO\EncryptAndDecrypt.cshtml"
  Html.BeginForm("EncryptAndDecrypt", "XlsIO", FormMethod.Post);
{

#line default
#line hidden
                BeginContext(389, 1997, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                <label>
                    This sample focuses on the encryption and decryption of Excel documents using Essential XlsIO.
                    <br />
                    <br/>
                    Encryption is a method of protecting workbook data. It is based on a password that converts the data into an incomprehensible form and it restricts anonymous users from accessing the document. Decryption is the process of converting encrypted data back into its original form so that data can be read from the workbook.
                    <br />
                    <br />
                     Note: The Excel document is encrypted with the password ""PASSWORD"".
                </label>
            </div>
            <br />
            <div class=""rowdiv"">
                <div class=""celldiv"">
                    <label>
                        <strong>  Save As :</strong>
                    </label");
                WriteLiteral(@">
                    <input id=""rbtnXls"" type=""radio"" name=""SaveOption"" value=""Xls"" />
                    <label for=""rbtnXls"">
                        Xls
                    </label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <input id=""rbtnXlsx"" type=""radio"" name=""SaveOption"" value=""Xlsx"" checked=""checked"" />
                    <label for=""rbtnXlsx"">
                        Xlsx
                    </label>
                </div>
                <br />                
            </div>
            <div class=""rowdiv"">                                
                <div class=""celldiv"">
                    <input class=""buttonStyle1"" type=""submit"" name=""button"" value=""Encrypt Document"" style="" width:200px;"" />
                    <input class=""buttonStyle"" type=""submit"" name=""button"" value=""Decrypt Document"" style="" width:200px;"" />
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 50 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\XlsIO\EncryptAndDecrypt.cshtml"
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
