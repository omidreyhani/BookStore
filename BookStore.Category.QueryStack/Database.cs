using System.Linq;

namespace BookStore.Category.QueryStack
{
    public class Database:IDatabase
    {
        private readonly CategoryContext _categoryContext;

        public Database()
        {
            _categoryContext = new CategoryContext();
        }

        public IQueryable<Model.Category> Categories => _categoryContext.Categories;
    }
}
