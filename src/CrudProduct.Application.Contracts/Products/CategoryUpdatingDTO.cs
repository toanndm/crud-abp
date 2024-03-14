using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CrudProduct.Products
{
    public class CategoryUpdatingDTO
    {
        [Required]
        [StringLength(128)]
        public string? Name { get; set; }
    }
}
