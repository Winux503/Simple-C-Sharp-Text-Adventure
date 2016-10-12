using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace ConsoleApplication2
{
    static class AIConsole
    {

        // Sound api functions
        public static string fileName = "Blip_Select3.wav";
        public static string path = Path.Combine(Environment.CurrentDirectory, @"sound\", fileName);
        public static string fileName2 = "intro.wav";
        public static string path2 = Path.Combine(Environment.CurrentDirectory, @"sound\", fileName2);
        public static bool Playing = false;
       
        
       
        //this is the remake of the Console.WriteLine(); function.
        //it has Thread.Sleep(); and ConsoleColor built in.
        //this has been done for both the Console.WriteLine and Console.Write functions.
        public static void WriteLine(string Text, ConsoleColor Colour, int Delay1, int Delay2)
        {
            if (Playing == true)
            {
                //add typewriter func here
                Console.ForegroundColor = Colour;
                //Console.WriteLine(Text);
                //Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(new Random().Next(Delay1, Delay2));
                SoundPlayer simpleSound = new SoundPlayer(path);
                for (int i = 0; i < Text.Length; i++)
                {
                    Console.Write(Text[i]);
                    new Thread(() => simpleSound.Play()).Start();
                    Thread.Sleep(50);
                }
            }
            else
            {
                SoundPlayer Sound = new SoundPlayer(path2);
                new Thread(() => Sound.Play()).Start();
                Playing = true;
                Console.ForegroundColor = Colour;
                //Console.WriteLine(Text);
                //Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(new Random().Next(Delay1, Delay2));
                SoundPlayer simpleSound = new SoundPlayer(path);
                for (int i = 0; i < Text.Length; i++)
                {
                    Console.Write(Text[i]);
                    new Thread(() => simpleSound.Play()).Start();
                    Thread.Sleep(50);
                }
                
            }
        }

        public static void WriteLine(string Text, ConsoleColor Colour)
        {
            Console.ForegroundColor = Colour;
            //Console.WriteLine(Text);
            //Console.ForegroundColor = ConsoleColor.White;
            SoundPlayer simpleSound = new SoundPlayer(path);
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
            SoundPlayer simpleSound = new SoundPlayer(path);
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
            SoundPlayer simpleSound = new SoundPlayer(path);
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(Text[i]);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

        public static void Write(string Text, ConsoleColor Colour, int Delay1, int Delay2)
        {
            Console.ForegroundColor = Colour;
            Console.Write(Text);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(new Random().Next(Delay1,Delay2));
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
