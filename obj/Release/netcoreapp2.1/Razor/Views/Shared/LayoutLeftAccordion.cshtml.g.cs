#pragma checksum "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c1616784ae6b4eccbdace9c5eb63b994ab7a63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LayoutLeftAccordion), @"mvc.1.0.view", @"/Views/Shared/LayoutLeftAccordion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/LayoutLeftAccordion.cshtml", typeof(AspNetCore.Views_Shared_LayoutLeftAccordion))]
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
#line 5 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c1616784ae6b4eccbdace9c5eb63b994ab7a63", @"/Views/Shared/LayoutLeftAccordion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_LayoutLeftAccordion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("watermark-text", "Search Here", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("select", "onSelectSearchItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "210px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
   var iisvalue = @Url.Content("~/");

#line default
#line hidden
            BeginContext(40, 86, true);
            WriteLiteral("\r\n<div class=\"accordion-panel cols-fixed-sidebar\">\r\n    <div class=\"search\">\r\n        ");
            EndContext();
            BeginContext(126, 335, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-autocomplete", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948c6505e65f4ba9a2c7dc2410d8ea22", async() => {
            }
            );
            __Syncfusion_JavaScript_Models_AutocompleteProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AutocompleteProperties>();
            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AutocompleteProperties);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Syncfusion_JavaScript_Models_AutocompleteProperties.WatermarkText = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 5 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.ShowPopupButton = false;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("show-popup-button", __Syncfusion_JavaScript_Models_AutocompleteProperties.ShowPopupButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 5 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.FilterType = FilterOperatorType.Contains;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("filter-type", __Syncfusion_JavaScript_Models_AutocompleteProperties.FilterType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("<a href= \'");
#line 5 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
                                                                                                                                             WriteLiteral(iisvalue);

#line default
#line hidden
            WriteLiteral("${id}\' class=\'anchorclass\'><div class=\'control_name\'>${control}</div> <div class=\'control_samplename\'>${text}</div></a>");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Syncfusion_JavaScript_Models_AutocompleteProperties.Template = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("template", __Syncfusion_JavaScript_Models_AutocompleteProperties.Template, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Syncfusion_JavaScript_Models_AutocompleteProperties.Select = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Syncfusion_JavaScript_Models_AutocompleteProperties.Width = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(461, 145, true);
            WriteLiteral("        \r\n        <span class=\'search-icon\'></span>\r\n        <span class=\"navigation\"></span>\r\n    </div>\r\n    <div id=\"dashboardheader\">\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 606, "", 648, 2);
#line 10 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
WriteAttributeValue("", 612, Url.Content("~/"), 612, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 630, "introduction/index", 630, 18, true);
            EndWriteAttribute();
            BeginContext(648, 769, true);
            WriteLiteral(@" >
            <div id=""sbdashboard"" class=""dashboardhead"">
                <span class=""anchor"">SHOWCASE SAMPLES</span>
            </div>
    </a>
        </div>
    <div id=""scrollcontainer"">
        <div>

            <div class=""accordion"" id=""accordion2"">
            </div>

            <script id=""accordionGroupTmpl"" type=""text/x-jsrender"">
			<div class=""SB-groupIt downArrow""><span>{{:#view.data}}</span><span class=""SB-Arrow""></span></div>
			<div class=""SB-group {{RemoveWhiteSpace:#view.data}}""></div>
            </script>
            <script id=""accordionTmpl"" type=""text/x-jsrender"">
                <div class=""anchorclass mainlevel {{ensureURL:id}}_nav"" hashbang=""/{{>controller}}/{{ensureURL:action}}"">
                    <a href=");
            EndContext();
            BeginContext(1418, 17, false);
#line 28 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
                       Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 1741, true);
            WriteLiteral(@"{{ensureURL:controller}}/{{ensureURL:action}}>
                        <div class=""dashboard"">
                            <span class=""anchor"">{{>name}}</span>
                            {{if type}} <span class=""samplestatus {{>type}}""></span>{{/if}}
                        </div>
                    </a>
                </div>
            </script>
            <div class=""accordion samplesCollection"" id=""samplesDiv""></div>
            <script type=""text/x-jsrender"" id=""accordionTmplchild"">
                <div class=""samples {{ensureURL:id}}_nav"">
                    <div id=""{{ensureURL:id}}_nav_back"" class=""firstlevelback dashboardhead"">
                        <span class=""arrowback""></span>
                        <span class=""anchor sbheading"">ALL CONTROLS</span>
                    </div>
                    <div id=""{{ensureURL:id}}_nav_header"" class=""dashboardhead"">
                        <span class=""anchor sbheading"">{{:name}}</span>
                    </div>
                 ");
            WriteLiteral(@"   {{for samples ~pId=id}}
                    {{if (childcount>0)}}
                    <div class=""subsample-1"">
                        <div class=""SB-groupIt downArrow"">
                            <span>{{Upperstring:name}}</span>
                            <span class=""SB-Arrow""></span>
                        </div>
                        <div id=""{{>pId}}"" width=""200px"">
                            {{for samples ~rId=~pId ~sId=name}}
                            <div hashbang=""/{{>~sId}}/{{>action}}"" class=""secondlevelload SB-group SB-hashcollection {{ensureURL:id}}_nav"" childcount=""{{>childcount}}"" controller=""{{>controller}}"" action=""{{>action}}"">
                                <a href=");
            EndContext();
            BeginContext(3177, 17, false);
#line 56 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
                                   Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(3194, 729, true);
            WriteLiteral(@"{{ensureURL:controller}}/{{ensureURL:action}}>
                                    <div class=""dashboard"">
                                        <span class=""anchor"">{{>name}}</span>
                                        {{if type}} <span class=""samplestatus {{>type}}""></span>{{/if}}
                                    </div>
                                </a>
                            </div>
                            {{/for}}
                        </div>
                    </div>
                    {{else}}
                    <div class=""firstlevelload SB-hashcollection {{ensureURL:id}}"" childcount=""{{>childcount}}"" controller=""{{>~pId}}"" action=""{{>action}}"">
                        <a href=");
            EndContext();
            BeginContext(3924, 17, false);
#line 68 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\Shared\LayoutLeftAccordion.cshtml"
                           Write(Url.Content("~/"));

#line default
#line hidden
            EndContext();
            BeginContext(3941, 601, true);
            WriteLiteral(@"{{ensureURL:controller}}/{{ensureURL:action}}>
                            <div class=""dashboard"">
                                <span class=""anchor"">{{>name}}</span>
                                {{if type}} <span class=""samplestatus {{>type}}""></span>{{/if}}
                            </div>
                        </a>
                    </div>
                    {{/if}}
                                    {{/for}}
                </div>
            </script>
            <div id=""subsamplesDiv"" style=""display: none"">
            </div>
        </div>
    </div>
</div>
");
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
