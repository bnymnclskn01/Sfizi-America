#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82a36cad92e144f1428844f6596d91fb8712fb54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionRezervation_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionRezervation/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82a36cad92e144f1428844f6596d91fb8712fb54", @"/Areas/Admin/Views/ActionRezervation/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionRezervation_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateRezervationViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
  
    ViewData["Title"] = "Update New Rezervation";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/PageJs/updateRezervation.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""header-title"">Add New Rezervation</h4>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <form id=""form-submit"">
                            <input hidden name=""ID""");
            BeginWriteAttribute("value", " value=\"", 640, "\"", 669, 1);
#nullable restore
#line 17 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 648, Model.Rezervation.ID, 648, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"mb-3\">\r\n                                <label for=\"simpleinput\" class=\"form-label\">Name Surname</label>\r\n                                <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 871, "\"", 909, 1);
#nullable restore
#line 20 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 879, Model.Rezervation.NameSurname, 879, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""NameSurname"" maxlength=""75"" required placeholder=""Please Enter Name Surname Trial : John Doe"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Phone</label>
                                <input type=""tel""");
            BeginWriteAttribute("value", " value=\"", 1260, "\"", 1292, 1);
#nullable restore
#line 24 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 1268, Model.Rezervation.Phone, 1268, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Phone"" maxlength=""15"" required placeholder=""Please Enter Phone Trial : 7035331191"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Email</label>
                                <input type=""email""");
            BeginWriteAttribute("value", " value=\"", 1634, "\"", 1666, 1);
#nullable restore
#line 28 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 1642, Model.Rezervation.Email, 1642, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Email"" maxlength=""70"" required placeholder=""Please Enter Email Trial : john.doe@gmail.com"" />
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Rezervation Date</label>
                                <input type=""date""");
            BeginWriteAttribute("value", " value=\"", 2026, "\"", 2057, 1);
#nullable restore
#line 32 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 2034, Model.Rezervation.Date, 2034, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" name=""Date"" required placeholder=""Please Enter Rezervation Date Trial : 16/02/2031"" />
                            </div>
                            <div class=""mb-3"">
                                <label class=""form-label"">Rezervation Time</label>
                                <select name=""Time"" class=""form-select"" placeholder=""Selected Rezervation"">
                                    <optgroup label=""Select Model"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 2561, "\"", 2592, 1);
#nullable restore
#line 38 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 2569, Model.Rezervation.Time, 2569, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
                                                                           Write(Model.Rezervation.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                                    </optgroup>
                                    <optgroup label=""AM A CLCOK"">
                                        <option value=""00:00 am"">00:00 am</option>
                                        <option value=""00:30 am"">00:30 am</option>
                                        <option value=""01:00 am"">01:00 am</option>
                                        <option value=""01:30 am"">01:30 am</option>
                                        <option value=""02:00 am"">02:00 am</option>
                                        <option value=""02:30 am"">02:30 am</option>
                                        <option value=""03:00 am"">03:00 am</option>
                                        <option value=""03:30 am"">03:30 am</option>
                                        <option value=""04:00 am"">04:00 am</option>
                                        <option value=""04:30 am"">04:30 am</option>
                                        <option value=""05");
            WriteLiteral(@":00 am"">05:00 am</option>
                                        <option value=""05:30 am"">05:30 am</option>
                                        <option value=""06:00 am"">06:00 am</option>
                                        <option value=""06:30 am"">06:30 am</option>
                                        <option value=""07:00 am"">07:00 am</option>
                                        <option value=""07:30 am"">07:30 am</option>
                                        <option value=""08:00 am"">08:00 am</option>
                                        <option value=""08:30 am"">08:30 am</option>
                                        <option value=""09:00 am"">09:00 am</option>
                                        <option value=""09:30 am"">09:30 am</option>
                                        <option value=""10:00 am"">10:00 am</option>
                                        <option value=""10:30 am"">10:30 am</option>
                                        <option value=""11:30 am"">11:00 am");
            WriteLiteral(@"</option>
                                        <option value=""11:30 am"">11:30 am</option>
                                    </optgroup>
                                    <optgroup label=""PM A CLOCK"">
                                        <option value=""12:00 pm"">12:00 pm</option>
                                        <option value=""12:30 pm"">12:30 pm</option>
                                        <option value=""01:00 pm"">01:00 pm</option>
                                        <option value=""01:30 pm"">01:30 pm</option>
                                        <option value=""02:00 pm"">02:00 pm</option>
                                        <option value=""02:30 pm"">02:30 pm</option>
                                        <option value=""03:00 pm"">03:00 pm</option>
                                        <option value=""03:30 pm"">03:30 pm</option>
                                        <option value=""04:00 pm"">04:00 pm</option>
                                        <option value=""04");
            WriteLiteral(@":30 pm"">04:30 pm</option>
                                        <option value=""05:00 pm"">05:00 pm</option>
                                        <option value=""05:30 pm"">05:30 pm</option>
                                        <option value=""06:00 pm"">06:00 pm</option>
                                        <option value=""06:30 pm"">06:30 pm</option>
                                        <option value=""07:00 pm"">07:00 pm</option>
                                        <option value=""07:30 pm"">07:30 pm</option>
                                        <option value=""08:00 pm"">08:00 pm</option>
                                        <option value=""08:30 pm"">08:30 pm</option>
                                        <option value=""09:00 pm"">09:00 pm</option>
                                        <option value=""09:30 pm"">09:30 pm</option>
                                        <option value=""10:00 pm"">10:00 pm</option>
                                        <option value=""10:30 pm"">10:30 pm");
            WriteLiteral(@"</option>
                                        <option value=""11:30 pm"">11:00 pm</option>
                                        <option value=""11:30 pm"">11:30 pm</option>
                                    </optgroup>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label class=""form-label"">Rezervation Person</label>
                                <select name=""Person"" class=""form-select"" placeholder=""Selected Rezervation"">
                                    <optgroup label=""Select Model"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 7381, "\"", 7414, 1);
#nullable restore
#line 98 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 7389, Model.Rezervation.Person, 7389, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
                                                                             Write(Model.Rezervation.Person);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                                    </optgroup>
                                    <option value=""1"">1</option>
                                    <option value=""2"">2</option>
                                    <option value=""3"">3</option>
                                    <option value=""4"">4</option>
                                    <option value=""5"">5</option>
                                    <option value=""6"">6</option>
                                    <option value=""7"">7</option>
                                    <option value=""8"">8</option>
                                    <option value=""9"">9</option>
                                    <option value=""10"">10</option>
                                    <option value=""11"">11</option>
                                    <option value=""12"">12</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label ");
            WriteLiteral("for=\"simpleinput\" class=\"form-label\">Rezervation Message</label>\r\n                                <textarea class=\"form-control\" name=\"Message\" maxlength=\"1000\" required placeholder=\"Please Enter Your Rezervation Message\">");
#nullable restore
#line 116 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
                                                                                                                                                       Write(Model.Rezervation.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                            </div>
                            <div class=""mb-3"">
                                <label class=""form-label"">Rezervation Table Type</label>
                                <select name=""TableType"" class=""form-select"" placeholder=""Selected Rezervation"">
                                    <optgroup label=""Select Model"">
                                        <option");
            BeginWriteAttribute("value", " value=\"", 9130, "\"", 9166, 1);
#nullable restore
#line 122 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
WriteAttributeValue("", 9138, Model.Rezervation.TableType, 9138, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 122 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionRezervation\Edit.cshtml"
                                                                                Write(Model.Rezervation.TableType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                                    </optgroup>
                                    <option value=""In The Garden"">In The Garden</option>
                                    <option value=""Inside The Restaurant"">Inside The Restaurant</option>
                                    <option value=""Table With Smoking Area Zone"">Table With Smoking Area Zone</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <label for=""simpleinput"" class=""form-label"">Status</label>
                                <select required name=""IsActive"" class=""form-select"">
                                    <option value=""1"">Active</option>
                                    <option value=""0"">Passive</option>
                                </select>
                            </div>
                            <div class=""mb-3"">
                                <button type=""submit"" class=""btn btn-out");
            WriteLiteral(@"line-primary d-inline-block""><i class=""fa fa-edit""></i> Update New Rezervation</button>
                                <a href=""/admin/rezervasyon-listele"" class=""btn btn-outline-dark""><i class=""fa fa-reply-all""></i> Back To List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SfiziAmerica.WebUIandUX.Areas.Admin.ViewModel.updateRezervationViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
