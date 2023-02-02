using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    static class IntParse
    {
        public static int Parse(string message, ILogger logger)
        {
            int number = 0;
            bool Isnumber = false;
            while (!Isnumber)
            {
                logger.Event(message);
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    Isnumber = true;
                }
                catch (FormatException)
                {
                    logger.Error("Введено не число");
                }

            }
            return number;
        }
    }
}
