#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aee95e32b0fb2d03b2c6ecbce2d899e5ef09eaa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionMenu_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionMenu/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee95e32b0fb2d03b2c6ecbce2d899e5ef09eaa5", @"/Areas/Admin/Views/ActionMenu/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionMenu_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateMenuViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
  
    ViewData["Title"] = "Update New Menu";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        CKEDITOR.replace(\'Description\');\r\n        CKEDITOR.instances.Description.setData(`");
#nullable restore
#line 9 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                           Write(Html.Raw(Model.Menu.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("`);\r\n    </script>\r\n    <script src=\"/PageJs/updateMenu.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Update New Menu</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <input hidden name=""ID""");
            BeginWriteAttribute("value", " value=\"", 772, "\"", 794, 1);
#nullable restore
#line 21 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 780, Model.Menu.ID, 780, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Category Menu</label>
                                <select required name=""MenuCategoryID"" multiple class=""form-control"">
                                    <optgroup label=""Please Multi Select Category Menu"">
");
#nullable restore
#line 26 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                         foreach (var item in Model.MenuCategories.OrderBy(x => x.Rank))
                                        {
                                            if (Model.Menu.CategoryMenus.Any(s => s.MenuCategoryID == item.ID))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("value", " value=\"", 1504, "\"", 1520, 1);
#nullable restore
#line 30 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 1512, item.ID, 1512, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 30 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 31 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("value", " value=\"", 1751, "\"", 1767, 1);
#nullable restore
#line 34 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 1759, item.ID, 1759, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 35 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </optgroup>

                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 1</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl1"" accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 2</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl2"" accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 3</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl3"" accept=""image/*"">
                            </div>
                           ");
            WriteLiteral(@" <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 4</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl4"" accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Title</label>
                                <input required");
            BeginWriteAttribute("value", " value=\"", 3353, "\"", 3378, 1);
#nullable restore
#line 59 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 3361, Model.Menu.Title, 3361, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Title"" type=""text"" placeholder=""Please Enter Catering Title"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Short Description</label>
                                <textarea class=""form-control"" name=""ShortDescription"" placeholder=""Please Enter Short Description"">");
#nullable restore
#line 63 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                                                                                                               Write(Model.Menu.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n                            </div>\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Description</label>\r\n                                <textarea id=\"Description\"");
            BeginWriteAttribute("value", " value=\"", 4069, "\"", 4097, 1);
#nullable restore
#line 67 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 4077, Model.Menu.Discount, 4077, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control ckeditor"" name=""Description"" required placeholder=""Please Enter Description""></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Price</label>
                                <input required class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4452, "\"", 4477, 1);
#nullable restore
#line 71 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 4460, Model.Menu.Price, 4460, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Price"" type=""text"" placeholder=""Please Enter Catering Price Trial:35.99"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Discount</label>
                                <input required class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4806, "\"", 4834, 1);
#nullable restore
#line 75 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 4814, Model.Menu.Discount, 4814, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Discount"" type=""text"" placeholder=""Please Enter Catering Discont Trial:18"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
                                    <option value=""1"">Active</option>
                                    <option value=""0"">Passive</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Main Status</label>
                                <select required name=""IsMainActive"" class=""form-select"">
");
#nullable restore
#line 87 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                     if (Model.Menu.IsMainActive == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected value=\"1\">Show on homepage</option>\r\n                                        <option value=\"0\">Remove from home page</option>\r\n");
#nullable restore
#line 91 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option value=\"1\">Show on homepage</option>\r\n                                        <option selected value=\"0\">Remove from home page</option>\r\n");
#nullable restore
#line 96 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 6553, "\"", 6581, 1);
#nullable restore
#line 101 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 6561, Model.Menu.seoTitle, 6561, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 6931, "\"", 6962, 1);
#nullable restore
#line 105 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 6939, Model.Menu.seoKeywords, 6939, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 7321, "\"", 7355, 1);
#nullable restore
#line 109 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 7329, Model.Menu.seoDescription, 7329, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Reply</label>
                                <input type=""email""");
            BeginWriteAttribute("value", " value=\"", 7715, "\"", 7743, 1);
#nullable restore
#line 113 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 7723, Model.Menu.seoReply, 7723, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoReply"" required maxlength=""70"" placeholder=""Please Enter Seo Reply Trial: info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Twitter Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 8106, "\"", 8141, 1);
#nullable restore
#line 117 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 8114, Model.Menu.seoTwitterTitle, 8114, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Twitter Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 8514, "\"", 8552, 1);
#nullable restore
#line 121 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 8522, Model.Menu.seoTwitterKeywords, 8522, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Twitter Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 8934, "\"", 8975, 1);
#nullable restore
#line 125 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 8942, Model.Menu.seoTwitterDescription, 8942, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Twitter Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Url</label>
                                <input type=""url""");
            BeginWriteAttribute("value", " value=\"", 9354, "\"", 9387, 1);
#nullable restore
#line 129 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 9362, Model.Menu.seoTwitterUrl, 9362, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Twitter Url"" />
                            </div>

                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Facebook Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 9743, "\"", 9779, 1);
#nullable restore
#line 134 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 9751, Model.Menu.seoFacebookTitle, 9751, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 10155, "\"", 10194, 1);
#nullable restore
#line 138 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 10163, Model.Menu.seoFacebookKeywrods, 10163, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookKeywrods"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 10579, "\"", 10621, 1);
#nullable restore
#line 142 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 10587, Model.Menu.seoFacebookDescription, 10587, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Facebook Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Url</label>
                                <input type=""url""");
            BeginWriteAttribute("value", " value=\"", 11003, "\"", 11037, 1);
#nullable restore
#line 146 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Edit.cshtml"
WriteAttributeValue("", 11011, Model.Menu.seoFacebookUrl, 11011, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Facebook Url"" />
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-primary d-inline-block""><i class=""fa fa-check""></i> Update New Menu</button>
                                <a href=""/admin/menu-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateMenuViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591