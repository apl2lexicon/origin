#pragma checksum "C:\DevOps\Code\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductSlides.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b956b857ffaf518e7e2370db6aa5cc41f65e3509"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/productslides")]
    public partial class ProductSlides : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"products-slideshow mt-5\" b-32l2o97oox><div class=\"items mx-auto\" b-32l2o97oox><div class=\"header d-flex col-12\" b-32l2o97oox><span class=\"youmay\" b-32l2o97oox>YOU MAY</span>\r\n            <span class=\"alsolike ms-2\" b-32l2o97oox>ALSO LIKE</span></div>\r\n\r\n        <div class=\"wave d-flex col-12\" b-32l2o97oox><img src=\"images/wave-pattern.png\" alt b-32l2o97oox></div></div>\r\n\r\n    <div class=\"slideshow-container col-12 col-s-6 mt-5\" b-32l2o97oox><div class=\"prev-btn\" b-32l2o97oox><img src=\"images/prev-btn.png\" alt b-32l2o97oox></div>\r\n\r\n        <div class=\"gallery container d-flex\" b-32l2o97oox><div class=\"gallery-cell col-3\" b-32l2o97oox><div class=\"new-label mt-2 ms-2\" b-32l2o97oox><p b-32l2o97oox>New</p></div>\r\n                <img src=\"images/Hat.png\" alt b-32l2o97oox>\r\n                <div class=\"subtitle\" b-32l2o97oox><span class=\"subtitle-text\" b-32l2o97oox>Circle pattern girls shirt</span></div></div>\r\n\r\n            <div class=\"gallery-cell col-3\" b-32l2o97oox><div class=\"new-label mt-2 ms-2\" b-32l2o97oox><p b-32l2o97oox>New</p></div>\r\n                <img src=\"images/Dress.png\" alt b-32l2o97oox>\r\n                <div class=\"subtitle\" b-32l2o97oox><span class=\"subtitle-text\" b-32l2o97oox>Circle pattern girls shirt</span></div></div>\r\n\r\n            <div id=\"selected-gallery-cell\" class=\"gallery-cell-selected col-3\" b-32l2o97oox><div b-32l2o97oox><div class=\"quick-guide\" b-32l2o97oox><div class=\"red-dot\" b-32l2o97oox><img src=\"images/Red-dot.png\" alt b-32l2o97oox></div>\r\n\r\n                        <div class=\"heart\" b-32l2o97oox><img src=\"images/Heart icon.png\" alt b-32l2o97oox>\r\n                            <span class=\"tooltiptext\" b-32l2o97oox>Like</span></div>\r\n\r\n                        <div class=\"compare\" b-32l2o97oox><img src=\"images/Compare icon.png\" alt b-32l2o97oox>\r\n                            <span class=\"tooltiptext\" b-32l2o97oox>Compare</span></div>\r\n\r\n                        <div class=\"search\" b-32l2o97oox><img src=\"images/search icon.png\" alt b-32l2o97oox>\r\n                            <span class=\"tooltiptext\" b-32l2o97oox>Search</span></div>\r\n\r\n                        <div class=\"cart\" b-32l2o97oox><img src=\"images/Cart icon.png\" alt b-32l2o97oox>\r\n                            <span class=\"tooltiptext\" b-32l2o97oox>Add to cart</span></div></div></div>\r\n\r\n                <div b-32l2o97oox><div class=\"product-data container\" b-32l2o97oox><div class=\"description\" b-32l2o97oox><p b-32l2o97oox>New Look men\'s coat</p></div>\r\n\r\n                        <div class=\"category\" b-32l2o97oox><div class=\"category-text\" b-32l2o97oox><p b-32l2o97oox>Fashion</p></div></div>\r\n\r\n                        <div class=\"old-price\" b-32l2o97oox><p b-32l2o97oox>$220.00</p></div>\r\n\r\n                        <div class=\"price-and-rating d-flex\" b-32l2o97oox><div class=\"new-price\" b-32l2o97oox><p b-32l2o97oox>$190.00</p></div>\r\n\r\n                            <div class=\"rating\" b-32l2o97oox><img src=\"images/star-selected.png\" alt b-32l2o97oox>\r\n                                <img src=\"images/star-selected.png\" alt b-32l2o97oox>\r\n                                <img src=\"images/star-selected.png\" alt b-32l2o97oox>\r\n                                <img src=\"images/star-selected.png\" alt b-32l2o97oox>\r\n                                <img src=\"images/star-nonselected.png\" alt b-32l2o97oox></div></div></div></div></div>\r\n\r\n            <div class=\"gallery-cell col-3\" b-32l2o97oox><div class=\"discount-label mt-2 ms-2\" b-32l2o97oox><p b-32l2o97oox>-20%</p></div>\r\n                <img src=\"images/Dress-2.png\" alt b-32l2o97oox>\r\n                <div class=\"subtitle\" b-32l2o97oox><span class=\"subtitle-text\" b-32l2o97oox>Circle pattern girls shirt</span></div></div></div>\r\n\r\n        <div class=\"next-btn\" b-32l2o97oox><img src=\"images/next-btn.png\" alt b-32l2o97oox></div></div>\r\n\r\n    <div class=\"current-slide\" b-32l2o97oox><span class=\"dot\" onclick=\"currentSlide(1)\" b-32l2o97oox></span>\r\n        <span class=\"dot\" onclick=\"currentSlide(2)\" b-32l2o97oox></span>\r\n        <span class=\"dot\" onclick=\"currentSlide(3)\" b-32l2o97oox></span></div></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
