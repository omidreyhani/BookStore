using System.Data.Entity;
using BookStore.Search.CommandStack;

namespace BookStore.Search.QueryStack
{
    public interface IQuerySearchContextDatabaseInitializer
    {
        void Initialize();
    }

    public class QuerySearchContextDatabaseInitializer : IQuerySearchContextDatabaseInitializer
    {
        public void Initialize()
        {
            using (QuerySearchContext querySearchContext =new QuerySearchContext())
            {
               querySearchContext.Database.Initialize(true); 
            } 
        }
    }

}
