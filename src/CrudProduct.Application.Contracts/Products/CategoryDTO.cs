using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CrudProduct.Products
{
    public class CategoryDTO : EntityDto<Guid>
    {
        [Required]
        [StringLength(128, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }
    }
}
