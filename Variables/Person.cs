using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Person
    {
        public static void MyMethod(ref string name, ref int age) //static methods/variables can be called without creating an instance 
        {
            name = "juampon";
            age = 25;
            Console.WriteLine("name: " + name + ", age: " + age.ToString());
        }

        public static void OutMethod(out string nameout, out int ageout)
        {
            nameout = "el tampon";
            ageout = 33;
            Console.WriteLine("name: " + nameout + ", age: " + ageout.ToString());
        }

        public void AnotherMethod(string name, int age)
        {
            Console.WriteLine("name: "+name+", age: "+age.ToString());
        }
    }
}
