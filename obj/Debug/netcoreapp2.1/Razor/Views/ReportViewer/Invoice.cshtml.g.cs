#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\ReportViewer\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe77c30f15660fa83df5e7d497b7d84ab1dec402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReportViewer_Invoice), @"mvc.1.0.view", @"/Views/ReportViewer/Invoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReportViewer/Invoice.cshtml", typeof(AspNetCore.Views_ReportViewer_Invoice))]
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
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\ReportViewer\Invoice.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe77c30f15660fa83df5e7d497b7d84ab1dec402", @"/Views/ReportViewer/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ReportViewer_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reportviewer1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("report-service-url", "../ReportViewer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("report-path", "Invoice.rdl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("report-print", "onReportPrint", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ReportViewerProperties __Syncfusion_JavaScript_Models_ReportViewerProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(56, 53, true);
                WriteLiteral("<span class=\"sampleName\"> ReportViewer/Invoice</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(137, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(143, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-report-viewer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "acfbd7ee27184dc8a7e4d1d753d32f00", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ReportViewerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ReportViewerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ReportViewerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ReportViewerProperties.ReportServiceUrl = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ReportViewerProperties.ReportPath = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_ReportViewerProperties.ReportPrint = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(273, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(301, 186, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n            function onReportPrint(args) {               \r\n                args.isStyleLoad = false;               \r\n            }\r\n    </script>\r\n");
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
