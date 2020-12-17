#pragma checksum "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44539f3e0439afc0f452ea06482bf172d1d0fb65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NavigationDrawer_Default), @"mvc.1.0.view", @"/Views/NavigationDrawer/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NavigationDrawer/Default.cshtml", typeof(AspNetCore.Views_NavigationDrawer_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44539f3e0439afc0f452ea06482bf172d1d0fb65", @"/Views/NavigationDrawer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_NavigationDrawer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("mouse-up", "headChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("navpane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "butdrawer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("content-id", "content_container", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.NavigationDrawerProperties __Syncfusion_JavaScript_Models_NavigationDrawerProperties;
        private global::Syncfusion.JavaScript.Models.ListViewBase __Syncfusion_JavaScript_Models_ListViewBase;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 81, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Navigation Drawer / Default Functionalities</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(125, 194, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to display a sliding panel and list of navigation options using the Syncfusion ASP.NET Core Navigation Drawer component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(347, 8417, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""cols-sample-area"" style=""padding: 0px; position: relative; margin: 0px; min-height: 451px;"">
            <div>
                <div>
                    <div id=""container"">
                        <div class=""e-lv"">
                            <div class=""e-header"">
                                <div id=""butdrawer"" class=""drawericon e-icon""></div>
                                <h2>Home</h2>
                            </div>
                        </div>
                    <div id=""content_container""></div>
                        <div id=""home"" class=""subpage"">
                            <p>
                                The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom (UK) and Britain, is a sovereign state located off the north-western coast of continental Europe. The country includes the island of Great Britain, the north-eastern part of the island of Ireland and many smaller islands. Northern ");
                WriteLiteral(@"Ireland is the only part of the UK that shares a land border with another state—the Republic of Ireland. Apart from this land border, the UK is surrounded by the Atlantic Ocean in the west and north, the North Sea in the east, the English Channel in the south and the Irish Sea in the west.
                            </p>
                        </div>
                        <div id=""people"" class=""subpage"">
                            <table cellpadding=""5px"">
                                <tbody>
                                    <tr>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/1.png')"" class=""peopleimage""></div>
                                            <span>Agatha Jessie</span>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/2.png')"" class=""peoplei");
                WriteLiteral(@"mage""></div>
                                            <span>Andrew Philip</span>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/3.png')"" class=""peopleimage""></div>
                                            <span>Lilly Thomas</span>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/4.png')"" class=""peopleimage""></div>
                                            <span>Jaden Storm</span>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/5.png')"" class=""peopleimage""></div>
                                            <span>Angel Christie</span>
                                     ");
                WriteLiteral(@"   </td>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/6.png')"" class=""peopleimage""></div>
                                            <span>Joe Michael</span>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/7.png')"" class=""peopleimage""></div>
                                            <span>Marie Luke</span>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/8.png')"" class=""peopleimage""></div>
                                            <span>Magen Mia</span>
                                        </td>

                                    </tr>
                                </tbody>
                            </tab");
                WriteLiteral(@"le>
                        </div>
                        <div id=""profile"" class=""subpage"">
                            <table>
                                <tbody>
                                    <tr>
                                        <td>
                                            <div style=""background-image: url('../Images/Employees/2.png')"" class=""profileimage""></div>
                                        </td>
                                        <td>
                                            <h2>Andrew Philip</h2>                                            
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                            <br />
                            <span style=""font-weight: bold"">Profile</span><br>
                            <p>
                                Born on December 25, 1954, in Spokane, Washington. Philip graduated ");
                WriteLiteral(@"from Texas University in 1978. He started his career as a teacher.
                                Later he started business with his friend Paul. They both spent more time together working on business. They earned enough money and spent that for poor and social welfares. Later they together started an organization for children welfare.
                            </p>
                        </div>
                        <div id=""photos"" class=""subpage"">
                            <table>
                                <tbody>
                                    <tr>
                                        <td>
                                            <div style=""background-image: url('../Images/navigationdrawer/photo/01.png')"" class=""photoimage""></div>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/navigationdrawer/photo/02.png')"" class=""photoimage""></div>
 ");
                WriteLiteral(@"                                       </td>
                                        <td>
                                            <div style=""background-image: url('../Images/navigationdrawer/photo/03.png')"" class=""photoimage""></div>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/navigationdrawer/photo/04.png')"" class=""photoimage""></div>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/navigationdrawer/photo/05.png')"" class=""photoimage""></div>
                                        </td>
                                        <td>
                                            <div style=""background-image: url('../Images/navigationdrawer/photo/06.png')"" class=""photoimage""></div>
                                        </td>
          ");
                WriteLiteral(@"                          </tr>
                                </tbody>
                            </table>
                        </div>
                        <div id=""communities"" class=""subpage"">
                            <h2>Product Breadth</h2>
                            <p>UI, reporting and business intelligence on any .NET platform, all from one vendor.</p>
                            <h2>No-Hassle Licensing</h2>
                            <p>No royalties, run-time, or server-deployment fees means no surprises.</p>
                            <h2>Uncompromising Quality</h2>
                            <p>An almost brutal QA process makes our products truly enterprise-quality.</p>
                            <h2>Outstanding Support</h2>
                            <p>Our team is in-house, accessible, and fast. The online forum, knowledge base, and Direct-Trac support system provide 24/7 access.</p>
                        </div>
                        <div id=""location"" class=""su");
                WriteLiteral("bpage\">\r\n                            <div style=\"background-image: url(\'../Images/navigationdrawer/location.png\')\" class=\"locationimage\"></div>\r\n                        </div>\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(8764, 1759, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-navigation-drawer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3285cbad328e4d0bb235b50840a46c33", async() => {
                    BeginContext(8957, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(8983, 127, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-list-view-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d717db3ff87148d6a30189e5c66151d5", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ListViewBase = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListViewBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListViewBase);
#line 126 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml"
__Syncfusion_JavaScript_Models_ListViewBase.Width = 300;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_ListViewBase.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 126 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml"
__Syncfusion_JavaScript_Models_ListViewBase.SelectedItemIndex = 0;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("selected-item-index", __Syncfusion_JavaScript_Models_ListViewBase.SelectedItemIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 126 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml"
__Syncfusion_JavaScript_Models_ListViewBase.ShowHeader = false;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-header", __Syncfusion_JavaScript_Models_ListViewBase.ShowHeader, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_Models_ListViewBase.MouseUp = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 126 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml"
__Syncfusion_JavaScript_Models_ListViewBase.PersistSelection = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("persist-selection", __Syncfusion_JavaScript_Models_ListViewBase.PersistSelection, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(9110, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(9136, 1342, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90871cc1c7994f8ab03b266c8a3cb8ec", async() => {
                        BeginContext(9156, 1301, true);
                        WriteLiteral(@"
                            <ul>
                                <li data-ej-imageurl=""../Images/navigationdrawer/home.png"" data-ej-text=""Home"" data-ej-href=""#home""
                                    id=""navhome""></li>
                                <li data-ej-imageurl=""../Images/navigationdrawer/people.png"" data-ej-text=""People"" data-ej-href=""#people""
                                    id=""navpeople""></li>
                                <li data-ej-imageurl=""../Images/navigationdrawer/profile.png"" data-ej-text=""Profile"" data-ej-href=""#profile""
                                    id=""navprofile""></li>
                                <li data-ej-imageurl=""../Images/navigationdrawer/photo.png"" data-ej-text=""Photos"" data-ej-href=""#photos""
                                    id=""navphotos""></li>
                                <li data-ej-imageurl=""../Images/navigationdrawer/communities.png"" data-ej-text=""Communities"" data-ej-href=""#communities""
                                    id=""navcommunit");
                        WriteLiteral(@"ies""></li>
                                <li data-ej-imageurl=""../Images/navigationdrawer/locations.png"" data-ej-text=""Location"" data-ej-href=""#location""
                                    id=""navlocation""></li>
                            </ul>
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
                    BeginContext(10478, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_NavigationDrawerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.NavigationDrawerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_NavigationDrawerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 125 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml"
__Syncfusion_JavaScript_Models_NavigationDrawerProperties.Direction = NavigationDrawerDirection.Left;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("direction", __Syncfusion_JavaScript_Models_NavigationDrawerProperties.Direction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 125 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml"
__Syncfusion_JavaScript_Models_NavigationDrawerProperties.Type = NavigationDrawerType.Overlay;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Syncfusion_JavaScript_Models_NavigationDrawerProperties.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 125 "D:\Samples_18.4.0.30\ASPNETCORE\samplebrowser\Views\NavigationDrawer\Default.cshtml"
__Syncfusion_JavaScript_Models_NavigationDrawerProperties.EnableListView = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("enable-list-view", __Syncfusion_JavaScript_Models_NavigationDrawerProperties.EnableListView, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_NavigationDrawerProperties.TargetId = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_NavigationDrawerProperties.ContentId = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10523, 94, true);
                WriteLiteral("                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(10643, 166, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function headChange(e) {\r\n            $(\"#butdrawer\").parent().children(\"h2\").text(e.text);\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(10834, 2914, true);
                WriteLiteral(@"
    <style>
        #navpane
        {
            z-index: 99998 !important;
        }
        #navpane_Overlay
        {
            z-index: 99997 !important;
        }
        #navpane_listbox img.e-list-img {
            padding-right: 10px;
        }

        body {
            margin: 0;
            padding: 0;
        }

        .e-header {
            padding-top: 8px;
        }

        #container p {
            padding: 10px;
            text-align: justify;
        }

        #container {
            -moz-user-select: none;
            -webkit-user-select: none;
            -ms-user-select: none;
            user-select: none;
            position: relative;
            overflow: hidden;
            min-height: 451px;
        }

        .peopleimage {
            background: none no-repeat scroll center center / 70px 70px rgba(0, 0, 0, 0);
            height: 100px;
            margin: auto;
            width: 100px;
            border: 1px solid #73737");
                WriteLiteral(@"3;
			background-size: contain;
  		    background-repeat: no-repeat;
        }

        .profileimage {
            background: none no-repeat scroll center center / 90px 90px rgba(0, 0, 0, 0);
            height: 95px;
            border: 1px solid #b3b3b3;
            margin-right: 12px;
            width: 95px;
			background-size: contain;
  		    background-repeat: no-repeat;
        }

        .photoimage {
            background: none no-repeat scroll center center / 140px 120px rgba(0, 0, 0, 0);
            height: 125px;
            margin: auto;
            width: 145px;
			background-size: contain;
  		    background-repeat: no-repeat;
        }

        .locationimage {
            background: url(""img/location.png"") no-repeat scroll center center / 300px 200px rgba(0, 0, 0, 0);
            height: 230px;
            margin: auto;
            padding: 10px;
            width: 320px;
			background-size: contain;
  		    background-repeat: no-repeat;
        }

    ");
                WriteLiteral(@"    .drawericon {
            background-position: center center;
            background-repeat: no-repeat;
            height: 32px;
            width: 32px;
            background-size: 100% 100%;
            padding-right: 10px;
        }

         #people td {
            border: 1px solid #9f9f9f;
            text-align: center;
			padding: 8px;
        }
		#photos td div {
			background-position: center center;
			background-size: 100% 100%;
			border: 1px solid #b3b3b3;
			margin-left: 7.6px;
		}
         .subpage {
            padding: 10px;
            text-align: justify;
            overflow:auto;
        }
        #navpane .subpage {
            padding:0px;
        }

        .drawericon:before {
            content: ""\e76b"";
            font-size: 28px;
            height: 26px;
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
