#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Presentation\SlideTransition.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c486c6d8d6ae1085954b57c824174016393d5106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presentation_SlideTransition), @"mvc.1.0.view", @"/Views/Presentation/SlideTransition.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Presentation/SlideTransition.cshtml", typeof(AspNetCore.Views_Presentation_SlideTransition))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c486c6d8d6ae1085954b57c824174016393d5106", @"/Views/Presentation/SlideTransition.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Presentation_SlideTransition : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(25, 70, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Presentation / SlideTransition</span>\r\n");
                EndContext();
            }
            );
            BeginContext(98, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(125, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Presentation\SlideTransition.cshtml"
      Html.BeginForm("SlideTransition", "Presentation", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(213, 2115, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                This sample demonstrates how to create slide transition effects in PowerPoint presentation.
                <br />
                &nbsp;
                <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                    Click the button to view a PowerPoint presentation generated by Essential Presentation.
                    Please note that Microsoft PowerPoint viewer or its equivalent is required to view the resultant document.
                    <br />
                    <div class=""rowdiv"" style=""margin-top: 10px"">
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input type=""submit"" class=""Button"" value=""Create Presentation"" style=""width: 150px; height: 27px"" />
                        </div>
                    </div>
                </div>
            </div>
  ");
                WriteLiteral(@"          <br />
            <div class=""rowdiv"">
                <b>Features:</b>
                <br />
                The below transition effects are supported as equivalent to Microsoft PowerPoint:
                <ul>
                    <li>
                        Subtle
                    </li>
                    <li>
                        Emphasis
                    </li>
                    <li>
                        Exciting
                    </li>
                </ul>
                The below transition options are supported as equivalent to Microsoft PowerPoint:
                <ul>
                    <li>
                        Effect options
                    </li>
                    <li>
                        Advance On Time
                    </li>
                    <li>
                        Advance Mouse On Click
                    </li>
                    <li>
                        Transition Duration
                    </li>
    ");
                WriteLiteral("            </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 60 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\Presentation\SlideTransition.cshtml"
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
