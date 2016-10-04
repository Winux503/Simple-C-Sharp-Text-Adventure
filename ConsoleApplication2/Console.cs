using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Media;

namespace ConsoleApplication2
{
    static class AIConsole
    {
        //this is the remake of the Console.WriteLine(); function.
        //it has Thread.Sleep(); and ConsoleColor built in.
        //this has been done for both the Console.WriteLine and Console.Write functions.
        public static void WriteLine(string Text, ConsoleColor Colour, int Delay)
        {
            //add typewriter func here
            Console.ForegroundColor = Colour;
            //Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(Delay);
            SoundPlayer simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(Text[i]);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string Text, ConsoleColor Colour)
        {
            Console.ForegroundColor = Colour;
            //Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
            SoundPlayer simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(Text[i]);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string Text, int Delay)
        {
            //Console.WriteLine(Text);
            Thread.Sleep(Delay);
            SoundPlayer simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(Text[i]);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void WriteLine(string Text)
        {
            //Console.WriteLine(Text);
            SoundPlayer simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(Text[i]);
                simpleSound.Play();
                Thread.Sleep(50);
            }
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
