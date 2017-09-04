using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using CalcContract;


    namespace CalcLib
    {
        //public interface ICalculator
        //{
        //    int Sum(int a, int b);

        //}
        public class CalcFactory
        {
            public static ICalculator GetCalculator()  // ICalculator : return type
            {
                //using reflection = RTTI
                //read config first
                //key value dictionary
                string calcLib = ConfigurationManager.AppSettings["CALCLIB"]; //helps to read key config file | CALCLIB gives calclib.dll
                string calcClass = ConfigurationManager.AppSettings["CALCCLASS"]; // CALCCLASS will read type of calculator

                Assembly assembly = Assembly.LoadFrom(calcLib); //loading my own dll after reading 
                //from the client | without loading this also we can get the output as they are in the same implementation

                //convert string form of class name to actual class type
                Type theType = Type.GetType(calcClass);

                //activator creates object without new
                ICalculator calc = (ICalculator)Activator.CreateInstance(theType);
                return calc; //obj returned

            }
        }
        internal class SimpleCalculator : ICalculator
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }
        }
        internal class ScientificCalculator : ICalculator
        {
            public int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }


