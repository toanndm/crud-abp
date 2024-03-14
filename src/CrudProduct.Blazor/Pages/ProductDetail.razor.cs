using AutoMapper;
using CrudProduct.Products;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Blazor.Pages
{
    public partial class ProductDetail
    {
        IReadOnlyList<CategoryDTO>? categories = null;
        [Parameter]
        public Guid ProductId { get; set; }

        private ProductDTO Product { get; set; }
        private bool isCreate;

        protected override async Task OnInitializedAsync()
        {
            if (ProductId != Guid.Empty)
            {
                Product = await ProductAppService!.GetAsync(ProductId);
                isCreate = false;
            }
            else
            {
                Product = new ProductDTO();
                isCreate = true;
            }
            var result = await CategoryService!.GetListAsync(new PagedAndSortedResultRequestDto());
            if (result != null)
            {
                categories = result.Items;
            }
        }

        protected async Task UpdateEntityAsync(ProductDTO product)
        {
            ProductUpdatingDTO productUpdate = Mapper!.Map<ProductDTO, ProductUpdatingDTO>(product);
            await ProductAppService!.UpdateAsync(ProductId, productUpdate);
            NavigationManager!.NavigateTo("/products");
        }
        protected async Task CreateEntityAsync(ProductDTO product)
        {
            ProductUpdatingDTO productUpdate = Mapper!.Map<ProductDTO, ProductUpdatingDTO>(product);
            await ProductAppService!.CreateAsync(productUpdate);
            NavigationManager!.NavigateTo("/products");
        }
    }
}
