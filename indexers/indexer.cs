using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersDemo
{
    class IndexedBooks
    {
        private string[] names = new string[size];
        static public int size = 5;

        public string this[int index] //this should be used in c# to overload []. here "this" will refer to books obj (in main)
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = names[index];
                }
                else
                {
                    tmp = "index wrong";
                }

                return (tmp);
            }
            set
            {
                Console.WriteLine("set");
                if (index >= 0 && index <= size - 1)
                {
                    names[index] = value; //value is inbuilt field
                }
            }
        }

        static void Main(string[] args)
        {
            IndexedBooks books = new IndexedBooks();

            books[0] = "C++";
            books[1] = "C#";
            books[2] = "Java";


            for (int i = 0; i < IndexedBooks.size; i++)
            {
                Console.WriteLine(books[i]);
            }

            Console.WriteLine(books[5]);
        }
    }
}

/*
 * output:
 * set
 * set
 * set
 * C++
 * C#
 * Java
 * blank
 * blank
 * wrong index
 */
