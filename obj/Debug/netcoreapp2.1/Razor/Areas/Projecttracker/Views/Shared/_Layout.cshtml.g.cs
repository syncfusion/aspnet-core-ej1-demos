#pragma checksum "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ccb652a2eb3e9f2e43e95e6f43b9b3072445f41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Projecttracker_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Projecttracker/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Projecttracker/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_Projecttracker_Views_Shared__Layout))]
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
#line 1 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccb652a2eb3e9f2e43e95e6f43b9b3072445f41", @"/Areas/Projecttracker/Views/Shared/_Layout.cshtml")]
    public class Areas_Projecttracker_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(69, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(106, 2544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b55198221334a17afa25aa8b3f627fa", async() => {
                BeginContext(112, 497, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Essential Studio for ASP.NET Core | Showcase Sample | Project Tracker</title>
    <meta name=""viewport"" content=""width=device-width"" />
    <meta name=""description"" content=""The Gantt control in ASP.Net Core is a project management tool used for visualizing and tracking the projects and schedules. Using the editing support available in ASP.NET Core Gantt, you can edit, manage and organize the projects dynamically."" />
    <link rel=""shortcut icon""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 609, "\"", 656, 1);
#line 11 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 616, Url.Content("~/css/images/favicon.ico"), 616, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(657, 12, true);
                WriteLiteral(">\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 669, "\"", 739, 1);
#line 12 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 676, Url.Content("~/css/ejthemes/gradient-lime/ej.web.all.min.css"), 676, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(740, 78, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <!--[if lt IE 9]>\r\n    <script src=\"");
                EndContext();
                BeginContext(819, 45, false);
#line 14 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/scripts/jquery-1.11.3.min.js"));

#line default
#line hidden
                EndContext();
                BeginContext(864, 71, true);
                WriteLiteral("\"></script>\r\n    <![endif]-->\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 935, "\"", 986, 1);
#line 17 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 941, Url.Content("~/scripts/jquery-3.4.1.min.js"), 941, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(987, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1032, "\"", 1079, 1);
#line 19 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1038, Url.Content("~/scripts/jsrender.min.js"), 1038, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1080, 46, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1126, "\"", 1175, 1);
#line 20 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1132, Url.Content("~/scripts/ej.web.all.min.js"), 1132, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1176, 1467, true);
                WriteLiteral(@"></script>
    <style>
        body, html {
            height: 100%;
            padding: 0;
            margin: 0;
        }

        #ganttSample {
            position: absolute;
        }
        /* Footerdiv CSS */
        #footer
        {
            display: none;
            background-color: #4F4F4C;
            color: GrayText;
            height: 45px;
            min-width: 300px;
            width:100%;
            float: left;
            bottom: 0;
            position: absolute;
            z-index:0;
        }

        .bottom-links
        {
            bottom: 0;
            margin: 0 auto;
            padding-top: 9px;
            position: relative;
        }

        .left
        {
            float: left;
        }

        .right
        {
            float: right;
            position: absolute;
            right: 0px;
        }

        .syncfusion-image
        {
            background-image: url('../../css/images/footer.png');
   ");
                WriteLiteral(@"         float: left;
            height: 30px;
            margin-top: 2px;
            width: 125px;
            background-position: -5px -50px;
            background-repeat: no-repeat;
        }

        #footer .right .left, #footer .left .sync-text
        {
            margin: 4px 25px 0;
        }

        .sync-text
        {
            color: #A4A09B;
            display: inline-block;
        }
    </style>
");
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
            BeginContext(2650, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2652, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e8f8b47d09e4b30b2d5e11936f3a696", async() => {
                BeginContext(2658, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2665, 12, false);
#line 90 "C:\Samples_20.4.0.38\ASPNETCORE\samplebrowser\Areas\Projecttracker\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2677, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2683, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-script-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de4afb07824a43a19a45ef95dcf34e4e", async() => {
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
                BeginContext(2722, 2, true);
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
            BeginContext(2731, 11, true);
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
