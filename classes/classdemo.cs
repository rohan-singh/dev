using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdemo
{
    class Employee
    {
        private int eno, experience;
        private string ename;
        private double salary;

        //using setters and getters

        //setters
        //public void SetEno(int eno)
        //{
        //    this.eno = eno;
        //}
        //public void SetEname(string ename)
        //{
        //    this.ename = ename;
        //}
        //public void SetSalary(double salary)
        //{
        //    this.salary = salary;
        //}

        //getters

        //public int GetEno()
        //{
        //    return eno;
        //}
        //public string GetEname()
        //{
        //    return ename;
        //}
        //public double GetSalary()
        //{
        //    return salary;
        //}



        ////using property
        //public int Eno
        //{
        //    get { return eno; }
        //    set { this.eno = value; } // value is an internal variable
        //}
        //public string Ename //automatic
        //{
        //    get { return ename; }
        //    set { this.ename = value; }
        //}
        //public double Salary
        //{
        //    get { return salary; }
        //    set { this.salary = value; }
        //}

        //public int Eno
        //{
        //    get;
        //    set;
        //}

        // when we have 2 variables of same type:
        public int Eno
        {
            get { return eno; }
            set { this.eno = value; } // value is an internal variable
        }
        public int Experience
        {
            set;
            get;
        }
        public string Ename
        {
            set;
            get;
        }
        public double Salary
        {
            set;
            get;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // method 1 : object initialization
            Employee employee2 = new Employee { Eno = 11, Experience = 4, Ename = "errr", Salary = 40000 }; // method 2 : object initialization


            //employee1.SetEno(11);
            //Console.WriteLine(employee1.GetEno());
            //employee1.SetEname("Rohan");
            //Console.WriteLine(employee1.GetEname());
            //employee1.SetSalary(40000);
            //Console.WriteLine(employee1.GetSalary());

            employee1.Eno = 100;
            Console.WriteLine(employee1.Eno);


            Console.WriteLine(employee2.Eno);
            Console.WriteLine(employee2.Experience);


        }
    }
    
    
}
