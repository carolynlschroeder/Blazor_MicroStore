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
                return Task.FromResult(context.Items.OrderBy(i=>i.CategoryId).ThenBy(i=>i.Price).ToList());
            }
            else            {
                return Task.FromResult(context.Items.Where(i => categoryList.Contains(i.CategoryId)).OrderBy(i=>i.CategoryId).ThenBy(i=>i.Price).ToList());
            }
        }

        public Task<Item?> GetItem(int id)
        {
            ApplicationDbContext context = _contextFactory.CreateDbContext();
            var item = context.Items.Include(i => i.Reviews).FirstOrDefault(i => i.Id == id);
            return Task.FromResult(item);
        }

        public void AddReview(Review review)
        {
            ApplicationDbContext context = _contextFactory.CreateDbContext();
            context.Reviews.Add(review);
            context.SaveChanges();
        }
    }
}
