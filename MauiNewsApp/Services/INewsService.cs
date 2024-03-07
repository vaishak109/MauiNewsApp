using MauiNewsApp.Models;

namespace MauiNewsApp.Services
{
    public interface INewsService
    {
        public Task<NewsResult> GetNewsAsync();
        public ICollection<NewsCategory> GetNewsCategories();
    }
}
