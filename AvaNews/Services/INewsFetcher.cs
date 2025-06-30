using AvaNews.Models;

namespace AvaNews.Services
{
    public interface INewsFetcher
    {
        Task<IEnumerable<NewsItem>> FetchLatestAsync();
    }
}
