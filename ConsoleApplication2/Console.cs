using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication2
{
    static class AIConsole
    {
        public static void WriteLine(string Text, ConsoleColor Colour, int Delay)
        {
            Console.ForegroundColor = Colour;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(Delay);
        }

        public static void WriteLine(string Text, ConsoleColor Colour)
        {
            Console.ForegroundColor = Colour;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteLine(string Text, int Delay)
        {
            Console.WriteLine(Text);
            Thread.Sleep(Delay);
        }

        public static void WriteLine(string Text)
        {
            Console.WriteLine(Text);
        }

        public static void Write(string Text, ConsoleColor Colour, int Delay)
        {
            Console.ForegroundColor = Colour;
            Console.Write(Text);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(Delay);
        }

        public static void Write(string Text, ConsoleColor Colour)
        {
            Console.ForegroundColor = Colour;
            Console.Write(Text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(string Text, int Delay)
        {
            Console.Write(Text);
            Thread.Sleep(Delay);
        }

        public static void Write(string Text)
        {
            Console.Write(Text);
        }
    }
}
