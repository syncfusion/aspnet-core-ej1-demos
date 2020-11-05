#pragma checksum "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Upload\FileTypesInput.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba7ccb997c99f9910bff3fd259a358ac05e09214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_FileTypesInput), @"mvc.1.0.view", @"/Views/Upload/FileTypesInput.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload/FileTypesInput.cshtml", typeof(AspNetCore.Views_Upload_FileTypesInput))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7ccb997c99f9910bff3fd259a358ac05e09214", @"/Views/Upload/FileTypesInput.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_FileTypesInput : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UploadInput"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("error", "onError", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("save-url", "//js.syncfusion.com/demos/ejServices/api/uploadbox/Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("remove-url", "//js.syncfusion.com/demos/ejServices/api/uploadbox/Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.UploadboxProperties __Syncfusion_JavaScript_Models_UploadboxProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 57, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Upload / File Input</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(108, 112, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            <div class=\"posupload\"> \r\n                ");
                EndContext();
                BeginContext(220, 252, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-upload-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "880a0a65d582454499de36e356282c10", async() => {
                    BeginContext(438, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_UploadboxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.UploadboxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_UploadboxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_UploadboxProperties.Error = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_UploadboxProperties.SaveUrl = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_UploadboxProperties.RemoveUrl = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 7 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Upload\FileTypesInput.cshtml"
__Syncfusion_JavaScript_Models_UploadboxProperties.MultipleFilesSelection = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("multiple-files-selection", __Syncfusion_JavaScript_Models_UploadboxProperties.MultipleFilesSelection, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(472, 51, true);
                WriteLiteral("\r\n             </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(553, 720, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3"">
            Extensions:
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <input type=""text"" id=""fileallow"" class=""tb6 ejinputtext"" placeholder=""Format"" />
        </div>
        <div class=""col-md-3"">
            <input type=""button"" class=""e-btn"" id=""upbutton1"" value=""Allow"" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <input type=""text"" id=""filedeny"" class=""tb6 ejinputtext"" placeholder=""Format"" />
        </div>
        <div class=""col-md-3"">
            <input type=""button"" class=""e-btn"" id=""upbutton2"" value=""Deny"" />
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1299, 1015, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var uploadobject;
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
            $(""#upbutton1"").ejButton({
                click: ""allowfiletype"",
            });
            $(""#upbutton2"").ejButton({
                click: ""denyfiletype"",
            });

        });
        function allowfiletype() {
            uploadobject = $(""#UploadInput"").data(""ejUploadbox"");
            uploadobject.option('extensionsAllow', $(""#fileallow"").val());
            uploadobject.option('extensionsDeny', """");
            $(""#filedeny"").val('');
        }
        function denyfiletype() {
            uploadobject = $(""#UploadInput"").data(""ejUploadbox"");
            uploadobject.option('extensionsAllow', """");
            uploadobject.option('extensionsDeny', $(""#filedeny"").val());
            $(""#fileallow"").val('');
        }
        function onError(args) {
            alert(args.error);
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2339, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2350, "\"", 2405, 1);
#line 67 "D:\Samples_18.3.0.47\ASPNETCORE\samplebrowser\Views\Upload\FileTypesInput.cshtml"
WriteAttributeValue("", 2357, Url.Content("~/css/samples/uploadfiletype.css"), 2357, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2406, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            BeginContext(2429, 1, true);
            WriteLiteral(" ");
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
