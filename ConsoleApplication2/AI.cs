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
            AIConsole.WriteLine("\n Initialising Artificial Inteligence Constructs\n\n", new Random().Next(2500,5000));
            AIConsole.WriteLine(" 0%>==========================================================>100%", new Random().Next(500, 1000));
            AIConsole.WriteLine("\n\n WARNING AI IS UNSTABLE\n\n", new Random().Next(500, 1000));
            AIConsole.WriteLine(" DO ", new Random().Next(500, 1000));
            AIConsole.WriteLine("NOT ", new Random().Next(500, 1000));
            AIConsole.WriteLine("PROVOKE ", new Random().Next(500, 1000));
            AIConsole.WriteLine("IT!\n", new Random().Next(500, 1000));
            AIConsole.WriteLine("\n Running Final Initialisation Script", new Random().Next(500, 1000));
            AIConsole.WriteLine("\n\n 0%>==========================================================>100%\n\n", new Random().Next(500, 1000));
            Console.Clear();
            AIConsole.WriteLine("", new Random().Next(500, 1000));
            AIConsole.WriteLine("", new Random().Next(500, 1000));
            AIConsole.WriteLine("", new Random().Next(500, 1000));


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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeWritter(", Huh, that is a ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            TypeWritter("STUPID ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
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