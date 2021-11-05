#pragma checksum "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1e1eccebc998808f6443532bc78df9795cd7c4"
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
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "ProdListPage");
            __builder.AddAttribute(2, "class", "inputfields container");
#nullable restore
#line 2 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor"
         if (products == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<div>Loading...</div>");
#nullable restore
#line 5 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "id", "product-list");
            __builder.AddAttribute(6, "class", "table");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 10 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor"
                     foreach (var product in products)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Kenkata_Adm_Products.Shared.ProductItem>(8);
            __builder.AddAttribute(9, "product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Kenkata_Adm_Products.Models.ProductModel>(
#nullable restore
#line 12 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor"
                                               product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Pages\ProductList.razor"
       
    public ProductModel[] products;

    protected async Task GetProductsAsync()
    {
        products = await Http.GetFromJsonAsync<ProductModel[]>("http://localhost:7071/api/GetAllProducts");
    }

    protected override void OnInitialized()
    {
        var timer = new Timer(new TimerCallback(_ => InvokeAsync(() => StateHasChanged())), null, 1000, 3000);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await GetProductsAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
