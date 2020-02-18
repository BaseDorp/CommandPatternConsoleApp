using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand.Commands
{
    class DigCommand : Command
    {
        public DigCommand()
        {
            this.CommandName = "Dig";
        }

        public override void Execute(GameComponent go)
        {
            go.Dig();
            base.Execute(go);
        }
    }
}
