#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7e988eebc4cedc973b72eec313de489961fe6a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionCateringMenu_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionCateringMenu/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e988eebc4cedc973b72eec313de489961fe6a5", @"/Areas/Admin/Views/ActionCateringMenu/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionCateringMenu_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateCateringMenuViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
  
    ViewData["Title"] = "Update New Catering Menu";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        CKEDITOR.replace(\'Description\');\r\n        CKEDITOR.instances.Description.setData(`");
#nullable restore
#line 9 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                           Write(Html.Raw(Model.CateringMenu.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("`);\r\n    </script>\r\n    <script src=\"/PageJs/updateCateringMenu.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Update New Catering</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <input hidden name=""ID""");
            BeginWriteAttribute("value", " value=\"", 809, "\"", 839, 1);
#nullable restore
#line 21 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 817, Model.CateringMenu.ID, 817, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Parent Catering</label>
                                <select required name=""CateringID"" class=""form-select"">
                                    <optgroup label=""Please Select Catering"">
                                        
");
#nullable restore
#line 27 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                         foreach (var item in Model.Caterings.OrderBy(x => x.Rank))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                             if (Model.CateringMenu.CateringID == item.ID)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("value", " value=\"", 1542, "\"", 1558, 1);
#nullable restore
#line 31 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 1550, item.ID, 1550, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 32 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <option");
            BeginWriteAttribute("value", " value=\"", 1781, "\"", 1797, 1);
#nullable restore
#line 35 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 1789, item.ID, 1789, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 36 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                             
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
                                <input type=""file"" class=""form-control"" name=""ImageUrl2"" accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 3</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl3"" accept=""image/*"">
                            </div>
                  ");
            WriteLiteral(@"          <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture - 4</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl4"" accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Title</label>
                                <input required");
            BeginWriteAttribute("value", " value=\"", 3392, "\"", 3425, 1);
#nullable restore
#line 60 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 3400, Model.CateringMenu.Title, 3400, 25, false);

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
#line 64 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                                                                                                               Write(Model.CateringMenu.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Description</label>
                                <textarea id=""Description"" class=""form-control ckeditor"" name=""Description"" required placeholder=""Please Enter Description""></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
");
#nullable restore
#line 73 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                     if (Model.CateringMenu.IsActive == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected value=\"1\">Aktif</option>\r\n                                        <option value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 77 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option value=\"1\">Aktif</option>\r\n                                        <option selected value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 82 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 5361, "\"", 5397, 1);
#nullable restore
#line 87 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 5369, Model.CateringMenu.seoTitle, 5369, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 5747, "\"", 5786, 1);
#nullable restore
#line 91 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 5755, Model.CateringMenu.seoKeywords, 5755, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 6145, "\"", 6187, 1);
#nullable restore
#line 95 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 6153, Model.CateringMenu.seoDescription, 6153, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Reply</label>
                                <input type=""email""");
            BeginWriteAttribute("value", " value=\"", 6547, "\"", 6583, 1);
#nullable restore
#line 99 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 6555, Model.CateringMenu.seoReply, 6555, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoReply"" required maxlength=""70"" placeholder=""Please Enter Seo Reply Trial: info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Twitter Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 6946, "\"", 6989, 1);
#nullable restore
#line 103 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 6954, Model.CateringMenu.seoTwitterTitle, 6954, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Twitter Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 7362, "\"", 7408, 1);
#nullable restore
#line 107 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 7370, Model.CateringMenu.seoTwitterKeywords, 7370, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterKeywords"" required maxlength=""110"" placeholder=""Please Enter Seo Twitter Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 7790, "\"", 7839, 1);
#nullable restore
#line 111 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 7798, Model.CateringMenu.seoTwitterDescription, 7798, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Twitter Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Twitter Url</label>
                                <input type=""url""");
            BeginWriteAttribute("value", " value=\"", 8218, "\"", 8259, 1);
#nullable restore
#line 115 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 8226, Model.CateringMenu.seoTwitterUrl, 8226, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoTwitterUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Twitter Url"" />
                            </div>

                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Seo Facebook Title</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 8615, "\"", 8659, 1);
#nullable restore
#line 120 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 8623, Model.CateringMenu.seoFacebookTitle, 8623, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookTitle"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Title"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Keywords</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 9035, "\"", 9082, 1);
#nullable restore
#line 124 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 9043, Model.CateringMenu.seoFacebookKeywrods, 9043, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookKeywrods"" required maxlength=""110"" placeholder=""Please Enter Seo Facebook Keywords"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Description</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 9467, "\"", 9517, 1);
#nullable restore
#line 128 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 9475, Model.CateringMenu.seoFacebookDescription, 9475, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookDescription"" required maxlength=""170"" placeholder=""Please Enter Seo Facebook Description"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""col-md-2 col-form-label"">Seo Facebook Url</label>
                                <input type=""url""");
            BeginWriteAttribute("value", " value=\"", 9899, "\"", 9941, 1);
#nullable restore
#line 132 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCateringMenu\Edit.cshtml"
WriteAttributeValue("", 9907, Model.CateringMenu.seoFacebookUrl, 9907, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""seoFacebookUrl"" required maxlength=""100"" placeholder=""Please Enter Seo Facebook Url"" />
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-primary d-inline-block""><i class=""fa fa-check""></i> Update New Catering Menu</button>
                                <a href=""/admin/catering-menu-Listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateCateringMenuViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
