using System.Linq;
using BookStore.Search.QueryStack.Model;

namespace BookStore.Search.QueryStack
{
    public class QueryRepository:IQueryRepository
    {
        private readonly QuerySearchContext _searchContext;

        public QueryRepository()
        {
            _searchContext = new QuerySearchContext();
        }

        public IQueryable<Book> Get(string[] isbns)
        {
            return _searchContext.Books.AsNoTracking().Where(x => isbns.Contains(x.Isbn13));
        }

        public IQueryable<Book> Get()
        {
            return _searchContext.Books.AsNoTracking();
        }
    }
}
