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
        public static string fileName = "Blip_Select3.wav";
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

        public static void TitleScreen()
        {
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
            ConsoleColor.Yellow
            };
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;
            for (int i = 0; i < 120; i++)
            {
                for (int o = 0; o < 60; o++)
                {
                    Console.BackgroundColor = Colours[new Random().Next(0, 5)];
                    
                    GraphicsEngine(" ", i, o);
                    Console.WriteLine();
                    //Thread.Sleep(new Random().Next(1,5));
                }
            }
            Console.SetCursorPosition(0, 0);
            TypeWriter(Logo);
            Thread.Sleep(1000);
            
        
            
        }
        public static void TypeWriter(string Text)
        {
            SoundPlayer simpleSound = new SoundPlayer(path);
            for (int i = 0; i < Text.Length; i++)
            {
                Console.Write(Text[i]);
                simpleSound.Play();
                Thread.Sleep(5);
            }
        }
    }
}
