#pragma checksum "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rating\Precision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf325b9d562127bd4357e2ec8193990c9100ecbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rating_Precision), @"mvc.1.0.view", @"/Views/Rating/Precision.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rating/Precision.cshtml", typeof(AspNetCore.Views_Rating_Precision))]
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
#line 1 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf325b9d562127bd4357e2ec8193990c9100ecbf", @"/Views/Rating/Precision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Rating_Precision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fullRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("halfRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exactRating"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Syncfusion.JavaScript.Models.RatingProperties __Syncfusion_JavaScript_Models_RatingProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 51, true);
                WriteLiteral(" <span class=\"sampleName\">Rating / Precision</span>");
                EndContext();
            }
            );
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(104, 200, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <table>\r\n            <tr>\r\n                <td valign=\"top\">\r\n                    Full Precision :\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(304, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rating", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c0aca8e2c44416e8405b57791474e47", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_RatingProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RatingProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RatingProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 11 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rating\Precision.cshtml"
__Syncfusion_JavaScript_Models_RatingProperties.Value = 4;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_RatingProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(342, 217, true);
                WriteLiteral("\r\n                   \r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td valign=\"top\">\r\n                    Half Precision :\r\n                </td>\r\n                <td>\r\n                ");
                EndContext();
                BeginContext(559, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rating", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6976363e1d0c4a44bf6dd52c7338aa35", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_RatingProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RatingProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RatingProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 20 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rating\Precision.cshtml"
__Syncfusion_JavaScript_Models_RatingProperties.Value = 3;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_RatingProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rating\Precision.cshtml"
__Syncfusion_JavaScript_Models_RatingProperties.Precision = Precision.Half;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("precision", __Syncfusion_JavaScript_Models_RatingProperties.Precision, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(626, 223, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td valign=\"top\">\r\n                    Exact Precision :\r\n                </td>\r\n                <td>\r\n                    \r\n                    ");
                EndContext();
                BeginContext(849, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rating", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84ad177ed5754f22b0ed691bd4954526", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_RatingProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RatingProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RatingProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 29 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rating\Precision.cshtml"
__Syncfusion_JavaScript_Models_RatingProperties.Value = 4;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_RatingProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "D:\Samples_19.4.0.38\ASPNETCORE\samplebrowser\Views\Rating\Precision.cshtml"
__Syncfusion_JavaScript_Models_RatingProperties.Precision = Precision.Exact;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("precision", __Syncfusion_JavaScript_Models_RatingProperties.Precision, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(917, 74, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1016, 119, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .frame {\r\n            width: 277px;\r\n        }\r\n    </style>\r\n");
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
