#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\BasvuruForm\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efd16536b117740f6a843f27a41676edaf2187b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BasvuruForm_Index), @"mvc.1.0.view", @"/Views/BasvuruForm/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.WebUIandUX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.WebUIandUX.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.EntityLayer.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.EntityLayer.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.WebUIandUX.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd16536b117740f6a843f27a41676edaf2187b3", @"/Views/BasvuruForm/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00930272c51c841bc21af59ef8f22a72f1282743", @"/Views/_ViewImports.cshtml")]
    public class Views_BasvuruForm_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Models.ViewModel.ApplicationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\BasvuruForm\Index.cshtml"
  
    ViewData["Title"] = "Application - Form";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- content  -->
<div class=""content"">
    <section class="" no-padding dark-bg hidden-section"">
        <div class=""map-container"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d326.43197183807376!2d-77.1801572318595!3d38.88826666290216!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89b7b4c5ae132f8b%3A0x1ff6ab87d1b1b9c!2sSfizi%20Cafe!5e0!3m2!1str!2str!4v1673493615219!5m2!1str!2str"" width=""100%"" height=""500"" style=""border:0; background-color: black;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 667, "\"", 685, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
        </div>
        <!-- map-view-wrap -->
        <div class=""map-view-wrap"">
            <div class=""container"">
                <div class=""map-view-wrap_item"">
                    <div class=""contact-details"">
                        <h4>Contacts Details</h4>
                        <ul>
");
#nullable restore
#line 19 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\BasvuruForm\Index.cshtml"
                             foreach (var item in Model.ContactInformations)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><span><i class=\"fal fa-map-marked-alt\"></i> Adress :</span> ");
#nullable restore
#line 21 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\BasvuruForm\Index.cshtml"
                                                                                               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li><span><i class=\"fal fa-phone-rotary\"></i> Phone :</span> ");
#nullable restore
#line 22 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\BasvuruForm\Index.cshtml"
                                                                                            Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li><span><i class=\"fal fa-mailbox\"></i> Mail :</span> ");
#nullable restore
#line 23 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\BasvuruForm\Index.cshtml"
                                                                                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\BasvuruForm\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <!--map-view-wrap end -->
        <div class=""brush-dec""></div>
    </section>
    <!--  section  -->
    <section class=""hidden-section big-padding con-sec"" data-scrollax-parent=""true"" id=""sec3"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-7"">
                    <div class=""section-title text-align_left"">
                        <h2>Application Form</h2>
                        <div class=""dots-separator fl-wrap""><span></span></div>
                    </div>
                    <div class=""contactform-wrap"">
                        <div id=""message""></div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd16536b117740f6a843f27a41676edaf2187b38635", async() => {
                WriteLiteral(@"
                            <fieldset>
                                <div id=""message2""></div>
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <input type=""text"" name=""NameSurname"" placeholder=""Your Name Surname *"" />
                                    </div>
                                    <div class=""col-sm-6"">
                                        <input type=""email"" name=""Email"" placeholder=""Email Address *""");
                BeginWriteAttribute("value", " value=\"", 2889, "\"", 2897, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    </div>\r\n                                    <div class=\"col-sm-6\">\r\n                                        <input type=\"text\" name=\"Phone\" placeholder=\"Phone *\"");
                BeginWriteAttribute("value", " value=\"", 3100, "\"", 3108, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                    <div class=""col-sm-6"">
                                        <div class="" fl-wrap"">
                                            <input type=""text"" name=""Subject"" placeholder=""Your Subject *"" />
                                        </div>
                                    </div>
                                </div>
                                <textarea name=""Message"" cols=""40"" rows=""3"" placeholder=""Your Message:""></textarea>
                                <div class=""clearfix""></div>
                                <button class=""btn float-btn flat-btn color-bg"" id=""submit_cnt"">Send Message <i class=""fal fa-long-arrow-right""></i></button>
                            </fieldset>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""section-dec sec-dec_top""></div>
                </div>
                <div class=""col-md-5"">
                    <div class=""column-text_inside fl-wrap dark-bg"">
                        <div class=""column-text"">
                            <div class=""section-title"">
                                <h4>Call For Reservations</h4>
                                <h2>Opening Hours</h2>
                                <div class=""dots-separator fl-wrap""><span></span></div>
                            </div>
                            <div class=""work-time fl-wrap"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <h3>Sunday to Tuesday</h3>
                                        <div class=""hours"">
                                            09:00<br>
                                            22:00
                                   ");
            WriteLiteral(@"     </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <h3>Friday to Saturday</h3>
                                        <div class=""hours"">
                                            11:00<br>
                                            19:00
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""illustration_bg"">
                            <div class=""bg"" data-bg=""/Site/images/bg/dec/6.png""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""section-bg"">
            <div class=""bg"" data-bg=""/Site/images/bg/dec/section-bg.png""></div>
        </div>
    </section>
    <!--  section end  -->
    <div class=""brush-dec2 brush-");
            WriteLiteral("dec_bottom\"></div>\r\n</div>\r\n<!-- content end  -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Models.ViewModel.ApplicationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
