#pragma checksum "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c8de35e9ea8eaae36c1d3d03b3907131d79c874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReportDesigner_Default), @"mvc.1.0.view", @"/Views/ReportDesigner/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReportDesigner/Default.cshtml", typeof(AspNetCore.Views_ReportDesigner_Default))]
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
#line 1 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 1 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c8de35e9ea8eaae36c1d3d03b3907131d79c874", @"/Views/ReportDesigner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ReportDesigner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rptdesigner1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "controlInitialized", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("service-url", "../ReportDesigner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ReportDesignerProperties __Syncfusion_JavaScript_Models_ReportDesignerProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(56, 55, true);
                WriteLiteral("<span class=\"sampleName\"> ReportDesigner/Default</span>");
                EndContext();
            }
            );
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("StyleSection", async() => {
                BeginContext(138, 132, true);
                WriteLiteral("\r\n    <style>\r\n        #rptdesigner1 {\r\n            min-height: 650px;\r\n            width: 100%;\r\n        }\r\n    </style>\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 270, "\"", 332, 1);
#line 12 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
WriteAttributeValue("", 277, Url.Content("~/scripts/CodeMirror/codemirror.min.css"), 277, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(333, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 364, "\"", 425, 1);
#line 13 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
WriteAttributeValue("", 371, Url.Content("~/scripts/CodeMirror/show-hint.min.css"), 371, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(426, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            BeginContext(451, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(478, 40, true);
                WriteLiteral("\r\n    <div style=\"width:100%\">\r\n        ");
                EndContext();
                BeginContext(518, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-report-designer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8706dd1b283643c8a05ec9ef85db54f1", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ReportDesignerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ReportDesignerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ReportDesignerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_ReportDesignerProperties.Create = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_ReportDesignerProperties.ServiceUrl = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(637, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(654, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(679, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 692, "\"", 748, 1);
#line 23 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
WriteAttributeValue("", 698, Url.Content("~/scripts/CodeMirror/codemirror.js"), 698, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(749, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 772, "\"", 827, 1);
#line 24 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
WriteAttributeValue("", 778, Url.Content("~/scripts/CodeMirror/show-hint.js"), 778, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(828, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 851, "\"", 905, 1);
#line 25 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
WriteAttributeValue("", 857, Url.Content("~/scripts/CodeMirror/sql-hint.js"), 857, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(906, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 929, "\"", 978, 1);
#line 26 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
WriteAttributeValue("", 935, Url.Content("~/scripts/CodeMirror/sql.js"), 935, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(979, 92, true);
                WriteLiteral("></script>\r\n\r\n    <script type=\"text/javascript\">\r\n        var controlId = \'rptdesigner1\';\r\n");
                EndContext();
#line 30 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
           var isSupport = true; 

#line default
#line hidden
                BeginContext(1107, 370, true);
                WriteLiteral(@"
        function controlInitialized(args) {
            var designer = $('#' + controlId).data('ejReportDesigner');
            designer.openReport('/Catagory2/Invoice');
        }

        if ((ej.browserInfo().name === ""msie"" && Number(ej.browserInfo().version) < 9)) {
            alert(""ReportDesigner will not be supported in IE Version < 9"");
            ");
                EndContext();
                BeginContext(1478, 9, false);
#line 39 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\ReportDesigner\Default.cshtml"
       Write(isSupport);

#line default
#line hidden
                EndContext();
                BeginContext(1487, 37, true);
                WriteLiteral(" = false;\r\n        }\r\n    </script>\r\n");
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
