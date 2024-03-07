namespace MauiNewsApp.Models
{
    public class NewsCategory
    {
        public string Name { get; set; } = string.Empty;
        public string ImgUrl { get; set; } = string.Empty;

        public NewsCategory(string Name, string ImgUrl)
        {
            this.Name = Name;
            this.ImgUrl = ImgUrl;
        }
    }
}
