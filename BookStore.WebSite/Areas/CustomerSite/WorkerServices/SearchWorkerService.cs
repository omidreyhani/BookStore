using System.Collections.Generic;
using System.Linq;
using BookStore.Search.CommandStack.Commands;
using BookStore.Search.CommandStack.Sagas;
using BookStore.Search.QueryStack;
using BookStore.WebSite.Areas.CustomerSite.Models;
using Memento.Messaging.Postie;

namespace BookStore.WebSite.Areas.CustomerSite.WorkerServices
{
    public class SearchWorkerService
    {
        private readonly IQueryRepository _queryRepository;
        readonly IUpdateCommandHandler _updateCommandHandler;

        public SearchWorkerService(IQueryRepository queryRepository, IUpdateCommandHandler updateCommandHandler)
        {
            _queryRepository = queryRepository;
            _updateCommandHandler = updateCommandHandler;
        }

        public IEnumerable<BookViewModel> GetBooksViewModel(string[] isbns)
        {
            if(isbns == null || isbns.Length==0) return null;

            _updateCommandHandler.Execute(new UpdateCommand(isbns));

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
