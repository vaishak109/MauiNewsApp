using Newtonsoft.Json;

namespace MauiNewsApp.Models
{
    public class NewsResult
    {
        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
        [JsonProperty("articles")]
        public IEnumerable<News> Articles { get; set; } = new List<News>();
    }
}
