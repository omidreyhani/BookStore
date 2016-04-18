using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Saxo.ProductService
{
    public class FakeProductApi:IProductApi
    {
        public IEnumerable<Product> Get(string[] isbns)
        {
            foreach (var isbn in isbns)
            {
            //    Thread.Sleep(200);
                yield return new Product()
                {
                    isbn13 = isbn,
                    title = "Title",
                    url = "http://google.com/"+isbn,
                    imageurl = "https://imgcdn.saxo.com/ItemImage.aspx?ItemID=20467107",
                };
                
            }
        }
    }
}
