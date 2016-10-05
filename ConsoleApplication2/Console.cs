using System;
using System.Threading;
using System.Media;

namespace ConsoleApplication2
{
    internal static class AiConsole
    {
        //this is the remake of the Console.WriteLine(); function.
        //it has Thread.Sleep(); and ConsoleColor built in.
        //this has been done for both the Console.WriteLine and Console.Write functions.
        public static void WriteLine(string text, ConsoleColor colour, int delay)
        {
            //add typewriter func here
            Console.ForegroundColor = colour;
            //Console.WriteLine(Text);
            //Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(delay);
            var simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");

            foreach (var letter in text)
            {
                Console.Write(letter);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            //Console.WriteLine(Text);
            //Console.ForegroundColor = ConsoleColor.White;
            var simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");
            foreach (var letter in text)
            {
                Console.Write(letter);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string text, int delay)
        {
            //Console.WriteLine(Text);
            Thread.Sleep(delay);
            var simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");
            foreach (var letter in text)
            {
                Console.Write(letter);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string text)
        {
            //Console.WriteLine(Text);
            var simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");
            foreach (var letter in text)
            {
                Console.Write(letter);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

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
