#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61147ba09c8c7dd09ccda60cfac0098363aef6de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionBookComment_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionBookComment/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61147ba09c8c7dd09ccda60cfac0098363aef6de", @"/Areas/Admin/Views/ActionBookComment/Edit.cshtml")]
    public class Areas_Admin_Views_ActionBookComment_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateBookCommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
  
    ViewData["Title"] = "Update New Customer Comment";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n  <script src=\"/PageJs/updateBookComment.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Update New Customer Comment</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <input hidden name=""ID""");
            BeginWriteAttribute("value", " value=\"", 651, "\"", 680, 1);
#nullable restore
#line 17 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
WriteAttributeValue("", 659, Model.BookComment.ID, 659, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Picture</label>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 863, "\"", 915, 2);
            WriteAttributeValue("", 869, "/Image/BookComment/", 869, 19, true);
#nullable restore
#line 20 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
WriteAttributeValue("", 888, Model.BookComment.ImageUrl, 888, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" />\r\n                            </div>\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Name Surname</label>\r\n                                <input readonly");
            BeginWriteAttribute("value", " value=\"", 1161, "\"", 1199, 1);
#nullable restore
#line 24 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
WriteAttributeValue("", 1169, Model.BookComment.NameSurname, 1169, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Title"" type=""text"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone</label>
                                <input readonly");
            BeginWriteAttribute("value", " value=\"", 1471, "\"", 1503, 1);
#nullable restore
#line 28 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
WriteAttributeValue("", 1479, Model.BookComment.Phone, 1479, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Phone"" type=""text"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email</label>
                                <input readonly");
            BeginWriteAttribute("value", " value=\"", 1775, "\"", 1807, 1);
#nullable restore
#line 32 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
WriteAttributeValue("", 1783, Model.BookComment.Email, 1783, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Email"" type=""text"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Short Description</label>
                                <textarea class=""form-control"" name=""ShortDescription"">");
#nullable restore
#line 36 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
                                                                                  Write(Model.BookComment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
");
#nullable restore
#line 41 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
                                     if (Model.BookComment.IsActive == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected value=\"1\">Aktif</option>\r\n                                        <option value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 45 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option value=\"1\">Aktif</option>\r\n                                        <option selected value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 50 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-primary d-inline-block""><i class=""fa fa-edit""></i> Update New Customer Comment</button>
                                <a href=""/admin/musteri-yorumlari-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateBookCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
