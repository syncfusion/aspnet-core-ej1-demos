#pragma checksum "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\TreeView\RemoteData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d820af5526ecec82d58a7a4b6b7693c915307fa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeView_RemoteData), @"mvc.1.0.view", @"/Views/TreeView/RemoteData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeView/RemoteData.cshtml", typeof(AspNetCore.Views_TreeView_RemoteData))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d820af5526ecec82d58a7a4b6b7693c915307fa5", @"/Views/TreeView/RemoteData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeView_RemoteData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("table-name", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("parent-id", "CategoryID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ProductName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query", "ej.Query().from(\'Categories\').select(\'CategoryID,CategoryName\').take(3)", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "CategoryID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "CategoryName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("treeView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TreeViewProperties __Syncfusion_JavaScript_Models_TreeViewProperties;
        private global::Syncfusion.JavaScript.Models.TreeViewFields __Syncfusion_JavaScript_Models_TreeViewFields;
        private global::Syncfusion.JavaScript.Models.TreeViewMocks __Syncfusion_JavaScript_Models_TreeViewMocks;
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 54, true);
                WriteLiteral("<span class=\"sampleName\">TreeView / RemoteData </span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(105, 45, true);
                WriteLiteral("\r\n    <div style=\"width: 300px;\">\r\n\r\n        ");
                EndContext();
                BeginContext(150, 628, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-view", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "658799ec2e51405dac268028e77ede06", async() => {
                    BeginContext(178, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(192, 561, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-view-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9621ea60eb94b5ab81346a3e40907d2", async() => {
                        BeginContext(329, 19, true);
                        WriteLiteral(" \r\n                ");
                        EndContext();
                        BeginContext(348, 238, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-child", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb05374a9f87495395de70478cccebe2", async() => {
                            BeginContext(421, 23, true);
                            WriteLiteral(" \r\n                    ");
                            EndContext();
                            BeginContext(444, 113, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5eb33fb6ea647f6829878917ff5caa3", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                            __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\TreeView\RemoteData.cshtml"
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
                            BeginContext(557, 19, true);
                            WriteLiteral(" \r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_TreeViewMocks = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeViewMocks>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeViewMocks);
                        __Syncfusion_JavaScript_Models_TreeViewMocks.TableName = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        __Syncfusion_JavaScript_Models_TreeViewMocks.ParentId = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_TreeViewMocks.Text = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(586, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(604, 113, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9069f72c7bb84bd38b2edabe5d10eb8d", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                        __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 10 "D:\Samples_19.2.0.44\ASPNETCORE\samplebrowser\Views\TreeView\RemoteData.cshtml"
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
                        BeginContext(717, 15, true);
                        WriteLiteral(" \r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_TreeViewFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeViewFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeViewFields);
                    __Syncfusion_JavaScript_Models_TreeViewFields.Query = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Syncfusion_JavaScript_Models_TreeViewFields.Id = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Syncfusion_JavaScript_Models_TreeViewFields.Text = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(753, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_TreeViewProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeViewProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeViewProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(778, 24, true);
                WriteLiteral("        \r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(827, 109, true);
                WriteLiteral("\r\n    <style>\r\n        .e-waitingPopup-panel {\r\n            top: 140px !important;\r\n        }\r\n    </style>\r\n");
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
