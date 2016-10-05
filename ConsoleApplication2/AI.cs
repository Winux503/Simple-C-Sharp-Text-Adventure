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
        private static SoundPlayer ConsoleSound = new SoundPlayer(@"F:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");

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
            string Name = "";
            Name = Console.ReadLine();
            AIConsole.WriteLine(Name, ConsoleColor.Magenta, 500, 1000);
            AIConsole.WriteLine(", Huh, that is a ", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine("STUPID ", ConsoleColor.Red, 500, 1000);
            AIConsole.WriteLine("name :D\n\n", ConsoleColor.Cyan, 500, 1000);
            AIConsole.WriteLine(" So what brings you here?\n\n", ConsoleColor.Cyan, 500, 1000);


            
        }
        
    }
}