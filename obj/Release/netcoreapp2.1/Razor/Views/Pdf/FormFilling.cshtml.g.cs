#pragma checksum "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Pdf\FormFilling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a557a021652dd59c3cfe9cbe5f699e5c88e04f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_FormFilling), @"mvc.1.0.view", @"/Views/Pdf/FormFilling.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/FormFilling.cshtml", typeof(AspNetCore.Views_Pdf_FormFilling))]
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
#line 1 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a557a021652dd59c3cfe9cbe5f699e5c88e04f", @"/Views/Pdf/FormFilling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_FormFilling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 78, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">User Interaction / Form Filling Sample</span>\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(129, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 6 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Pdf\FormFilling.cshtml"
      Html.BeginForm("FormFilling", "Pdf", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(206, 1420, true);
                WriteLiteral(@"            <div>
                <div class=""Outer"" style = ""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to fill and flatten the form fields to personalize your PDF document.It is also possible to create, edit, and delete the form fields using the Essential PDF library.
                </div>
                <br />
                <div>
                    <input id=""flatten"" type=""checkbox"" name=""flatten"" value=""From Flatten"" />
                    <label for=""Form Flatten"">Form Flatten</label>
                </div>
                <br />
                <div>
                    <input id=""viewtemplate"" type=""submit"" name=""submit1"" value=""View Template"" style=""width: 150px"" />
                </div>
                <br />
                <div>
                    <input id=""createpdf"" type=""submit"" name=""submit"" style=""width:150px"" value=""Generate PDF"" />
                </div>
                <br />
                <div style=""font-size: 17px;fon");
                WriteLiteral(@"t-weight: 400;"">

                    This feature can be used in filling forms from the database or from user, and read form fields for transferring user data to database.
                    More information about the forms can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-forms"">section.</a>
                </div>
            </div>
");
                EndContext();
#line 32 "D:\Samples_20.3.0.56\ASPNETCORE\samplebrowser\Views\Pdf\FormFilling.cshtml"
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
