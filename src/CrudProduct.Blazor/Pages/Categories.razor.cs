using CrudProduct.Products;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CrudProduct.Blazor.Pages
{
    public partial class Categories
    {
        [Inject]
        protected NavigationManager Navigation { get; set; } = default!;

        private void RedirectToDetail()
        {
            var detailUrl = $"/categories/detail/";

            Navigation.NavigateTo(detailUrl);
        }

        protected override async Task DeleteEntityAsync(CategoryDTO entity)
        {
            var confirmMessage = L["Delete this Category?", entity.Name!];
            if (!await Message.Confirm(confirmMessage))
            {
                return;
            }
            await base.DeleteEntityAsync(entity);
        }
    }
}
