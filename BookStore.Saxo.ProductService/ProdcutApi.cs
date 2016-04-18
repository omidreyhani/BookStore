using System.Collections.Generic;
using RestSharp;

namespace BookStore.Saxo.ProductService
{
    public class ProductApi:IProductApi 
    {
        public IEnumerable<Product> Get(string[] isbns)
        {
            if (isbns == null || isbns.Length == 0)
                return null;

            var client = new RestClient(RestConfig.GetUrl());
            var request = new RestRequest($"products.json?key={RestConfig.GetKey()}&isbn={string.Join(",",isbns)}");
            var response = client.Execute<RootObject>(request);
            return response.Data.products;
        }
    }
}