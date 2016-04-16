using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BookStore.Infrastructure;
using BookStore.Infrastructure.Command;
using BookStore.Search.QueryStack;
using BookStore.WebSite.Areas.CustomerSite.Models;

namespace BookStore.WebSite.Areas.CustomerSite.WorkerServices
{
    public class SearchWorkerService
    {
        private readonly IQueryRepository _queryRepository;
        private readonly IBus _bus;

        public SearchWorkerService(IQueryRepository queryRepository, IBus bus)
        {
            _queryRepository = queryRepository;
            _bus = bus;
        }

        public IEnumerable<BookViewModel> GetBooksViewModel(string[] isbns)
        {
            _bus.Execute(new UpdateCommand(isbns));
            var query =_queryRepository.Get(isbns);
            return from c in query 
                   select new BookViewModel()
                   {
                       Title = c.Title,
                       Url = c.Url,
                       Imageurl = c.Imageurl
                   };
        }
    }
}
