#pragma checksum "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\Shared\_partialHeaderMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "101843440a0ee2eb22fa8ac78b8b82d15e966c97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__partialHeaderMenu), @"mvc.1.0.view", @"/Views/Shared/_partialHeaderMenu.cshtml")]
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
#nullable restore
#line 1 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.WebUIandUX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.WebUIandUX.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.EntityLayer.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.EntityLayer.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\_ViewImports.cshtml"
using SfiziAmerica.WebUIandUX.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"101843440a0ee2eb22fa8ac78b8b82d15e966c97", @"/Views/Shared/_partialHeaderMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00930272c51c841bc21af59ef8f22a72f1282743", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__partialHeaderMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("            <!-- header  -->\r\n<header class=\"main-header\">\r\n    <!-- header-top  -->\r\n    <div class=\"header-top\">\r\n        <div class=\"container\">\r\n            ");
#nullable restore
#line 6 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\Shared\_partialHeaderMenu.cshtml"
       Write(await Component.InvokeAsync("HeaderAboutComponent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!--header-top end -->\r\n    <!-- header-inner -->\r\n    <div class=\"header-inner  fl-wrap\">\r\n        <div class=\"container\">\r\n            <div class=\"header-container fl-wrap\">\r\n                ");
#nullable restore
#line 14 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\Shared\_partialHeaderMenu.cshtml"
           Write(await Component.InvokeAsync("HeadLogoComponent"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""show-share-btn showshare htact""><i class=""fal fa-bullhorn""></i> <span class=""header-tooltip"">Share</span></div>
                <!-- nav-button-wrap-->
                <div class=""nav-button-wrap"">
                    <div class=""nav-button"">
                        <span></span><span></span><span></span>
                    </div>
                </div>
                <!-- nav-button-wrap end-->
                <!--  navigation -->
                <div class=""nav-holder main-menu"">
                    <nav>
                        <ul>
                            <li><a href=""/"">Home</a></li>
                            <li>
                                <a href=""#"">Corporate <i class=""fas fa-caret-down""></i></a>
                                <!--second level -->
                                <ul>
                                    <li><a href=""/about"">About</a></li>
                                    <li><a href=""/mission"">Mission</a></li>
          ");
            WriteLiteral(@"                          <li><a href=""/vision"">Vision</a></li>
                                </ul>
                                <!--second level end-->
                            </li>
                            <li>
                                <a href=""#"">Menu <i class=""fas fa-caret-down""></i></a>
                                <!--second level -->
                                <ul>
                                    ");
#nullable restore
#line 42 "C:\Users\fnsss\Documents\GitHub\Sfizi-America\SfiziAmerica\SfiziAmerica.WebUIandUX\Views\Shared\_partialHeaderMenu.cshtml"
                               Write(await Component.InvokeAsync("HeaderMenuComponentList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                                <!--second level end-->
                            </li>
                            <li><a href=""/catering"">Catering</a></li>
                            <li><a href=""/event"">Event</a></li>
                            <li>
                                <a href=""#"">Membership<i class=""fas fa-caret-down""></i></a>
                                <!--second level -->
                                <ul>
                                    <li><a href=""/sig-in"">Sig in</a></li>
                                    <li><a href=""/sigin-up"">Sigin up</a></li>
                                </ul>
                                <!--second level end-->
                            </li>
                            <li>
                                <a href=""#"">Contact Us<i class=""fas fa-caret-down""></i></a>
                                <!--second level -->
                                <ul>
                                ");
            WriteLiteral(@"    <li><a href=""/contact"">Contact</a></li>
                                    <li><a href=""/human-resources"">Human Resources</a></li>
                                    <li><a href=""/application-form"">Application Form</a></li>
                                    <li><a href=""/reservation"">Reservation</a></li>
                                </ul>
                                <!--second level end-->
                            </li>
                        </ul>
                    </nav>
                </div>
                <!-- navigation  end -->
                <!-- share-wrapper -->
                <div class=""share-wrapper isShare"">
                    <div class=""share-container fl-wrap""></div>
                </div>
                <!-- share-wrapper-end -->
            </div>
        </div>
    </div>
    <!-- header-inner end  -->
</header>
<!--header end -->	");
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
