using AutoMapper;
using CrudProduct.Model;
using CrudProduct.Products;
using System;

namespace CrudProduct;

public class CrudProductApplicationAutoMapperProfile : Profile
{
    public CrudProductApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDTO>()
            .ForMember(d => d.Category, o => o.MapFrom(s => s.Category!.Name));
        CreateMap<ProductUpdatingDTO, Product>();
        CreateMap<Category, CategoryDTO>();
        CreateMap<CategoryUpdatingDTO, Category>();
    }
}
