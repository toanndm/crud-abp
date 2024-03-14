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
    public class CategoryDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, Guid> _categoryRepository;

        public CategoryDataSeederContributor(IRepository<Category, Guid> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _categoryRepository.GetCountAsync() <= 0)
            {
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        Name = "Laptop"
                    },
                    autoSave: true
                );
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        Name = "PC"
                    },
                    autoSave: true
                );
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        Name = "Mobile"
                    },
                    autoSave: true
                );
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        Name = "Monitor"
                    },
                    autoSave: true
                );
                await _categoryRepository.InsertAsync(
                    new Category
                    {
                        Name = "Keyboard"
                    },
                    autoSave: true
                );
            }
        }
    }
}
