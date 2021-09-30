#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\Encryption.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "798dbd1b54ce5c09296a9b68b0d3052383fe6757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_Encryption), @"mvc.1.0.view", @"/Views/Pdf/Encryption.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/Encryption.cshtml", typeof(AspNetCore.Views_Pdf_Encryption))]
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
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798dbd1b54ce5c09296a9b68b0d3052383fe6757", @"/Views/Pdf/Encryption.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_Encryption : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 62, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">PDF/ Encryption Sample</span>\r\n");
                EndContext();
            }
            );
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(115, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\Encryption.cshtml"
      Html.BeginForm("Encryption", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(189, 5436, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style=""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to encrypt the PDF document with encryption standards like 40-bit RC4, 128-bit RC4, 128-bit AES, 256-bit AES, and advanced encryption standard 256-bit AES Revision 6 (PDF 2.0) to protect documents against unauthorized access.
                    <br />
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div style=""padding: 5px 7px 5px 0px;"">
                            <table width=""100%"" height=""50px"">
                                <tr>
                                    <td align=""left"" width=""18%"">
                                        <label>
                                            <b>Encryption Type&nbsp;&nbsp;:</b>
                                        </label>
                                    </td>
                 ");
                WriteLiteral(@"                   <td align=""left"" width=""15%"">
                                        <input type=""radio"" id=""rdButton40"" name=""encryptionType"" value=""40_RC4"" />
                                        <label for=""rdButton40"">
                                            40 Bit RC4
                                        </label>
                                    </td>
                                    <td align=""left"" width=""15%"">
                                        <input type=""radio"" id=""rdButton128RC4"" name=""encryptionType"" value=""128_RC4"" />
                                        <label for=""rdButton128RC4"">
                                            128 Bit RC4
                                        </label>
                                    </td>
                                    <td align=""left"" width=""15%"">
                                        <input type=""radio"" id=""rdButton128AES"" name=""encryptionType"" value=""128_AES"" checked=""checked"" />
                          ");
                WriteLiteral(@"              <label for=""rdButton128AES"">
                                            128 Bit AES
                                        </label>
                                    </td>
                                    <td align=""left"" width=""15%"">
                                        <input type=""radio"" id=""rdButton256"" name=""encryptionType"" value=""256_AES"" />
                                        <label for=""rdButton256"">
                                            256 Bit AES
                                        </label>
                                    </td>
                                    <td align=""left"" width=""20%"">
                                        <input type=""radio"" id=""rdButton256Revision6"" name=""encryptionType"" value=""256_AES_Revision_6"" />
                                        <label for=""rdButton256"">
                                            256 Bit AES Revision 6
                                        </label>
                                    ");
                WriteLiteral(@"</td>
                                </tr>
                            </table>
                        </div>
                        <div class=""tablediv"">
                            <div class=""rowdiv"">
                                <div class=""celldiv"">
                                    <div style=""padding: 5px 7px 5px 0px;"">
                                        <table width=""100%"">
                                            <tr>
                                                <td align=""left"" width=""100%"">
                                                    <b>User password</b>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;password
                                                </td>                                               
                                            </tr>
                                            <tr>
                                                <td align=""left"" width=""100%"">
                                                    <b>Owner pass");
                WriteLiteral(@"word</b>&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;syncfusion
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div style=""font-size: 17px;font-weight: 400;"">

                    It is possible to protect with user password or owner password or b");
                WriteLiteral(@"oth passwords and also possible to change or remove password and permission.
                    More information about encryption or decryption can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-security"">section.</a>
                </div>
            </div>
");
                EndContext();
#line 96 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Pdf\Encryption.cshtml"
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
