using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Search.CommandStack
{
    public interface ISearchContextDatabaseInitializer
    {
        void Initialize();
    }

    public class SearchContextDatabaseInitializer : ISearchContextDatabaseInitializer
    {
        public void Initialize()
        {
            using (SearchContext searchContext = new SearchContext())
            {
               searchContext.Database.Initialize(true); 
            }
        }
    }
}
