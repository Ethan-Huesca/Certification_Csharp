using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="mlpDrzola"; //previously declared variables for static method
            int age=24; //previously declared variables for static method
            string nameout;
            int ageout;

            string var1 = "string variable";
            string[] array = {"a01196533", "a01196564", "a01196783"};
            Program pro = new Program(); //Instance or object of class
            Person per = new Person(); //create instance to acces non-static classes
            per.AnotherMethod("king",33);
            Person.MyMethod(ref name,ref age); //static class doesnt need to be instantiated, but its variables need to be referenced
            Person.OutMethod(out nameout, out ageout); 

            Console.WriteLine(name + " " +age);
            Console.WriteLine(array.Length.ToString());
            Console.ReadKey(); //Pause until a key is pressed
        }
    }
}
