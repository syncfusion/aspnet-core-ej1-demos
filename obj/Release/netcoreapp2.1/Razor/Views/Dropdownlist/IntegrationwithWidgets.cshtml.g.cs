#pragma checksum "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Dropdownlist\IntegrationwithWidgets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62fcbd9937d2882cf804d36f69c3b14ca68a87a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dropdownlist_IntegrationwithWidgets), @"mvc.1.0.view", @"/Views/Dropdownlist/IntegrationwithWidgets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dropdownlist/IntegrationwithWidgets.cshtml", typeof(AspNetCore.Views_Dropdownlist_IntegrationwithWidgets))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62fcbd9937d2882cf804d36f69c3b14ca68a87a", @"/Views/Dropdownlist/IntegrationwithWidgets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Dropdownlist_IntegrationwithWidgets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DropDownList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "carsList1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("popup-height", "280px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("watermark-text", "Select an item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "dropdownOnCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("parent-id", "pid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "name", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("has-child", "hasChild", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("expanded", "expanded", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sprite-css-class", "spriteCss", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("treeView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("node-check", "onNodeCheck", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "treeViewOnCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("node-uncheck", "onNodeUnCheck", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("node-expand", "checkScroll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("node-collapse", "checkScroll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TreeViewProperties __Syncfusion_JavaScript_Models_TreeViewProperties;
        private global::Syncfusion.JavaScript.Models.TreeViewFields __Syncfusion_JavaScript_Models_TreeViewFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 75, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Dropdownlist / IntegrationwithWidgets</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(126, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(196, 171, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e507b27e7791414085d69b6b7bb19456", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Width = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_DropDownListProperties.PopupHeight = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_DropDownListProperties.WatermarkText = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Create = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(367, 92, true);
                WriteLiteral("\r\n           \r\n            <div id=\"carsList1\">\r\n                <ul> \r\n                    ");
                EndContext();
                BeginContext(459, 452, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-view", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "519a0ff0b2ea4cc7980748b0b1542fdb", async() => {
                    BeginContext(642, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(668, 206, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tree-view-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f339a8fb8a7424295709656e380ce33", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_TreeViewFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeViewFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeViewFields);
#line 11 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Dropdownlist\IntegrationwithWidgets.cshtml"
__Syncfusion_JavaScript_Models_TreeViewFields.DataSource = (IEnumerable<TreeDropDown>)ViewBag.datasource;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_TreeViewFields.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_Models_TreeViewFields.Id = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __Syncfusion_JavaScript_Models_TreeViewFields.ParentId = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __Syncfusion_JavaScript_Models_TreeViewFields.Text = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    __Syncfusion_JavaScript_Models_TreeViewFields.HasChild = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                    __Syncfusion_JavaScript_Models_TreeViewFields.Expanded = (string)__tagHelperAttribute_10.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                    __Syncfusion_JavaScript_Models_TreeViewFields.SpriteCssClass = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(874, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_TreeViewProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TreeViewProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TreeViewProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
#line 10 "D:\Samples_20.2.0.43\ASPNETCORE\samplebrowser\Views\Dropdownlist\IntegrationwithWidgets.cshtml"
__Syncfusion_JavaScript_Models_TreeViewProperties.ShowCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-checkbox", __Syncfusion_JavaScript_Models_TreeViewProperties.ShowCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_TreeViewProperties.NodeCheck = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_TreeViewProperties.Create = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __Syncfusion_JavaScript_Models_TreeViewProperties.NodeUncheck = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                __Syncfusion_JavaScript_Models_TreeViewProperties.NodeExpand = (string)__tagHelperAttribute_16.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
                __Syncfusion_JavaScript_Models_TreeViewProperties.NodeCollapse = (string)__tagHelperAttribute_17.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(911, 85, true);
                WriteLiteral("\r\n                            </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(1021, 195, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        .e-ddl-popup div > ul li .e-chkbox-wrap {\r\n            padding-right: 2px;\r\n        }\r\n\r\n        .frame {\r\n            width:40%;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1242, 4321, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        // prevents the default behaviour to perform custom action

   
        ej.DropDownList.prototype._OnMouseClick = function (e) { }
        ej.DropDownList.prototype._OnMouseEnter = function (e) { }
        ej.DropDownList.prototype._OnMouseLeave = function (e) { }
        ej.DropDownList.prototype._OnKeyUp = function (e) { }
        ej.DropDownList.prototype._OnKeyDown = function (e) { }

        function dropdownOnCreate(args) {
            drpdwnobj = this;
        }
        function treeViewOnCreate(args) {
            treeobj = this;
        }
        // check & uncheck the checkbox when click on text
        $(function () {
            $(""body"").on(""click"", "".e-treeview ul li a.e-text"", function (e) {
                if (!$(e.target).siblings("".e-chkbox-wrap"").children(""input.nodecheckbox"")[0].checked)
                    treeobj.checkNode($(e.target).closest(""li""));
                else
                    treeobj.uncheckNode($(e.target");
                WriteLiteral(@").closest(""li""));
            });
        });

        //Function triggers while check the checkbox in tree view and it adds the checked item text to dropdownlist value
        function checkScroll(args) {
            var scrolpos = drpdwnobj.scrollerObj.model.scrollTop;
            drpdwnobj._refreshScroller();
            drpdwnobj.popupList.css(""display"", ""block"");
            drpdwnobj.scrollerObj.setModel({ ""scrollTop"": scrolpos });
        }

        function onNodeCheck(args) {
            if (args.currentCheckedNodes != null) {
                var checkeditems = args.currentCheckedNodes;
                for (var i = 0; i < checkeditems.length; i++) {
                    if ((checkeditems[i] != null) && !isContains(checkeditems[i].text))
                        addOrRemoveItem(checkeditems[i].text, true);
                }
            }
        }
        //Function triggers while uncheck the checkbox in tree view and it removes the unchecked item text from dropdownlist value
     ");
                WriteLiteral(@"   function onNodeUnCheck(args) {
            if (args.currentUncheckedNodes != null) {
                var uncheckeditems = args.currentUncheckedNodes;
                for (var i = 0; i < uncheckeditems.length; i++) {
                    if (uncheckeditems[i] != null && isContains(uncheckeditems[i].text))
                        addOrRemoveItem(uncheckeditems[i].text);
                }
            }
            ensureRootCheck(args);
        }

        function ensureRootCheck(args) {
            var rootEle = $(args.currentElement).parents(""ul.e-treeview-ul"");
            for (var i = 0; i < rootEle.length; i++) {
                if ($(rootEle[i]).parent(""li"").length) {
                    if (isContains($(rootEle[i]).siblings(""[role=presentation]"").text()))
                        addOrRemoveItem($(rootEle[i]).siblings(""[role=presentation]"").text());
                }
            }
        }

        function addOrRemoveItem(currentValue, isAdd) {
            drpdwnobj._hiddenValue =");
                WriteLiteral(@" currentValue;
            isAdd ? drpdwnobj._addText(currentValue) : removeText(currentValue);
            drpdwnobj.model.value = drpdwnobj.model.text = drpdwnobj.element.val();
        }
        function removeText(currentValue) {
            var eleVal = drpdwnobj.element[0].value.split(drpdwnobj.model.delimiterChar), hidVal = drpdwnobj._visibleInput[0].value.split(drpdwnobj.model.delimiterChar),
                index = $.inArray(currentValue, eleVal);
            if (index >= 0) {
                eleVal.splice(index, 1);
                hidVal.splice(index, 1);
                drpdwnobj._valueContainer.splice(index, 1);
                drpdwnobj._textContainer.splice(index, 1);
            }
            drpdwnobj.element[0].value = eleVal.join(drpdwnobj.model.delimiterChar);
            drpdwnobj._visibleInput[0].value = hidVal.join(drpdwnobj.model.delimiterChar);
        }
        function isContains(val) {
            var data = drpdwnobj.getValue().split("",""), matched;
            fo");
                WriteLiteral("r (k = 0; k < data.length; k++) {\r\n                if (data[k] == val) {\r\n                    matched = 1;\r\n                    break;\r\n                }\r\n            }\r\n            return matched;\r\n        }\r\n    </script>\r\n");
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
