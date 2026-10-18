using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public class Person
    {
        //Attributes
        public string Name;
        public int Age;

        public Person(string _name)
        {
            this.Name = _name; //set received value to name local variable
        }

        //Method for a simple hello
        public void SayHi()
        {
            MessageBox.Show("Hello..."+Name);
        }

        //Method for a simple hello with name
        public void Salute(string name)
        {
            MessageBox.Show("Hello Hello "+name);
        }
    }

    public class Human
    {
        public char Gender;
        public bool State;

        public string Name()
        {
            return "Man";
        }
    }

    public enum Names
    {
        John, Pedro, Andrew
    }
}
