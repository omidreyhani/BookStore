using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using BookStore.Category.QueryStack;
using BookStore.WebSite.Areas.CustomerSite.WorkerServices;

namespace BookStore.WebSite
{
    public static class AutofacConfig
    {
        public static void Configure(ContainerBuilder builder)
        {
            // Register your MVC controllers.
            builder.RegisterControllers(typeof(BookStore.WebSite.WebApiApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();


            builder.RegisterType<HomeWorkerService>();
            builder.RegisterType<SearchWorkerService>();

            builder.RegisterType<Database>().As<IDatabase>();
            builder.RegisterType<Search.QueryStack.Database>().As<Search.QueryStack.IDatabase>();
        }

    }
}