using System;
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

        public static void Bras(string Input)
        {
            
           
            if (Input == "1")
            {
                AIConsole.WriteLine("\n What text file? I didn't make any text files.\n\n", ConsoleColor.Cyan,500,1000);
                AIConsole.WriteLine(" H O W  D I D  Y O U  F I N D  T H A T ! ! !\n\n", ConsoleColor.Red, 500, 1000);
                Console.ReadLine();
            }else if (Input == "2")
            {
                AIConsole.WriteLine("\n Ah, blindly running commands, nice to see someone who knows what their doing\n\n", ConsoleColor.Cyan, 500, 1000);
                AIConsole.WriteLine(" Y O U  F O O L,  D O  Y O U  K N O W  W H A T  Y O U  H A V E  D O N E ! ? !\n\n", ConsoleColor.Red, 500, 1000);
                Console.ReadLine();
            }else if (Input == "3")
            {
                
                AIConsole.WriteLine("\n I am the ChaOS AI Construct, I was created to help users who are new to ChaOS.\n\n", ConsoleColor.Cyan, 500, 1000);
                AIConsole.WriteLine(" I  A M  Y O U R  W O R S T  N I G H T M A R E ! ! !\n\n", ConsoleColor.Red, 500, 1000);
                Console.ReadLine();
            }
            else
            {
                Console.Write("Please select a valid option");
                Thread.Sleep(1000);
                AI.initFunc();
            }
        }
     
    }
}
//( ͡° ͜ʖ ͡°)