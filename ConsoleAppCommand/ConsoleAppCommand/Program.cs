using ConsoleAppCommand.Commands;
using System;

namespace ConsoleAppCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = true;

            GameComponent fakeComponentReceiver = new GameComponent();

            // I know that the laws a physics seem to not apply here, the user can just pass through blocks they have placed.
            // TODO add data structure that keeps track of blocks in the world space so the user cannot pass through solid objects
            Console.WriteLine("Press E to dig down and Press F to put a block under you\n\n");

            while (isPlaying)
            {
                // Game
                Console.Write("Please enter a key: ");
                ConsoleKeyInfo keyI = Console.ReadKey();

                ICommand command = GetCommandFromKey(keyI);
                
                if (command != null)
                {
                    command.Execute(fakeComponentReceiver);
                }
                else
                {
                    Console.WriteLine("Unknown Command");
                }

                switch (keyI.Key)
                {
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        isPlaying = false;
                        break;
                }

                Console.WriteLine($"x: { fakeComponentReceiver.X} y: {fakeComponentReceiver.Y} z: {fakeComponentReceiver.Z}");
            }
        }

        // Checks which key the user pressed
        private static ICommand GetCommandFromKey(ConsoleKeyInfo consoleKeyInfo)
        {
            Command command = null;
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    command = new MoveUpCommand();
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    command = new MoveDownCommand();
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    command = new MoveRightCommand();
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    command = new MoveLeftCommand();
                    break;
                case ConsoleKey.E:
                    System.Console.WriteLine($"\nYou dig down");
                    command = new DigCommand();
                    break;
                case ConsoleKey.F:
                    Console.WriteLine($"\nYou place a block below you");
                    command = new PlaceCommand();
                    break;
                default:
                    Console.WriteLine("Unknown key");
                    break;
            }
            return command;
        }
    }
}
