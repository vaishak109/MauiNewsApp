using MauiNewsApp.Models;
using Newtonsoft.Json;

namespace MauiNewsApp.Services
{
    public class NewsService: INewsService
    {
        HttpClient _client;
        public NewsResult NewsResult { get; private set; }

        public NewsService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("User-Agent", "My C# App (v1.0)");
        }

        public async Task<NewsResult> GetNewsAsync()
        {
            NewsResult = new NewsResult();
            try
            {
                HttpResponseMessage response = await _client.GetAsync("https://newsapi.org/v2/everything?q=bitcoin&apiKey=71970e1b912446b7b5f4bbe9a863d3c0");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Response success");
                    string content = await response.Content.ReadAsStringAsync();
                    NewsResult = JsonConvert.DeserializeObject<NewsResult>(content);
                }
                else
                {
                    Console.WriteLine("Response failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return NewsResult;
        }

        public ICollection<NewsCategory> GetNewsCategories() =>
            new List<NewsCategory>()
            {
                new NewsCategory("Lifestyle", "lifestyle.jpg"),
                new NewsCategory("Beauty", "beauty.png"),
                new NewsCategory("Healthcare", "healthcare.jpg"),
                new NewsCategory("Technology", "technology.jpg"),
                new NewsCategory("Space", "space.jpg"),
                new NewsCategory("Travel", "travel.jpg"),
                new NewsCategory("Food", "food.jpg"),
            };

    }
}
