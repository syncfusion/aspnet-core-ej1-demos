#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Dropdownlist\VirtualScrolling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b647fcf3b17c4bbc2bd5574507d848df5703342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dropdownlist_VirtualScrolling), @"mvc.1.0.view", @"/Views/Dropdownlist/VirtualScrolling.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dropdownlist/VirtualScrolling.cshtml", typeof(AspNetCore.Views_Dropdownlist_VirtualScrolling))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b647fcf3b17c4bbc2bd5574507d848df5703342", @"/Views/Dropdownlist/VirtualScrolling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Dropdownlist_VirtualScrolling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "CompanyName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ContactName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CompanyNames"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        private global::Syncfusion.JavaScript.Models.DropDownListFields __Syncfusion_JavaScript_Models_DropDownListFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 66, true);
                WriteLiteral("<span class=\"sampleName\"> Dropdownlist / Virtual Scrolling </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(117, 137, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            <div class=\"ctrllabel\"> Select a Company Name </div> \r\n            ");
                EndContext();
                BeginContext(254, 399, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b4a2eb731074c88a05c1b3dc7a51817", async() => {
                    BeginContext(396, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(414, 122, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "868855cac966481dae0b6dbc72f353b3", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                    __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Dropdownlist\VirtualScrolling.cshtml"
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
                    BeginContext(536, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(554, 65, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-drop-down-list-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "461f755fea2b4e078186301180bb5b68", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_DropDownListFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListFields);
                    __Syncfusion_JavaScript_Models_DropDownListFields.Text = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Syncfusion_JavaScript_Models_DropDownListFields.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(619, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Dropdownlist\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.AllowVirtualScrolling = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-virtual-scrolling", __Syncfusion_JavaScript_Models_DropDownListProperties.AllowVirtualScrolling, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Dropdownlist\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.VirtualScrollMode = VirtualScrollMode.Normal;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("virtual-scroll-mode", __Syncfusion_JavaScript_Models_DropDownListProperties.VirtualScrollMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Dropdownlist\VirtualScrolling.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.ItemsCount = 10;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("items-count", __Syncfusion_JavaScript_Models_DropDownListProperties.ItemsCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(653, 40, true);
                WriteLiteral("\r\n                </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(718, 183, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .e-ddl-popup {\r\n            margin: 0 auto;\r\n        }\r\n        .frame {\r\n            width: 250px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(931, 261, true);
                WriteLiteral(@"
    <div id=""ddl1"">
        <ul>
            <li>Normal</li>
            <li>Continuous</li>
        </ul>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            VirtualScroll mode
        </div>
        <div class=""col-md-3"">
");
                EndContext();
#line 36 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\Dropdownlist\VirtualScrolling.cshtml"
              (Html.EJ().DropDownList("scrollMode")
                        .TargetID("ddl1")
                        .Width("120px")
                        .SelectedIndex(0)
                        .ClientSideEvents(eve => { eve.Change("selectChange"); })
                    )
                    .Render();
            

#line default
#line hidden
                BeginContext(1525, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1579, 862, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        function selectChange(args) {
            var target = $('#CompanyNames').data(""ejDropDownList"");
            target.destroy();

            var dataManager = ej.DataManager({ url: ""//js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/Customers"", CrossDomain:true });
            
            var controlProperty =
			{
			    dataSource: dataManager,
			    fields: { text: ""CompanyName"", value: 'ContactName' },
			    width: 260,
			    itemsCount: 10,
			    allowVirtualScrolling: true
			};

            controlProperty.virtualScrollMode = args.itemId == 1 ? ""continuous"" : ""normal"";

            $('#CompanyNames').ejDropDownList(controlProperty);
               
        }
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(2444, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
