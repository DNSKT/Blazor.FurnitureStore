// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.FurnitureStore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Blazor.FurnitureStore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\TEMP\source\repos\Blazor.FurnitureStore\Blazor.FurnitureStore\Client\Pages\ProductDetails.razor"
       

    public Product Product = new Product();
    public string Message { get; set; }
    public IEnumerable<ProductCategory> productCategories = new List<ProductCategory>();
    public IEnumerable<Product> products = new List<Product>();

    [CascadingParameter]
    MudDialogInstance MudDialog { get; set; }

    protected async override Task OnInitializedAsync()
    {
        try
        {
            productCategories = await ProductCategoryService.GetProductCategories();

            if (productCategories != null && productCategories.Any())
            {
                Product.ProductCategoryId = productCategories.FirstOrDefault().Id;
                await LoadProducts(Product.ProductCategoryId);
            }
        }
        catch (Exception e)
        {

            Message = "Error... " + e.Message;
        }
    }

    protected async Task ProductCategoryHasChanged(int productCategoryId)
    {
        Product.ProductCategoryId = productCategoryId;

        if (Product.ProductCategoryId > 0)
            await LoadProducts(Product.ProductCategoryId);
    }

    protected async Task ProductHasChanged(int productId)
    {
        if (productId > 0)
            Product = await ProductService.GetDetails(productId);
    }

    private async Task LoadProducts(int productCategoryId)
    {
        products = await ProductService.GetByCategory(productCategoryId);
        if (products != null && products.Any())
            Product = await ProductService.GetDetails(products.FirstOrDefault().Id);
    }

    private void Cancel()
    {
        MudDialog.Cancel();
    }

    private void AddProduct()
    {
        Snackbar.Add("Product added", Severity.Success, a => a.VisibleStateDuration = 200);
        MudDialog.Close(DialogResult.Ok(Product));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductCategoryService ProductCategoryService { get; set; }
    }
}
#pragma warning restore 1591
