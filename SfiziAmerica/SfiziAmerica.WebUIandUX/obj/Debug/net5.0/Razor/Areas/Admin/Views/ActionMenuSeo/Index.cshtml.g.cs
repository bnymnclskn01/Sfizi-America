#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c1191d70be2e8dcbdd54882add24d1d76b4e26a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionMenuSeo_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionMenuSeo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1191d70be2e8dcbdd54882add24d1d76b4e26a", @"/Areas/Admin/Views/ActionMenuSeo/Index.cshtml")]
    public class Areas_Admin_Views_ActionMenuSeo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SfiziAmerica.EntityLayer.Model.MenuSeo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
  
    ViewData["Title"] = "Menu Seo Manager List";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/PageJs/menuSeo.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""mt-0 header-title"">Menu Seo Manager List</h4>

                <table id=""datatable-buttons"" class=""table table-striped table-bordered dt-responsive nowrap"">
                    <thead>
                        <tr>
                            <th>Page Name</th>
                            <th>Seo Title</th>
                            <th>Site Subject</th>
                            <th>Status</th>
                            <th></th>
                        </tr>
                    </thead>


                    <tbody>
");
#nullable restore
#line 28 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                               Write(item.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                               Write(item.seoTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                               Write(item.seoSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                                 if (item.IsActive)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Active</td>\r\n");
#nullable restore
#line 37 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Passive</td>\r\n");
#nullable restore
#line 41 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1635, "\"", 1679, 2);
            WriteAttributeValue("", 1642, "/admin/seo-yonetimi-guncelle/", 1642, 29, true);
#nullable restore
#line 43 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
WriteAttributeValue("", 1671, item.ID, 1671, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\"><i class=\'fa fa-edit\'></i></a>\r\n                                    <button data-id=\"");
#nullable restore
#line 44 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                                                Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger btn-sm btnDelete\"><i class=\'fa fa-trash\'></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionMenuSeo\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!-- end row -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SfiziAmerica.EntityLayer.Model.MenuSeo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
