using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Saxo.ProductService
{
    public static class RestConfig
    {
        public static string GetUrl()
        {
            return ConfigurationManager.AppSettings["saxo:product:url"];
        }
    }
}
