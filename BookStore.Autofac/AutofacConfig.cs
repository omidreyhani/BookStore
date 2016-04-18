using Autofac;
using BookStore.Saxo.ProductService;
using BookStore.Search.CommandStack;
using BookStore.Search.CommandStack.Sagas;
using BookStore.Search.QueryStack;
using  Memento.Messaging;
using Memento.Messaging.Postie;
using Microsoft.Practices.Unity;

namespace BookStore.Autofac
{
    public static class AutofacConfig
    {
        public static void Configure(ContainerBuilder builder)
        {
            // Register your MVC controllers.
       

            builder.RegisterType<QueryRepository>().As<IQueryRepository>();
            builder.RegisterType<ProductApi>().As<IProductApi>();
//            builder.RegisterType<FakeProductApi>().As<IProductApi>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<QuerySearchContextDatabaseInitializer>().As<IQuerySearchContextDatabaseInitializer>();
            builder.RegisterType<SearchContextDatabaseInitializer>().As<ISearchContextDatabaseInitializer>();
            builder.RegisterType<UpdateCommandHandler>().As<IUpdateCommandHandler>();
        }

        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            Configure(builder);
            return builder.Build();
        }

    }
}
