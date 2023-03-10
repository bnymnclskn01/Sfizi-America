#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb26ba01ccc9e11a179400f94aeb7d8f17282ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionCustomerSigin_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionCustomerSigin/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb26ba01ccc9e11a179400f94aeb7d8f17282ec1", @"/Areas/Admin/Views/ActionCustomerSigin/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionCustomerSigin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateCustomerSiginViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
  
    ViewData["Title"] = "Update New Customer";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/PageJs/updateCustomerSigin.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Update New User Member</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <input hidden name=""ID""");
            BeginWriteAttribute("value", " value=\"", 644, "\"", 675, 1);
#nullable restore
#line 17 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
WriteAttributeValue("", 652, Model.CustomerSigin.ID, 652, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Name Surname</label>\r\n                                <input type=\"text\" class=\"form-control\" name=\"NameSurname\"");
            BeginWriteAttribute("value", " value=\"", 917, "\"", 957, 1);
#nullable restore
#line 20 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
WriteAttributeValue("", 925, Model.CustomerSigin.NameSurname, 925, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""75"" required placeholder=""Please Enter Name Surname"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email</label>
                                <input type=""email"" class=""form-control"" name=""Email"" maxlength=""75""");
            BeginWriteAttribute("value", " value=\"", 1302, "\"", 1336, 1);
#nullable restore
#line 24 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
WriteAttributeValue("", 1310, Model.CustomerSigin.Email, 1310, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required placeholder=""Please Enter Email"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone</label>
                                <input type=""tel"" class=""form-control"" name=""Phone"" maxlength=""15""");
            BeginWriteAttribute("value", " value=\"", 1657, "\"", 1691, 1);
#nullable restore
#line 28 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
WriteAttributeValue("", 1665, Model.CustomerSigin.Phone, 1665, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required placeholder=""Please Enter Phone"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""password"" class=""form-label"">Password</label>
                                <div class=""input-group input-group-merge"">
                                    <input type=""password"" name=""Password""");
            BeginWriteAttribute("value", " value=\"", 2065, "\"", 2102, 1);
#nullable restore
#line 33 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
WriteAttributeValue("", 2073, Model.CustomerSigin.Password, 2073, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder=""Please Enter Your Password"">
                                    <div class=""input-group-text"" data-password=""false"">
                                        <span class=""password-eye""></span>
                                    </div>
                                </div>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
");
#nullable restore
#line 42 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
                                     if (Model.CustomerSigin.IsActive == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option selected value=\"1\">Aktif</option>\r\n                                        <option value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 46 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option value=\"1\">Aktif</option>\r\n                                        <option selected value=\"0\">Pasif</option>\r\n");
#nullable restore
#line 51 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionCustomerSigin\Edit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-outline-primary d-inline-block""><i class=""fa fa-edit""></i> Update New Customer</button>
                                <a href=""/admin/musteri-kayit-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateCustomerSiginViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
