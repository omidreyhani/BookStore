using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStore.Saxo.ProductService.Test
{
    [TestClass]
    public class UnitTestProductApi
    {
        [TestMethod]
        public void TestGet()
        {
            ProdcutApi api =new ProdcutApi();
            var result  = api.Get(new [] {"9788741201122","9788702168044"});
            result.Count().Should().Be(2);
        }
    }
}
