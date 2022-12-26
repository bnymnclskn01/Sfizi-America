#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionContactInformation\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e38cc8003342b725eb54cba0e801b2136ab7c80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionContactInformation_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionContactInformation/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e38cc8003342b725eb54cba0e801b2136ab7c80", @"/Areas/Admin/Views/ActionContactInformation/Create.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionContactInformation_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionContactInformation\Create.cshtml"
  
    ViewData["Title"] = "Add New Contact Information";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/PageJs/addContactInformation.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Add New Contact Information</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Address</label>
                                <textarea class=""form-control"" name=""Address"" maxlength=""500"" required placeholder=""Please Enter Address"" rows=""5""></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Address - 2</label>
                                <textarea class=""form-control"" name=""Address2"" maxlength=""500"" placeholder=""Not a Required Field. Please Enter Address"" rows=""5""></textarea>
                            </div>
                  ");
            WriteLiteral(@"          <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Address - 3</label>
                                <textarea class=""form-control"" name=""Address3"" maxlength=""500"" placeholder=""Not a Required Field. Please Enter Address"" rows=""5""></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Address - 4</label>
                                <textarea class=""form-control"" name=""Address4"" maxlength=""500"" placeholder=""Not a Required Field. Please Enter Address"" rows=""5""></textarea>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone</label>
                                <input type=""tel"" class=""form-control"" name=""Phone"" maxlength=""15"" required placeholder=""Please Enter Phone Trial : 7035331191"" />
                            <");
            WriteLiteral(@"/div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone - 2</label>
                                <input type=""tel"" class=""form-control"" name=""Phone2"" maxlength=""15"" placeholder=""Not a Required Field. Please Enter Phone Trial : 7035331191"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone - 3</label>
                                <input type=""tel"" class=""form-control"" name=""Phone3"" maxlength=""15"" placeholder=""Not a Required Field. Please Enter Phone Trial : 7035331191"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone - 4</label>
                                <input type=""tel"" class=""form-control"" name=""Phone4"" maxlength=""15"" placeholder=""Not a Required Field. Please Enter Phone Trial ");
            WriteLiteral(@": 7035331191"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email</label>
                                <input type=""email"" class=""form-control"" name=""Email"" maxlength=""100"" required placeholder=""Please Enter Email Trial : info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email - 2</label>
                                <input type=""email"" class=""form-control"" name=""Email2"" maxlength=""100"" placeholder=""Not a Required Field.Please Enter Email Trial : info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email - 3</label>
                                <input type=""email"" class=""form-control"" name=""Email3"" maxlength=""100"" placeholder=""No");
            WriteLiteral(@"t a Required Field.Please Enter Email Trial : info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email - 4</label>
                                <input type=""email"" class=""form-control"" name=""Email4"" maxlength=""100"" placeholder=""Not a Required Field.Please Enter Email Trial : info@sfizi.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
                                    <option value=""1"">Active</option>
                                    <option value=""0"">Passive</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""b");
            WriteLiteral(@"tn btn-outline-success d-inline-block""><i class=""fa fa-check""></i> Add New Contact Information</button>
                                <a href=""/admin/iletisim-bilgileri-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
