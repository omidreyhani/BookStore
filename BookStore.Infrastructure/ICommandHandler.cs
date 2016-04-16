namespace BookStore.Infrastructure
{
    public interface ICommandHandler
    {
        void Handle(ICommand T);
    }
}