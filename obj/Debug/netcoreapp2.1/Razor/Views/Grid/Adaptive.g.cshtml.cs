#pragma checksum "D:\Work\GitHub\aspnet-core-ej1-demos\Views\Grid\Adaptive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd3ecb689d18da010fae04c59cdddfbd687d5eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grid_Adaptive), @"mvc.1.0.view", @"/Views/Grid/Adaptive.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grid/Adaptive.cshtml", typeof(AspNetCore.Views_Grid_Adaptive))]
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
#line 1 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Work\GitHub\aspnet-core-ej1-demos\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd3ecb689d18da010fae04c59cdddfbd687d5eb", @"/Views/Grid/Adaptive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Grid_Adaptive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "320x494", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "614x364", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1000x364", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 48, true);
                WriteLiteral("<span class=\"sampleName\"> Grid/Responsive</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(92, 188, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo shows the responsive behavior of Syncfusion ASP.NET Core DataGrid control with respect to different client browser’s width and height.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(308, 248, true);
                WriteLiteral("\r\n    <div id=\"resMode\" class=\"emulatortap\">\r\n        <div class=\"sample-container\">\r\n            <iframe id=\"sample\" frameborder=\"0\" tabindex=\"1\" style=\"height: 364px;width: 616px\" src=\'../Grid/AdaptiveGrid\'></iframe>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(586, 227, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            Responsive Grid\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            <select id=\"columnName\" class=\"e-ddl\" data-bind=\"value: field\">\r\n                ");
                EndContext();
                BeginContext(813, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd8d13c922214b3c9675bfad813d2be6", async() => {
                    BeginContext(837, 11, true);
                    WriteLiteral("Mobile Mode");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(857, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(875, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88dc0e1d02384d7cb47a2623e92d47da", async() => {
                    BeginContext(919, 11, true);
                    WriteLiteral("Tablet Mode");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(939, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(957, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1082a5344b9143bb9733f2b6b5fd7f14", async() => {
                    BeginContext(982, 12, true);
                    WriteLiteral("Desktop Mode");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1003, 321, true);
                WriteLiteral(@"
            </select>
        </div>
        <div id=""mobilview"" style=""display: none"">
            <div class=""col-md-3"">
                DetailsView
            </div>
            <div class=""col-md-3"">
                <input type=""checkbox"" id=""allowCheck"" />
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1350, 3732, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            var browser = ej.Grid.prototype.getBrowserDetails();
            $(""#sampleProperties"").ejPropertiesPanel();
            $(""#allowCheck"").ejCheckBox({
                ""change"": function (args) {
                    if (args.isInteraction) {
                        if (browser.browser == ""msie"" && parseInt(browser.version, 10) <= 9) {
                            alert(""Details view not support in IE"" + parseInt(browser.version, 10));
                            $(""#allowCheck"").ejCheckBox({ checked: false });
                        }
                        else {
                            var iframe = document.getElementById('sample');
                            iframe.contentWindow.postMessage(args.isChecked, iframe.src);
                            $(iframe).contents().find("".e-responsesearch"").css(""display"", ""none"");
                        }
                    }
                }
            });
            v");
                WriteLiteral(@"ar dropDownSlectedValue = $(""#columnName option:selected"").text();
            $(""#columnName"").ejDropDownList({ width: ""120"", change: ""dropdownChange"", text: dropDownSlectedValue });
        });
        window.loadGridFrameTheme = function () {
            var iframe = document.getElementById('sample');
            iframe.contentWindow.postMessage(""theme_"" + window.theme, iframe.src);
        }
        function dropdownChange(args) {
            var str = args.selectedValue;
            if (args.text == ""Mobile Mode"") {
                $(""#allowCheck"").ejCheckBox({checked:false})
                var iframe = document.getElementById('sample');
                iframe.contentWindow.postMessage(""mobile"", iframe.src);
                $(""#sample"").parents().find(""#resMode"").removeClass(""emulatortap"").addClass(""emulatordesk"");
                $(""#sample"").css(""width"", str.split(""x"")[0]).css(""height"", str.split(""x"")[1]).css(""margin-left"", """");
                $("".cols-prop-area"").css(""width"", """").css(");
                WriteLiteral(@"""min-height"", """").css(""margin-left"", """");
                var grid = $(""#sample"").contents().find(""#Grid .e-gridcontent"").addClass(""e-widget"");
                $("".cols-sample-area"").css(""width"", ""72.956%"");
                $('#mobilview').css(""display"", ""block"");

            }

            else if (args.text == ""Tablet Mode"") {
                var browser = ej.browserInfo();
                document.getElementById(""sample"").contentDocument.location.reload();
                $(""#sample"").parents().find(""#resMode"").removeClass(""emulatordesk"").addClass(""emulatortap"");
                $(""#sample"").css(""width"", str.split(""x"")[0]).css(""height"", str.split(""x"")[1]);
                $("".cols-prop-area"").css(""width"", """").css(""min-height"", """").css(""margin-left"", """");
                if (browser.name == ""msie"")
                    $("".cols-sample-area"").css(""width"", ""100%"");
                else
                    $("".cols-sample-area"").css(""width"", ""72.956%"");
                $('#mobilview').css(""dis");
                WriteLiteral(@"play"", ""none"");
            }
            else {
                var iframe = document.getElementById('sample');
                iframe.contentWindow.postMessage(""desktop"", iframe.src);
                $(""#sample"").parents().find(""#resMode"").removeClass(""emulatortap"").removeClass(""emulatordesk"");
                $(""#sample"").css(""width"", ""100%"").css(""height"", str.split(""x"")[1]);
                $("".cols-prop-area"").css(""width"", ""99%"").css(""min-height"", ""200px"").css(""margin-left"", ""0px"");
                $("".cols-sample-area"").css(""width"", ""99%"");
                $('#mobilview').css(""display"", ""none"");
            }
        }
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
