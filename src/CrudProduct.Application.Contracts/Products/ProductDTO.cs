using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Products
{
    public class ProductDTO : EntityDto<Guid>
    {
        [Required]
        [StringLength(128, ErrorMessage = "Name is too long.")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        public string? Category { get; set; }
    }
}
