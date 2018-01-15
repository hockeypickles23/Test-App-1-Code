using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == 'a')
            {
                Console.WriteLine("That is not a number KNOCK IT OFF!");
            }
            else
            {
                Console.WriteLine("\nDid you type {0}", keyInfo.KeyChar.ToString());
            }
            printfootoscreen100times();
        }
        static void printfootoscreen()
        {
            Console.WriteLine("Foo");
        }
        static void printfootoscreen100times()
        {
            for (int counter = 0; counter <= 100; counter++)
            {
                printfootoscreen();
            }
        }
    }
}