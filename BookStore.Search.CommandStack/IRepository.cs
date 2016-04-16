using System.Linq;
using BookStore.Search.CommandStack.Model;

namespace BookStore.Search.CommandStack
{
    public interface IRepository
    {
        void Add(Book book);
    }
}
