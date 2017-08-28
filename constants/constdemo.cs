//const | readonly | static readonly
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Account
    {
        const int ifsc_code=1001;//by def static
        public readonly int micr_code=345;//var initializer
        static readonly int stat_read=777;
        static Account()
        {
            stat_read = 456;
        }
        public Account()
        {
            micr_code = 25;
            //stat_read = 1;
        }
        public Account(int code)
        {
            this.micr_code = code;
        }
        public void disp()
        {
            //micr_code = 50;
            Console.WriteLine(micr_code+"   "+ifsc_code+" "+stat_read);
        }
    }
    class ConstDemo
    {
        static void Main(string[] args)
        {
            //Account a1 = new Account() { micr_code = 100 };
            Account a2 = new Account(code:123);//var initailizer
            a2.disp();
        }
    }
}
