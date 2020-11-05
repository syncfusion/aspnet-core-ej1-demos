#pragma checksum "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Autocomplete\Databindingremote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3699d65a26f8384d633b72799b4de4879ddfcc98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autocomplete_Databindingremote), @"mvc.1.0.view", @"/Views/Autocomplete/Databindingremote.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autocomplete/Databindingremote.cshtml", typeof(AspNetCore.Views_Autocomplete_Databindingremote))]
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
#line 1 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3699d65a26f8384d633b72799b4de4879ddfcc98", @"/Views/Autocomplete/Databindingremote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Autocomplete_Databindingremote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/ejServices/wcf/NorthWind.svc/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ContactName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("key", "SupplierID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchCustomer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query", "ej.Query().from(\'Suppliers\').select(\'SupplierID\', \'ContactName\')", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("watermark-text", "Search a customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.AutocompleteProperties __Syncfusion_JavaScript_Models_AutocompleteProperties;
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        private global::Syncfusion.JavaScript.AutocompleteFields __Syncfusion_JavaScript_AutocompleteFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 79, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Autocomplete / Data Binding - Remote data</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(123, 148, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to bind remote data in the Syncfusion ASP.NET Core Autocomplete component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(299, 72, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n\r\n            ");
                EndContext();
                BeginContext(371, 410, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-autocomplete", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfa631b3cf5f454982743e8e2411ee7d", async() => {
                    BeginContext(529, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(547, 123, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577d2a4068a40a0a3b5d623d13984cf", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                    __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 11 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Autocomplete\Databindingremote.cshtml"
__Syncfusion_JavaScript_DataSource.CrossDomain = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("cross-domain", __Syncfusion_JavaScript_DataSource.CrossDomain, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Autocomplete\Databindingremote.cshtml"
__Syncfusion_JavaScript_DataSource.Offline = false;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("offline", __Syncfusion_JavaScript_DataSource.Offline, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(670, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(688, 61, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-autocomplete-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bab0713b70f94a71a8fd809cb6ce6683", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_AutocompleteFields = CreateTagHelper<global::Syncfusion.JavaScript.AutocompleteFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_AutocompleteFields);
                    __Syncfusion_JavaScript_AutocompleteFields.Text = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_JavaScript_AutocompleteFields.Key = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(749, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_AutocompleteProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AutocompleteProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AutocompleteProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.Query = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.WatermarkText = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(781, 32, true);
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
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
