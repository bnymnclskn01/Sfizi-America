#pragma checksum "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51af6b0a475e6fa8a76f3f84c0045c7c82417036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionApplicationForm_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionApplicationForm/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51af6b0a475e6fa8a76f3f84c0045c7c82417036", @"/Areas/Admin/Views/ActionApplicationForm/Details.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionApplicationForm_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.EntityLayer.Model.ApplicationForm>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
  
    ViewData["Title"] = "Başvuru Form Detayı";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Başvuru Form Detayı</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Adı Soyadı</label><hr />
                                <label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 16 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                                                       Write(Model.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Konu</label><hr />
                                <label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 20 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                                                       Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Telefon</label><hr />
                                <label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 24 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                                                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">E-posta</label><hr />
                                <label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 28 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                                                       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Mesaj</label><hr />
                                <label for=""simpleinput"" class=""form-label"">");
#nullable restore
#line 32 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                                                       Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Statü</label>\r\n");
#nullable restore
#line 36 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                 if (Model.IsActive == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label for=\"simpleinput\" class=\"form-label\">Akif</label>\r\n");
#nullable restore
#line 39 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label for=\"simpleinput\" class=\"form-label\">Pasif</label>\r\n");
#nullable restore
#line 43 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Okunma Durumu</label>\r\n");
#nullable restore
#line 47 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                 if (Model.IsRead == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label for=\"simpleinput\" class=\"form-label\">Okundu</label>\r\n");
#nullable restore
#line 50 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <label for=\"simpleinput\" class=\"form-label\">Okunmadı</label>\r\n");
#nullable restore
#line 54 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionApplicationForm\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <div class=""mb-3"">
                                <a href=""/admin/basvuru-formu-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Listeye Geri Dön</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.EntityLayer.Model.ApplicationForm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
