using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using BookStore.Autofac;
using BookStore.Infrastructure;
using BookStore.WebSite.Areas.CustomerSite.Commands;
using BookStore.WebSite.Areas.CustomerSite.WorkerServices;

namespace BookStore.WebSite
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

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

    

            builder.RegisterType<SearchWorkerService>();
            builder.RegisterType<UpdateCommandHandler>();
            // Set the dependency resolver to be Autofac.
            AutofacConfig.Configure(builder);
            var container = builder.Build();
            ConfigureCommandHandler(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        public void ConfigureCommandHandler(IContainer container)
        {
             IBus bus = container.Resolve<IBus>();
             UpdateCommandHandler commandHandler = container.Resolve<UpdateCommandHandler>();
            bus.RegisterCommand(commandHandler);
           
        }
    }
}
