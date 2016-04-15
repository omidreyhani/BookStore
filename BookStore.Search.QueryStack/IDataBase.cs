using System.Linq;
using BookStore.Search.QueryStack.Model;

namespace BookStore.Search.QueryStack
{
    public interface IDatabase 
    {
        IQueryable<Book> Books { get; }
    }
}
