// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Lab3_Blazer.WASM.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
using Lab3_Blazer.shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
using Lab3_Blazer.WASM.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class UserProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\UserProducts.razor"
       
    public List<Product> prodlist { get; set; }
    protected async  override Task OnInitializedAsync()//pareter /inject 
    {
        prodlist= await proservices.GetAll();
        await  base.OnInitializedAsync();
    }
    public async Task handleDelete(int id)
    {
        proservices.Delete(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServices<Product> proservices { get; set; }
    }
}
#pragma warning restore 1591
