using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CrudProduct.Products
{
    public class ProductUpdatingDTO
    {
        [Required]
        [StringLength(128)]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
    }
}
