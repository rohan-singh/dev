using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPOL
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 10;
            p1.y = 20;
            Point p2 = new Point();
            p2.x = 10;
            p2.y = 20;
            Point p3 = p1 + p2;
            //p3 = Point.operator+(p1,p2);

        }

    }

    class Point
    {
        public int x;
        public int y;
        //compulsory op ol to be implemented as static

        static public Point operator +(Point lhs, Point rhs)
        {
            Point temp = new Point();
            temp.x = lhs.x + rhs.x;
            temp.y = lhs.x + rhs.y;
            return temp;
        }
    }
}


