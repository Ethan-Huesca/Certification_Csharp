using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOOP2
{
    public class Personal
    {
        private string name;
        private string dni;

        public Personal(string _nam, string _dni)
        {
            this.name = _nam; //set new name
            this.dni = _dni; //set new dni
        }

        public string GetName()
        {
            return name; //Return name value
        }

        public void SetName(string _name)
        {
            this.name = _name; //set new name to name attribute
        }

        public string GetDni()
        {
            return dni; //Return name value
        }

        public void SetDni(string _dni)
        {
            this.dni = _dni; //set new name to name attribute
        }

        public virtual void Wave() //virtual makes the other classes override the method
        {
            Console.WriteLine("hola jorge, :"+name+" y me la turbopelas");
        }
    }

    //Professor class now inherits personal class attributes and methods
    public class Professor : Personal
    {
        private string direction;

        public string GetDirection()
        {
            return this.direction;
        }
        //constructor
        public Professor(string _nam_, string _dni_, string _direc) : base(_nam_, _dni_) //base makes reference to father class (Personal)
        {
            this.direction = _direc;
        }
    }
}
