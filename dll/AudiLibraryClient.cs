using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudiLibrary;
//if namespace is commented then we need to write AudiLibrary.Audi
namespace AudiLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi r7 = new Audi();
            r7.start();
        }
    }
}
