#pragma checksum "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Upload\DragAndDrop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f772aab23eeff6c56b9acd6c9c558c1238d0a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_DragAndDrop), @"mvc.1.0.view", @"/Views/Upload/DragAndDrop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload/DragAndDrop.cshtml", typeof(AspNetCore.Views_Upload_DragAndDrop))]
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
#line 1 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f772aab23eeff6c56b9acd6c9c558c1238d0a8", @"/Views/Upload/DragAndDrop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_DragAndDrop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Draganddrop"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("save-url", "//js.syncfusion.com/demos/ejServices/api/uploadbox/Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("remove-url", "//js.syncfusion.com/demos/ejServices/api/uploadbox/Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(23, 61, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Upload / Drag And Drop </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(112, 71, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n             ");
                EndContext();
                BeginContext(183, 259, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-upload-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "076c8f4592e54b709df337be900cd62b", async() => {
                    BeginContext(412, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_UploadboxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.UploadboxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_UploadboxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_UploadboxProperties.SaveUrl = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_UploadboxProperties.RemoveUrl = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Upload\DragAndDrop.cshtml"
__Syncfusion_JavaScript_Models_UploadboxProperties.AllowDragAndDrop = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-drag-and-drop", __Syncfusion_JavaScript_Models_UploadboxProperties.AllowDragAndDrop, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 6 "D:\Samples_18.3.0.35\ASPNETCORE\samplebrowser\Views\Upload\DragAndDrop.cshtml"
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
                BeginContext(442, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(497, 217, true);
                WriteLiteral("\r\n    <style class=\"cssStyles\">\r\n        .frame {\r\n            width: 500px;\r\n            height: 100px;\r\n        }\r\n\r\n        .control {\r\n            width: 100%;\r\n            height: 100%;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(740, 343, true);
                WriteLiteral(@"
 <script>
document.addEventListener('dragover',function(event){
    event.preventDefault();
    event.dataTransfer.dropEffect = 'none';
    return false;
	},false);
	document.addEventListener('drop',function(event){
    event.dataTransfer.dropEffect = 'none';
    event.preventDefault();
    return false;
  },false);
 </script>
");
                EndContext();
            }
            );
            BeginContext(1086, 3, true);
            WriteLiteral(" \r\n");
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
