using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure
{
    public class Bus:IBus
    {
        readonly List<ICommandHandler> _commandHandlers= new List<ICommandHandler>();

        public void Execute(ICommand command)
        {
            foreach (var handler in _commandHandlers)
            {
               handler.Handle(command); 
            }
        }

        public void RegisterCommand(ICommandHandler commandHandler)
        {
           _commandHandlers.Add(commandHandler); 
        }
    }
}
