namespace BookStore.Infrastructure
{
    public interface IResolver
    {
        T Resolve<T>();
    }
}
