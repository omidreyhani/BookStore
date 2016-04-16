using System;
using BookStore.Search.CommandStack.Model;

namespace BookStore.Search.CommandStack
{
    public interface IUnitOfWork:IDisposable
    {
        void Add(Book book);
        void Save();
    }
}