#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de92b4b3623dfb064ffed2e3519f9e65770d0e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionVision_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionVision/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de92b4b3623dfb064ffed2e3519f9e65770d0e38", @"/Areas/Admin/Views/ActionVision/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionVision_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateVisionViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
  
    ViewData["Title"] = "Update New Vision";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        CKEDITOR.replace(\'Description\');\r\n        CKEDITOR.instances.Description.setData(`");
#nullable restore
#line 9 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
                                           Write(Html.Raw(Model.Vision.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("`);\r\n    </script>\r\n    <script src=\"/PageJs/updateVision.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Update New Vision</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <input hidden name=""ID""");
            BeginWriteAttribute("value", " value=\"", 782, "\"", 806, 1);
#nullable restore
#line 21 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
WriteAttributeValue("", 790, Model.Vision.ID, 790, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Picture</label>
                                <input type=""file"" class=""form-control"" name=""ImageUrl"" accept=""image/*"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Title</label>
                                <input required");
            BeginWriteAttribute("value", " value=\"", 1282, "\"", 1309, 1);
#nullable restore
#line 28 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
WriteAttributeValue("", 1290, Model.Vision.Title, 1290, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Title"" type=""text"">
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Short Description</label>
                                <textarea class=""form-control"" name=""ShortDescription"">");
#nullable restore
#line 32 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
                                                                                  Write(Model.Vision.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Description</label>
                                <textarea id=""Description"" class=""form-control ckeditor"" name=""Description"" required></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
");
#nullable restore
#line 41 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
                                     if (Model.Vision.IsActive == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected value=\"1\">Aktif</option>\r\n                                        <option value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 45 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option value=\"1\">Aktif</option>\r\n                                        <option selected value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 50 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionVision\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-primary d-inline-block""><i class=""fa fa-edit""></i> Update New Vision</button>
                                <a href=""/admin/vizyon-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateVisionViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
