using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand.Commands
{
    public abstract class Command : ICommand
    {
        public string CommandName;

        public Command()
        {
            this.CommandName = "Base Command";
        }

        public virtual void Execute(GameComponent go)
        {
            this.Log();
        }

        protected virtual void Log()
        {
            // Log basic command to console
            Console.WriteLine($"\n{this.CommandName} executed");
        }

        protected virtual void Log(GameComponent go)
        {
            this.Log();
            Console.WriteLine($" on {go.ToString()}");
        }
    }
}
