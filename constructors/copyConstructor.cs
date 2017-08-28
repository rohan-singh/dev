using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticDemo
{

    class Test
    {
        int data;
        public Test()
        {
            Console.WriteLine("cons");
        }
        public Test(Test t1) //copy constructor
        {
            this.data = t1.data;
            Console.WriteLine("copy");
        }
    }
    class interfaceExample
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test(t1);

        }
    }
}
