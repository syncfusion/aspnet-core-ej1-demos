#pragma checksum "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "538f4e452c134b6ed1c866a7264f4e6797b753a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileExplorer_CustomTool), @"mvc.1.0.view", @"/Views/FileExplorer/CustomTool.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FileExplorer/CustomTool.cshtml", typeof(AspNetCore.Views_FileExplorer_CustomTool))]
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
#line 1 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538f4e452c134b6ed1c866a7264f4e6797b753a7", @"/Views/FileExplorer/CustomTool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_FileExplorer_CustomTool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Download{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/GetImage{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Upload{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "help", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tooltip", "help", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("css", "e-fileExplorer-toolbar-icon Help", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", "dialogOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "wwwroot/css/images/FileExplorerContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("helpDialog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", "FileExplorer Help", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("css-class", "e-fe-dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.FileExplorerTools __Syncfusion_JavaScript_Models_FileExplorerTools;
        private global::Syncfusion.JavaScript.Models.FileCustomToolSettings __Syncfusion_JavaScript_Models_FileCustomToolSettings;
        private global::Syncfusion.JavaScript.Models.FileExplorerCustomTool __Syncfusion_JavaScript_Models_FileExplorerCustomTool;
        private global::Syncfusion.JavaScript.Models.DialogProperties __Syncfusion_JavaScript_Models_DialogProperties;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 58, true);
                WriteLiteral("<span class=\"sampleName\">FileExplorer / CustomTool </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(109, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(115, 866, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-file-explorer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b60dc0be716e4ad09faf9aed70e4e736", async() => {
                    BeginContext(399, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(409, 264, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-ajax-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecd225de81244f238f7194d51dbfc89b", async() => {
                        BeginContext(431, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(445, 57, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-download", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cba9acc0fe684d5eaab064ce04bf7bff", async() => {
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
                        BeginContext(502, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(516, 59, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-get-image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c4b7b09d3e44793b2a23cb9c215a4bb", async() => {
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
                        BeginContext(575, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(589, 51, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-upload", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0373bc2237c143b68f9cf49ad8ac022b", async() => {
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
                        BeginContext(640, 10, true);
                        WriteLiteral("\r\n        ");
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
                    BeginContext(673, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(683, 273, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-tools", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9aa74ec43a44e8b82c0bb2c945af3fd", async() => {
                        BeginContext(697, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(711, 220, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-custom-tools", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc02c0faf7c14d0f9436d246b304eb29", async() => {
                            BeginContext(732, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(750, 145, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-custom-tool", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3746cab199e472d94dc2b94e3f90a50", async() => {
                                BeginContext(856, 18, true);
                                WriteLiteral("\r\n                ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_Models_FileExplorerCustomTool = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerCustomTool>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerCustomTool);
                            __Syncfusion_JavaScript_Models_FileExplorerCustomTool.Name = (string)__tagHelperAttribute_3.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                            __Syncfusion_JavaScript_Models_FileExplorerCustomTool.Tooltip = (string)__tagHelperAttribute_4.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                            __Syncfusion_JavaScript_Models_FileExplorerCustomTool.Css = (string)__tagHelperAttribute_5.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                            __Syncfusion_JavaScript_Models_FileExplorerCustomTool.Action = (string)__tagHelperAttribute_6.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(895, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_FileCustomToolSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileCustomToolSettings>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileCustomToolSettings);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(931, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_FileExplorerTools = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerTools>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerTools);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(956, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_FileExplorerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Path = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.Layout = global::Syncfusion.JavaScript.LayoutType.Tile;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("layout", __Syncfusion_JavaScript_Models_FileExplorerProperties.Layout, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
                                                                                               WriteLiteral(Url.Content("FileActionDefault"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("ajax-action", __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Width = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.ToolsList = new List<string>(){"creation","navigation","addressBar", "copyPaste", "searchBar", "customTool"};

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tools-list", __Syncfusion_JavaScript_Models_FileExplorerProperties.ToolsList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(981, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(989, 728, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dff30b937b4e80b2e2d698aa1b7cfc", async() => {
                    BeginContext(1141, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1151, 548, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8bda7ab41914541bc3adee6ad3662e6", async() => {
                        BeginContext(1171, 507, true);
                        WriteLiteral(@"
            <div class=""text-content"">
                <div class=""header-content"">Need assistance?</div>
                <div class=""header-content"">Our help document assists you to know more about FileExplorer control.</div>
                <div class=""header-content"">
                    Please refer -> <a href=""//help.syncfusion.com/aspnet-core/fileexplorer/overview""
                                       target=""_blank"">Help Document</a>
                </div>
            </div>
        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1699, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_DialogProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DialogProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DialogProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_DialogProperties.Title = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 17 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
__Syncfusion_JavaScript_Models_DialogProperties.EnableResize = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-resize", __Syncfusion_JavaScript_Models_DialogProperties.EnableResize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
__Syncfusion_JavaScript_Models_DialogProperties.EnableModal = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-modal", __Syncfusion_JavaScript_Models_DialogProperties.EnableModal, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
__Syncfusion_JavaScript_Models_DialogProperties.ShowOnInit = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-on-init", __Syncfusion_JavaScript_Models_DialogProperties.ShowOnInit, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "D:\Samples_19.3.0.43\ASPNETCORE\samplebrowser\Views\FileExplorer\CustomTool.cshtml"
__Syncfusion_JavaScript_Models_DialogProperties.Width = 350;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_DialogProperties.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DialogProperties.CssClass = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1717, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1745, 122, true);
                WriteLiteral("\r\n    <script>\r\n        function dialogOpen() {\r\n            $(\'#helpDialog\').ejDialog(\'open\')\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1892, 376, true);
                WriteLiteral(@"
<style type=""text/css"">
    /*Specify the custom tool icon*/
    .e-fileExplorer-toolbar-icon {
        height: 22px;
        width: 22px;
        font-family: 'ej-webfont';
        font-size: 18px;
        margin-top: 2px;
        text-align: center;
    }

        .e-fileExplorer-toolbar-icon.Help:before {
            content: ""\e72b"";
        }
</style>
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
