#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e31e28dcde0e0cef2fa3aa2f2afdd5adaba6a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionBookComment_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionBookComment/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e31e28dcde0e0cef2fa3aa2f2afdd5adaba6a31", @"/Areas/Admin/Views/ActionBookComment/Details.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionBookComment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateBookCommentViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
  
    ViewData["Title"] = "Customer Comment Details";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Customer Comment Details</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture</label>
                                <img");
            BeginWriteAttribute("src", " src=\"", 693, "\"", 745, 2);
            WriteAttributeValue("", 699, "/Image/BookComment/", 699, 19, true);
#nullable restore
#line 16 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
WriteAttributeValue("", 718, Model.BookComment.ImageUrl, 718, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""50"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Name Surname</label>
                                <hr /><label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 20 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
                                                                             Write(Model.BookComment.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone</label>
                                <hr /><label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 24 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
                                                                             Write(Model.BookComment.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email</label>
                                <hr /><label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 28 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
                                                                             Write(Model.BookComment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Short Description</label>
                                <hr /><label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 32 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
                                                                             Write(Model.BookComment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Status</label><hr />\r\n");
#nullable restore
#line 36 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
                                 if (Model.BookComment.IsActive == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label for=\"simpleinput\" class=\"form-label\">Active</label>\r\n");
#nullable restore
#line 39 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <label for=\"simpleinput\" class=\"form-label\">Passive</label>\n");
#nullable restore
#line 43 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionBookComment\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <div class=""mb-3"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateBookCommentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
