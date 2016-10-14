using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Calc
    {
        public static void calc()
        {
            int numberOne;
            string Mod;
            int numberTwo;
            AIConsole.Write(" \nWelcome to the basic calculator application\n\n",ConsoleColor.White,500,1000);
            AIConsole.Write(" \nPlease enter the first number\n\n", ConsoleColor.White, 500, 1000);
            numberOne = int.Parse(Console.ReadLine());
            AIConsole.Write(" \nPlease enter the modifier\n\n", ConsoleColor.White, 500, 1000);
            Mod = Console.ReadLine();
            AIConsole.Write(" \nPlease enter the second number\n\n", ConsoleColor.White, 500, 1000);
            numberTwo = int.Parse(Console.ReadLine());
            
            int output;
            if (Mod == "+")
            {
                output = numberOne + numberTwo;
                AIConsole.Write(" \nThe answer is: " + output, ConsoleColor.White, 500, 1000);
            }
            else if(Mod == "-")
            {
                output = numberOne - numberTwo;
                AIConsole.Write(" \nThe answer is: " + output, ConsoleColor.White, 500, 1000);
            }
            else if(Mod == "*")
            {
                output = numberOne * numberTwo;
                AIConsole.Write(" \nThe answer is: " + output, ConsoleColor.White, 500, 1000);
            }
            else if (Mod == "/")
            {
                output = numberOne / numberTwo;
                AIConsole.Write(" \nThe answer is: " + output, ConsoleColor.White, 500, 1000);
            }
            else
            {
                AIConsole.Write("Please enter a Valid modifier");
            }
        }
    }
}
