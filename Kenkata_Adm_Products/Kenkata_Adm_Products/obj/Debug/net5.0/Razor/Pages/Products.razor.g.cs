#pragma checksum "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e8c2b5a048fe6ff209f4b63fa3db6fc3704a310"
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
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"products\" b-pbrwj2bgeu><div class=\"items mx-auto\" b-pbrwj2bgeu><div class=\"filter\" b-pbrwj2bgeu><div class=\"btn-group\" b-pbrwj2bgeu><button class=\"btn filter-btn btn-lg  square-dark dropdown-toggle\" type=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"true\" b-pbrwj2bgeu>\r\n                        Filter\r\n                    </button>\r\n                    <div class=\"dropdown-menu\" b-pbrwj2bgeu><div class=\"product-categories\" b-pbrwj2bgeu><p b-pbrwj2bgeu>Product Categories</p>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>Men\'s</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>18</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>Women\'s</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>23</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>Kids</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>32</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>Hats</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>12</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name active\" b-pbrwj2bgeu>Sunglasses</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>15</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name \" b-pbrwj2bgeu>Shoes</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>12</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name \" b-pbrwj2bgeu>Watches</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>20</div></div></a></div>\r\n                        \r\n                        <div class=\"filter-by-color\" b-pbrwj2bgeu><p b-pbrwj2bgeu>Filter by Color</p>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-1 color-square bg-black\" b-pbrwj2bgeu></div>\r\n                                    <div class=\"col col-10 color-name\" b-pbrwj2bgeu>Black</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>12</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-1 color-square bg-gray\" b-pbrwj2bgeu></div>\r\n                                    <div class=\"col col-10 color-name\" b-pbrwj2bgeu>Gray</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>20</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-1 color-square bg-red\" b-pbrwj2bgeu></div>\r\n                                    <div class=\"col col-10 color-name\" b-pbrwj2bgeu>Red</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>18</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-1 color-square bg-green\" b-pbrwj2bgeu><i class=\"fas fa-check\" b-pbrwj2bgeu></i></div>\r\n                                    <div class=\"col col-10 color-name\" b-pbrwj2bgeu>Green</div>\r\n                                    <div class=\"col col-1 number-of-items square bg-active\" b-pbrwj2bgeu>25</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-1 color-square bg-orange\" b-pbrwj2bgeu></div>\r\n                                    <div class=\"col col-10 color-name\" b-pbrwj2bgeu>Orange</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>9</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-1 color-square bg-brown\" b-pbrwj2bgeu></div>\r\n                                    <div class=\"col col-10 color-name\" b-pbrwj2bgeu>Brown</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>7</div></div></a></div>\r\n                        \r\n                        <div class=\"filter-by-size \" b-pbrwj2bgeu><p b-pbrwj2bgeu>Filter by Size</p>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>XS</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>18</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>S</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>23</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>M</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>32</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>L</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>12</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>XL</div>\r\n                                    <div class=\"col col-1 number-of-items square bg-active\" b-pbrwj2bgeu>15</div></div></a>\r\n                            <a href=\"#\" b-pbrwj2bgeu><div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-11 name\" b-pbrwj2bgeu>xxl</div>\r\n                                    <div class=\"col col-1 number-of-items square\" b-pbrwj2bgeu>12</div></div></a></div>\r\n                        <div class=\"filter-by-brand \" b-pbrwj2bgeu><p b-pbrwj2bgeu>Filter by Brand</p>\r\n                            <div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-6\" b-pbrwj2bgeu><a href b-pbrwj2bgeu><img src=\"images/bexim.png\" alt b-pbrwj2bgeu></a></div>\r\n                                <div class=\"col col-6\" b-pbrwj2bgeu><a href b-pbrwj2bgeu><img src=\"images/lighton.png\" alt b-pbrwj2bgeu></a></div>\r\n                                <div class=\"col col-6\" b-pbrwj2bgeu><a href b-pbrwj2bgeu><img src=\"images/dismis.png\" alt b-pbrwj2bgeu></a></div>\r\n                                <div class=\"col col-6\" b-pbrwj2bgeu><a href b-pbrwj2bgeu><img src=\"images/rosimo.png\" alt b-pbrwj2bgeu></a></div>\r\n                                <div class=\"col col-6\" b-pbrwj2bgeu><a href b-pbrwj2bgeu><img src=\"images/dallas.png\" alt b-pbrwj2bgeu></a></div>\r\n                                <div class=\"col col-6\" b-pbrwj2bgeu><a href b-pbrwj2bgeu><img src=\"images/concord.png\" alt b-pbrwj2bgeu></a></div></div></div>\r\n                        <div class=\"filter-by-brand \" b-pbrwj2bgeu><p b-pbrwj2bgeu>Product Status</p>\r\n                            <div class=\"row filter-row\" b-pbrwj2bgeu><div class=\"col col-1 name\" b-pbrwj2bgeu><input class=\"square\" type=\"checkbox\" id=\"on-sale\" name=\"on-sale\" value=\"On Sale\" b-pbrwj2bgeu></div>\r\n                                <div class=\"col col-11 on-sale\" b-pbrwj2bgeu>On Sale</div>\r\n                                <div class=\"col col-1 name\" b-pbrwj2bgeu><input class=\"square\" type=\"checkbox\" id=\"in-stock\" name=\"in-stock\" value=\"In Stock\" b-pbrwj2bgeu></div>\r\n                                <div class=\"col col-11 in-stock\" b-pbrwj2bgeu>In Stock</div></div></div></div></div></div>\r\n            <div class=\"product-items\" b-pbrwj2bgeu><div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div>\r\n                <div class=\"item\" b-pbrwj2bgeu><div class=\"item-image\" b-pbrwj2bgeu><div class=\"div\" b-pbrwj2bgeu><div class=\"item-price\" b-pbrwj2bgeu>\r\n                                12$\r\n                            </div></div>\r\n                        <img src=\"/images/shirt.png\" alt b-pbrwj2bgeu></div>\r\n                    <div class=\"item-name-price\" b-pbrwj2bgeu><div class=\"item-name\" b-pbrwj2bgeu>Circle pattern girls shirt</div>\r\n                        <div class=\"item-buy\" b-pbrwj2bgeu><a style=\"color: inherit;\" href=\"#\" b-pbrwj2bgeu><i class=\"fas fa-cart-plus fa-lg\" b-pbrwj2bgeu></i></a></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
