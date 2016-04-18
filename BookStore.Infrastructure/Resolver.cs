using Autofac;

namespace BookStore.Infrastructure
{
    public class Resolver :IResolver
    {
        readonly IContainer _container;
        public Resolver(IContainer container)
        {
            _container = container;
        }
        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}