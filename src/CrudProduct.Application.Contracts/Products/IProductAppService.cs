using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CrudProduct.Products
{
    public interface IProductAppService : ICrudAppService<
        ProductDTO, Guid, PagedAndSortedResultRequestDto, ProductUpdatingDTO>
    {
        
    }
}
