using System.Collections.Generic;
using System.Linq;
using BookStore.Infrastructure;
using BookStore.Infrastructure.Command;
using BookStore.Search.QueryStack.Model;

namespace BookStore.Search.QueryStack
{
    public class QueryRepository:IQueryRepository
    {
        private readonly SearchContext _searchContext;

        public QueryRepository()
        {
            _searchContext = new SearchContext();
        }

        public IQueryable<Book> Get(string[] isbns)
        {
         
            return _searchContext.Books.Where(x => isbns.Any(y => y == x.Isbn13));
        }

        public IQueryable<Book> Get()
        {
            return _searchContext.Books;
        }
    }
}
