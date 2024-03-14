using Blazorise.DataGrid;
using CrudProduct.Products;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Blazor.Pages
{
    public partial class Categories
    {
        private IReadOnlyList<CategoryDTO> CategorytList { get; set; }
        private CategoryDTO CurrentCategory { get; set; }
        private int PageSize { get; } = LimitedResultRequestDto.DefaultMaxResultCount;
        private int CurrentPage { get; set; } = 1;
        private int TotalCount { get; set; }
        private bool modalVisible;

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            await base.OnInitializedAsync();
        }

        private Task ToggleModal(CategoryDTO category)
        {
            modalVisible = !modalVisible;
            CurrentCategory = category;
            return Task.CompletedTask;
        }
        private Task ToggleModal()
        {
            modalVisible = !modalVisible;
            return Task.CompletedTask;
        }

        private void RedirectToDetail()
        {
            var detailUrl = $"/categories/detail/";

            Navigation.NavigateTo(detailUrl);
        }

        protected async Task DeleteEntityAsync(CategoryDTO entity)
        {
            await CategoryService.DeleteAsync(entity.Id);
            modalVisible = !modalVisible;
            await LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            var result = await CategoryService.GetListAsync(new PagedAndSortedResultRequestDto
            {
                MaxResultCount = PageSize,
                SkipCount = (CurrentPage - 1) * PageSize,
            });
            CategorytList = result.Items;
            TotalCount = (int)result.TotalCount;
        }
        private async Task OnPageChanged(DataGridPageChangedEventArgs e)
        {
            CurrentPage = e.Page;
            await LoadDataAsync();
        }
    }
}
