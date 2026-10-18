using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public abstract class Person //added "public" to ensure it can be accesed from anywhere
    {
        private string name; //private can only be accesed from this Person class
        protected string name2; //protected 
        private const int document = 1234; //constant must have an initial value and cant be null

        public abstract string Name2 //make it public so it can be overwritten
        {
            get;
            set;
        }

        public virtual void MyMethod() //this method needs to be implemented in derivated class
        {

        }
    }

    public class Employee : Person //same level of acces as father class
    {
        private int age;
        void Method()
        {
            name2.ToString();
        }

        public override string Name2 //Override to override the Name property 
        {
            get { return name2; }
            set { name2 = value; }
        }

        public override void MyMethod()
        {
            //base.MyMethod();
            System.Console.WriteLine("Overwritten method");
        }
    }
}
