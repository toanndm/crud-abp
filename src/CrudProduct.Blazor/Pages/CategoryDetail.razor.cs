using AutoMapper;
using CrudProduct.Products;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Blazor.Pages
{
    public partial class CategoryDetail
    {
        [Parameter]
        public Guid CategoryId { get; set; }
        [Inject]
        protected ICategoryService? CategoryService { get; set; }
        [Inject]
        protected IMapper? Mapper { get; set; }
        [Inject]
        private NavigationManager? NavigationManager { get; set; }
        private CategoryDTO Category { get; set; }
        private bool isCreate;
        protected override async Task OnInitializedAsync()
        {
            if (CategoryId != Guid.Empty)
            {
                Category = await CategoryService!.GetAsync(CategoryId);
                isCreate = false;
            }
            else
            {
                Category = new CategoryDTO();
                isCreate = true;
            }
        }
        protected async Task UpdateEntityAsync(CategoryDTO category)
        {
            CategoryUpdatingDTO categoryUpdate = Mapper!.Map<CategoryDTO, CategoryUpdatingDTO>(category);
            await CategoryService!.UpdateAsync(CategoryId, categoryUpdate);
            NavigationManager!.NavigateTo("/categories");
        }
        protected async Task CreateEntityAsync(CategoryDTO category)
        {
            CategoryUpdatingDTO categoryUpdate = Mapper!.Map<CategoryDTO, CategoryUpdatingDTO>(category);
            await CategoryService!.CreateAsync(categoryUpdate);
            NavigationManager!.NavigateTo("/categories");
        }
    }
}
