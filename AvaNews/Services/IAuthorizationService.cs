namespace AvaNews.Services
{
    public interface IAuthorizationService
    {
        bool IsAuthorized(string token);
    }
}
