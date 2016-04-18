using System.Data.Entity;
using BookStore.Search.CommandStack.Model;

namespace BookStore.Search.CommandStack
{
    public class SearchContext : DbContext
    {
        public SearchContext():base("SearchStoreModel")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(entity=> entity.ToTable($"{"Category"}_{entity.ClrType.Name}"));
        }

        public DbSet<Book> Books { get; set; }
    }
}
