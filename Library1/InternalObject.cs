using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class InternalObject
    {
        public string name = "Hello"; //Internal type cant be referenced in main class
        public string name2 = "jorge";
        public int age = 100;
        public readonly string lastname = "huesca"; //REadonly doesnt let the value to be modified

        /*void method()
        {
            lastname = "";
        }*/

        public InternalObject() {
            lastname = "mlp";
        }
    }

    public static class TooInternalObject
    {
        public static string name3 = "goodbye"; //Internal type cant be referenced in main class
        public static string name23 = "jason";
        public static int age3 = 200;
    }

    public class Deriv : InternalObject
    {
        new public int age = 15; //Deriv class inherits age attribute from InternalObject class. Declared NEW value
        public void PrintName()
        {
            System.Console.WriteLine(name2);
        }
        public void PrintAge()
        {
            System.Console.WriteLine(age);
        }
        public void PrintAgeFather()
        {
            System.Console.WriteLine(base.age); //base.age calls for the age attribute from base (father) class
        }
    }

    /*public class Meriv : TooInternalObject
    {
        new public int age3 = 234;
        public void TooprintAgeFather()
        {
            System.Console.WriteLine(TooInternalObject.age3)
        }
    }*/
}
