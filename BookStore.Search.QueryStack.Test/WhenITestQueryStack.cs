using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Transactions;
using BookStore.Infrastructure;
using BookStore.Infrastructure.Command;
using BookStore.Saxo.ProductService;
using BookStore.Search.CommandStack;
using BookStore.WebSite.Areas.CustomerSite.Commands;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BookStore.Search.QueryStack.Test
{
    [TestClass]
    public class WhenITestQueryStack
    {

        [TestInitialize]
        public void Init()
        {
            SearchContext searchContext = new SearchContext();
            searchContext.Database.Delete();
        }
        [TestMethod]
        public void CachingWorksCorrectly()
        {
            var bus = new Bus();
            bus.RegisterCommand(new UpdateCommandHandler(new ProdcutApi(), new QueryRepository(), new UnitOfWork()));

            var repository = new QueryRepository();
            var count = repository.Get().Count();
            var isbns = new[] { "9788741201122" };
            bus.Execute(new UpdateCommand(isbns));
            repository.Get().Count().Should().Be(count + 1);
        }
    }
}
