﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace CrudProduct.Model
{
    public class Category : Entity<Guid>
    {
        public string? Name { get; set; }
    }
}
