#pragma checksum "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf3bf8a7c160bf18532bfda893fe2ff565a6a23"
// <auto-generated/>
#pragma warning disable 1591
namespace HappySnailJavascriptInBlazor.Pages
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
#line 12 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\_Imports.razor"
using Lab3_Blazer.WASM.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<head b-bxarqcvg6w><meta charset=""utf-8"" b-bxarqcvg6w>
  <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"" b-bxarqcvg6w>

  <title b-bxarqcvg6w>Delicious Bootstrap Template - Index</title>
  <meta content name=""description"" b-bxarqcvg6w>
  <meta content name=""keywords"" b-bxarqcvg6w>

  
  <link href=""assets/img/favicon.png"" rel=""icon"" b-bxarqcvg6w>
  <link href=""assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"" b-bxarqcvg6w>

  
  <link href=""https://fonts.googleapis.com/css?family=Poppins:300,300i,400,400i,600,600i,700,700i|Satisfy|Comic+Neue:300,300i,400,400i,700,700i"" rel=""stylesheet"" b-bxarqcvg6w>

  
  <link href=""assets/vendor/animate.css/animate.min.css"" rel=""stylesheet"" b-bxarqcvg6w>
  <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" b-bxarqcvg6w>
  <link href=""assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"" b-bxarqcvg6w>
  <link href=""assets/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"" b-bxarqcvg6w>
  <link href=""assets/vendor/glightbox/css/glightbox.min.css"" rel=""stylesheet"" b-bxarqcvg6w>
  <link href=""assets/vendor/swiper/swiper-bundle.min.css"" rel=""stylesheet"" b-bxarqcvg6w>
  

  
  <link href=""/css/style.css"" rel=""stylesheet"" b-bxarqcvg6w></head>



  
  ");
            __builder.AddMarkupContent(1, "<header id=\"header\" class=\" navbar-fixed-top bg-dark mb-5 \" b-bxarqcvg6w><div class=\"container-fluid container-xl d-flex align-items-center justify-content-between\" b-bxarqcvg6w><div class=\"logo me-auto\" b-bxarqcvg6w><h1 b-bxarqcvg6w><a href=\"index.html\" b-bxarqcvg6w>Delicious</a></h1></div>\r\n\r\n      <nav id=\"navbar\" class=\"navbar order-last order-lg-0\" b-bxarqcvg6w><ul b-bxarqcvg6w><li b-bxarqcvg6w><a class=\"nav-link scrollto active\" href=\"/Product\" b-bxarqcvg6w>Home</a></li>\r\n          <li b-bxarqcvg6w><a class=\"nav-link scrollto\" href=\"#about\" b-bxarqcvg6w>About</a></li>\r\n          <li b-bxarqcvg6w><a class=\"nav-link scrollto\" href=\"/login\" b-bxarqcvg6w>Login</a></li>\r\n          <li b-bxarqcvg6w><a class=\"nav-link scrollto\" href=\"#specials\" b-bxarqcvg6w>Specials</a></li>\r\n          <li b-bxarqcvg6w><a class=\"nav-link scrollto\" href=\"#events\" b-bxarqcvg6w>Events</a></li>\r\n          <li b-bxarqcvg6w><a class=\"nav-link scrollto\" href=\"#chefs\" b-bxarqcvg6w>Chefs</a></li>\r\n          <li b-bxarqcvg6w><a class=\"nav-link scrollto\" href=\"#gallery\" b-bxarqcvg6w>Gallery</a></li>\r\n          <li class=\"dropdown\" b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w><span b-bxarqcvg6w>Drop Down</span> <i class=\"bi bi-chevron-down\" b-bxarqcvg6w></i></a>\r\n            <ul b-bxarqcvg6w><li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Drop Down 1</a></li>\r\n              <li class=\"dropdown\" b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w><span b-bxarqcvg6w>Deep Drop Down</span> <i class=\"bi bi-chevron-right\" b-bxarqcvg6w></i></a>\r\n                <ul b-bxarqcvg6w><li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Deep Drop Down 1</a></li>\r\n                  <li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Deep Drop Down 2</a></li>\r\n                  <li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Deep Drop Down 3</a></li>\r\n                  <li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Deep Drop Down 4</a></li>\r\n                  <li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Deep Drop Down 5</a></li></ul></li>\r\n              <li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Drop Down 2</a></li>\r\n              <li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Drop Down 3</a></li>\r\n              <li b-bxarqcvg6w><a href=\"#\" b-bxarqcvg6w>Drop Down 4</a></li></ul></li>\r\n          <li b-bxarqcvg6w><a class=\"nav-link scrollto\" href=\"#contact\" b-bxarqcvg6w>Contact</a></li></ul>\r\n        <i class=\"bi bi-list mobile-nav-toggle\" b-bxarqcvg6w></i></nav>\r\n\r\n      <a href=\"#book-a-table\" class=\"book-a-table-btn scrollto\" b-bxarqcvg6w>Book a table</a></div></header>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591