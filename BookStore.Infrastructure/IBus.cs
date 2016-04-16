using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure
{
    public interface IBus
    {
        void Execute(ICommand command);
        void RegisterCommand(ICommandHandler commandHandler);
    }
}
