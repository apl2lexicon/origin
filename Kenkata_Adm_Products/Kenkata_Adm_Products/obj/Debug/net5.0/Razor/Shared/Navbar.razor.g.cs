#pragma checksum "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\Shared\Navbar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f91e859a291e072587c45c0913476067baa228"
// <auto-generated/>
#pragma warning disable 1591
namespace Kenkata_Adm_Products.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Kenkata_Adm_Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Kenkata_Adm_Products.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Kenkata_Adm_Products.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/navbar")]
    public partial class Navbar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"items mx-auto\" b-g3o3l9ycbo><div class=\"header\" b-g3o3l9ycbo><div class=\"top-head d-flex flex-row align-items-center\" b-g3o3l9ycbo><div class=\"left d-flex justify-content-start\" b-g3o3l9ycbo><ul class=\"nav top-links\" b-g3o3l9ycbo><li class=\"nav-item dropdown\" b-g3o3l9ycbo><a class=\"nav-link dropdown-toggle\" data-bs-toggle=\"dropdown\" href=\"#\" role=\"button\" aria-expanded=\"false\" b-g3o3l9ycbo>ENG</a>\r\n                        <ul class=\"dropdown-menu dropdown-menu-right\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>SE</a></li>\r\n                            <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>....</a></li>\r\n                            <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>....</a></li>\r\n                            <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>.....</a></li></ul></li>\r\n                    <li class=\"nav-item dropdown\" b-g3o3l9ycbo><a class=\"nav-link dropdown-toggle\" data-bs-toggle=\"dropdown\" href=\"#\" role=\"button\" aria-expanded=\"false\" b-g3o3l9ycbo>USD</a>\r\n                        <ul class=\"dropdown-menu dropdown-menu-right \" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>SEK</a></li>\r\n                            <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>....</a></li>\r\n                            <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>....</a></li>\r\n                            <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>.....</a></li></ul></li></ul></div>\r\n            <div class=\"right d-flex justify-content-end\" b-g3o3l9ycbo><ul class=\"nav top-links\" b-g3o3l9ycbo><li class=\"nav-item\" b-g3o3l9ycbo><a class=\"nav-link\" href=\"#\" b-g3o3l9ycbo>Newsletter</a></li>\r\n                    <li class=\"nav-item\" b-g3o3l9ycbo><a class=\"nav-link\" href=\"#\" b-g3o3l9ycbo>Contact us</a></li>\r\n                    <li class=\"nav-item\" b-g3o3l9ycbo><a class=\"nav-link\" href=\"#\" b-g3o3l9ycbo>FAQs</a></li></ul></div></div>\r\n        <div class=\"content d-flex align-items-center\" b-g3o3l9ycbo><div class=\"logo d-flex\" b-g3o3l9ycbo><a href b-g3o3l9ycbo><img src=\"./logo.png\" alt b-g3o3l9ycbo></a></div>\r\n            <div class=\"search d-flex\" b-g3o3l9ycbo><form b-g3o3l9ycbo><input type=\"text\" placeholder=\"Search products...\" b-g3o3l9ycbo>\r\n                    <input class=\"input-btn\" value=\"Search\" type=\"submit\" b-g3o3l9ycbo></form></div>\r\n            <div class=\"customer d-flex\" b-g3o3l9ycbo><ul b-g3o3l9ycbo><a href b-g3o3l9ycbo><i class=\"fa fa-user\" b-g3o3l9ycbo><span class=\"account\" b-g3o3l9ycbo> My Account</span></i></a>\r\n                    <a href b-g3o3l9ycbo><i class=\"fas fa-heart\" b-g3o3l9ycbo></i></a>\r\n                    <a href b-g3o3l9ycbo><i class=\"fas fa-random\" b-g3o3l9ycbo></i></a>\r\n                    <a href b-g3o3l9ycbo><i class=\"fas fa-shopping-bag\" b-g3o3l9ycbo><span class=\"shopcart \" b-g3o3l9ycbo>0</span> <span class=\"total\" b-g3o3l9ycbo> 0$</span></i></a></ul></div></div>\r\n        <div class=\"nav-content d-flex\" b-g3o3l9ycbo><nav class=\"navbar navbar-expand-lg navbar-light bg-white\" b-g3o3l9ycbo><button class=\"navbar-toggler\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#navbarSupportedContent\" aria-controls=\"navbarSupportedContent\" aria-expanded=\"false\" aria-label=\"Toggle navigation\" b-g3o3l9ycbo><span class=\"navbar-toggler-icon\" b-g3o3l9ycbo></span></button>\r\n                <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\" b-g3o3l9ycbo><ul class=\"navbar-nav bg-light\" b-g3o3l9ycbo><li class=\"nav-item dropdown browse-categories\" b-g3o3l9ycbo><a class=\"nav-link dropdown-toggle  \" data-bs-toggle=\"dropdown\" href=\"#\" role=\"button\" aria-expanded=\"false\" b-g3o3l9ycbo><i class=\"fas fa-bars mx-3\" b-g3o3l9ycbo></i>Browse Categories</a>\r\n                            <ul class=\"dropdown-menu categories-items\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>Men\'s</a></li>\r\n                                <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>Women\'s</a></li>\r\n                                <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>Kids</a></li>\r\n                                <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>Hats</a></li>\r\n                                <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>Sunglasses</a></li>\r\n                                <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>Shoes</a></li>\r\n                                <li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>Watches</a></li></ul></li>\r\n                        <li class=\"nav-item\" b-g3o3l9ycbo><a class=\"nav-link active\" aria-current=\"page\" href=\"#\" b-g3o3l9ycbo>Home</a></li>\r\n                        <li class=\"nav-item dropdown\" b-g3o3l9ycbo><a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-g3o3l9ycbo>\r\n                                Shop\r\n                            </a>\r\n                            <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul>\r\n                            <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul></li>\r\n\r\n                        <li class=\"nav-item dropdown\" b-g3o3l9ycbo><a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-g3o3l9ycbo>\r\n                                Products\r\n                            </a>\r\n                            <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul>\r\n                            <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul></li>\r\n                        <li class=\"nav-item dropdown\" b-g3o3l9ycbo><a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-g3o3l9ycbo>\r\n                                Categories\r\n                            </a>\r\n                            <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul>\r\n                            <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul></li>\r\n\r\n                        <li class=\"nav-item dropdown\" b-g3o3l9ycbo><a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-g3o3l9ycbo>\r\n                                Pages\r\n                            </a>\r\n                            <ul class=\"dropdown-menu \" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul>\r\n                            <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\" b-g3o3l9ycbo><li b-g3o3l9ycbo><a class=\"dropdown-item\" href=\"#\" b-g3o3l9ycbo>link</a></li></ul></li>\r\n                        <li class=\"nav-item\" b-g3o3l9ycbo><a class=\"nav-link\" aria-current=\"page\" href=\"#\" b-g3o3l9ycbo>Blog</a></li></ul>\r\n                    <div class=\"special-offer d-flex\" b-g3o3l9ycbo><button class=\"btn\" b-g3o3l9ycbo>SPECIAL OFFER</button></div></div></nav>\r\n            <div class=\" customer-mobile d-flex align-items-center\" b-g3o3l9ycbo><ul b-g3o3l9ycbo><a href b-g3o3l9ycbo><i class=\"fa fa-user\" b-g3o3l9ycbo><span class=\"account\" b-g3o3l9ycbo>My Account</span></i></a>\r\n                    <a href b-g3o3l9ycbo><i class=\"fas fa-heart\" b-g3o3l9ycbo></i></a>\r\n                    <a href b-g3o3l9ycbo><i class=\"fas fa-random\" b-g3o3l9ycbo></i></a>\r\n                    <a href b-g3o3l9ycbo><i class=\"fas fa-shopping-bag\" b-g3o3l9ycbo><span class=\"shopcart\" b-g3o3l9ycbo>0</span> <span class=\"total\" b-g3o3l9ycbo>\r\n                                300$\r\n                            </span></i></a></ul></div></div></div></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
