// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Kenkata_Adm_Products.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\DevOpsCode\Kenkata_Adm_Products\Kenkata_Adm_Products\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
