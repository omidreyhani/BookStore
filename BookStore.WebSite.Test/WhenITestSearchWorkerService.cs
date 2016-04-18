using System.Linq;
using System.Transactions;
using Autofac;
using BookStore.Search.CommandStack.Sagas;
using BookStore.Search.QueryStack;
using BookStore.WebSite.Areas.CustomerSite.WorkerServices;
using FluentAssertions;
using Memento.Messaging.Postie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static BookStore.Autofac.AutofacConfig;

namespace BookStore.WebSite.Test
{
    [TestClass]
    public class WhenITestSearchWorkerService
    {
        [TestMethod]
        public void GetBooksViewModelWorksCorrectly()
        {
            var container = GetContainer();
           
            var queryRepository = container.Resolve<IQueryRepository>();
            var updateCommandHandler = container.Resolve<IUpdateCommandHandler>();
            var service = new SearchWorkerService(queryRepository,updateCommandHandler);
            var books = service.GetBooksViewModel(new []{"9788741201122", "9788702168044"});
            books.Count().Should().Be(2);
            books.First().Title.Should().Be("Kapitalen i det 21. århundrede");
        }
    }
}
