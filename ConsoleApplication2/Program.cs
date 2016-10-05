using System;

namespace ConsoleApplication2
{
    internal static class Program
    {
        // This is an example command.
        // All commans are stored in a separate function
        private static void ExampleCommand(string[] args)
        {
            //AIConsole is a separate function that combines Console.Write, ConsoleColor and Thread.Sleep.
            AiConsole.WriteLine("Hello World!");
        }

        private static void Credits(string[] args)
        {
            //AIConsole is a separate function that combines Console.Write, ConsoleColor and Thread.Sleep.
            GraphicsCon.GMain();
        }

        private static void User(string[] args)
        {
            AiConsole.Write("\n NO USER ACOUNT FOUND EXITING!\n\n",ConsoleColor.Red, RandomNumber.BasicTextDelay());
        }

        private static void Init(string[] args)
        {
            Ai.InitFunc();
        }

        private static void ListDir(string[] args)
        {
            AiConsole.Write("\n Listing Current Working Directory...\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.Write(" COS/base/users/UNKNOWN/home", ConsoleColor.Blue, RandomNumber.BasicTextDelay());
            AiConsole.Write("\n Existing to prompt...\n\n ", ConsoleColor.White, RandomNumber.BasicTextDelay());
        }

        private static void List(string[] args)
        {
            AiConsole.Write(" Listing contents of: ", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.Write("COS/base/users/UNKNOWN/home\n", ConsoleColor.Blue, RandomNumber.BasicTextDelay());
            AiConsole.Write("     config.txt           Documents            TotallyNotAMeme.PNG     \n     RUN_INIT.txt    ", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.Write("\n Existing to prompt...\n\n ",ConsoleColor.White, RandomNumber.BasicTextDelay());
            
        }

        //commands can accept arguments for extendended functionality. 
        private static void ExampleCommandArgs(string[] args)
        {
            if (args != null)
            {
                AiConsole.Write("Args: ");
                foreach (var arg in args)
                {
                    AiConsole.Write(arg);
                }
            }

            else
            {
                /*No Args Entered*/
            }
        }

        private static void Read(string[] args)
        {
            if (args != null)
            {
                if (args[0] == "config.txt")
                {
                    AiConsole.Write("  Users: ERROR 451\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
                    AiConsole.Write("  Permissions: NONE\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
                    AiConsole.Write("  AI_status: OFFLINE\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
                    AiConsole.Write("  Error_logging: False\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
                    AiConsole.Write("\n Existing to prompt...\n\n ", ConsoleColor.White, RandomNumber.BasicTextDelay());
                }

                else if (args[0] == "RUN_INIT.txt")
                {
                    AiConsole.Write("  Run the init command.....\n Please\n I beg you\n\n", ConsoleColor.White,
                        RandomNumber.BasicTextDelay());
                }

                else
                {
                    AiConsole.Write(" Please enter a valid argument");
                }
            }

            else
            {
                AiConsole.Write(" Please enter a valid argument");
                /*No Args Entered*/
            }
        }

        //this help application reads all current comands and displays its name and desccription.
        //this function extends itslef depending on the amount of commands.
        private static void Help(string[] args)
        {
            foreach(var command in CommandProcessor.Commands)
            {
                AiConsole.Write(" " + command.Name + " - " + command.Description + "\n");
            }
        }

        private static void Main(string[] args)
        {
            /*Add Commands*/
            //this section is where the commands are added.
            //they all have a description, a name and some flags
            CommandProcessor.AddCommand("Test", "Example Command", ExampleCommand, CommandFlags.Default);
            CommandProcessor.AddCommand("Credits", "Shows the people who made this", Credits, CommandFlags.Default);
            CommandProcessor.AddCommand("init", "<command description not found>", Init, CommandFlags.Default);
            CommandProcessor.AddCommand("Read", "Prints the contents of a text file to the screen", Read, CommandFlags.Default);
            CommandProcessor.AddCommand("ListDir", "List the current working directory", ListDir, CommandFlags.Default);
            CommandProcessor.AddCommand("TestArgs", "Example Command For Args", ExampleCommandArgs, CommandFlags.Default);
            CommandProcessor.AddCommand("Help", "Shows Commands", Help, CommandFlags.Default);
            CommandProcessor.AddCommand("List", "Lists the contents of the current directory", List, CommandFlags.Default);

            //this is the beginning of the program itself.
            AiConsole.Write(" [Initiating first boot procedure]...\n\n",ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.Write(" {Success}\n\n", ConsoleColor.Green, RandomNumber.Between(1000, 1500));
            AiConsole.Write(" [Loading core operating functions]...\n\n", RandomNumber.BasicTextDelay());
            AiConsole.Write(" {Success}\n\n", ConsoleColor.Green, RandomNumber.Between(1000, 1500));
            AiConsole.Write(" [Loading User space]...\n\n", RandomNumber.Between(3000, 5000));
            AiConsole.Write(" [ERROR 451 - NO USERS FOUND] \n\n",ConsoleColor.Red, RandomNumber.Between(600, 1000));
            AiConsole.Write(" {Ignoring}\n\n", ConsoleColor.Green, RandomNumber.Between(600, 1000));
            AiConsole.Write(" {Continuing}\n\n", ConsoleColor.Green, RandomNumber.Between(600, 1000));

            Console.Clear();

            AiConsole.Write(" Welcome to ");
            AiConsole.Write("ChaOS V. 50.15.1 REV2\n", ConsoleColor.Cyan, RandomNumber.Between(300,500));
            AiConsole.Write(" Welcome ");
            AiConsole.Write("<unknown>\n\n",ConsoleColor.Red, RandomNumber.Between(300,500));
            AiConsole.Write(" Type help on the next line to see a list of commands:\n\n", RandomNumber.Between(300, 500));
        
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
