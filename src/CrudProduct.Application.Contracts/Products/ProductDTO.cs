using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Products
{
    public class ProductDTO : EntityDto<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public string? Category { get; set; }
    }
}
