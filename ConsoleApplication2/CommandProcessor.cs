using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    public delegate void CommandHandler(string[] args);

    public static class CommandProcessor
    {
        public static readonly List<Command> Commands = new List<Command>();

        public static void AddCommand(string name, string description, CommandHandler handler, CommandFlags flags)
        {
            Commands.Add(new Command(name, description, handler, flags));
        }

        public static void ProcessCommand(string input)
        {
            var args = input.Split(' ');
            var currentCommand = Commands.FirstOrDefault(x => x.Name == args[0].ToLower());

            if (currentCommand.Name != null)
            {
                if (args.Length == 1)
                {
                    currentCommand.Handler(null);
                }

                else
                {
                    var argsToSend = args.ToList();
                    argsToSend.RemoveAt(0);
                    currentCommand.Handler(argsToSend.ToArray());
                }
            }
        }
    }
}
