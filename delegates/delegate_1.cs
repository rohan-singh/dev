using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //class MyDelegate:MulticastDelegate
    //{
    //    //ctor
    //}

    public delegate void MyDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            /*comparing with fnction pointer in cpp
             * 
             * void (*ptr)(string)
             * ptr = Disp;
             * ptr("abcd");
             */

            MyDelegate dele = new MyDelegate(Disp);
            //dele("qwer");
            //dele.Invoke("abcd");
            Program p1 = new Program();
            //Publish-Subscribe Pattern
            dele += Show;//subscribe : adding function to delegate
            dele("lop");
            dele.Invoke("abcd");
            dele -= Disp;//un subscribing
            dele("pop");
            // Disp("abcd");

        }
        public static void Disp(string name)
        {
            Console.WriteLine("Disp " + name);
        }
        public static void Show(string name)
        {
            Console.WriteLine("Show " + name);
        }
    }
}
