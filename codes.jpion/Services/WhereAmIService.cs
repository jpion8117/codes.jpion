namespace codes.jpion.Services
{
    public class WhereAmIService
    {
        public string AppRoot
        {
            get
            {
                var root = Environment.GetEnvironmentVariable("ROOT_URL");

                if (root != null)
                    return root;

                return "";
            }
        }

        public string GetUrl(string relativePath) => AppRoot + relativePath;
    }
}
