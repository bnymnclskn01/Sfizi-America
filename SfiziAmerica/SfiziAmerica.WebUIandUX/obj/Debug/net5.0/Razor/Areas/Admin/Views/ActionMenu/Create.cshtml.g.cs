#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501957177c80f636dcf9d7c52ff3aea58c1fcd20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionMenu_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionMenu/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501957177c80f636dcf9d7c52ff3aea58c1fcd20", @"/Areas/Admin/Views/ActionMenu/Create.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionMenu_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SfiziAmerica.EntityLayer.Model.MenuCategory>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Create.cshtml"
  
    ViewData["Title"] = "Add New Menu";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/PageJs/addMenu.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Add New Menu</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Category Menu</label>
                                <select required name=""MenuCategoryID"" multiple class=""form-control"">
                                    <optgroup label=""Please Multi Select Category Menu"">
");
#nullable restore
#line 21 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Create.cshtml"
                                         foreach (var item in Model.OrderBy(x => x.Rank))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <option");
            BeginWriteAttribute("value", " value=\"", 1071, "\"", 1087, 1);
#nullable restore
#line 23 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Create.cshtml"
WriteAttributeValue("", 1079, item.ID, 1079, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Create.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 24 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenu\Create.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </optgroup>

                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 1</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl1"" required accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 2</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl2""  accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 3</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl3"" accept=""image/*"">
                            </div>
                 ");
            WriteLiteral(@"           <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 4</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl4"" accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Title</label>
                                <input required class=""form-control"" name=""Title"" type=""text"" placeholder=""Please Enter Catering Title"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Short Description</label>
                                <textarea class=""form-control"" name=""ShortDescription"" placeholder=""Please Enter Short Description""></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" cl");
            WriteLiteral(@"ass=""form-label"">Description</label>
                                <textarea id=""Description"" class=""form-control ckeditor"" name=""Description"" required placeholder=""Please Enter Description""></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Price</label>
                                <input required class=""form-control"" name=""Price"" type=""text"" placeholder=""Please Enter Catering Price Trial:35.99"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Discount</label>
                                <input required class=""form-control"" name=""Discount"" type=""number"" placeholder=""Please Enter Catering Discont Trial:18"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">");
            WriteLiteral(@"Status</label>
                                <select required name=""IsActive"" class=""form-select"">
                                    <option value=""1"">Active</option>
                                    <option value=""0"">Passive</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Title</label>
                                <input type=""text"" class=""form-control"" name=""seoTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Keywords</label>
                                <input type=""text"" class=""form-control"" name=""seoKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Keywords"" />
                            </div>
           ");
            WriteLiteral(@"                 <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Description</label>
                                <input type=""text"" class=""form-control"" name=""seoDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Reply</label>
                                <input type=""email"" class=""form-control"" name=""seoReply"" required maxlength=""70"" placeholder=""Please Enter Seo Reply Trial: info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Twitter Title</label>
                                <input type=""text"" class=""form-control"" name=""seoTwitterTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Tw");
            WriteLiteral(@"itter Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Keywords</label>
                                <input type=""text"" class=""form-control"" name=""seoTwitterKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Twitter Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Description</label>
                                <input type=""text"" class=""form-control"" name=""seoTwitterDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Twitter Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Url</label>
                                <input type=");
            WriteLiteral(@"""url"" class=""form-control"" name=""seoTwitterUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Twitter Url"" />
                            </div>

                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Facebook Title</label>
                                <input type=""text"" class=""form-control"" name=""seoFacebookTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Keywords</label>
                                <input type=""text"" class=""form-control"" name=""seoFacebookKeywrods"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-f");
            WriteLiteral(@"orm-label"">Seo Facebook Description</label>
                                <input type=""text"" class=""form-control"" name=""seoFacebookDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Facebook Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Url</label>
                                <input type=""url"" class=""form-control"" name=""seoFacebookUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Facebook Url"" />
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-success d-inline-block""><i class=""fa fa-check""></i> Add New Menu</button>
                                <a href=""/admin/menu-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
                            </div>
                  ");
            WriteLiteral("      </form>\r\n                    </div> <!-- end col -->\r\n                </div>\r\n                <!-- end row-->\r\n\r\n            </div> <!-- end card-body -->\r\n        </div> <!-- end card -->\r\n    </div><!-- end col -->\r\n</div>\r\n<!-- end row -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SfiziAmerica.EntityLayer.Model.MenuCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
