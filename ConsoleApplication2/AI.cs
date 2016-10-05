using System;
using System.Media;

namespace ConsoleApplication2
{
    internal static class Ai
    {
        private static SoundPlayer _consoleSound =
            new SoundPlayer(@"F:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");

        public static void InitFunc()
        {
            Console.Clear();
            AiConsole.WriteLine("\n Initialising Artificial Inteligence Constructs\n\n", new Random().Next(2500, 5000));
            AiConsole.WriteLine(" 0%>==========================================================>100%",
                new Random().Next(500, 1000));
            AiConsole.WriteLine("\n\n WARNING AI IS UNSTABLE\n\n", new Random().Next(500, 1000));
            AiConsole.WriteLine(" DO ", new Random().Next(500, 1000));
            AiConsole.WriteLine("NOT ", new Random().Next(500, 1000));
            AiConsole.WriteLine("PROVOKE ", new Random().Next(500, 1000));
            AiConsole.WriteLine("IT!\n", new Random().Next(500, 1000));
            AiConsole.WriteLine("\n Running Final Initialisation Script", new Random().Next(500, 1000));
            AiConsole.WriteLine("\n\n 0%>==========================================================>100%\n\n",
                new Random().Next(500, 1000));
            Console.Clear();
            AiConsole.WriteLine(" Hello there, I am the ChaOS AI Program\n\n", ConsoleColor.Cyan,
                new Random().Next(500, 1000));
            AiConsole.WriteLine(" My name is sys-fs\n\n", ConsoleColor.Cyan, new Random().Next(500, 1000));
            AiConsole.WriteLine(" Hmm... it would apear that this user acount is errored, lets fix that.",
                ConsoleColor.Cyan, new Random().Next(500, 1000));
            AiConsole.WriteLine(" Together..\n\n", ConsoleColor.Cyan, new Random().Next(500, 1000));
            AiConsole.WriteLine(" Please...\n\n", ConsoleColor.Cyan, new Random().Next(500, 1000));
            AiConsole.WriteLine(" Tell me your name...\n\n", ConsoleColor.Cyan, new Random().Next(500, 1000));
            var name = "";
            name = Console.ReadLine();
            AiConsole.WriteLine(name, ConsoleColor.Magenta, new Random().Next(500, 1000));
            AiConsole.WriteLine(", Huh, that is a ", ConsoleColor.Cyan, new Random().Next(500, 1000));
            AiConsole.WriteLine("STUPID ", ConsoleColor.Red, new Random().Next(500, 1000));
            AiConsole.WriteLine("name :D\n\n", ConsoleColor.Cyan, new Random().Next(500, 1000));
            AiConsole.WriteLine(" So what brings you here?\n\n", ConsoleColor.Cyan, new Random().Next(500, 1000));

            /* Console.Clear();
            Thread.Sleep(5000);
            TypeWritter("\n Initialising Artificial Inteligence Constructs\n\n");
            Thread.Sleep(1000);
            TypeWritter(" 0%>==========================================================>100%");
            Thread.Sleep(1000);
            TypeWritter("\n\n WARNING AI IS UNSTABLE\n\n");
            Thread.Sleep(1000);
            TypeWritter(" DO ");
            Thread.Sleep(1000);
            TypeWritter("NOT ");
            Thread.Sleep(1000);
            TypeWritter("PROVOKE ");
            Thread.Sleep(1000);
            TypeWritter("IT!\n");
            Thread.Sleep(1000);
            TypeWritter("\n Running Final Initialisation Script");
            Thread.Sleep(1000);
            TypeWritter("\n\n 0%>==========================================================>100%\n\n");
            TypeWritter(".");
            Thread.Sleep(1000);
            TypeWritter(".");
            Thread.Sleep(1000);
            TypeWritter(".\n\n");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWritter(" Hello there, I am the ChaOS AI Program\n\n");
            Thread.Sleep(2000);
            TypeWritter(" My name is sys-fs\n\n");
            Thread.Sleep(2000);
            TypeWritter(" Hmm... it would apear that this user acount is errored, lets fix that.");
            Thread.Sleep(2000);
            TypeWritter(" Together..\n\n");
            Thread.Sleep(2000);
            TypeWritter(" Please...\n\n");
            Thread.Sleep(2000);
            TypeWritter(" Tell me your name...\n\n");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            string Name = "";
            Name =  Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWritter("\n " + Name + "");
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWritter(", Huh, that is a ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            TypeWritter("STUPID ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWritter("name :D\n\n");
            Thread.Sleep(2000);
            TypeWritter(" So what brings you here?\n\n");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Your options are: \n\n");
            Console.Write("     1. I found your text file\n");
            Console.Write("     2. I found you by accident\n");
            Console.Write("     3. What are you?\n\n");
            Console.Write(" Type the numbe that corrisponds to your choice: ");
            string Input = "";
            Branchs.Bras(Input = Console.ReadLine());
        }
        public static void TypeWritter(string MyTxt)
        {
            for (int i = 0; i < MyTxt.Length; i++)
            {
                Console.Write(MyTxt[i]);
                ConsoleSound.Play();
                Thread.Sleep(50);
            }*/
        }
    }
}