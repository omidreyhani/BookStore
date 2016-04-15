using System.Data.Entity;
using BookStore.Search.QueryStack.Model;

namespace BookStore.Search.QueryStack
{
    class SearchContext : DbContext
    {
        public SearchContext():base("SearchStoreModel")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(entity=> entity.ToTable(string.Format("{0}_{1}","Category",entity.ClrType.Name)));
        }

        public DbSet<Book> Books { get; set; }
    }
}
