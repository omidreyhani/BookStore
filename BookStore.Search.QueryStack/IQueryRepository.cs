using System.Linq;
using BookStore.Search.QueryStack.Model;

namespace BookStore.Search.QueryStack
{
    public interface IQueryRepository
    {
        IQueryable<Book> Get(string[] isbns);
        IQueryable<Book> Get();
    }
}