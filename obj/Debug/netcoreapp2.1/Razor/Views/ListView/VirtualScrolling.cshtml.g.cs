#pragma checksum "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\ListView\VirtualScrolling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ecf3a1ae21e4a34cc7bb106a59661e67b8a65f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListView_VirtualScrolling), @"mvc.1.0.view", @"/Views/ListView/VirtualScrolling.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListView/VirtualScrolling.cshtml", typeof(AspNetCore.Views_ListView_VirtualScrolling))]
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
#line 1 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ecf3a1ae21e4a34cc7bb106a59661e67b8a65f", @"/Views/ListView/VirtualScrolling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListView_VirtualScrolling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("List1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "120px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "onValueChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "Targetid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 66, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListView / Virtual Scrolling</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(110, 165, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to load a large amount of data on demand in the Syncfusion ASP.NET Core ListView component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(303, 125, true);
                WriteLiteral("\r\n    <div class=\"control frame\">\r\n        <div class=\"ctrllabel\">\r\n            Select a customer\r\n        </div>\r\n\r\n        ");
                EndContext();
                BeginContext(428, 158, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-view", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df9f29113484cf6bc20dfcbc60ce72d", async() => {
                    BeginContext(561, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ListViewProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListViewProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListViewProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 12 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\ListView\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.Height = 200;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("height", __Syncfusion_JavaScript_Models_ListViewProperties.Height, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\ListView\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.Width = 250;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_ListViewProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\ListView\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.AllowVirtualScrolling = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-virtual-scrolling", __Syncfusion_JavaScript_Models_ListViewProperties.AllowVirtualScrolling, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\ListView\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.VirtualScrollMode = global::Syncfusion.JavaScript.VirtualScrollMode.Normal;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("virtual-scroll-mode", __Syncfusion_JavaScript_Models_ListViewProperties.VirtualScrollMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\ListView\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_ListViewProperties.ItemRequestCount = 8;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("item-request-count", __Syncfusion_JavaScript_Models_ListViewProperties.ItemRequestCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(586, 16, true);
                WriteLiteral("\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(632, 118, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">Select Mode</div>\r\n        <div class=\"col-md-3\">\r\n            ");
                EndContext();
                BeginContext(750, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f2f5b5479324516bb44277a58c66ae4", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 21 "D:\Samples_18.1.0.52\ASPNETCORE\samplebrowser\Views\ListView\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-item-index", __Syncfusion_JavaScript_Models_DropDownListProperties.SelectedItemIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(885, 254, true);
                WriteLiteral("\r\n\r\n            <div id=\"Targetid\">\r\n                <ul>\r\n                    <li value=\"Normal\">Normal Mode</li>\r\n                    <li value=\"Continuous\">Continuous Mode</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1164, 233, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .ctrllabel {\r\n            padding: 0px 0px 12px 3px;\r\n            font-weight: 600;\r\n        }\r\n\r\n        .e-ddl-popup {\r\n            margin: 0 auto;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1423, 1729, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        dataManger = ej.DataManager({
            url: ""//js.syncfusion.com/ejServices/Wcf/Northwind.svc/"", crossDomain: true
        });

        var query = ej.Query()
               .from(""Customers"");
        $(function () {
            $(""#List1"").ejListView({
                height:200,
                dataSource: dataManger,
                totalItemsCount: 10,
                fieldSetting: { text: ""CustomerID"" },
                query: query, allowVirtualScrolling: true
                     });
                 })
        $(""#List1"").ejListView({
            height: 200,
            dataSource: dataManger,
            fieldSettings: { text: ""CustomerID"" },
            query: query, allowVirtualScrolling: true
        });
        function onValueChange(args) {
            var target = $('#List1').data(""ejListView"");
            if (args.value == ""Continuous"") {
                $(""#List1"").ejListView({
                    height: 200,
    ");
                WriteLiteral(@"                dataSource: dataManger,
                    fieldSettings: { text: ""CustomerID"" },
                    query: query, allowVirtualScrolling: true, virtualScrollMode: ej.VirtualScrollMode.Continuous

                });
            }
            if (args.value == ""Normal"") {
                $(""#List1"").ejListView({
                    dataSource: dataManger,
                    fieldSettings: { text: ""CustomerID"" },
                    query:  ej.Query()
               .from(""Customers""), allowVirtualScrolling: true
                });
            }
        }
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });
    </script>
");
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
