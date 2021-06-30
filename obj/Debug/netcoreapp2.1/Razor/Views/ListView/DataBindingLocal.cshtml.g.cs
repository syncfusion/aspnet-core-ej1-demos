#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\ListView\DataBindingLocal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "959999a32af7ce9771c580c569dd365593ab15b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListView_DataBindingLocal), @"mvc.1.0.view", @"/Views/ListView/DataBindingLocal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListView/DataBindingLocal.cshtml", typeof(AspNetCore.Views_ListView_DataBindingLocal))]
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
#line 1 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959999a32af7ce9771c580c569dd365593ab15b2", @"/Views/ListView/DataBindingLocal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListView_DataBindingLocal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ListData>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "texts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("locallistview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ListViewProperties __Syncfusion_JavaScript_Models_ListViewProperties;
        private global::Syncfusion.JavaScript.Models.ListViewFields __Syncfusion_JavaScript_Models_ListViewFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 67, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListView / Data Binding Local</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(111, 172, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to bind the local data source key value mapping to the Syncfusion ASP.NET Core ListView component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(334, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(340, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-view", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d165790c85a44658fc3dd0ec5172e6a", async() => {
                    BeginContext(437, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(447, 33, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-field-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adca629f956042658b149b70e60e1463", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ListViewFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListViewFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListViewFields);
                    __Syncfusion_JavaScript_Models_ListViewFields.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(480, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ListViewProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListViewProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListViewProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 8 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\ListView\DataBindingLocal.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.ShowHeader = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-header", __Syncfusion_JavaScript_Models_ListViewProperties.ShowHeader, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\ListView\DataBindingLocal.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.Width = 400;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_ListViewProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\ListView\DataBindingLocal.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.Height = 206;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_Models_ListViewProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 8 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\ListView\DataBindingLocal.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.DataSource = Model;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ListViewProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(501, 9, true);
                WriteLiteral("       \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ListData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
