using AvaNews.Models;

namespace AvaNews.Services
{
    public interface INewsEnricher
    {
        Task<NewsItem> EnrichAsync(NewsItem rawNews);
    }
}
