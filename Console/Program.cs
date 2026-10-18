using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person per = new Person(); //create new object for person class
            InternalObject io = new InternalObject();
            io.name2 = "";

            Employee emp = new Employee(); //Can be instantiated because its not abstract
            Deriv d = new Deriv(); //instantiate deriv class
            d.PrintAge();
            d.PrintName();
            d.PrintAgeFather();
            System.Console.WriteLine(TooInternalObject.age3);
            emp.MyMethod();

            System.Console.ReadKey();
        }
    }
}
