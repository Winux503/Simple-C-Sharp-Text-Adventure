using System;
using System.Threading;
using System.Media;

namespace ConsoleApplication2
{
    internal class Branchs
    {

        public static void Bras(string input)
        {

            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeWritter("\n What text file? I didn't make any text files.\n\n");
                Console.ForegroundColor = ConsoleColor.Red;
                TypeWritter(" H O W  D I D  Y O U  F I N D  T H A T ! ! !\n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadLine();
            }

            else if (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeWritter("\n Ah, blindly running commands, nice to see someone who knows what their doing\n\n");
                Console.ForegroundColor = ConsoleColor.Red;
                TypeWritter(" Y O U  F O O L,  D O  Y O U  K N O W  W H A T  Y O U  H A V E  D O N E ! ? !\n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadLine();
            }

            else if (input == "3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeWritter("\n I am the ChaOS AI Construct, I was created to help users who are new to ChaOS.\n\n");
                Console.ForegroundColor = ConsoleColor.Red;
                TypeWritter(" I  A M  Y O U R  W O R S T  N I G H T M A R E ! ! !\n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ReadLine();
            }

            else
            {
                Console.Write("Please select a valid option");
                Thread.Sleep(1000);
                Ai.InitFunc();
            }

        }

        private static void TypeWritter(string text)
        {
            var simpleSound = new SoundPlayer(@"E:\ConsoleApplication2\ConsoleApplication2\sound\Blip_Select3.wav");

            foreach (var letter in text)
            {
                Console.Write(letter);
                simpleSound.Play();
                Thread.Sleep(50);
            }
        }

    }
}
