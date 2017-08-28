using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudiLibrary
{
        abstract public class Car
        {
            public abstract void start();
        }

        public class Audi:Car
        {
            public override void start()
            {
                Console.WriteLine("AUDI started");
            }
        }

            public class Class1
            {

            }
    }
