using AvaNews.Models;

namespace AvaNews.Services
{
    public interface INewsRepository
    {
        Task SaveAsync(NewsItem item);
        Task<IEnumerable<NewsItem>> GetAllAsync();
        Task<IEnumerable<NewsItem>> GetByDateRangeAsync(DateTime from, DateTime to);
        Task<IEnumerable<NewsItem>> GetByInstrumentAsync(string instrumentName, int limit = 10);
        Task<IEnumerable<NewsItem>> SearchByTextAsync(string searchTerm);
        Task<IEnumerable<NewsItem>> GetLatestDistinctInstrumentsAsync(int count = 5);
    }
}
