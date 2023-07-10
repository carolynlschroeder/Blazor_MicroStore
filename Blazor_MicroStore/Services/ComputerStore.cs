using Blazor_MicroStore.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Blazor_MicroStore.Services
{
    public class ComputerStore
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        public ComputerStore(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Task<List<Category>> GetCategories()
        {
            ApplicationDbContext context = _contextFactory.CreateDbContext();
            return Task.FromResult(context.Categories.ToList());
        }

        public Task<List<Item>> GetItems(List<int> categoryList)
        {
            ApplicationDbContext context = _contextFactory.CreateDbContext();
            if (!categoryList.Any())
            {
                return Task.FromResult(context.Items.ToList());
            }
            else            {
                return Task.FromResult(context.Items.Where(i => categoryList.Contains(i.CategoryId)).ToList());
            }
        }
    }
}
