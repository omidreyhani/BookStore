using System;
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
            var result  = api.Get("");
            result.Count().Should().Be(2);
        }
    }
}
