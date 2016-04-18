using System.Collections.Generic;

namespace BookStore.Saxo.ProductService
{
    public interface IProductApi
    {
        IEnumerable<Product> Get(string[] isbns);
    }
}