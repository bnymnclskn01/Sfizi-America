#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionSocialMedia\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d707acb3bcb10f98ef1b99e73cd3ffef3bedc363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionSocialMedia_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionSocialMedia/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d707acb3bcb10f98ef1b99e73cd3ffef3bedc363", @"/Areas/Admin/Views/ActionSocialMedia/Create.cshtml")]
    public class Areas_Admin_Views_ActionSocialMedia_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionSocialMedia\Create.cshtml"
  
    ViewData["Title"] = "Add New Social Media";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/PageJs/addSocialMedia.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Add New Social Media</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Title</label>
                                <input type=""text"" class=""form-control"" name=""Title"" maxlength=""75"" required placeholder=""Please Enter Title Trial : Facebook"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Url</label>
                                <input type=""url"" class=""form-control"" name=""Url"" maxlength=""115"" placeholder=""Not a Required Field. Please Enter Url Trial : https://www.facebook.com/sfizi.com"" />
                            </div>
        ");
            WriteLiteral(@"                    <div class=""mb-3"">
                                <label class=""form-label"">Social Media</label>
                                <select data-toggle=""select2"" name=""Icon"" class=""form-select"" placeholder=""Selected Social Media"">
                                    <option value=""fa fa-facebook"">fa fa-facebook</option>
                                    <option value=""fa fa-youtube"">fa fa-youtube</option>
                                    <option value=""fa fa-instagram"">fa fa-instagram</option>
                                    <option value=""fa fa-whatsapp"">fa fa-whatsapp</option>
                                    <option value=""fa fa-linkedin"">fa fa-linkedin</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
      ");
            WriteLiteral(@"                              <option value=""1"">Active</option>
                                    <option value=""0"">Passive</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-success d-inline-block""><i class=""fa fa-check""></i> Add New Social Media</button>
                                <a href=""/admin/sosyal-medya-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
