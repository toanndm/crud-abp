using CrudProduct.Products;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CrudProduct.Blazor.Pages
{
    public partial class Products
    {
        private void RedirectToDetail()
        {
            var detailUrl = $"/products/detail/";

            Navigation.NavigateTo(detailUrl);
        }
        protected override async Task DeleteEntityAsync(ProductDTO entity)
        {
            var confirmMessage = L["Delete this product?", entity.Name!];
            if (! await Message.Confirm(confirmMessage))
            {
                return;
            }
            await base.DeleteEntityAsync(entity);
        }
    }
}
