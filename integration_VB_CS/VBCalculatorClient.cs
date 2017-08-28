//in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CalculatorLibrary;


namespace VBCalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10; b = 20;
            CalculatorLibrary.Calculator calc = new CalculatorLibrary.Calculator();
            Console.WriteLine(calc.add(a,b));
        }
    }
}
