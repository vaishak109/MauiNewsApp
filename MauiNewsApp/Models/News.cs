using Humanizer;
using Humanizer.Localisation;
using Newtonsoft.Json;

namespace MauiNewsApp.Models
{
    public class News
    {
        [JsonProperty("source")]
        public Source Source { get; set; } = new Source(string.Empty, string.Empty);
        [JsonProperty("author")]
        public string Author { get; set; } = string.Empty;
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;
        [JsonProperty("url")]
        public string Url { get; set; } = string.Empty;
        [JsonProperty("urlToImage")]
        public string UrlToImage { get; set; } = string.Empty;
        [JsonProperty("publishedAt")]
        private String _publishedAt;
        public string PublishedAt
        {
            set { _publishedAt = value; }
            get
            {
                return TimeSpan
                    .FromMilliseconds(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - DateTimeOffset.Parse(_publishedAt)
                    .ToUnixTimeMilliseconds())
                    .Humanize(maxUnit: TimeUnit.Year);
            }
        }
        [JsonProperty("content")]
        public string Content { get; set; } = string.Empty;

        public News(Source source, string author, string title, string description, string url, string urlToImage, string publishedAt, string content)
        {
            Source = source;
            Author = author;
            Title = title;
            Description = description;
            Url = url;
            UrlToImage = urlToImage;
            PublishedAt = publishedAt;
            Content = content;
        }
    }
}
