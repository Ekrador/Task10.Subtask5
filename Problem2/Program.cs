using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var calc = new Calculator(Logger);
            int summ = calc.Add();
            Logger.Event("Сумма равна " + summ);
            Console.ReadLine();
        }
    }

    class Calculator : ISum
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public int Add()
        {
            int value1 = 0;
            int value2 = 0;
            value1 = IntParse.Parse("Введите первое слагаемое.", Logger);
            value2 = IntParse.Parse("Введите второе слагаемое.", Logger);
            return value1 + value2;
        }
    }
}
