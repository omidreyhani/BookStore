using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookStore.Saxo.ProductService.Test
{
    [TestClass]
    public class WhenITestProductApi
    {
        [TestMethod]
        public void GetWorksCorrectly()
        {
            ProductApi api =new ProductApi();
            var result  = api.Get(new [] {"9788741201122","9788702168044"});
            result.Count().Should().Be(2);
        }
    }
}
