namespace codes.jpion.Services
{
    public class WhereAmIService
    {
        private IConfiguration _config;

        public WhereAmIService(IConfiguration config)
        {
            _config = config;
        }

        public string AppRoot
        {
            get
            {
                var root = Environment.GetEnvironmentVariable("ROOT_URL") ?? 
                    _config.GetValue<string>("WhereAmIService:rootUrl");

                if (root != null)
                    return root;

                return "";
            }
        }

        public string GetUrl(string relativePath) => AppRoot + relativePath;
    }
}
