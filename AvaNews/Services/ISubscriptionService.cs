using AvaNews.Models;

namespace AvaNews.Services
{
    public interface ISubscriptionService
    {
        Task SubscribeAsync(string customerId, string instrumentOrKeyword);
        Task<IEnumerable<NewsItem>> GetSubscribedNewsAsync(string customerId);
    }
}
