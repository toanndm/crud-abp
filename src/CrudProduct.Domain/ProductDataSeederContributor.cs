using CrudProduct.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CrudProduct
{
    public class ProductDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductDataSeederContributor(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _productRepository.GetCountAsync() <= 0)
            {
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "Thinkpad",
                        Price = 499.99m,
                        CategoryId = Guid.Parse("3a1142d3-617f-4a3b-a7b6-6c15e415659c")
                    },
                    autoSave: true
                );
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "MacBook",
                        Price = 599.99m,
                        CategoryId = Guid.Parse("3a1142d3-617f-4a3b-a7b6-6c15e415659c")
                    },
                    autoSave: true
                );
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "SamSung",
                        Price = 499.99m,
                        CategoryId = Guid.Parse("3a1142d3-637e-0959-88aa-93bc1acda56f")
                    },
                    autoSave: true
                );
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "IPhone",
                        Price = 499.99m,
                        CategoryId = Guid.Parse("3a1142d3-637e-0959-88aa-93bc1acda56f")
                    },
                    autoSave: true
                );
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "Dell",
                        Price = 199.99m,
                        CategoryId = Guid.Parse("3a1142d3-6375-61d6-eee9-7f381152880a")
                    },
                    autoSave: true
                );
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "HP",
                        Price = 399.99m,
                        CategoryId = Guid.Parse("3a1142d3-6375-61d6-eee9-7f381152880a")
                    },
                    autoSave: true
                );
                await _productRepository.InsertAsync(
                    new Product
                    {
                        Name = "Sony",
                        Price = 999.99m,
                        CategoryId = Guid.Parse("3a1142d3-6384-5f2e-7f62-d38681e3906c")
                    },
                    autoSave: true
                );
            }
        }
    }
}
