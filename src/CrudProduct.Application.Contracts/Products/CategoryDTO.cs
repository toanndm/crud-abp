using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Products
{
    public class CategoryDTO : EntityDto<Guid>
    {
        public string? Name { get; set; }
    }
}
