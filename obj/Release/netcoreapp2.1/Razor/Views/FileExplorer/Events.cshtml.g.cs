#pragma checksum "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5ef3ac86a7ba2527124510cff4212aebde0aec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileExplorer_Events), @"mvc.1.0.view", @"/Views/FileExplorer/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FileExplorer/Events.cshtml", typeof(AspNetCore.Views_FileExplorer_Events))]
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
#line 1 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ef3ac86a7ba2527124510cff4212aebde0aec3", @"/Views/FileExplorer/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_FileExplorer_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Download{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/GetImage{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Upload{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fileExplorer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "wwwroot/css/images/FileExplorerContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("layout-change", "onLayoutChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("select", "onSelect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create-folder", "onCreateFolder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("remove", "onRemove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cut", "onCut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("copy", "onCopy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("paste", "onPaste", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("open", "onOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("unselect", "onUnselect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectControls_input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "target", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "evtpropscheckedevent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.FileExplorerProperties __Syncfusion_JavaScript_Models_FileExplorerProperties;
        private global::Syncfusion.JavaScript.Models.AjaxSettings __Syncfusion_JavaScript_Models_AjaxSettings;
        private global::Syncfusion.JavaScript.jQueryAjaxOptions __Syncfusion_JavaScript_jQueryAjaxOptions;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 54, true);
                WriteLiteral("<span class=\"sampleName\">FileExplorer / Events</span> ");
                EndContext();
            }
            );
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(107, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(113, 676, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-file-explorer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e38ad603456e46d0b6376e1641eba5a2", async() => {
                    BeginContext(514, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(520, 248, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-ajax-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56843c05f7f54c8b929220d421538903", async() => {
                        BeginContext(542, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(552, 57, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-download", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b2af255819f47e598061b6b0da7ea3e", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_jQueryAjaxOptions = CreateTagHelper<global::Syncfusion.JavaScript.jQueryAjaxOptions>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_jQueryAjaxOptions);
                        __Syncfusion_JavaScript_jQueryAjaxOptions.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(609, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(619, 59, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-get-image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20443d9638c748448d19acd4adb4feed", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_jQueryAjaxOptions = CreateTagHelper<global::Syncfusion.JavaScript.jQueryAjaxOptions>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_jQueryAjaxOptions);
                        __Syncfusion_JavaScript_jQueryAjaxOptions.Url = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(678, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(688, 51, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-upload", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f98ab5d0eba6415e8f77d5bf56f72fca", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_jQueryAjaxOptions = CreateTagHelper<global::Syncfusion.JavaScript.jQueryAjaxOptions>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_jQueryAjaxOptions);
                        __Syncfusion_JavaScript_jQueryAjaxOptions.Url = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(739, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_AjaxSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.AjaxSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AjaxSettings);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(768, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_FileExplorerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Path = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 4 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\Events.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.Layout = global::Syncfusion.JavaScript.LayoutType.Tile;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("layout", __Syncfusion_JavaScript_Models_FileExplorerProperties.Layout, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 4 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\Events.cshtml"
                                                                                                     WriteLiteral(Url.Content("FileActionDefault"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("ajax-action", __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 4 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\Events.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.LayoutChange = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Select = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.CreateFolder = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Remove = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Cut = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Copy = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Paste = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Open = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Unselect = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(789, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(794, 279, true);
            WriteLiteral(@"<div id=""target"">
    <ul>
        <li>layoutChange</li>
        <li>select</li>
        <li>unselect</li>
        <li>createFolder</li>
        <li>remove</li>
        <li>cut</li>
        <li>copy</li>
        <li>paste</li>
        <li>open</li>
    </ul>
</div>
");
            EndContext();
            DefineSection("EventsDropdown", async() => {
                BeginContext(1097, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1103, 134, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8fa89157cf42468a97ff7736c2d0b271", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_16.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
#line 28 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-checkbox", __Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("check-all", __Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1237, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(1267, 3007, true);
                WriteLiteral(@"
    <script>
        var fileExplorerObj;
        function evtpropscheckedevent(args) {
            fileExplorerObj = $(""#fileExplorer"").data(""ejFileExplorer"");
            if (args.isChecked) {
                switch (args.selectedValue) {
                    case ""layoutChange"": fileExplorerObj.option(args.selectedValue, ""onLayoutChange""); break;
                    case ""select"": fileExplorerObj.option(args.selectedValue, ""onSelect""); break;
                    case ""unselect"": fileExplorerObj.option(args.selectedValue, ""onUnselect""); break;
                    case ""createFolder"": fileExplorerObj.option(args.selectedValue, ""onCreateFolder""); break;
                    case ""remove"": fileExplorerObj.option(args.selectedValue, ""onRemove""); break;
                    case ""cut"": fileExplorerObj.option(args.selectedValue, ""onCut""); break;
                    case ""copy"": fileExplorerObj.option(args.selectedValue, ""onCopy""); break;
                    case ""paste"": fileExplorerObj.option(args.se");
                WriteLiteral(@"lectedValue, ""onPaste""); break;
                    case ""open"": fileExplorerObj.option(args.selectedValue, ""onOpen""); break;
                }
            }
            else fileExplorerObj.option(args.selectedValue, null);
        }

        function onLayoutChange(args) {
            jQuery.addEventLog(""<span class='eventTitle'>Layout changed</span> to '"" + args.layoutType + ""' view."");
        }
        function onSelect(args) {
            jQuery.addEventLog(""'"" + args.name + ""' "" + args.nodeType + "" has been <span class='eventTitle'>selected</span>."");
        }
        function onUnselect(args) {
            jQuery.addEventLog(""'"" + args.name + ""' "" + args.nodeType + "" has been <span class='eventTitle'>unselected</span>."");
        }
        function onCreateFolder(args) {
            jQuery.addEventLog(""'"" + args.data.files[0].name + ""' Directory has been <span class='eventTitle'>created</span>."");
        }
        function onRemove(args) {
            jQuery.addEventLog(""'"" + arg");
                WriteLiteral(@"s.name + ""' "" + args.selectedItems[0].type + "" has been <span class='eventTitle'>removed</span>."");
        }
        function onCut(args) {
            jQuery.addEventLog(""'"" + args.name + ""' "" + args.selectedItems[0].type + "" has been <span class='eventTitle'>cut</span>."");
        }
        function onCopy(args) {
            jQuery.addEventLog(""'"" + args.name + ""' "" + args.selectedItems[0].type + "" has been <span class='eventTitle'>copied</span>."");
        }
        function onPaste(args) {
            jQuery.addEventLog(""'"" + args.selectedItems[0].name + ""' "" + args.selectedItems[0].type + "" has been <span class='eventTitle'>pasted</span>."");
        }
        function onOpen(args) {
            jQuery.addEventLog(""'"" + args.selectedItems[0].name + ""' "" + args.itemType + "" has been <span class='eventTitle'>opened</span>."");
        }
        function onClear() {
            jQuery.clearEventLog();
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(4277, 2, true);
            WriteLiteral("\r\n");
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
