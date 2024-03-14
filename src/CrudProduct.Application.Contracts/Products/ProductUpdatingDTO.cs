using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProduct.Products
{
    public class ProductUpdatingDTO
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
    }
}
