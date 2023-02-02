using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    static class IntParse
    {
        public static int Parse(string message)
        {
            int number = 0;
            bool Isnumber = false;
            while (!Isnumber)
            {
                Console.WriteLine(message);
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    Isnumber = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено не число");
                }

            }
            return number;
        }
    }
}
