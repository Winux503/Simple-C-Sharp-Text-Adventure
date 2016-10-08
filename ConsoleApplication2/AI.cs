using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.IO;

namespace ConsoleApplication2
{
    class AI
    {

        public static string Name = "";
        public static void initFunc()
        {
            Console.Clear();
            AIConsole.WriteLine("\n Initialising Artificial Inteligence Constructs\n\n", ConsoleColor.White, 2500,5000);
            AIConsole.WriteLine(" 0%>==========================================================>100%", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine("\n\n WARNING AI IS UNSTABLE\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" DO ", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" NOT ", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" PROVOKE ", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" IT!\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine("\n Running Final Initialisation Script", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine("\n\n 0%>==========================================================>100%\n\n", ConsoleColor.White, 500, 1000);
            Console.Clear();
            AIConsole.WriteLine(" Hello there, I am the ChaOS AI Program\n\n", ConsoleColor.Cyan ,500, 1000);
            AIConsole.WriteLine(" My name is sys-fs\n\n", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine(" Hmm... it would apear that this user acount is errored, lets fix that.", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine(" Together..\n\n", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine(" Please...\n\n", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine(" Tell me your name...\n\n", ConsoleColor.Cyan, 500, 1000);
            
            Name = Console.ReadLine();
            AIConsole.WriteLine(" "+Name, ConsoleColor.Magenta);
            AIConsole.WriteLine(", Huh, that is a ", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine("STUPID ", ConsoleColor.Red, 500, 1000);
            AIConsole.WriteLine("name :D\n\n", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine(" So what brings you here?\n\n", ConsoleColor.Cyan, 500, 1000);
            AIConsole.Write(" Your optirons are: \n\n 1. I found your text file\n 2. I was exiting random commands and found you\n 3. What are you?\n\n Enter the number that corrisonds to your answer on the line bellow\n\n", ConsoleColor.White, 500, 1000);
            Branchs.Bras(Console.ReadLine());
            
            
        }
        
    }
}