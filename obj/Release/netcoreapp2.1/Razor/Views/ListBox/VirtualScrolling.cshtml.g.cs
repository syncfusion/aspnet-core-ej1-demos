#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\ListBox\VirtualScrolling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d19eec1469197f9b216346503ad43aa7d176af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListBox_VirtualScrolling), @"mvc.1.0.view", @"/Views/ListBox/VirtualScrolling.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListBox/VirtualScrolling.cshtml", typeof(AspNetCore.Views_ListBox_VirtualScrolling))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d19eec1469197f9b216346503ad43aa7d176af", @"/Views/ListBox/VirtualScrolling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListBox_VirtualScrolling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/ejServices/wcf/NorthWind.svc/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "CustomerID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectlang"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query", "ej.Query().from(\'Customers\')", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "120px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onValueChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "Targetid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ListBoxProperties __Syncfusion_JavaScript_Models_ListBoxProperties;
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        private global::Syncfusion.JavaScript.Models.ListBoxFields __Syncfusion_JavaScript_Models_ListBoxFields;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 65, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListBox / Virtual Scrolling</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(109, 163, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to load large amounts of data on demand in the Syncfusion ASP.NET Core ListBox component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(300, 125, true);
                WriteLiteral("\r\n    <div class=\"control frame\">\r\n        <div class=\"ctrllabel\">\r\n            Select a customer\r\n        </div>\r\n\r\n        ");
                EndContext();
                BeginContext(425, 320, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f296a9113d4d219603f7d028f6cbb7", async() => {
                    BeginContext(546, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(560, 108, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b496713b3de14035b8be8f5113a7959a", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                    __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\ListBox\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_DataSource.CrossDomain = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("cross-domain", __Syncfusion_JavaScript_DataSource.CrossDomain, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(668, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(682, 39, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-list-box-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ae24d67613c4f5f873f7d1462c0b754", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ListBoxFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxFields);
                    __Syncfusion_JavaScript_Models_ListBoxFields.Text = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(721, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ListBoxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_ListBoxProperties.Query = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 12 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\ListBox\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.AllowVirtualScrolling = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-virtual-scrolling", __Syncfusion_JavaScript_Models_ListBoxProperties.AllowVirtualScrolling, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\ListBox\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.ItemRequestCount = 10;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("item-request-count", __Syncfusion_JavaScript_Models_ListBoxProperties.ItemRequestCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(745, 24, true);
                WriteLiteral("        \r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(799, 122, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">Select Dropdown</div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(921, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5776fa121f5e4bed8132a9379dc9b64b", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 23 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\ListBox\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-item-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1056, 277, true);
                WriteLiteral(@"            

            <div id=""Targetid"">
                <ul>
                    <li value=""disablevirtual"">Normal Mode</li>
                    <li value=""enablevirtual"">Continuous Mode</li>
                </ul>
            </div>
        </div>
    </div>

");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1358, 233, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .ctrllabel {\r\n            padding: 0px 0px 12px 3px;\r\n            font-weight: 600;\r\n        }\r\n\r\n        .e-ddl-popup {\r\n            margin: 0 auto;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1617, 1200, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function onValueChange(args) {
            var target = $('#selectlang').data(""ejListBox"");
            //target.destroy();
            var dataManger = ej.DataManager({
                url: ""//js.syncfusion.com/ejServices/Wcf/Northwind.svc/"", crossDomain: true
            });
            // Query creation
            var query = ej.Query()
                   .from(""Customers"");
            if (args.value == ""enablevirtual"") {
                $(""#selectlang"").ejListBox({
                    dataSource: dataManger,
                    fields: { text: ""CustomerID"" },
                    query: query, allowVirtualScrolling: true, virtualScrollMode: ej.VirtualScrollMode.Continuous

                });
            }
            if (args.value == ""disablevirtual"") {
                $(""#selectlang"").ejListBox({
                    dataSource: dataManger,
                    fields: { text: ""CustomerID"" },
                    query: query, allowVirtu");
                WriteLiteral("alScrolling: true\r\n                });\r\n            }\r\n        }\r\n        $(function () {\r\n            $(\"#sampleProperties\").ejPropertiesPanel();\r\n        });\r\n    </script>\r\n");
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
