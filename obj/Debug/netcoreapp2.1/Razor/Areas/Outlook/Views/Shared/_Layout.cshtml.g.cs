#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee0de9cc5a5d1d04f9ceabb54e3fc0f11a341203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Outlook_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Outlook/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Outlook/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_Outlook_Views_Shared__Layout))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee0de9cc5a5d1d04f9ceabb54e3fc0f11a341203", @"/Areas/Outlook/Views/Shared/_Layout.cshtml")]
    public class Areas_Outlook_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Syncfusion.JavaScript.TagHelperScriptManager __Syncfusion_JavaScript_TagHelperScriptManager;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(136, 1081, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf39ef5db40c4c8d863da431561cb8dc", async() => {
                BeginContext(142, 43, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>");
                EndContext();
                BeginContext(186, 13, false);
#line 9 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(199, 185, true);
                WriteLiteral("</title>\r\n\t<meta name=\"description\" content=\"Outlook-like user interface with Office 365 theme. It can replicate the UI for Microsoft Outlook for your web mail application.\">\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 384, "\"", 430, 1);
#line 11 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 391, Url.Content("~/css/bootstrap.min.css"), 391, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(431, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 478, "\"", 548, 1);
#line 12 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 485, Url.Content("~/css/ejthemes/default-theme/ej.web.all.min.css"), 485, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(549, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 596, "\"", 666, 1);
#line 13 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 603, Url.Content("~/css/ejthemes/responsive-css/ej.responsive.css"), 603, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(667, 78, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <!--[if lt IE 9]>\r\n    <script src=\"");
                EndContext();
                BeginContext(746, 45, false);
#line 15 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/scripts/jquery-1.11.3.min.js"));

#line default
#line hidden
                EndContext();
                BeginContext(791, 71, true);
                WriteLiteral("\"></script>\r\n    <![endif]-->\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 862, "\"", 913, 1);
#line 18 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 868, Url.Content("~/scripts/jquery-3.4.1.min.js"), 868, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(914, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 959, "\"", 1006, 1);
#line 20 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 965, Url.Content("~/scripts/jsrender.min.js"), 965, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1007, 46, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1053, "\"", 1095, 1);
#line 21 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1059, Url.Content("~/scripts/respond.js"), 1059, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1096, 52, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1148, "\"", 1197, 1);
#line 23 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1154, Url.Content("~/scripts/ej.web.all.min.js"), 1154, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1198, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1219, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58d4f544aee848f8a66d440ac9a6f214", async() => {
                BeginContext(1225, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1234, 12, false);
#line 27 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1246, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1254, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-script-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b25d89320a7844a693fdf53c395cf546", async() => {
                }
                );
                __Syncfusion_JavaScript_TagHelperScriptManager = CreateTagHelper<global::Syncfusion.JavaScript.TagHelperScriptManager>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TagHelperScriptManager);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1293, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 31 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("ScriptSection"))
    {
        

#line default
#line hidden
                BeginContext(1358, 47, false);
#line 33 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
   Write(RenderSection("ScriptSection", required: false));

#line default
#line hidden
                EndContext();
#line 33 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Areas\Outlook\Views\Shared\_Layout.cshtml"
                                                        
    }

#line default
#line hidden
                BeginContext(1414, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1423, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
