#pragma checksum "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37620fb7a4bfee980e50edb477c7abf1a930ee1c"
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
#line 1 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Kenkata_Adm_Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Kenkata_Adm_Products.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using Kenkata_Adm_Products.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productsinstockcomponent")]
    public partial class ProductsInStockComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductsInStockComponent</h3>");
#nullable restore
#line 6 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
}
else 
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>Id</th>
                <th>Customer Category</th>
                <th>Season</th>
                <th>Category</th>
                <th>Brand</th>
                <th>Color</th>
                <th>Size</th>
                <th>InStock</th>
                <th>Price</th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 27 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 30 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 31 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.CustomerCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 32 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.Season

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 33 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 34 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.Color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 36 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.Size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.InStock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 38 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
                         product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
} 

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductsInStockComponent.razor"
       
    private ProductModel[] products;

    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<ProductModel[]>("GetProductsInStock");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591