using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BookStore.Saxo.ProductService
{
    public class ProdcutApi 
    {
        public IEnumerable<Product> Get(string param)
        {
            var client = new RestClient(RestConfig.GetUrl());
            var request = new RestRequest("products.json?key=08964e27966e4ca99eb0029ac4c4c217&isbn=9788741201122,9788702168044");
            request.AddUrlSegment("id", "123");
            var response = client.Execute<RootObject>(request);
            return response.Data.products;
        }
    }
}
