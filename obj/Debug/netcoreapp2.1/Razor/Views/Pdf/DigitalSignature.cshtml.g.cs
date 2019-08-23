#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Pdf\DigitalSignature.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807d1760daf9acca33c5ad55a876764c2581143a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_DigitalSignature), @"mvc.1.0.view", @"/Views/Pdf/DigitalSignature.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/DigitalSignature.cshtml", typeof(AspNetCore.Views_Pdf_DigitalSignature))]
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
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807d1760daf9acca33c5ad55a876764c2581143a", @"/Views/Pdf/DigitalSignature.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_DigitalSignature : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(25, 74, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Security / DigitalSignature Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(129, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Pdf\DigitalSignature.cshtml"
      Html.BeginForm("DigitalSignature", "Pdf", FormMethod.Post, new { enctype = "multipart/form-data" });
        {

#line default
#line hidden
                BeginContext(250, 669, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style=""font-size: 17px;font-weight: 400;"" >
                    This sample demonstrates how to digitally sign the PDF document with the PFX certificate file. It is possible to digitally sign with X509 certificates such as .pfx files with private keys and support for Hardware Security Module (HSM), Online Certificate Status Protocol (OCSP), Certificate Revocation List (CRL), and Windows Certificate Store to offer authenticity and integrity.
                </div>
                <div id=""errorlabel"" value=""error"">
                    <p style=""color: #FF0000;"">
                        ");
                EndContext();
                BeginContext(920, 35, false);
#line 15 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Pdf\DigitalSignature.cshtml"
                   Write(Html.Label("", (string)ViewBag.lab));

#line default
#line hidden
                EndContext();
                BeginContext(955, 10259, true);
                WriteLiteral(@"
                </div>
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <table width=""100%"">
                                <tbody>
                                    <tr>
                                        <td align=""left"">
                                            <span style=""font-weight: bold;"" id=""label8"">Sign new PDF document</span><br>
                                            <div style=""border: solid 1px #788DB3; line-height: 23px; padding: 10px; background-color: #EDF0F7;"">
                                                <table cellspacing=""0"" cellpadding=""0"" border=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td valign=""middle"" style=""padding-left: 0px; width: 100%;"">
                                                              ");
                WriteLiteral(@"  <span id=""label4"">Standard Type: </span>
                                                                <span style=""margin-left: 10px"">
                                                                    <input type=""radio"" checked=""checked"" value=""Standard"" name=""RadioButtonList2"" id=""RadioButtonList1""><label for=""RadioButtonList2_0"">Standard</label>
                                                                </span>
                                                                <span style=""margin-left: 20px"">
                                                                    <input type=""radio"" value=""Author""
                                                                           name=""RadioButtonList2"" id=""RadioButtonList2_1""><label for=""RadioButtonList2"">Author</label>
                                                                </span>
                                                            </td>
                                                            <td align=""right"">");
                WriteLiteral(@"
                                                                <input name=""submit"" id=""submit"" type=""submit"" value=""Generate PDF"" style=""width: 150px;"" />
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>

                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <table width=""100%"">
                                <tbody>
                                    <tr>
                                        <td align=""left"">
                      ");
                WriteLiteral(@"                      <span style=""font-weight: bold;"" id=""label8"">Sign existing PDF document</span><br>
                                            <div style=""border: solid 1px #788DB3; line-height: 23px; padding: 10px; background-color: #EDF0F7;"">
                                                <table cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                                    <tbody>
                                                        <tr>
                                                            <td align=""left"" width=""100%"">
                                                                <div>
                                                                    <label for=""page index"">Source Document</label>
                                                                    <input type=""file"" id=""file"" name=""file"" accept=""application/pdf"" />
                                                                </div>
                                             ");
                WriteLiteral(@"               </td>
                                                        </tr>
                                                        <tr>
                                                            <td align=""left"">
                                                                <br />
                                                                <label>Certificate</label>
                                                                <input type=""file"" id=""certificate "" name=""certificate"" accept=""application/pfx"" />

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align=""left"" width=""100%"">
                                                                <br />
                                                                <div>
                                                        ");
                WriteLiteral(@"            <label>Password</label>
                                                                    <label>
                                                                        <input type=""password"" style=""width: 102%; margin-left: 105px"" id=""password"" value="""" textmode=""Password""
                                                                               name=""password"">
                                                                    </label>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <div style=""line-height: 23px;"">
                                                                    <span style=""font-weight: bold;"" id=""label1"">Reason</span>
");
                WriteLiteral(@"                                                                    <label>
                                                                        <input type=""text"" style=""width: 97%; margin-left: 120px"" id=""Reason"" value=""""
                                                                               name=""Reason"">
                                                                    </label>
                                                                </div>

                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align=""left"">
                                                                <div style=""line-height: 23px;"">
                                                                    <span style=""font-weight: bold;"" id=""label1"">Contact</span>
                                                  ");
                WriteLiteral(@"                  <label>
                                                                        <input type=""text"" style=""width: 98%; margin-left: 116px"" id=""Contact"" value=""""
                                                                               name=""Contact"">
                                                                    </label>
                                                                </div>
                                                            </td>
                                                        </tr>

                                                        <tr>
                                                            <td align=""left"">
                                                                <div style=""line-height: 23px;"">
                                                                    <span style=""font-weight: bold;"" id=""label1"">Location</span>
                                                                    <label>
                    ");
                WriteLiteral(@"                                                    <input type=""text"" style=""width: 100%; margin-left: 111px"" id=""Location"" value=""""
                                                                               name=""Location"">
                                                                    </label>
                                                                </div>
                                                            </td>                                                            
                                                        </tr> 
                                                        <tr>
                                                            <td align=""right"">
                                                                <input name=""submit"" type=""submit"" id=""submit"" value=""Sign PDF"" style=""width: 150px;"" />
                                                            </td>
                                                        </tr>                           ");
                WriteLiteral(@"                           
                                                    </tbody>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>                                    
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">
                    It is also possible to digitally sign with <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-digitalsignature#adding-a-timestamp-in-digital-signature"">timestamp.</a>
                    More information about the digital signature and timestamp can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-digitalsignature"">section.</a>

                </div>
 ");
                WriteLiteral("           </div>\r\n");
                EndContext();
#line 149 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\Pdf\DigitalSignature.cshtml"
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
