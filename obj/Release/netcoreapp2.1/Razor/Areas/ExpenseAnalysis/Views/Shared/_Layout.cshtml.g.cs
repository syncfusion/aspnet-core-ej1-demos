#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7089217447bee99d8782aecb145e7b1c40a518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ExpenseAnalysis_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/ExpenseAnalysis/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ExpenseAnalysis/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_ExpenseAnalysis_Views_Shared__Layout))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7089217447bee99d8782aecb145e7b1c40a518", @"/Areas/ExpenseAnalysis/Views/Shared/_Layout.cshtml")]
    public class Areas_ExpenseAnalysis_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(99, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(134, 1230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f55e9b309e4bd6b96047a65e360636", async() => {
                BeginContext(140, 269, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>ASP.NET Core | Showcase Sample | Expense Analysis</title>
	<meta name=""description"" content=""The ASP.NET Core Expense Analysis application is used to categorize and analyze the expenses details against budget."">			
    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 409, "\"", 455, 1);
#line 10 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 416, Url.Content("~/css/bootstrap.min.css"), 416, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(456, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 503, "\"", 573, 1);
#line 11 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 510, Url.Content("~/css/ejthemes/default-theme/ej.web.all.min.css"), 510, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(574, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 621, "\"", 691, 1);
#line 12 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 628, Url.Content("~/css/ejthemes/responsive-css/ej.responsive.css"), 628, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(692, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 739, "\"", 813, 1);
#line 13 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 746, Url.Content("~/css/ejthemes/responsive-css/ejgrid.responsive.css"), 746, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(814, 78, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <!--[if lt IE 9]>\r\n    <script src=\"");
                EndContext();
                BeginContext(893, 45, false);
#line 15 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/scripts/jquery-1.11.3.min.js"));

#line default
#line hidden
                EndContext();
                BeginContext(938, 71, true);
                WriteLiteral("\"></script>\r\n    <![endif]-->\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1009, "\"", 1060, 1);
#line 18 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1015, Url.Content("~/scripts/jquery-3.4.1.min.js"), 1015, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1061, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1106, "\"", 1153, 1);
#line 20 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1112, Url.Content("~/scripts/jsrender.min.js"), 1112, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1154, 46, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1200, "\"", 1242, 1);
#line 21 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1206, Url.Content("~/scripts/respond.js"), 1206, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1243, 52, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1295, "\"", 1344, 1);
#line 23 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1301, Url.Content("~/scripts/ej.web.all.min.js"), 1301, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1345, 12, true);
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
            BeginContext(1364, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1366, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef063906b4fb44359fe76e9a02d132f6", async() => {
                BeginContext(1372, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1379, 12, false);
#line 26 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1391, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1399, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-script-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e510adafd4f47cbb93d6da7888e4437", async() => {
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
                BeginContext(1438, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 30 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("ScriptSection"))
    {
        

#line default
#line hidden
                BeginContext(1503, 47, false);
#line 32 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
   Write(RenderSection("ScriptSection", required: false));

#line default
#line hidden
                EndContext();
#line 32 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\ExpenseAnalysis\Views\Shared\_Layout.cshtml"
                                                        
    }

#line default
#line hidden
                BeginContext(1559, 2, true);
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
            BeginContext(1568, 11, true);
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
