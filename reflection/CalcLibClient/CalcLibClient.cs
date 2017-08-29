using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;
using CalcContract;
namespace CalcLibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number");
            int fno = int.Parse(Console.ReadLine());
            Console.Write("enter sec number");
            int sno = int.Parse(Console.ReadLine());
            //CalcFactory fac = new CalcFactory();
            ICalculator calc = CalcLib.CalcFactory.GetCalculator();
            int sum = calc.Sum(fno, sno);
            Console.WriteLine(sum);
        }
    }
}
