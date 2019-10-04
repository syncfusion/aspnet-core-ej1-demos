#pragma checksum "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c013acfa6353b9142ebfe15818683aa3be562454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rotator_ImgWithContent), @"mvc.1.0.view", @"/Views/Rotator/ImgWithContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rotator/ImgWithContent.cshtml", typeof(AspNetCore.Views_Rotator_ImgWithContent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c013acfa6353b9142ebfe15818683aa3be562454", @"/Views/Rotator/ImgWithContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Rotator_ImgWithContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sliderContent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-height", "300px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RotatorProperties __Syncfusion_JavaScript_Models_RotatorProperties;
        private global::Syncfusion.JavaScript.Models.RotatorBase __Syncfusion_JavaScript_Models_RotatorBase;
        private global::Syncfusion.JavaScript.Models.RotatorBaseItem __Syncfusion_JavaScript_Models_RotatorBaseItem;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 59, true);
                WriteLiteral("<span class=\"sampleName\">Rotator / ImageWithContent</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(103, 174, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to create images with content in rotator slides using the Syncfusion ASP.NET Core Rotator component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(305, 37, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n\r\n        ");
                EndContext();
                BeginContext(342, 4952, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rotator", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "942e77cb2ec94b85b03838b9d53a56b4", async() => {
                    BeginContext(437, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(451, 4820, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7753fd7387a84da9a4308177ab719342", async() => {
                        BeginContext(468, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(486, 962, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "212906a7847a42309be34063f56c7dff", async() => {
                            BeginContext(502, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(524, 889, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32298d855c904a7c9e05bd63fb10d407", async() => {
                                BeginContext(544, 122, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <div class=\"leftPanel\">\r\n                                <img");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 666, "\"", 715, 1);
#line 14 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml"
WriteAttributeValue("", 672, Url.Content("~/Images/rotator/tablet.jpg"), 672, 43, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(716, 676, true);
                                WriteLiteral(@" />
                            </div>
                            <div class=""rightPanel blck"">
                                <div class=""contentPanel"">Tablet </div>
                                <ul>
                                    <li>A tablet computer, or simply tablet, is a mobile computer with display, circuitry and battery in a single unit.</li>
                                    <li>
                                        Tablets are equipped with sensors, including cameras, microphone, accelerometer and touchscreen,
                                </ul>
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
                            BeginContext(1413, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1448, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1466, 993, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1d45db90b194faab5d20c99e1d52566", async() => {
                            BeginContext(1482, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1504, 920, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05461df0f7d54143a4f3784ce6cc61af", async() => {
                                BeginContext(1524, 122, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <div class=\"leftPanel\">\r\n                                <img");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1646, "\"", 1693, 1);
#line 31 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml"
WriteAttributeValue("", 1652, Url.Content("~/Images/rotator/rose.jpg"), 1652, 41, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(1694, 709, true);
                                WriteLiteral(@" />
                            </div>
                            <div class=""rightPanel"">
                                <div class=""contentPanel"">Rose </div>
                                <ul>
                                    <li>A rose is a woody perennial of the genus Rosa, within the family Rosaceae</li>
                                    <li>
                                        Flowers vary in size and shape and are usually large and showy,
                                        There are over 100 species
                                    </li>
                                </ul>
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
                            BeginContext(2424, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2459, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(2477, 928, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3d6d6fbb7842f286c5ea739a1c9032", async() => {
                            BeginContext(2493, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(2515, 855, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11708010177642caaeca0a517e46b74a", async() => {
                                BeginContext(2535, 122, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <div class=\"leftPanel\">\r\n                                <img");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 2657, "\"", 2708, 1);
#line 50 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml"
WriteAttributeValue("", 2663, Url.Content("~/Images/rotator/snowfall.jpg"), 2663, 45, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(2709, 640, true);
                                WriteLiteral(@" />
                            </div>
                            <div class=""rightPanel rightSide"">
                                <div class=""contentPanel"">Snowfall </div>
                                <ul>
                                    <li>Mt. Baker ski area in Washington State has the world record for snowfall at 1,140 inches of snow in the 1998/1999 winter season</li>
                                    <li>Mt. Baker ski area is located near but not on the real 10,781’ Mount Baker</li>
                                </ul>
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
                            BeginContext(3370, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(3405, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(3423, 903, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf997709deb4eccba4761aba942decf", async() => {
                            BeginContext(3439, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(3461, 830, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa357388e719421db44e6d28114d86d6", async() => {
                                BeginContext(3481, 122, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <div class=\"leftPanel\">\r\n                                <img");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 3603, "\"", 3652, 1);
#line 66 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml"
WriteAttributeValue("", 3609, Url.Content("~/Images/rotator/nature.jpg"), 3609, 43, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(3653, 617, true);
                                WriteLiteral(@" />
                            </div>
                            <div class=""rightPanel"">
                                <div class=""contentPanel"">Nature </div>
                                <ul>
                                    <li>The health of the natural environment is critical to the long-term future of the planet</li>
                                    <li>Nature, in the broadest sense, is equivalent to the natural, physical, or material world or universe.</li>

                                </ul>
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
                            BeginContext(4291, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(4326, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(4344, 895, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f43f9381e6c411a8dab1591b651308e", async() => {
                            BeginContext(4360, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(4382, 822, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a59a582b57b444118b21d8884e02d790", async() => {
                                BeginContext(4402, 122, true);
                                WriteLiteral("\r\n                        <div>\r\n                            <div class=\"leftPanel\">\r\n                                <img");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 4524, "\"", 4571, 1);
#line 83 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml"
WriteAttributeValue("", 4530, Url.Content("~/Images/rotator/card.jpg"), 4530, 41, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(4572, 611, true);
                                WriteLiteral(@" />
                            </div>
                            <div class=""rightPanel credit"">
                                <div class=""contentPanel"">Credit card </div>
                                <ul>
                                    <li>A credit card is a payment card issued to users as a system of payment</li>
                                    <li>It allows the cardholder to pay for goods and services based on the holder's promise to pay for them</li>

                                </ul>
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
                            BeginContext(5204, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(5239, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_RotatorBase = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBase);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5271, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_RotatorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 8 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-play-button", __Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideWidth = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideHeight = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5294, 16, true);
                WriteLiteral("\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(5335, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5346, "\"", 5408, 1);
#line 102 "D:\Samples_17.3.0.14\ASPNETCORE\samplebrowser_core_2_0\Views\Rotator\ImgWithContent.cshtml"
WriteAttributeValue("", 5353, Url.Content("~/css/Samples/RotatorImgWithContent.css"), 5353, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5409, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            BeginContext(5434, 2, true);
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
