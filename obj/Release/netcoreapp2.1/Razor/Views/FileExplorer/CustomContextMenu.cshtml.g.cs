#pragma checksum "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\CustomContextMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb0b6b7f5bfa73bdf16d57b09830b1e95a4229bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileExplorer_CustomContextMenu), @"mvc.1.0.view", @"/Views/FileExplorer/CustomContextMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FileExplorer/CustomContextMenu.cshtml", typeof(AspNetCore.Views_FileExplorer_CustomContextMenu))]
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
#line 1 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0b6b7f5bfa73bdf16d57b09830b1e95a4229bd", @"/Views/FileExplorer/CustomContextMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_FileExplorer_CustomContextMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Download{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/GetImage{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Upload{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "tile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Tile view", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", "onLayout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "grid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Grid view", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "largeicons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Large icons view", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "View by", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sprite-css-class", "custom-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fileExplorer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "wwwroot/css/images/FileExplorerContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("menu-open", "onMenuOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("layout-change", "onLayoutChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.FileExplorerContextMenuSettings __Syncfusion_JavaScript_Models_FileExplorerContextMenuSettings;
        private global::Syncfusion.JavaScript.Models.FileExplorerItems __Syncfusion_JavaScript_Models_FileExplorerItems;
        private global::Syncfusion.JavaScript.Models.customMenuFields __Syncfusion_JavaScript_Models_customMenuFields;
        private global::Syncfusion.JavaScript.Models.FileExplorerCustomMenuFields __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 67, true);
                WriteLiteral("<span class=\"sampleName\">FileExplorer / Custom Context Menu </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(118, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(124, 1695, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-file-explorer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ed479aa54f94728b51384da4653efe5", async() => {
                    BeginContext(362, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(372, 264, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-ajax-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e837d63f554d958c543b9b399421c9", async() => {
                        BeginContext(394, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(408, 57, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-download", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccd23ddea1304e7e8e8899251571c634", async() => {
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
                        BeginContext(465, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(479, 59, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-get-image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "720d75d02b944536a0d983c8022e9b9c", async() => {
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
                        BeginContext(538, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(552, 51, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-upload", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00a572cd7e5c483a9f6c942c734e10f4", async() => {
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
                        BeginContext(603, 10, true);
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
                    BeginContext(636, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(646, 1148, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-context-menu-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3c62e151c04477d8b85efc499cd0671", async() => {
                        BeginContext(676, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(690, 469, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "169e1c5daa6c4c45ba1437c6a924016d", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_FileExplorerItems = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerItems>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerItems);
#line 10 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\CustomContextMenu.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerItems.Navbar = new List<string>() { "Upload", "|", "Delete", "Rename", "|", "Cut", "Copy", "Paste", "|", "Getinfo" };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("navbar", __Syncfusion_JavaScript_Models_FileExplorerItems.Navbar, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 11 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\CustomContextMenu.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerItems.Cwd = new List<string>() { "Refresh", "Paste", "|", "SortBy", "View", "|", "NewFolder", "Upload", "|", "Getinfo" };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("cwd", __Syncfusion_JavaScript_Models_FileExplorerItems.Cwd, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\CustomContextMenu.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerItems.Files = new List<string>() { "Open", "Download", "|", "Delete", "Rename", "|", "Cut", "Copy", "Paste", "|", 
          "OpenFolderLocation", "Getinfo" };

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("files", __Syncfusion_JavaScript_Models_FileExplorerItems.Files, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1159, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1173, 580, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-custom-menu-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bb140cc4d9a457c8dbf6708ac62f5e3", async() => {
                            BeginContext(1200, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                            BeginContext(1218, 493, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-menu-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b99669f15af48098a9db5822404c4e8", async() => {
                                BeginContext(1289, 22, true);
                                WriteLiteral("\r\n                    ");
                                EndContext();
                                BeginContext(1311, 366, false);
                                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-child-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89efaab9c4fa4b2cb38223b26b536bf1", async() => {
                                    BeginContext(1326, 26, true);
                                    WriteLiteral("\r\n                        ");
                                    EndContext();
                                    BeginContext(1352, 74, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-child-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25fe55b9ec04e4fb92d474c86c3f4fb", async() => {
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerCustomMenuFields>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Id = (string)__tagHelperAttribute_3.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Text = (string)__tagHelperAttribute_4.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Action = (string)__tagHelperAttribute_5.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1426, 26, true);
                                    WriteLiteral("\r\n                        ");
                                    EndContext();
                                    BeginContext(1452, 74, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-child-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5cb9307aecb46618dca5a574d44f78f", async() => {
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerCustomMenuFields>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Id = (string)__tagHelperAttribute_6.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Text = (string)__tagHelperAttribute_7.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Action = (string)__tagHelperAttribute_5.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1526, 26, true);
                                    WriteLiteral("\r\n                        ");
                                    EndContext();
                                    BeginContext(1552, 87, false);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-child-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f88a314b3984175b258006a868d8218", async() => {
                                    }
                                    );
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerCustomMenuFields>();
                                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Id = (string)__tagHelperAttribute_8.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Text = (string)__tagHelperAttribute_9.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                                    __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Action = (string)__tagHelperAttribute_5.Value;
                                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                                    {
                                        await __tagHelperExecutionContext.SetOutputContentAsync();
                                    }
                                    Write(__tagHelperExecutionContext.Output);
                                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                    EndContext();
                                    BeginContext(1639, 22, true);
                                    WriteLiteral("\r\n                    ");
                                    EndContext();
                                }
                                );
                                __Syncfusion_JavaScript_Models_customMenuFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.customMenuFields>();
                                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_customMenuFields);
                                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                                if (!__tagHelperExecutionContext.Output.IsContentModified)
                                {
                                    await __tagHelperExecutionContext.SetOutputContentAsync();
                                }
                                Write(__tagHelperExecutionContext.Output);
                                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                                EndContext();
                                BeginContext(1677, 18, true);
                                WriteLiteral("\r\n                ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerCustomMenuFields>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields);
                            __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Id = (string)__tagHelperAttribute_10.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                            __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.Text = (string)__tagHelperAttribute_11.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                            __Syncfusion_JavaScript_Models_FileExplorerCustomMenuFields.SpriteCssClass = (string)__tagHelperAttribute_12.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1711, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_customMenuFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.customMenuFields>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_customMenuFields);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1753, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_FileExplorerContextMenuSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerContextMenuSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerContextMenuSettings);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1794, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_FileExplorerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Path = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\CustomContextMenu.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.Layout = global::Syncfusion.JavaScript.LayoutType.LargeIcons;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("layout", __Syncfusion_JavaScript_Models_FileExplorerProperties.Layout, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\CustomContextMenu.cshtml"
                                                                                                           WriteLiteral(Url.Content("FileActionDefault"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("ajax-action", __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Width = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
#line 3 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\CustomContextMenu.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.MenuOpen = (string)__tagHelperAttribute_16.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.LayoutChange = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1819, 209, true);
                WriteLiteral("\r\n\r\n<h6>\r\n    <span style=\"font-style:italic; margin-top: 5px;margin-left: 20%;\">\r\n        Note: A new custom ContextMenu item (\"View\") is added to Current Working Directory\'s ContextMenu\r\n    </span>\r\n</h6>\r\n");
                EndContext();
            }
            );
            BeginContext(2031, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("ScriptSection", async() => {
                BeginContext(2058, 678, true);
                WriteLiteral(@"

<script>
    function onLayout(args) {
        var feObj = $('#fileExplorer').data(""ejFileExplorer"");
        feObj && feObj.option(""layout"", args.ID);
    }
    function onMenuOpen(args) {
        if (args.contextMenu == ""cwd"") {
            $("".fe-context-menu"").find("".e-fe-activeicon"").removeClass(""e-fe-activeicon"");
            $("".fe-context-menu"").find(""."" + this.model.layout).addClass(""e-fe-activeicon"");
        }
    }
    function onLayoutChange(args) {
        $("".fe-context-menu .View"").removeClass(""custom-grid custom-tile custom-largeicons"");
        $("".fe-context-menu .View"").addClass(""custom-"" + this.model.layout);
    }
</script>


");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2761, 268, true);
                WriteLiteral(@"
   <style>
    .fe-context-menu .custom-grid:before {
        content: ""\e7b9"";
    }

    .fe-context-menu .custom-largeicons:before {
        content: ""\e7bb"";
    }

    .fe-context-menu .custom-tile:before {
        content: ""\e7be"";
    }
</style>
");
                EndContext();
            }
            );
            BeginContext(3032, 2, true);
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
