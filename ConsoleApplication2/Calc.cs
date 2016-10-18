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

            int output = 0;
            string Input = "";
            int numberOne;
            //string Mod;
            int numberTwo;
            AIConsole.Write(" \nWelcome to the Simple calculator application\n\n",ConsoleColor.White,500,1000);
            AIConsole.Write(" \nPlease enter the calculation\n\n", ConsoleColor.White, 500, 1000);
            Input = Console.ReadLine();
            if (Input.Contains('+'))
            {
                string[] numbers = Input.Split('+');
                numberOne = Convert.ToInt32(numbers[0]);
                numberTwo = Convert.ToInt32(numbers[1]);
                output = numberOne + numberTwo;
            }else if (Input.Contains('-'))
            {
                string[] numbers = Input.Split('-');
                numberOne = Convert.ToInt32(numbers[0]);
                numberTwo = Convert.ToInt32(numbers[1]);
                output = numberOne - numberTwo;
            }
            else if (Input.Contains('/'))
            {
                string[] numbers = Input.Split('/');
                numberOne = Convert.ToInt32(numbers[0]);
                numberTwo = Convert.ToInt32(numbers[1]);
                output = numberOne / numberTwo;
            }
            else if (Input.Contains('*'))
            {
                string[] numbers = Input.Split('*');
                numberOne = Convert.ToInt32(numbers[0]);
                numberTwo = Convert.ToInt32(numbers[1]);
                output = numberOne * numberTwo;
            }
            AIConsole.Write(" \nThe answer is: " + output, ConsoleColor.White, 500, 1000);
        }
    }
}
