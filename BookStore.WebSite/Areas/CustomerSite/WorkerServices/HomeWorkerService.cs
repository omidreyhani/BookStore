using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Category.QueryStack;
using BookStore.WebSite.Areas.CustomerSite.Models;

namespace BookStore.WebSite.Areas.CustomerSite.WorkerServices
{
    public class HomeWorkerService
    {
        private IDataBase _dataBase;

        public HomeWorkerService(IDataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public IEnumerable<CategoryViewModel> GetCategoryViewModel()
        {
            return from c in _dataBase.Categories
                select new CategoryViewModel()
                {
                    Title = c.Title,
                    Url = c.Url,
                    TotalItems = c.TotalItems
                };
        }
    }
}
