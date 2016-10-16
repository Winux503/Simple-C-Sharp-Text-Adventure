using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Writer
    {
        public static void write()
        {
            Console.Clear();
            AIConsole.Write(" Welcome to the Simple document writing program...\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.Write(" Saving has been disabled sue to a user space error\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.Write(" To start typing just type on the line below\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.Write(" Type \\ to quit\n\n", ConsoleColor.White, 500, 1000);
            AIConsole.Write(" \n\n____________________________________________________unamed.txt____________________________________________________\n\n", ConsoleColor.White, 500, 1000);
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                char ch = Convert.ToChar(Console.Read());
                sb.Append(ch);
                if (ch == '\\')
                {
                    AIConsole.Write("\n\n Returning to prompt...\n\n", ConsoleColor.White, 500, 1000);
                    break;
                }
            }
        }
    }
}
