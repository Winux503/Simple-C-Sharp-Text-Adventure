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
    class StartScreen
    {
        public static bool skip = true;
        public static string fileName = "intro.wav";
        public static string path = Path.Combine(Environment.CurrentDirectory, @"sound\", fileName);
        public static int origRow;
        public static int origCol;
        public static void GraphicsEngine(string s, int x, int y)
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
        public static void skipper()
        {
            if (skip == true)
            {
                Console.ReadKey(Convert.ToBoolean(ConsoleKey.Escape));
                skip = false;
                Thread.Sleep(5000);
            }
            
        }
        public static void TitleScreen()
        {
            /*skipper();
            if (skip == true)
            {*/
                string Logo =
                    @"
 ██████╗ ██████╗ ███╗   ██╗███████╗ ██████╗ ██╗     ███████╗   ██╗    ██╗██████╗ ██╗████████╗███████╗ ██╗
██╔════╝██╔═══██╗████╗  ██║██╔════╝██╔═══██╗██║     ██╔════╝   ██║    ██║██╔══██╗██║╚══██╔══╝██╔════╝██╔╝
██║     ██║   ██║██╔██╗ ██║███████╗██║   ██║██║     █████╗     ██║ █╗ ██║██████╔╝██║   ██║   █████╗  ██║ 
██║     ██║   ██║██║╚██╗██║╚════██║██║   ██║██║     ██╔══╝     ██║███╗██║██╔══██╗██║   ██║   ██╔══╝  ██║ 
╚██████╗╚██████╔╝██║ ╚████║███████║╚██████╔╝███████╗███████╗██╗╚███╔███╔╝██║  ██║██║   ██║   ███████╗╚██╗
 ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝   ╚═╝   ╚══════╝ ╚═╝
                                                                                                         
██╗  ██╗███████╗██╗     ██╗      ██████╗     ██╗    ██╗ ██████╗ ██████╗ ██╗     ██████╗ ██╗              
██║  ██║██╔════╝██║     ██║     ██╔═══██╗    ██║    ██║██╔═══██╗██╔══██╗██║     ██╔══██╗██║              
███████║█████╗  ██║     ██║     ██║   ██║    ██║ █╗ ██║██║   ██║██████╔╝██║     ██║  ██║██║              
██╔══██║██╔══╝  ██║     ██║     ██║   ██║    ██║███╗██║██║   ██║██╔══██╗██║     ██║  ██║╚═╝              
██║  ██║███████╗███████╗███████╗╚██████╔╝    ╚███╔███╔╝╚██████╔╝██║  ██║███████╗██████╔╝██╗              
╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝ ╚═════╝      ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═════╝ ╚═╝              
                                                                                                         
██╗                                                                                                      
╚██╗██╗                                                                                                  
 ██║╚═╝                                                                                                  
 ██║▄█╗                                                                                                  
██╔╝▀═╝                                                                                                  
╚═╝                                                                                                      
";
                ConsoleColor[] Colours = {
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Magenta,
                ConsoleColor.Yellow,
                ConsoleColor.Red
            };

                origRow = Console.CursorTop;
                origCol = Console.CursorLeft;
                SoundPlayer simpleSound = new SoundPlayer(path);
                simpleSound.Play();
                for (int Width = 0; Width < Console.WindowWidth; ++Width)
                {
                    for (int Height = 0; Height < Console.WindowHeight; ++Height)
                    {
                        Console.BackgroundColor = Colours[new Random().Next(0, 6)];
                        GraphicsEngine(" ", Width, Height);
                        Console.WriteLine();
                        Thread.Sleep(new Random().Next(1, 5));
                    }
                }
                Console.SetCursorPosition(0, 0);
                Console.ResetColor();
                TypeWriter(Logo);
                Thread.Sleep(1000);
                Console.ResetColor();
                TypeWriter("Press enter to continue...\n\n");
                Console.ReadLine();
                simpleSound.Stop();
            //}
        }
        public static void TypeWriter(string Text)
        {
            SoundPlayer simpleSound = new SoundPlayer(path);
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(Text[i]);
                //simpleSound.Play();
                Thread.Sleep(5);
            }
        }
    }
}
