#pragma checksum "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db4e8d65c7d273dc487ff9906ce0d71d7ac6fcb7"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Details/{id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
 if(pro!=null){
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "html");
            __builder.AddAttribute(1, "lang", "en");
            __builder.AddMarkupContent(2, @"<head><meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <title>eCommerce Product Detail</title>
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:400,700"" rel=""stylesheet"">
	<link rel=""stylesheet"" href=""/css/Details.css"">
	<style></style></head>

  ");
            __builder.OpenElement(3, "body");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container mb-5");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container-fliud");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "wrapper row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "preview col-md-6");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "preview-pic tab-content");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "tab-pane active");
            __builder.AddAttribute(18, "id", "pic-1");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", "/Images/" + (
#nullable restore
#line 28 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                                     pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "tab-pane");
            __builder.AddAttribute(24, "id", "pic-2");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "src", "/Images/" + (
#nullable restore
#line 29 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                              pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "tab-pane");
            __builder.AddAttribute(30, "id", "pic-3");
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "src", "/Images/" + (
#nullable restore
#line 30 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                              pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "tab-pane");
            __builder.AddAttribute(36, "id", "pic-4");
            __builder.OpenElement(37, "img");
            __builder.AddAttribute(38, "src", "/Images/" + (
#nullable restore
#line 31 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                              pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "tab-pane");
            __builder.AddAttribute(42, "id", "pic-5");
            __builder.OpenElement(43, "img");
            __builder.AddAttribute(44, "src", "/Images/" + (
#nullable restore
#line 32 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                              pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(46, "ul");
            __builder.AddAttribute(47, "class", "preview-thumbnail nav nav-tabs");
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "class", "active");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "data-target", "#pic-1");
            __builder.AddAttribute(52, "data-toggle", "tab");
            __builder.OpenElement(53, "img");
            __builder.AddAttribute(54, "src", "/Images/" + (
#nullable restore
#line 35 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                                                          pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(56, "li");
            __builder.OpenElement(57, "a");
            __builder.AddAttribute(58, "data-target", "#pic-2");
            __builder.AddAttribute(59, "data-toggle", "tab");
            __builder.OpenElement(60, "img");
            __builder.AddAttribute(61, "src", "/Images/" + (
#nullable restore
#line 36 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                                           pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(63, "li");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "data-target", "#pic-3");
            __builder.AddAttribute(66, "data-toggle", "tab");
            __builder.OpenElement(67, "img");
            __builder.AddAttribute(68, "src", "/Images/" + (
#nullable restore
#line 37 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                                           pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(70, "li");
            __builder.OpenElement(71, "a");
            __builder.AddAttribute(72, "data-target", "#pic-4");
            __builder.AddAttribute(73, "data-toggle", "tab");
            __builder.OpenElement(74, "img");
            __builder.AddAttribute(75, "src", "/Images/" + (
#nullable restore
#line 38 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                                           pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\t\t\t\t\t\t  ");
            __builder.OpenElement(77, "li");
            __builder.OpenElement(78, "a");
            __builder.AddAttribute(79, "data-target", "#pic-5");
            __builder.AddAttribute(80, "data-toggle", "tab");
            __builder.OpenElement(81, "img");
            __builder.AddAttribute(82, "src", "/Images/" + (
#nullable restore
#line 39 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
                                                                                           pro.img

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(84, "<div class=\"details col-md-6\"><h3 class=\"product-title\">waman shoes fashion</h3>\r\n\t\t\t\t\t\t<div class=\"rating\"><div class=\"stars\"><span class=\"fa fa-star checked\"></span>\r\n\t\t\t\t\t\t\t\t<span class=\"fa fa-star checked\"></span>\r\n\t\t\t\t\t\t\t\t<span class=\"fa fa-star checked\"></span>\r\n\t\t\t\t\t\t\t\t<span class=\"fa fa-star\"></span>\r\n\t\t\t\t\t\t\t\t<span class=\"fa fa-star\"></span></div>\r\n\t\t\t\t\t\t\t<span class=\"review-no\">41 reviews</span></div>\r\n\t\t\t\t\t\t<p class=\"product-description\">Suspendisse quos? Tempus cras iure temporibus? Eu laudantium cubilia sem sem! Repudiandae et! Massa senectus enim minim sociosqu delectus posuere.</p>\r\n\t\t\t\t\t\t<h4 class=\"price\">current price: <span>$180</span></h4>\r\n\t\t\t\t\t\t<p class=\"vote\"><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>\r\n\t\t\t\t\t\t<h5 class=\"sizes\">sizes:\r\n\t\t\t\t\t\t\t<span class=\"size\" data-toggle=\"tooltip\" title=\"small\">s</span>\r\n\t\t\t\t\t\t\t<span class=\"size\" data-toggle=\"tooltip\" title=\"medium\">m</span>\r\n\t\t\t\t\t\t\t<span class=\"size\" data-toggle=\"tooltip\" title=\"large\">l</span>\r\n\t\t\t\t\t\t\t<span class=\"size\" data-toggle=\"tooltip\" title=\"xtra large\">xl</span></h5>\r\n\t\t\t\t\t\t<h5 class=\"colors\">colors:\r\n\t\t\t\t\t\t\t<span class=\"color orange not-available\" data-toggle=\"tooltip\" title=\"Not In store\"></span>\r\n\t\t\t\t\t\t\t<span class=\"color green\"></span>\r\n\t\t\t\t\t\t\t<span class=\"color blue\"></span></h5>\r\n\t\t\t\t\t\t<div class=\"action\"><button class=\"add-to-cart btn btn-default\" type=\"button\">add to cart</button>\r\n\t\t\t\t\t\t\t<button class=\"like btn btn-default\" type=\"button\"><span class=\"fa fa-heart\"></span></button></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "<h3>Product Not Found -- Wait!!</h3>");
#nullable restore
#line 84 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "F:\Blazer\Lab3_Blazer\Lab3_Blazer.WASM\Components\ProductDetails.razor"
       

    [Parameter]
    public int id { get; set; }
    public Product pro { get; set; }
    protected async override Task OnInitializedAsync()
	{
		pro=await productservices.GetByID(id);
		
		Console.Write(pro);
	 await base.OnInitializedAsync();

	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServices<Product> productservices { get; set; }
    }
}
#pragma warning restore 1591
