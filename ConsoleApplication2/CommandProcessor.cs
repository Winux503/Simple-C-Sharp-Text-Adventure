using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public enum CommandFlags
    {
        DEFAULT,
        CORRUPTED,

    };

    public delegate void CommandHandler(string[] Args);
    public struct Command
    {
        public string Name;
        public string Description;
        public CommandHandler Handler;
        public CommandFlags Flags;

        public Command(string Name, string Description, CommandHandler Handler, CommandFlags Flags)
        {
            this.Name = Name.ToLower();
            this.Description = Description;
            this.Handler = Handler;
            this.Flags = Flags;
        }
    }

    public static class CommandProcessor
    {
        public static List<Command> Commands = new List<Command>();

        public static void AddCommand(string Name, string Description, CommandHandler Handler, CommandFlags Flags)
        {
            Commands.Add(new Command(Name, Description, Handler, Flags));
        }

        public static void ProcessCommand(string Input)
        {
            string[] Args = Input.Split(' ');
            Command CurrentCommand = Commands.FirstOrDefault(x => x.Name == Args[0].ToLower());
            if(CurrentCommand.Name != null)
            {
                if (Args.Count() == 1)
                {
                    CurrentCommand.Handler(null);
                }
                else
                {
                    var ArgsToSend = Args.ToList();
                    ArgsToSend.RemoveAt(0);
                    CurrentCommand.Handler(ArgsToSend.ToArray());
                }
            }
        }
    }
}
