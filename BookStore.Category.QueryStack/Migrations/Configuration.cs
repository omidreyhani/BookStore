namespace BookStore.Category.QueryStack.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Category.QueryStack.CategoryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BookStore.Category.QueryStack.CategoryContext";
        }

        protected override void Seed(BookStore.Category.QueryStack.CategoryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Categories.AddOrUpdate(c=>c.CategoryId, new []
            {
                new Model.Category() {Title = "Fiction", TotalItems = 2000, Url = "/"},
                new Model.Category() {Title = "Philosophy", TotalItems = 3000, Url = "/"}
            });
        }
    }
}
