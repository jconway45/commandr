using System.Collections.Generic;

namespace Commandr
{
    public class Invoker : IInvoker
    {
        public IList<ICommand> commands;

        public Invoker()
        {
            commands = new List<ICommand>();
        }

        public void Register(ICommand command)
        {
            commands.Add(command);
        }

        public void Run()
        {
            foreach (ICommand c in commands)
            {
                c.Execute();
                c.Log();
            }
        }

        public void Rollback()
        {
            foreach (ICommand c in commands)
            {
                c.Rollback();
            }
        }
    }
}
