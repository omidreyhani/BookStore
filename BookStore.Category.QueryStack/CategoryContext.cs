using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Category.QueryStack
{
    class CategoryContext : DbContext
    {
        public CategoryContext():base("BookStoreModel")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(entity=> entity.ToTable(string.Format("{0}_{1}","Category",entity.ClrType.Name)));
        }

        public DbSet<Model.Category> Categories { get; set; }
    }
}
