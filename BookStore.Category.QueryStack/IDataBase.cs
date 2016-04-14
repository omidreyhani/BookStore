using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Category.QueryStack
{
    public interface IDataBase 
    {
        IQueryable<Model.Category> Categories { get; }
    }
}
