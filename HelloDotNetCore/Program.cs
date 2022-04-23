using HelloDotNetCore.Basic;
using System;
using HelloDotNetCore.OOPS.Inheritance;

namespace HelloDotNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Basics

            //Input input = new Input();

            // HelloMethods obj=new HelloMethods();
            //int sum=obj.Add(34, 45);
            // HelloMethods.EvenNumbers(30);

            // Inputuser inp = new Inputuser();

            //buildintype build = new buildintype();

            // Stringtype strtype = new Stringtype();

            // commonoperator common = new commonoperator();

            //ternaryoperator5 ternary = new ternaryoperator5();

            // datatypeconversion7 conversion = new datatypeconversion7();

            //class8array arr = new class8array();

            // Class11switch swt = new Class11switch();
            // customer c1 = new customer();
            // c1.printfullname();
            // customer c2 = new customer("p", "t");
            //c2.printfullname();

            //Circle c1 = new Circle(5);
            // float area1 = c1.CalculateArea();
            // Console.WriteLine("area={0}", area1);

            //Circle c2 = new Circle(5);
            //float area2 = c2.CalculateArea();
            //Console.WriteLine("area={0}", area2);



            #endregion

            #region OOPS
            //Inheritance (is a)
            Employee employee = new Employee();
            Employee employe1 = new FullTimeEmployee();// a parent class reference can refer to child class instance

            #endregion




        }
    }
}
