#pragma checksum "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionLogin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31d4095f390587b873413ed1c02ce65e7e0c3e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActionLogin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ActionLogin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d4095f390587b873413ed1c02ce65e7e0c3e06", @"/Areas/Admin/Views/ActionLogin/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ActionLogin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("loading authentication-bg authentication-bg-pattern"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ever_\OneDrive\Belgeler\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Areas\Admin\Views\ActionLogin\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31d4095f390587b873413ed1c02ce65e7e0c3e063555", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>ImproBio.Tech - Admin Dashboard Panel</title>
    <!-- App favicon -->
    <link rel=""shortcut icon"" href=""/Admin/assets/kio.png"">
    <!-- App css -->

    <link href=""/Admin/assets/css/app.min.css"" rel=""stylesheet"" type=""text/css"" id=""app-style"" />

    <!-- icons -->
    <link href=""/Admin/assets/css/icons.min.css"" rel=""stylesheet"" type=""text/css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31d4095f390587b873413ed1c02ce65e7e0c3e064977", async() => {
                WriteLiteral(@"
    <div class=""account-pages my-5"">
        <div class=""container"">

            <div class=""row justify-content-center"">
                <div class=""col-md-8 col-lg-6 col-xl-4"">
                    <div class=""text-center"">
                        <a href=""index.html"">
                            <img src=""/Admin/assets/black-karaton.png"" alt=""KaratonIO"" height=""22"" class=""mx-auto"">
                        </a>
                        <p class=""text-muted mt-2 mb-4"">ImproBio.Tech - Admin Dashboard Panel</p>

                    </div>
                    <div class=""card"">
                        <div class=""card-body p-4"">

                            <div class=""text-center mb-4"">
                                <h4 class=""text-uppercase mt-0"">Sign In</h4>
                            </div>

                            <form id=""form-submit"">
                                <div class=""mb-3"">
                                    <label for=""emailaddress"" class=""form-label"">Email Addr");
                WriteLiteral(@"ess</label>
                                    <input class=""form-control"" type=""email"" name=""Email"" placeholder=""Enter your email"">
                                </div>

                                <div class=""mb-3"">
                                    <label for=""password"" class=""form-label"">Password</label>
                                    <input class=""form-control"" type=""password"" name=""Password"" placeholder=""Enter your password"">
                                </div>

                                <div class=""mb-3 d-grid text-center"">
                                    <button class=""btn btn-primary"" type=""submit""> Log In </button>
                                </div>
                            </form>

                        </div> <!-- end card-body -->
                    </div>
                    <!-- end card -->

                </div> <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
                WriteLiteral(@"
    <!-- end page -->
    <!-- Vendor -->

    <script src=""/Admin/assets/libs/jquery/jquery.min.js""></script>
    <script src=""/Admin/assets/libs/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""/Admin/assets/libs/simplebar/simplebar.min.js""></script>
    <script src=""/Admin/assets/libs/node-waves/waves.min.js""></script>
    <script src=""/Admin/assets/libs/waypoints/lib/jquery.waypoints.min.js""></script>
    <script src=""/Admin/assets/libs/jquery.counterup/jquery.counterup.min.js""></script>
    <script src=""/Admin/assets/libs/feather-icons/feather.min.js""></script>

    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <!-- App js -->
    <script src=""/Admin/assets/js/app.min.js""></script>
    <script src=""/PageJs/login.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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