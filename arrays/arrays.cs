using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D array
            int[] arr1 = new int[3];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);  
            }
            //Rank gives dimension
            Console.WriteLine(arr1.Rank);

            //2D array
            int[,] arr2 = { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };
            foreach (int i in arr2)
                Console.WriteLine("{0}", i);
            Console.WriteLine(arr2.Rank);

            //Jagged Array
            int[][] arr4 = new int[2][];
            arr4[0] = new int[2]{99, 77};
            arr4[1] = new int[3] { 55, 66, 33 };

            Console.WriteLine(arr4.Length); //2
            Console.WriteLine(arr4[1].Length); //3

            //Rank gives dimension. in case of jagged array, we do not get the right answer
            Console.WriteLine(arr4.Rank); //1
            Console.WriteLine(arr4[0].Rank); //1
            Console.WriteLine(arr4[1].Rank);//1
            for (int i = 0; i < arr4.Length; i++)
            {
                foreach (int j in arr4[i])
                {
                    Console.WriteLine("{0}", j);                    
                }
            }
        }
    }
}
