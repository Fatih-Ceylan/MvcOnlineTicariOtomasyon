namespace MvcOnlineTicariOtomasyon.Services
{
    public class SessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetSessionValue(string key, string value)
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            session?.SetString(key, value);
        }

        public string? GetSessionValue(string key)
        {
            var session = _httpContextAccessor.HttpContext?.Session;

            return session?.GetString(key);
        }

        public void RemoveSessionValue(string key)
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            session?.Remove(key);
        }
    }
}
