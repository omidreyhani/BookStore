using System.Configuration;

namespace BookStore.Saxo.ProductService
{
    public static class RestConfig
    {
        public static string GetUrl()
        {
            return ConfigurationManager.AppSettings["saxo:product:url"];
        }

        public static string GetKey()
        {
            return ConfigurationManager.AppSettings["saxo:product:key"];
        }
    }
}
