using Newtonsoft.Json;

namespace MauiNewsApp.Models
{
    public class Source
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        public Source(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
