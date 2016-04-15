using System.Collections.Generic;
using System.Linq;
using BookStore.Search.QueryStack;
using BookStore.WebSite.Areas.CustomerSite.Models;

namespace BookStore.WebSite.Areas.CustomerSite.WorkerServices
{
    public class SearchWorkerService
    {
        private readonly IDatabase _database;

        public SearchWorkerService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<BookViewModel> GetBooksViewModel(string isbns)
        {
            return from c in _database.Books
                select new BookViewModel()
                {
                    Title = c.Title,
                    Url = c.Url,
                    TotalItems = c.TotalItems
                };
        }
    }
}
