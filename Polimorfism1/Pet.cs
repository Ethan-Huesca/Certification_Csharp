using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism1
{
    abstract class Pet
    {
        protected string _name;
        protected int _age;

        public abstract string Salute();
    }

    class Cat : Pet
    {
        public Cat(string name) : base()
        {
            this._name = name;
        }
        public override string Salute()
        {
            return "hello cat: "+this._name;
        }
    }

    class Bird : Pet
    {
        public Bird(string name) : base()
        {
            this._name = name;
        }
        public override string Salute()
        {
            return "hello bird: "+this._name;
        }
    }
}
