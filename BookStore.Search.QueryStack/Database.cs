using System.Linq;
using System.Linq.Expressions;
using BookStore.Search.QueryStack.Model;

namespace BookStore.Search.QueryStack
{
    public class Database:IDatabase
    {
        private readonly SearchContext _searchContext;

        public Database()
        {
            _searchContext = new SearchContext();
        }

        public IQueryable<Book> Books => _searchContext.Books;
    }
}
