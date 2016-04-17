using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace BookStore.Infrastructure
{
    public class Bus:IBus
    {
        readonly List<Type> _commandHandlers = new List<Type>();
        public IContainer Container { get; set; }

        public void Execute(ICommand command)
        {
            foreach (var handler in _commandHandlers)
            {
                ICommandHandler a =(ICommandHandler) Container.Resolve(handler);
               a.Handle(command); 
            }
        }

        public void RegisterCommandHandler<T>() where T : ICommandHandler
        {
           _commandHandlers.Add(typeof(T)); 
        }
    }
}
