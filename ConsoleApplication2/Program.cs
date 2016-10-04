using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Media;

namespace ConsoleApplication2
{
    class Program
    {
        // This is an example command.
        // All commans are stored in a separate function
        private static void ExampleCommand(string[] Args)
        {
            //AIConsole is a separate function that combines Console.Write, ConsoleColor and Thread.Sleep.
            AIConsole.WriteLine("Hello World!");
        }
        private static void Credits(string[] Args)
        {
            //AIConsole is a separate function that combines Console.Write, ConsoleColor and Thread.Sleep.
            GraphicsCon.GMain();
        }


        private static void user(string[] Args)
        {
            AIConsole.Write("\n NO USER ACOUNT FOUND EXITING!\n\n",ConsoleColor.Red,new Random().Next(500,100));
        }

        private static void init(string[] Args)
        {
            AI.initFunc();
        }
        private static void listdir(string[] Args)
        {
            AIConsole.Write("\n Listing Current Working Directory...\n", ConsoleColor.White, new Random().Next(500, 1000));
            AIConsole.Write(" COS/base/users/UNKNOWN/home", ConsoleColor.Blue, new Random().Next(500, 1000));
            AIConsole.Write("\n Existing to prompt...\n\n ", ConsoleColor.White, new Random().Next(500, 1000));
        }

        private static void list(string[] Args)
        {
            AIConsole.Write(" Listing contents of: ", ConsoleColor.White, new Random().Next(500, 1000));
            AIConsole.Write("COS/base/users/UNKNOWN/home\n", ConsoleColor.Blue, new Random().Next(500, 1000));
            AIConsole.Write("     config.txt           Documents            TotallyNotAMeme.PNG     \n     RUN_INIT.txt    ", ConsoleColor.White, new Random().Next(500, 1000));
            AIConsole.Write("\n Existing to prompt...\n\n ",ConsoleColor.White,new Random().Next(500,1000));
            
        }

        //commands can accept arguments for extendended functionality. 
        private static void ExampleCommandArgs(string[] Args)
        {
            if (Args != null)
            {
                AIConsole.Write("Args: ");
                foreach (string Arg in Args)
                {
                    AIConsole.Write(Arg);
                }
            }
            else
            {
                /*No Args Entered*/
            }
        }
        private static void Read(string[] Args)
        {
            if (Args != null)
            {
                if(Args[0] == "config.txt")
                {
                    AIConsole.Write("  Users: ERROR 451\n", ConsoleColor.White, new Random().Next(500, 1000));
                    AIConsole.Write("  Permissions: NONE\n", ConsoleColor.White, new Random().Next(500, 1000));
                    AIConsole.Write("  AI_status: OFFLINE\n", ConsoleColor.White, new Random().Next(500, 1000));
                    AIConsole.Write("  Error_logging: False\n\n", ConsoleColor.White, new Random().Next(500, 1000));
                    AIConsole.Write("\n Existing to prompt...\n\n ", ConsoleColor.White, new Random().Next(500, 1000));
                }else if(Args[0] == "RUN_INIT.txt")
                {
                    AIConsole.Write("  Run the init command.....\n Please\n I beg you\n\n", ConsoleColor.White, new Random().Next(500, 1000));
                }
                else
                {
                    AIConsole.Write(" Please enter a valid argument");
                }
            }
            else
            {
                AIConsole.Write(" Please enter a valid argument");
                /*No Args Entered*/
            }
        }

        //this help application reads all current comands and displays its name and desccription.
        //this function extends itslef depending on the amount of commands.
        public static void Help(string[] Args)
        {
            foreach(var Command in CommandProcessor.Commands)
            {
                AIConsole.Write(" " + Command.Name + " - " + Command.Description + "\n");
            }
        }

        static void Main(string[] args)
        {
            /*Add Commands*/
            //this section is where the commands are added.
            //they all have a description, a name and some flags
            CommandProcessor.AddCommand("Test", "Example Command", ExampleCommand, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("Credits", "Shows the people who made this", Credits, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("init", "<command description not found>", init, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("Read", "Prints the contents of a text file to the screen", Read, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("ListDir", "List the current working directory", listdir, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("TestArgs", "Example Command For Args", ExampleCommandArgs, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("Help", "Shows Commands", Help, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("List", "Lists the contents of the current directory", list, CommandFlags.DEFAULT);

            //this is the beginning of the program itself.
            AIConsole.Write(" [Initiating first boot procedure]...\n\n",ConsoleColor.White, new Random().Next(500, 1000));
            AIConsole.Write(" {Success}\n\n", ConsoleColor.Green, new Random().Next(1000, 1500));
            AIConsole.Write(" [Loading core operating functions]...\n\n", new Random().Next(500, 1000));
            AIConsole.Write(" {Success}\n\n", ConsoleColor.Green, new Random().Next(1000, 1500));
            AIConsole.Write(" [Loading User space]...\n\n", new Random().Next(3000, 5000));
            AIConsole.Write(" [ERROR 451 - NO USERS FOUND] \n\n",ConsoleColor.Red, new Random().Next(600, 1000));
            AIConsole.Write(" {Ignoring}\n\n", ConsoleColor.Green, new Random().Next(600, 1000));
            AIConsole.Write(" {Continuing}\n\n", ConsoleColor.Green, new Random().Next(600, 1000));
            Console.Clear();
            AIConsole.Write(" Welcome to ");
            AIConsole.Write("ChaOS V. 50.15.1 REV2\n", ConsoleColor.Cyan,new Random().Next(300,500));
            AIConsole.Write(" Welcome ");
            AIConsole.Write("<unkown>\n\n",ConsoleColor.Red, new Random().Next(300,500));
            AIConsole.Write(" Type help on the next line to see a list of commands:\n\n", new Random().Next(300, 500));
        
            //this while starts the command processor.
            while (true)
            {
                CommandProcessor.ProcessCommand(Console.ReadLine());
            }
            //this is old code ignore it.
            /*int Usercontrol = 1;
            Thread.Sleep(1000);
            Console.Write(" [Initiating first boot procedure]...\n\n");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" {Success}\n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Write(" [Loading core operating functions]...\n\n");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" {Success}\n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Write(" [Loading User space]...\n\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" [ERROR 451 - NO USERS FOUND] \n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" {Ignoring}\n\n");
            Thread.Sleep(500);
            Console.Write(" {Continuing}\n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.Write(" Welcome to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ChaOS V. 50.15.1 REV2\n");
            Console.ResetColor();
            Thread.Sleep(500);
            Console.Write(" Welcome ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("<UNKOWN>");
            Console.ResetColor();
            Console.Write("!\n\n");
            Thread.Sleep(1000);
            Console.Write(" Type help on the next line to see a list of commands:\n\n");
            string Command = Console.ReadLine();
            while (Usercontrol == 1)
            {
                if (Command == "help")
                {
                    Console.Write("\n All commands are to be entered in lower case\n");
                    Console.Write(" The 'Complete' list of commands is as follows:\n");
                    Thread.Sleep(1000);
                    Console.Write("  help     - Displays this menu\n");
                    Console.Write("  list     - Lists the contents of the current directory\n");
                    Console.Write("  listdir  - List the current directory\n");
                    Console.Write("  user     - List current user\n");
                    Console.Write("  read     - Displays the contents of any text file\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  init     - FUNCTION DESCRIPTION UNKNOWN(error 444)\n\n");
                    Console.ResetColor();
                    Command = "";
                    Command = Console.ReadLine();
                }
               
                else if (Command == "list")
                {
                    Console.Write("\n listing contents of: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("COS/base/users/UNKNOWN/home\n");
                    Console.ResetColor();
                    Console.Write("     config.txt      ");
                    Thread.Sleep(100);
                    Console.Write("     Documents       ");
                    Thread.Sleep(100);
                    Console.Write("     TotallyNotAMeme.PNG     \n");
                    Thread.Sleep(2000);
                    Console.Write("     RUN_INIT.txt    ");
                    Thread.Sleep(1000);
                    Console.Write("\n Existing to prompt...\n\n ");
                    Command = "";
                    Command = Console.ReadLine();
                }
                
                else if (Command == "listdir")
                {
                    Console.Write("\n Listing Current Working Directory...\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" COS/base/users/UNKNOWN/home\n\n");
                    Console.ResetColor();
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if(Command == "")
                {
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if(Command == "read")
                {
                    Console.Write(" Please select a .txt file to read (include file extention)");
                    string Input = "";
                    Input = Console.ReadLine();
                    if (Input == "config.txt")
                    {
                        Console.Write("  Users: ERROR 451\n");
                        Console.Write("  Permissions: NONE\n");
                        Console.Write("  AI_status: OFFLINE\n");
                        Console.Write("  Error_logging: False\n\n");
                        Console.Write(" Press Enter fo return to normal prompt\n");
                        Console.ReadLine();
                                            
                    }
                    else if (Input == "RUN_INIT.txt")
                    {
                        Console.Write("  Run the init command.....\n Please\n I beg you\n\n");
                        Console.Write(" Press Enter fo return to normal prompt\n");
                        Console.ReadLine();
                        
                    }
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if (Command == "user")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO USER DETECTED ERROR 451, EXITING.\n\n");
                    Console.ResetColor();
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if (Command == "init")
                {
                    Usercontrol = 0;
                    AI.initFunc();
                }else
                {
                    Console.Write("\n Please enter a valid command.\n\n");
                    Command = "";
                    Command = Console.ReadLine();
                }
            }                */
        }
    }
}
