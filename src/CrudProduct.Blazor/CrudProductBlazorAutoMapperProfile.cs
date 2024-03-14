using AutoMapper;
using CrudProduct.Products;

namespace CrudProduct.Blazor;

public class CrudProductBlazorAutoMapperProfile : Profile
{
    public CrudProductBlazorAutoMapperProfile()
    {
        CreateMap<CategoryDTO, CategoryUpdatingDTO>();
        CreateMap<ProductDTO, ProductUpdatingDTO>();
    }
}
