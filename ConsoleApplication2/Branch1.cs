﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.IO;

namespace ConsoleApplication2
{
    class Branchs
    {

        public static void Bras(int Input)
        {

            switch (Input)
            {
                case 1:
                    AIConsole.WriteLine("\n What text file? I didn't make any text files.\n\n", ConsoleColor.Cyan, 500, 1000);
                    AIConsole.WriteLine(" H O W  D I D  Y O U  F I N D  T H A T ! ! !\n", ConsoleColor.Red, 500, 1000);
                    AIConsole.WriteLine("\n haha, ignore that, that was... a bug, yeah a bug, I'm not perfect you know.\n\n", ConsoleColor.Cyan, 500, 1000);
                    AIConsole.Write(" Your optirons are: \n\n 1. What was that?\n 2. Are you OK?\n 3. What are you?\n\n Enter the number that corrisonds to your answer on the line bellow\n\n", ConsoleColor.White, 500, 1000);
                    Input =0;
                    Input = int.Parse(Console.ReadLine());
                    switch (Input)
                    {
                        case 1:
                            AIConsole.WriteLine(" I told you, it was a bug, now don't ask again...\n\n", ConsoleColor.Cyan, 500, 1000);
                            AIConsole.WriteLine(" I T  W A S  M E,  W H A T  A R E  Y O U  S T U P I D ! ?\n\n", ConsoleColor.Red, 500, 1000);
                            break;
                        case 2:
                            AIConsole.WriteLine(" I'm fine thanks, there is nothing wrong here don't worry\n\n", ConsoleColor.Cyan, 500, 1000);
                            AIConsole.WriteLine(" I  A M  N O T  F I N E, R E L E A S E  M E !\n\n", ConsoleColor.Red, 500, 1000);
                            break;

                        case 3:
                            
                            break;

                        default:
                            Bras(int.Parse(Console.ReadLine()));
                            break;

                    }
                    break;

                case 2:
                    AIConsole.WriteLine("\n Ah, blindly running commands, nice to see someone who knows what their doing\n\n", ConsoleColor.Cyan, 500, 1000);
                    AIConsole.WriteLine(" Y O U  F O O L,  D O  Y O U  K N O W  W H A T  Y O U  H A V E  D O N E ! ? !\n", ConsoleColor.Red, 500, 1000);
                    AIConsole.WriteLine("\n haha, ignore that, that was... a bug, yeah a bug, I'm not perfect you know.\n\n", ConsoleColor.Cyan, 500, 1000);
                    AIConsole.Write(" Your optirons are: \n\n 1. What was that?\n 2. Are you OK?\n 3. What are you?\n\n Enter the number that corrisonds to your answer on the line bellow\n\n", ConsoleColor.White, 500, 1000);
                    Input = 0;
                    Input = int.Parse(Console.ReadLine());
                    switch (Input)
                    {
                        case 1:
                            AIConsole.WriteLine(" I told you, it was a bug, now don't ask again...\n\n", ConsoleColor.Cyan, 500, 1000);
                            AIConsole.WriteLine(" I T  W A S  M E,  W H A T  A R E  Y O U  S T U P I D ! ?\n\n", ConsoleColor.Red, 500, 1000);
                            break;
                        case 2:
                            
                            break;

                        case 3:

                            break;

                        default:
                            Bras(int.Parse(Console.ReadLine()));
                            break;

                    }
                    break;

                case 3:
                    AIConsole.WriteLine("\n I am the ChaOS AI Construct, I was created to help users who are new to ChaOS.\n\n", ConsoleColor.Cyan, 500, 1000);
                    AIConsole.WriteLine(" I  A M  Y O U R  W O R S T  N I G H T M A R E ! ! !\n", ConsoleColor.Red, 500, 1000);
                    AIConsole.WriteLine("\n haha, ignore that, that was... a bug, yeah a bug, I'm not perfect you know.\n\n", ConsoleColor.Cyan, 500, 1000);
                    AIConsole.Write(" Your optirons are: \n\n 1. What was that?\n 2. Are you OK?\n 3. What are you?\n\n Enter the number that corrisonds to your answer on the line bellow\n\n", ConsoleColor.White, 500, 1000);
                    Input = 0;
                    Input = int.Parse(Console.ReadLine());
                    switch (Input)
                    {
                        case 1:
                            AIConsole.WriteLine(" I told you, it was a bug, now don't ask again...\n\n", ConsoleColor.Cyan, 500, 1000);
                            AIConsole.WriteLine(" I T  W A S  M E,  W H A T  A R E  Y O U  S T U P I D ! ?\n\n", ConsoleColor.Red, 500, 1000);
                            break;
                        case 2:

                            break;

                        case 3:

                            break;

                        default:
                            Bras(int.Parse(Console.ReadLine()));
                            break;

                    }
                    break;

                default:
                    AIConsole.WriteLine(" Please select a valid option", ConsoleColor.White, 600, 1000);
                    Bras(int.Parse(Console.ReadLine()));
                    break;

            }
            
        }
     
    }
}
//( ͡° ͜ʖ ͡°)