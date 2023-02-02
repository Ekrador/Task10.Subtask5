using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            int summ = calc.Add();
            Console.WriteLine("Сумма равна " + summ);
            Console.ReadLine(); 
        }
    }

    class Calculator : ISum
    {
        public Calculator() { }
        public int Add()
        {
            int value1 = 0;
            int value2 = 0;
            value1 = IntParse.Parse("Введите первое слагаемое.");
            value2 = IntParse.Parse("Введите второе слагаемое.");
            return value1 + value2;
        }   
    }
}
