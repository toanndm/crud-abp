using CrudProduct.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CrudProduct.Products
{
    public class CategoryService : CrudAppService<
        Category, CategoryDTO, Guid, PagedAndSortedResultRequestDto,CategoryUpdatingDTO>, ICategoryService
    {
        public CategoryService(IRepository<Category, Guid> repository) : base(repository)
        {
        }
    }
}
