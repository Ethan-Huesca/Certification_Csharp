using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOOP2
{
    public class Student : Personal
    {
        //constructor
        public Student(string _nam_, string _dni_) : base(_nam_, _dni_) //base makes reference to father class (Personal)
        {
            
        }
        public override void Wave()
        {
            //base.Wave();
            Console.WriteLine("mi name is: "+GetName()+" and im student");
        }
    }
}
