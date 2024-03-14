using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CrudProduct.Products
{
    public interface ICategoryService : ICrudAppService<
        CategoryDTO, Guid, PagedAndSortedResultRequestDto, CategoryUpdatingDTO>
    {

    }
}
