#pragma checksum "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\Shop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3002f00eaf1e6fcdfa44e314877ed42ff77153c4"
// <auto-generated/>
#pragma warning disable 1591
namespace Kenkata_Adm_Products.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/shop")]
    public partial class Shop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Kenkata_Adm_Products.Shared.Navbar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "shop-content");
            __builder.AddAttribute(4, "b-qvnwwmpbdb");
            __builder.AddMarkupContent(5, @"<dvi class=""showcase"" b-qvnwwmpbdb><div class=""items d-flex mx-auto"" b-qvnwwmpbdb><div class=""offer d-flex flex-column justify-content-center"" b-qvnwwmpbdb><div class=""text d-flex align-items-end"" b-qvnwwmpbdb><span class=""play-36-bold"" style=""color: white;"" b-qvnwwmpbdb>
                        New Customer<br b-qvnwwmpbdb>Can Get
                        <span style=""color:#20D3C2;"" b-qvnwwmpbdb>
                            30% off
                        </span></span></div>
                <div class=""button"" b-qvnwwmpbdb><button b-qvnwwmpbdb>
                        LEARN MORE
                    </button></div></div>
            <div class=""image  d-flex justify-content-center align-items-center"" b-qvnwwmpbdb><img src=""/images/shoes.png"" alt b-qvnwwmpbdb></div></div></dvi>
    ");
            __builder.AddMarkupContent(6, "<div class=\"view-customizer\" b-qvnwwmpbdb><div class=\"items mx-auto d-flex\" b-qvnwwmpbdb><div class=\"links d-flex align-items-center\" b-qvnwwmpbdb><nav aria-label=\"breadcrumb\" b-qvnwwmpbdb><h4 b-qvnwwmpbdb>Shop</h4>\r\n                    <ol class=\"breadcrumb page-links\" b-qvnwwmpbdb><li class=\"breadcrumb-item\" b-qvnwwmpbdb><a href=\"#\" b-qvnwwmpbdb>Home</a></li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\" b-qvnwwmpbdb>Shop</li></ol></nav></div>\r\n            <div class=\"customizer-items d-flex justify-content-end align-items-center\" b-qvnwwmpbdb><div class=\"nr-per-page\" b-qvnwwmpbdb><ul class=\"nav \" b-qvnwwmpbdb><li class=\"nav-item\" b-qvnwwmpbdb><a class=\"nav-link \" href=\"#\" b-qvnwwmpbdb>9</a></li>\r\n                        <li class=\"nav-item\" b-qvnwwmpbdb><a class=\"nav-link\" href=\"#\" b-qvnwwmpbdb>12</a></li>\r\n                        <li class=\"nav-item\" b-qvnwwmpbdb><a class=\"nav-link\" href=\"#\" b-qvnwwmpbdb>18</a></li>\r\n                        <li class=\"nav-item\" b-qvnwwmpbdb><a class=\"nav-link\" href=\"#\" b-qvnwwmpbdb>24</a></li></ul></div>\r\n                <div class=\"view-as\" b-qvnwwmpbdb><div class=\"item-1\" b-qvnwwmpbdb><i class=\"fas fa-th-list\" b-qvnwwmpbdb></i></div>\r\n                    <div class=\"item-2\" b-qvnwwmpbdb><i class=\"fas fa-th-large\" b-qvnwwmpbdb></i></div>\r\n                    <div class=\"item-3 \" b-qvnwwmpbdb><i class=\"fas fa-th\" b-qvnwwmpbdb></i></div></div>\r\n                <div class=\"sorting\" b-qvnwwmpbdb><button class=\"btn btn-secondary dropdown-toggle\" type=\"button\" id=\"dropdownMenuButton1\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-qvnwwmpbdb>\r\n                        Default sorting\r\n                    </button></div></div></div></div>\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "Products");
            __builder.AddAttribute(9, "b-qvnwwmpbdb");
            __builder.OpenComponent<Kenkata_Adm_Products.Pages.Products>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "subscribe");
            __builder.AddAttribute(14, "b-qvnwwmpbdb");
            __builder.OpenComponent<Kenkata_Adm_Products.Pages.Subscribe>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "brands");
            __builder.AddAttribute(19, "b-qvnwwmpbdb");
            __builder.OpenComponent<Kenkata_Adm_Products.Pages.Brands>(20);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "b-qvnwwmpbdb");
            __builder.OpenComponent<Kenkata_Adm_Products.Shared.Footer>(24);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
