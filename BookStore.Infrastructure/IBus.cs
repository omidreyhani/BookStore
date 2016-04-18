using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace BookStore.Infrastructure
{
    public interface IBus
    {
        void Execute(ICommand command);
        void RegisterCommandHandler<T>() where T: ICommandHandler;
        IContainer Container { get; set; }
    }
}
