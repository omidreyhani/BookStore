namespace BookStore.Infrastructure.Command
{
    public class UpdateCommand : ICommand
    {
        public string[] Isbns { get; private set; }

        public UpdateCommand(string[] isbns)
        {
            Isbns = isbns;
        }
    }
}