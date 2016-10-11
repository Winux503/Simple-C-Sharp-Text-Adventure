using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Media;
/*  
 ██████╗ ██████╗ ███╗   ██╗███████╗ ██████╗ ██╗     ███████╗   ██╗    ██╗██████╗ ██╗████████╗███████╗ ██╗
██╔════╝██╔═══██╗████╗  ██║██╔════╝██╔═══██╗██║     ██╔════╝   ██║    ██║██╔══██╗██║╚══██╔══╝██╔════╝██╔╝
██║     ██║   ██║██╔██╗ ██║███████╗██║   ██║██║     █████╗     ██║ █╗ ██║██████╔╝██║   ██║   █████╗  ██║ 
██║     ██║   ██║██║╚██╗██║╚════██║██║   ██║██║     ██╔══╝     ██║███╗██║██╔══██╗██║   ██║   ██╔══╝  ██║ 
╚██████╗╚██████╔╝██║ ╚████║███████║╚██████╔╝███████╗███████╗██╗╚███╔███╔╝██║  ██║██║   ██║   ███████╗╚██╗
 ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝   ╚═╝   ╚══════╝ ╚═╝
                                                                                                         
██╗  ██╗███████╗██╗     ██╗      ██████╗     ██╗    ██╗ ██████╗ ██████╗ ██╗     ██████╗ ██╗              
██║  ██║██╔════╝██║     ██║     ██╔═══██╗    ██║    ██║██╔═══██╗██╔══██╗██║     ██╔══██╗██║              
███████║█████╗  ██║     ██║     ██║   ██║    ██║ █╗ ██║██║   ██║██████╔╝██║     ██║  ██║██║              
██╔══██║██╔══╝  ██║     ██║     ██║   ██║    ██║███╗██║██║   ██║██╔══██╗██║     ██║  ██║╚═╝              
██║  ██║███████╗███████╗███████╗╚██████╔╝    ╚███╔███╔╝╚██████╔╝██║  ██║███████╗██████╔╝██╗              
╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝ ╚═════╝      ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═════╝ ╚═╝              
                                                                                                         
██╗                                                                                                      
╚██╗██╗                                                                                                  
 ██║╚═╝                                                                                                  
 ██║▄█╗                                                                                                  
██╔╝▀═╝                                                                                                  
╚═╝   
A lightweight, open sourse text adventure.
Made my Winux503
 */

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
        private static void Exit(string[] Args)
        {
            //AIConsole is a separate function that combines Console.Write, ConsoleColor and Thread.Sleep.
            Environment.Exit(0);
        }

        private static void user(string[] Args)
        {
            AIConsole.Write("\n NO USER ACOUNT FOUND EXITING!\n\n",ConsoleColor.Red,new Random().Next(500,100));
        }
        private static void clear(string[] Args)
        {
            Console.Clear();
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
                    AIConsole.Write(" Run the init command.....\n Please\n I beg you\n\n", ConsoleColor.White, new Random().Next(500, 1000));
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
            CommandProcessor.AddCommand("Exit", "Exits the console", Exit, CommandFlags.DEFAULT);
            //CommandProcessor.AddCommand("Test", "Example Command", ExampleCommand, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("Credits", "Shows the people who made this", Credits, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("init", "<command description not found>", init, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("Read", "Prints the contents of a text file to the screen", Read, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("ListDir", "List the current working directory", listdir, CommandFlags.DEFAULT);
            //CommandProcessor.AddCommand("TestArgs", "Example Command For Args", ExampleCommandArgs, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("Help", "Shows Commands", Help, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("List", "Lists the contents of the current directory", list, CommandFlags.DEFAULT);
            CommandProcessor.AddCommand("Clear"," Clears the screen", clear, CommandFlags.DEFAULT);

            //this is the beginning of the program itself.
            StartScreen.TitleScreen();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            AIConsole.Write(" [Initiating first boot procedure]...\n\n",ConsoleColor.White, 1000, 1500);
            AIConsole.Write(" {Success}\n\n", ConsoleColor.Green, new Random().Next(1000, 1500));
            AIConsole.Write(" [Loading core operating functions]...\n\n", ConsoleColor.White, 1000, 1500);
            AIConsole.Write(" {Success}\n\n", ConsoleColor.Green, 1000, 1500);
            AIConsole.Write(" [Loading User space]...\n\n", ConsoleColor.White,  3000, 5000);
            AIConsole.Write(" [ERROR 451 - NO USERS FOUND] \n\n",ConsoleColor.Red, 600, 1000);
            AIConsole.Write(" {Ignoring}\n\n", ConsoleColor.Green, 600, 1000);
            AIConsole.Write(" {Continuing}\n\n", ConsoleColor.Green, 600, 1000);
            Console.Clear();
            AIConsole.Write(" Welcome to ");
            AIConsole.Write("ChaOS V. 50.15.1 REV2\n", ConsoleColor.Cyan, 300, 500);
            AIConsole.Write(" Welcome ");
            AIConsole.Write("<unkown>\n\n",ConsoleColor.Red, 300, 500);
            AIConsole.Write(" Type help on the next line to see a list of commands:\n\n", ConsoleColor.White, 300, 500);
        
            //this while starts the command processor.
            while (true)
            {
                CommandProcessor.ProcessCommand(Console.ReadLine());
            }
            
        }
    }
}
