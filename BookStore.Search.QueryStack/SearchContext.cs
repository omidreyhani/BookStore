using System.Data.Entity;
using BookStore.Search.QueryStack.Model;

namespace BookStore.Search.QueryStack
{
    public class QuerySearchContext : DbContext
    {
        public QuerySearchContext():base("SearchStoreModel")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(entity=> entity.ToTable($"{"Category"}_{entity.ClrType.Name}"));
        }

        public DbSet<Book> Books { get; set; }
    }
}
