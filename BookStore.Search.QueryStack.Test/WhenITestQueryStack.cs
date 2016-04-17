using System.Linq;
using BookStore.Saxo.ProductService;
using BookStore.Search.CommandStack;
using BookStore.Search.CommandStack.Commands;
using BookStore.Search.CommandStack.Sagas;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var repository = new QueryRepository();
            var count = repository.Get().Count();
            var isbns = new[] { "9788741201122" };
            var command= new UpdateCommand(isbns);
            (new UpdateCommandHandler(new FakeProductApi(), new UnitOfWork())).Execute(command); 
            repository.Get().Count().Should().Be(count + 1);
        }
    }
}
