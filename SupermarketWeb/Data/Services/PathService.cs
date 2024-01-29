namespace SupermarketWeb.Data.Services
{
    public class PathService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PathService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string getPaht()
        {
            string urlPage = _httpContextAccessor.HttpContext.Request.Path.ToString().Substring(1).Trim();
            return urlPage+"#";
        }
    }
}