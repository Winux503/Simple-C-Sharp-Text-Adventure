using System;
using System.Threading;
using System.Media;

namespace ConsoleApplication2
{
    internal static class AiConsole
    {
        private static readonly SoundPlayer _typewriterSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");

        //this is the remake of the Console.WriteLine(); function.
        //it has Thread.Sleep(); and ConsoleColor built in.
        //this has been done for both the Console.WriteLine and Console.Write functions.
        public static void WriteLine(string text, ConsoleColor colour, int delay)
        {
            //add typewriter func here
            Console.ForegroundColor = colour;
            Thread.Sleep(delay);
            foreach (var letter in text)
            {
                Console.Write(letter);
                _typewriterSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string text, ConsoleColor colour) => WriteLine(text, colour, 0);
        
        public static void WriteLine(string text, int delay)
        {
            Thread.Sleep(delay);
            foreach (var letter in text)
            {
                Console.Write(letter);
                _typewriterSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string text) => WriteLine(text, 0);

        public static void Write(string text, ConsoleColor colour, int delay)
        {
            Console.ForegroundColor = colour;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(delay);
        }

        public static void Write(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(string text, int delay)
        {
            Console.Write(text);
            Thread.Sleep(delay);
        }

        public static void Write(string text)
        {
            Console.Write(text);
        }
    }
}
