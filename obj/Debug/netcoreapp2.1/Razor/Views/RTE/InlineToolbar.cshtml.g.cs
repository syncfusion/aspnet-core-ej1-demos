#pragma checksum "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f41cddb6a24092d3520110b450ff34591ecae8b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RTE_InlineToolbar), @"mvc.1.0.view", @"/Views/RTE/InlineToolbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RTE/InlineToolbar.cshtml", typeof(AspNetCore.Views_RTE_InlineToolbar))]
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
#line 1 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41cddb6a24092d3520110b450ff34591ecae8b3", @"/Views/RTE/InlineToolbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_RTE_InlineToolbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("css", "e-rte-toolbar-icon e-rte-listitems customOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("list-style", "lower-greek", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "orderInsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tooltip", "Custom Orderlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Lower-Greek", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("css", "e-rte-toolbar-icon e-rte-unlistitems customUnOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("list-image", "url(\'../images/rte/smiley-gif.gif\')", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "unOrderInsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Smiley", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tooltip", "Custom UnOrderList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rteSample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min-width", "20px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RTEproperties __Syncfusion_JavaScript_Models_RTEproperties;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        private global::Syncfusion.JavaScript.Models.RTEtools __Syncfusion_JavaScript_Models_RTEtools;
        private global::Syncfusion.JavaScript.Models.RTETagHelperLists __Syncfusion_JavaScript_Models_RTETagHelperLists;
        private global::Syncfusion.JavaScript.Models.CustomOrderedList __Syncfusion_JavaScript_Models_CustomOrderedList;
        private global::Syncfusion.JavaScript.Models.CustomUnorderedList __Syncfusion_JavaScript_Models_CustomUnorderedList;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(32, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 45, "\"", 109, 1);
#line 2 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
WriteAttributeValue("", 51, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 51, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(110, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(148, 58, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">RTE / Inline Toolbar</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(234, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
      List<String> toolsList = new List<string>() { "formatStyle", "font", "style", "effects", "alignment", "lists", "indenting", "clipboard", "doAction", "clear", "links", "images", "media", "tables", "casing", "customTool", "view", "edit", "print" };
        List<String> font = new List<string>() { "fontName", "fontSize", "fontColor", "backgroundColor" };
        List<String> style = new List<string>() { "bold", "italic", "underline", "strikethrough" };
        List<String> alignment = new List<string>() { "justifyLeft", "justifyCenter", "justifyRight", "justifyFull" };
        List<String> edit = new List<String>() { "findAndReplace" };
        List<String> lists = new List<string>() { "unorderedList", "orderedList" };
        List<String> indenting = new List<string> { "outdent", "indent" };
        List<String> clipboard = new List<string>() { "cut", "copy", "paste" };
        List<String> doAction = new List<string>() { "undo", "redo" };
        List<String> clear = new List<string>() { "clearFormat", "clearAll" };
        List<String> tables = new List<string>() { "createTable", "addRowAbove", "addRowBelow", "addColumnLeft", "addColumnRight", "deleteRow", "deleteColumn", "deleteTable" };
        List<String> links = new List<string>() { "createLink", "removeLink" };
        List<String> images = new List<string>() { "image" };
        List<String> media = new List<string>() { "video" };
        List<String> effects = new List<string>() { "superscript", "subscript" };
        List<String> casing = new List<string>() { "upperCase", "lowerCase" };
        List<String> formatStyle = new List<string>() { "format" };
        List<String> view = new List<string>() { "fullScreen", "zoomIn", "zoomOut" };
        List<String> print = new List<string>() { "print" };
    

#line default
#line hidden
                BeginContext(2055, 3, true);
                WriteLiteral("   ");
                EndContext();
                BeginContext(2058, 2411, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rte", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a3546e3a87b467b80a8b36f4a97c9a1", async() => {
                    BeginContext(2229, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(2235, 1374, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80a77371821944d290c71fe77da3247b", async() => {
                        BeginContext(2255, 1333, true);
                        WriteLiteral(@"
        <div>
            &lt;p&gt;&lt;b&gt;Description:&lt;/b&gt;&lt;/p&gt;
            &lt;p&gt;The Rich Text Editor (RTE) control is an easy to render in
            client side. Customer easy to edit the contents and get the HTML content for
            the displayed content. A rich text editor control provides users with a toolbar
            that helps them to apply rich text formats to the text entered in the text
            area. &lt;/p&gt;
            &lt;p&gt;&lt;b&gt;Functional
            Specifications/Requirements:&lt;/b&gt;&lt;/p&gt;
            &lt;ol&gt;&lt;li&gt;&lt;p&gt;Provide
            the tool bar support, it’s also customizable.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Options
            to get the HTML elements with styles.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Support
            to insert image from a defined path.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Footer
            elements and styles(tag / Element information , Action button (Upload, Cancel))&lt;/p&gt;&lt;/l");
                        WriteLiteral(@"i&gt;&lt;li&gt;&lt;p&gt;Re-size
            the editor support. &lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Provide
            efficient public methods and client side events.&lt;/p&gt;&lt;/li&gt;&lt;li&gt;&lt;p&gt;Keyboard
            navigation support.&lt;/p&gt;&lt;/li&gt;&lt;/ol&gt;
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
                    BeginContext(3609, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(3615, 841, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tools", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd78fccbd4554cdf8b6b7080c1a1ac52", async() => {
                        BeginContext(3903, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(3913, 243, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-custom-ordered-lists", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d5512b2c704a3a81458a97db03042a", async() => {
                            BeginContext(3937, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(3951, 168, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-custom-ordered-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adb3c60775cd481fac4f2b55808bf88e", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_CustomOrderedList = CreateTagHelper<global::Syncfusion.JavaScript.Models.CustomOrderedList>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_CustomOrderedList);
                            __Syncfusion_JavaScript_Models_CustomOrderedList.Css = (string)__tagHelperAttribute_0.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                            __Syncfusion_JavaScript_Models_CustomOrderedList.ListStyle = (string)__tagHelperAttribute_1.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                            __Syncfusion_JavaScript_Models_CustomOrderedList.Name = (string)__tagHelperAttribute_2.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                            __Syncfusion_JavaScript_Models_CustomOrderedList.Tooltip = (string)__tagHelperAttribute_3.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                            __Syncfusion_JavaScript_Models_CustomOrderedList.Text = (string)__tagHelperAttribute_4.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(4119, 12, true);
                            WriteLiteral("\r\n\r\n        ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RTETagHelperLists = CreateTagHelper<global::Syncfusion.JavaScript.Models.RTETagHelperLists>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RTETagHelperLists);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(4156, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(4166, 274, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-custom-unordered-lists", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c523a94d1bdf46c48a839b37877a484d", async() => {
                            BeginContext(4192, 14, true);
                            WriteLiteral("\r\n            ");
                            EndContext();
                            BeginContext(4206, 197, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-custom-unordered-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7e9f03b0eb84fb2b45211302a55a954", async() => {
                            }
                            );
                            __Syncfusion_JavaScript_Models_CustomUnorderedList = CreateTagHelper<global::Syncfusion.JavaScript.Models.CustomUnorderedList>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_CustomUnorderedList);
                            __Syncfusion_JavaScript_Models_CustomUnorderedList.Css = (string)__tagHelperAttribute_5.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                            __Syncfusion_JavaScript_Models_CustomUnorderedList.ListImage = (string)__tagHelperAttribute_6.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                            __Syncfusion_JavaScript_Models_CustomUnorderedList.Name = (string)__tagHelperAttribute_7.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                            __Syncfusion_JavaScript_Models_CustomUnorderedList.Text = (string)__tagHelperAttribute_8.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                            __Syncfusion_JavaScript_Models_CustomUnorderedList.Tooltip = (string)__tagHelperAttribute_9.Value;
                            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(4403, 10, true);
                            WriteLiteral("\r\n        ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RTETagHelperLists = CreateTagHelper<global::Syncfusion.JavaScript.Models.RTETagHelperLists>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RTETagHelperLists);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(4440, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_RTEtools = CreateTagHelper<global::Syncfusion.JavaScript.Models.RTEtools>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RTEtools);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Clear = clear;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("clear", __Syncfusion_JavaScript_Models_RTEtools.Clear, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.FormatStyle = formatStyle;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("format-style", __Syncfusion_JavaScript_Models_RTEtools.FormatStyle, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Edit = edit;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("edit", __Syncfusion_JavaScript_Models_RTEtools.Edit, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Tables = tables;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("tables", __Syncfusion_JavaScript_Models_RTEtools.Tables, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Links = links;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("links", __Syncfusion_JavaScript_Models_RTEtools.Links, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Images = images;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("images", __Syncfusion_JavaScript_Models_RTEtools.Images, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Effects = effects;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("effects", __Syncfusion_JavaScript_Models_RTEtools.Effects, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Casing = casing;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("casing", __Syncfusion_JavaScript_Models_RTEtools.Casing, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Font = font;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("font", __Syncfusion_JavaScript_Models_RTEtools.Font, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Styles = style;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("styles", __Syncfusion_JavaScript_Models_RTEtools.Styles, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Media = media;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("media", __Syncfusion_JavaScript_Models_RTEtools.Media, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Alignment = alignment;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("alignment", __Syncfusion_JavaScript_Models_RTEtools.Alignment, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Lists = lists;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("lists", __Syncfusion_JavaScript_Models_RTEtools.Lists, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.DoAction = doAction;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("do-action", __Syncfusion_JavaScript_Models_RTEtools.DoAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Indenting = indenting;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("indenting", __Syncfusion_JavaScript_Models_RTEtools.Indenting, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.View = view;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("view", __Syncfusion_JavaScript_Models_RTEtools.View, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 48 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEtools.Print = print;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("print", __Syncfusion_JavaScript_Models_RTEtools.Print, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4456, 4, true);
                    WriteLiteral("\r\n\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_RTEproperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RTEproperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RTEproperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#line 27 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEproperties.ToolsList = toolsList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("tools-list", __Syncfusion_JavaScript_Models_RTEproperties.ToolsList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEproperties.ShowHtmlSource = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-html-source", __Syncfusion_JavaScript_Models_RTEproperties.ShowHtmlSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_RTEproperties.Width = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 27 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEproperties.ShowFooter = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-footer", __Syncfusion_JavaScript_Models_RTEproperties.ShowFooter, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEproperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_RTEproperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_RTEproperties.MinWidth = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
#line 27 "D:\Samples_19.1.0.63\ASPNETCORE\samplebrowser\Views\RTE\InlineToolbar.cshtml"
__Syncfusion_JavaScript_Models_RTEproperties.ToolbarOverflowMode = global::Syncfusion.JavaScript.ToolbarOverflowMode.Inline;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("toolbar-overflow-mode", __Syncfusion_JavaScript_Models_RTEproperties.ToolbarOverflowMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4469, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(4498, 529, true);
                WriteLiteral(@"
    <style type=""text/css"" class=""cssStyles"">
        .customUnOrder, .customOrder {
            height: 25px;
        }

            .customUnOrder:after {
                content: ""\e7f1"";
                font-size: 20px;
                float: left;
                padding: 0px 4px 0px 4px;
            }

            .customOrder:after {
                content: ""\e7f0"";
                font-size: 20px;
                float: left;
                padding: 0px 4px 0px 4px;
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
