using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOOP2
{
    public class Person
    {
        //private attributes means objects cannot reference them in other classes
        private string _name; 
        private string _lastname;
        private int _age;
        private string _document;

        //public method to access attributes from other classes
        public void SetName(string name)
        {
            this._name = name; //give attribute the new name value
        }

        //public method to access attributes from other classes
        public string GetName()
        {
            return this._name; //return name value
        }

        //public method to access attributes from other classes
        public void SetLastname(string lastname)
        {
            this._lastname = lastname; //give attribute the new lastname value
        }

        //public method to access attributes from other classes
        public string GetLastname()
        {
            return this._lastname; //return lastname value
        }

        //public method to access attributes from other classes
        public void SetAge(int age)
        {
            this._age = age; //give attribute the new age value
        }

        //public method to access attributes from other classes
        public int GetAge()
        {
            return this._age; //return age value
        }
    }
}
