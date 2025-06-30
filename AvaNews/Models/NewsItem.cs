namespace AvaNews.Models
{
    public class NewsItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Ticker { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Source { get; set; }
        public string ChartImageUrl { get; set; } // optional enrichment
        public string Sentiment { get; set; } // optional enrichment
    }
}
