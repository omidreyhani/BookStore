using System;
using BookStore.Search.CommandStack.Model;

namespace BookStore.Search.CommandStack
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly SearchContext _searchContext;
        public IRepository Repository { get; set; }

        public UnitOfWork()
        {
            _searchContext = new SearchContext();
            Repository = new Repository(_searchContext);
        }

        public void Add(Book book)
        {
            Repository.Add(book);
        }

        public void Save()
        {
            try
            {

            _searchContext.SaveChanges();
            }
            catch (Exception)
            {
//                throw;
            }
        }

          private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _searchContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
