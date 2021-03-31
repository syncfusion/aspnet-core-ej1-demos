#pragma checksum "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToJSON.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab3cd845bc3c2917e919979d3d4d84de34418989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XlsIO_ExcelToJSON), @"mvc.1.0.view", @"/Views/XlsIO/ExcelToJSON.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XlsIO/ExcelToJSON.cshtml", typeof(AspNetCore.Views_XlsIO_ExcelToJSON))]
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
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 1 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToJSON.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3cd845bc3c2917e919979d3d4d84de34418989", @"/Views/XlsIO/ExcelToJSON.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_XlsIO_ExcelToJSON : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(75, 51, true);
                WriteLiteral("<span class=\"sampleName\">XlsIO / ExcelToJSON</span>");
                EndContext();
            }
            );
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(156, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToJSON.cshtml"
      ViewBag.Title = "    Essential XlsIO (Excel) : Excel To JSON : Syncfusion";

#line default
#line hidden
                BeginContext(242, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToJSON.cshtml"
      Html.BeginForm("ExcelToJSON", "XlsIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(319, 1833, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <p>
                            Essential XlsIO supports to convert Excel data to JSON files by simply saving the workbook using the SaveAsJson method.
                        </p>
                        <br />
                        <b>Features:</b>
                        <br />
                        <br />
                        <ul>
                            <li>Save as a simple JSON file or a JSON file with XML schema</li>
                            <li>Save a workbook to JSON</li>
                            <li>Save a worksheet to JSON</li>
                            <li>Save a range to JSON</li>
                            <li>Save as a stream with the above features</li>
                        </ul>
                        <br />
                        <br />
                        <label>
                            Click the “Input ");
                WriteLiteral(@"Template” button to view the input Excel document. Please note that the Microsoft Excel viewer  or Microsoft Excel is required to view the Excel document.
                        </label>
						<br />
                        <label>
                            Click the “Convert to JSON” button to view the converted JSON file.
                        </label>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <label>
                                Convert
                            </label>
                            &nbsp;&nbsp;&nbsp;
                            <select name=""ConvertOptions"" id=""convertOption"" style=""width:120px;"">
                                ");
                EndContext();
                BeginContext(2152, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a07d9759a4428981847da09b52f586", async() => {
                    BeginContext(2160, 8, true);
                    WriteLiteral("Workbook");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2177, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2211, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "375a804c635d497c88a54a596f4c5ffb", async() => {
                    BeginContext(2219, 9, true);
                    WriteLiteral("Worksheet");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2237, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2271, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c4e9acf8304662bdb759121c994151", async() => {
                    BeginContext(2279, 5, true);
                    WriteLiteral("Range");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2293, 1002, true);
                WriteLiteral(@"
                            </select>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <input type=""checkbox"" id=""checkBoxAsSchema"" name=""checkBox"" checked=""checked"" value=""Schema"" />
                            <label for=""checkBoxAsSchema"">
                                As Schema
                            </label>
                        </div>
                        <br />
                    </div>
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <input id=""inputTemplate"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Input Template"" style=""width:150px;"" />
                            &nbsp;&nbsp;&nbsp;
                            <input id=""convertToJSON"" class=""buttonStyle"" type=""submit"" name=""button"" value=""Convert to JSON"" style=""width:150px;"" />
                        </div>
                    </div>
                </div>
            </div>
");
                EndContext();
#line 67 "D:\Samples_19.1.0.54\ASPNETCORE\samplebrowser\Views\XlsIO\ExcelToJSON.cshtml"
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
