using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    static class Emp//static block
    {
        static int stat1;
        static public void disp()
        {
            Console.WriteLine("disp " + stat1);
        }
        static Emp()//no access modifiers on static cons
        {
            stat1 = 100;
            Console.WriteLine("Static cons");
        }
    }
    class Address
    {
        //static
        static int stat = 200;
        int local;
        static public void show(Address a1)
        {
            Console.WriteLine(a1.local);
            //Console.WriteLine(local); //err
            Console.WriteLine(stat);
            //Console.WriteLine(a1.stat); //err
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Emp e1 = new Emp();//err
            Emp.disp();
            Address a1 = new Address();
            Address.show(a1);

        }
    }
}
