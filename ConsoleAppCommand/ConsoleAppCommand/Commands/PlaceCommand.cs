using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCommand.Commands
{
    class PlaceCommand : Command
    {
        public PlaceCommand()
        {
            this.CommandName = "Place";
        }

        public override void Execute(GameComponent go)
        {
            go.Place();
            base.Execute(go);
        }
    }
}
