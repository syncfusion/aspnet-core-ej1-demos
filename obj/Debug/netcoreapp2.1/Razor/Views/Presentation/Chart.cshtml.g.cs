#pragma checksum "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\Presentation\Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4759b67467be974c32b9d8f36b3ca43739fffe74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presentation_Chart), @"mvc.1.0.view", @"/Views/Presentation/Chart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Presentation/Chart.cshtml", typeof(AspNetCore.Views_Presentation_Chart))]
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
#line 1 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4759b67467be974c32b9d8f36b3ca43739fffe74", @"/Views/Presentation/Chart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Presentation_Chart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(25, 60, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Presentation / Chart</span>\r\n");
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
#line 7 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\Presentation\Chart.cshtml"
      Html.BeginForm("Chart", "Presentation", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(193, 1822, true);
                WriteLiteral(@"    <div class=""Common"">
        <div class=""tablediv"">
            <div class=""rowdiv"">
                This sample demonstrates how to create charts in a presentation using PowerPoint presentation.
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
            </div>");
                WriteLiteral(@"
            <br />
            <div class=""rowdiv"">
                <b>Features:</b>
                <br />
                <ul>
                    <li>
                        Create and edit more than 80 chart types.
                    </li>
                    <li>
                        Create custom charts by adding combinations from different chart types.
                    </li>
                    <li>
                        Modify, include and remove chart elements like axes, label, legend and chart title.
                    </li>
                    <li>
                        Edit color for chart elements like chart area and plot area of an existing chart.
                    </li>
                </ul>
            </div>
        </div>
    </div>
");
                EndContext();
#line 47 "D:\Samples_19.3.0.53\ASPNETCORE\samplebrowser\Views\Presentation\Chart.cshtml"
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
