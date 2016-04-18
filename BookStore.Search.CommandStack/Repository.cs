using System.Linq;
using BookStore.Search.CommandStack.Model;

namespace BookStore.Search.CommandStack
{
     class Repository:IRepository
     {
         readonly SearchContext _searchContext;
         public Repository(SearchContext searchContext)
         {
             _searchContext = searchContext;
         }

         public void Add(Book book)
         {
             _searchContext.Books.Add(book);
         }

         public IQueryable<Book> GetBooks()
         {
             return _searchContext.Books;
         }
     }
}
