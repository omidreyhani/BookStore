using BookStore.Search.CommandStack.Sagas;

namespace BookStore.Search.CommandStack.Commands
{
    public class UpdateCommand:ICommand
    {
        public string[] Isbns { get; set; }

        public UpdateCommand(string[] isbns)
        {
            Isbns = isbns;
        }
    }
}
