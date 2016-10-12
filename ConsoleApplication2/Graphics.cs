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
    class GraphicsCon
    {
        public static string fileName = "intro.wav";
        public static string path = Path.Combine(Environment.CurrentDirectory, @"sound\", fileName);
        public static string fileName2 = "intro.wav";
        public static string path2 = Path.Combine(Environment.CurrentDirectory, @"sound\", fileName2);
        private static void DrawCredits()
        {

        }
        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }

        }


        public static void GMain()
        {
            ConsoleColor[] Colours = {
            ConsoleColor.Red,
            ConsoleColor.Blue,
            ConsoleColor.Cyan,
            ConsoleColor.Green,
            ConsoleColor.Magenta,
            ConsoleColor.Yellow
            };
            Console.Clear();
            AIConsole.WriteLine("", ConsoleColor.White,500,1000);
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;
            for (int Width = 0; Width < Console.WindowWidth; ++Width)
            {
                for (int Height = 0; Height < Console.WindowHeight; ++Height)
                {
                    Console.BackgroundColor = Colours[new Random().Next(0, 6)];
                    Console.ForegroundColor = Colours[new Random().Next(0, 6)];
                    WriteAt("m", Width, Height);
                    Console.WriteLine();
                    Thread.Sleep(new Random().Next(1,5));
                }
            }
            
            Console.ResetColor();
            Console.SetCursorPosition(0,0);
            AIConsole.WriteLine(" \n----------------------------Credits----------------------------\n\n", ConsoleColor.White,500,1000);
            AIConsole.WriteLine(" iMoD1998 - Cronstuction of the new Console commands and ideas\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" tfm - Grumbler\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" Squad Chat - \"Morale Support\"\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" MLP - Ideas and assistance\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" Winux503 - Initial ideas and implementation\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" BLB - Being French\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" BLJ - Existing\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" Tizzle - Being a Gizzle\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" Jack - Being Scouse\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" Lewis - GNU\\Linux\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" TeOz - Being a spooki\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" /r/csharp - Being kind and suggesting ideas \n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" Druaga1 - Providing the music \n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine(" ----------------------------Credits----------------------------\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.WriteLine("Press enter to continue...\n\n",ConsoleColor.White);
            Console.ReadLine();
           
            Console.Clear();
        }
    }
}
