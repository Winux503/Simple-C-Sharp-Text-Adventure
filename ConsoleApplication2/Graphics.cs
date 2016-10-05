using System;
using System.Threading;

namespace ConsoleApplication2
{
    internal static class GraphicsCon
    {
        private static int _originalRow;
        private static int _originalColumn;

        private static void DrawCredits()
        {
        }

        private static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(_originalColumn + x, _originalRow + y);
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
            ConsoleColor[] colours =
            {
                ConsoleColor.Red,
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Magenta,
                ConsoleColor.Yellow
            };

            Console.Clear();

            _originalRow = Console.CursorTop;
            _originalColumn = Console.CursorLeft;

            for (var i = 0; i < 120; i++)
                for (var o = 0; o < 60; o++)
                {
                    Console.ForegroundColor = colours[RandomNumber.Between(0, 5)];
                    WriteAt("+", i, o);
                    Console.WriteLine();
                    Thread.Sleep(1);
                }

            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
            AiConsole.WriteLine(" \n----------------------------Credits----------------------------\n\n",
                ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" iMoD1998 - Cronstuction of the new Console commands and ideas\n\n", ConsoleColor.White,
                RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" tfm - Troubleshooting and testing\n\n", ConsoleColor.White,
                RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" Squad Chat - \"Morale Support\"\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" MLP - Ideas and assistance\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" Winux503 - Initial ideas and implementation\n\n", ConsoleColor.White,
                RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" BLB - Being French\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" BLJ - Existing\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" Tizzle - Being a G\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" Jack - Being Scouse\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" Lewis - GNU\\Linux\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" TeOz - Being a spooki\n\n", ConsoleColor.White, RandomNumber.BasicTextDelay());
            AiConsole.WriteLine(" ----------------------------Credits----------------------------\n\n",
                ConsoleColor.White, RandomNumber.BasicTextDelay());
        }
    }
}