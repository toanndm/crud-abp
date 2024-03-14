using Blazorise.DataGrid;
using CrudProduct.Products;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Blazor.Pages
{
    public partial class Products
    {
        private IReadOnlyList<ProductDTO> ProductList {  get; set; }
        private ProductDTO CurrentProduct { get; set; }
        private int PageSize { get; } = LimitedResultRequestDto.DefaultMaxResultCount;
        private int CurrentPage { get; set; } = 1;
        private int TotalCount { get; set; }
        private bool modalVisible;

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            await base.OnInitializedAsync();
        }

        private Task ToggleModal(ProductDTO product)
        {
            modalVisible = !modalVisible;
            CurrentProduct = product;
            return Task.CompletedTask;
        }
        private Task ToggleModal()
        {
            modalVisible = !modalVisible;
            return Task.CompletedTask;
        }
        private void RedirectToDetail()
        {
            var detailUrl = $"/products/detail/";

            Navigation.NavigateTo(detailUrl);
        }
        protected async Task DeleteEntityAsync(ProductDTO entity)
        {
            await ProductService.DeleteAsync(entity.Id);
            modalVisible = !modalVisible;
            await LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            var result = await ProductService.GetListAsync(new PagedAndSortedResultRequestDto {
                MaxResultCount = PageSize,
                SkipCount = (CurrentPage - 1) * PageSize,
            });
            ProductList = result.Items;
            TotalCount = (int) result.TotalCount;
        }
        private async Task OnPageChanged(DataGridPageChangedEventArgs e)
        {
            CurrentPage = e.Page;
            await LoadDataAsync();
        }
    }
}
