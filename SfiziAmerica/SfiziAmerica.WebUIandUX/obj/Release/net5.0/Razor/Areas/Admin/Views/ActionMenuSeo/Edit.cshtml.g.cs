#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5b184986dfc2143141230f1e75c71a1008b9f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionMenuSeo_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionMenuSeo/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b184986dfc2143141230f1e75c71a1008b9f64", @"/Areas/Admin/Views/ActionMenuSeo/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionMenuSeo_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateMenuSeoViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
  
    ViewData["Title"] = "Update New Menu Seo Manager";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/PageJs/updateMenuSeo.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Update New Menu Seo Manager</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <input hidden name=""ID""");
            BeginWriteAttribute("value", " value=\"", 645, "\"", 670, 1);
#nullable restore
#line 17 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 653, Model.MenuSeo.ID, 653, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Page Name</label>
                                <select required name=""PageName"" class=""form-select"">
                                    <optgroup label=""Please Select Menu Seo"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 1032, "\"", 1063, 1);
#nullable restore
#line 22 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 1040, Model.MenuSeo.PageName, 1040, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
                                                                           Write(Model.MenuSeo.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                                        <option value=""Home"">Home</option>
                                        <option value=""About"">About</option>
                                        <option value=""Mission"">Mission</option>
                                        <option value=""Vision"">Vision</option>
                                        <option value=""Event"">Event</option>
                                        <option value=""Menu Category"">Menu Category</option>
                                        <option value=""Catering"">Catering</option>
                                        <option value=""Rezervation"">Rezervation</option>
                                        <option value=""Human Resources"">Human Resources</option>
                                        <option value=""Application Form"">Application Form</option>
                                        <option value=""Customer Comment"">Customer Comment</option>
                                        <option value");
            WriteLiteral(@"=""Contact"">Contact</option>

                                    </optgroup>

                                </select>
                            </div>
                            
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
");
#nullable restore
#line 44 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
                                     if (Model.MenuSeo.IsActive == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected value=\"1\">Aktif</option>\r\n                                        <option value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 48 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option value=\"1\">Aktif</option>\r\n                                        <option selected value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 53 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 3388, "\"", 3419, 1);
#nullable restore
#line 58 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 3396, Model.MenuSeo.seoTitle, 3396, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 3769, "\"", 3803, 1);
#nullable restore
#line 62 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 3777, Model.MenuSeo.seoKeywords, 3777, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 4162, "\"", 4199, 1);
#nullable restore
#line 66 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 4170, Model.MenuSeo.seoDescription, 4170, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Reply</label>
                                <input type=""email""");
            BeginWriteAttribute("value", " value=\"", 4559, "\"", 4590, 1);
#nullable restore
#line 70 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 4567, Model.MenuSeo.seoReply, 4567, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoReply"" required maxlength=""70"" placeholder=""Please Enter Seo Reply Trial: info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Twitter Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 4953, "\"", 4991, 1);
#nullable restore
#line 74 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 4961, Model.MenuSeo.seoTwitterTitle, 4961, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Twitter Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 5364, "\"", 5405, 1);
#nullable restore
#line 78 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 5372, Model.MenuSeo.seoTwitterKeywords, 5372, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Twitter Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 5787, "\"", 5831, 1);
#nullable restore
#line 82 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 5795, Model.MenuSeo.seoTwitterDescription, 5795, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Twitter Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Url</label>
                                <input type=""url""");
            BeginWriteAttribute("value", " value=\"", 6210, "\"", 6246, 1);
#nullable restore
#line 86 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 6218, Model.MenuSeo.seoTwitterUrl, 6218, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Twitter Url"" />
                            </div>

                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Facebook Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 6602, "\"", 6641, 1);
#nullable restore
#line 91 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 6610, Model.MenuSeo.seoFacebookTitle, 6610, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 7017, "\"", 7059, 1);
#nullable restore
#line 95 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 7025, Model.MenuSeo.seoFacebookKeywrods, 7025, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookKeywrods"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 7444, "\"", 7489, 1);
#nullable restore
#line 99 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 7452, Model.MenuSeo.seoFacebookDescription, 7452, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Facebook Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Url</label>
                                <input type=""url""");
            BeginWriteAttribute("value", " value=\"", 7871, "\"", 7908, 1);
#nullable restore
#line 103 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Edit.cshtml"
WriteAttributeValue("", 7879, Model.MenuSeo.seoFacebookUrl, 7879, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Facebook Url"" />
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-primary d-inline-block""><i class=""fa fa-check""></i> Update New Menu Seo Manager</button>
                                <a href=""/admin/seo-yonetimi-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
                            </div>
                        </form>
                    </div> <!-- end col -->
                </div>
                <!-- end row-->

            </div> <!-- end card-body -->
        </div> <!-- end card -->
    </div><!-- end col -->
</div>
<!-- end row -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateMenuSeoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
