#pragma checksum "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ShopCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4f04866aceea45c838d8270898eff26693b7cbb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/shopcart")]
    public partial class ShopCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"shopping-cart\" b-bkxwp7unbd><div class=\"showcase\" b-bkxwp7unbd><div class=\"items d-flex mx-auto justify-content-center container\" b-bkxwp7unbd><span class=\"shoppingcart-text\" b-bkxwp7unbd>Shopping Cart</span>\r\n                <span class=\"first-arrow-right\" b-bkxwp7unbd>></span>\r\n                <span class=\"checkout-text\" b-bkxwp7unbd>Check Out</span>\r\n                <span class=\"second-arrow-right\" b-bkxwp7unbd>></span>\r\n                <span class=\"order-complete-text\" b-bkxwp7unbd>Order Complete</span></div></div>\r\n\r\n        <div class=\"shopping row container\" b-bkxwp7unbd><div class=\"shopping-list col-8 col-s-12\" b-bkxwp7unbd><table class=\"shopping-table\" b-bkxwp7unbd><thead class=\"products-header\" b-bkxwp7unbd><tr b-bkxwp7unbd><th b-bkxwp7unbd>Product</th>\r\n                            <th b-bkxwp7unbd>Price</th>\r\n                            <th b-bkxwp7unbd>Quantity</th>\r\n                            <th b-bkxwp7unbd>Subtotal</th></tr></thead>\r\n                    <tbody b-bkxwp7unbd><tr b-bkxwp7unbd><td b-bkxwp7unbd><input type=\"image\" img src=\"images/Close icon.png\" class=\"img-fluid\" alt b-bkxwp7unbd></td>\r\n                            <td b-bkxwp7unbd></td>\r\n                            <td b-bkxwp7unbd><input type=\"button\" value=\"+\" class=\"plusbutton\" b-bkxwp7unbd>\r\n                                <input type=\"text\" id=\"numOfItems\" class=\"numOfItems\" maxlength=\"3\" size=\"3\" b-bkxwp7unbd>\r\n                                <input type=\"button\" value=\"-\" class=\"minusbutton\" b-bkxwp7unbd></td></tr></tbody></table>\r\n\r\n                <div class=\"row mt-5\" b-bkxwp7unbd><div class=\"col-8 col-s-12\" b-bkxwp7unbd><div class=\"coupon-code\" b-bkxwp7unbd><div class=\"have-code\" b-bkxwp7unbd><p b-bkxwp7unbd>If you have a coupon code, please apply it below.</p></div>\r\n                            <div class=\"coupon-input d-flex\" b-bkxwp7unbd><input type=\"text\" class=\"coupon-text\" placeholder=\"Coupon code\" b-bkxwp7unbd>\r\n                                <a class=\"btn btn-default col-5 container\" href=\"#\" b-bkxwp7unbd><div class=\"apply-coupon-btn\" b-bkxwp7unbd><p class=\"button-text\" b-bkxwp7unbd>Apply Coupon</p></div></a></div></div></div>\r\n\r\n                    <div class=\"col-4 col-s-12\" b-bkxwp7unbd><a class=\"btn btn-default me-2\" href=\"#\" b-bkxwp7unbd><div class=\"update-cart-btn\" b-bkxwp7unbd><p class=\"update-cart-text\" b-bkxwp7unbd>UPDATE CART</p></div></a></div></div></div>\r\n\r\n            <div class=\"shopping-total col-4 col-s-12\" b-bkxwp7unbd><div class=\"shopping-total-header\" b-bkxwp7unbd><span class=\"shopping-total-header-text\" b-bkxwp7unbd>CART TOTALS</span></div>\r\n\r\n                <div class=\"cart\" b-bkxwp7unbd><div class=\"subtotal d-flex align-items-end\" b-bkxwp7unbd><span class=\"subtotal-header\" b-bkxwp7unbd>Subtotal</span>\r\n                        <span class=\"subtotal-value ms-2\" b-bkxwp7unbd>$910.00</span></div>\r\n\r\n                    <hr class=\"subtotal-divider\" b-bkxwp7unbd>\r\n\r\n                    <div class=\"shipping d-flex\" b-bkxwp7unbd><div class=\"shipping-header\" b-bkxwp7unbd><span class=\"shipping-header-text\" b-bkxwp7unbd>Shipping</span></div>\r\n                        <div class=\"shipping-data container\" b-bkxwp7unbd><div class=\"flatrate d-flex\" b-bkxwp7unbd><div class=\"flatrate-header\" b-bkxwp7unbd><span class=\"flatrate-header-text\" b-bkxwp7unbd>Flatrate: </span></div>\r\n                                <div class=\"flatrate-value ms-2 me-2\" b-bkxwp7unbd><span class=\"flatrate-value-text\" b-bkxwp7unbd>$20.00</span></div>\r\n                                <input type=\"radio\" id=\"flatrate\" value=\"ship-flatrate\" name=\"shipment\" b-bkxwp7unbd></div>\r\n\r\n                            <div class=\"freeshipping d-flex\" b-bkxwp7unbd><span class=\"freeshipping-text\" b-bkxwp7unbd>Free shipping</span>\r\n                                <div class=\"me-2\" b-bkxwp7unbd></div>\r\n                                <input type=\"radio\" id=\"freeshipping\" value=\"ship-free\" name=\"shipment\" b-bkxwp7unbd></div>\r\n\r\n                            <div class=\"localpickup d-flex\" b-bkxwp7unbd><div class=\"localpickup-header\" b-bkxwp7unbd><span class=\"localpickup-header-text\" b-bkxwp7unbd>Local pickup: </span></div>\r\n                                <div class=\"localpickup-value ms-2 me-2\" b-bkxwp7unbd><span class=\"localpickup-value-text\" b-bkxwp7unbd>$25.00</span></div>\r\n                                <input type=\"radio\" id=\"localpickup\" value=\"ship-localpickup\" name=\"shipment\" b-bkxwp7unbd></div>\r\n\r\n                            <div b-bkxwp7unbd><a class=\"btn btn-default\" href=\"#\" b-bkxwp7unbd><div class=\"shipping-to-AL d-flex\" b-bkxwp7unbd><div class=\"shipping-to-AL-1\" b-bkxwp7unbd><span class=\"shipping-to-AL-1-text\" b-bkxwp7unbd>Shipping to</span></div>\r\n                                        <div class=\"shipping-to-AL-2 ms-2\" b-bkxwp7unbd><span class=\"shipping-to-AL-2-text\" b-bkxwp7unbd>AL</span></div></div></a></div>\r\n\r\n                            <a class=\"btn btn-default\" href=\"#\" b-bkxwp7unbd><div class=\"change-address-btn\" b-bkxwp7unbd><span class=\"change-address-text\" b-bkxwp7unbd>Change address</span></div></a></div></div>\r\n\r\n                    <hr class=\"subtotal-divider\" b-bkxwp7unbd>\r\n\r\n                    <div class=\"total d-flex\" b-bkxwp7unbd><div class=\"total-header\" b-bkxwp7unbd><span b-bkxwp7unbd>Total</span></div>\r\n                        <div class=\"total-value ms-2\" b-bkxwp7unbd><span b-bkxwp7unbd>$910.00</span></div></div></div>\r\n\r\n                <div b-bkxwp7unbd><a class=\"btn btn-default justify-content-center align-items-center d-flex\" href=\"#\" b-bkxwp7unbd><div class=\"proceed-to-checkout-btn\" b-bkxwp7unbd><p b-bkxwp7unbd>PROCEED TO CHECKOUT</p></div></a></div></div></div></div>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "brands");
            __builder.AddAttribute(3, "b-bkxwp7unbd");
            __builder.OpenComponent<Kenkata_Adm_Products.Pages.Brands>(4);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "b-bkxwp7unbd");
            __builder.OpenComponent<Kenkata_Adm_Products.Pages.Footer>(8);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
