using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    //Father class
    public class Vehicle
    {
        protected string _brand; //protected cannot be used outside the class  , only inside class and subclasses
        protected string _model;
        protected double _km;
        protected int _velocity;

        public Vehicle(){}
        public Vehicle(string brand, string model, double km, int velo)
        {
            this._brand = brand; //set new properties to protected ones
            this._model = model;
            this._km = km;
            this._velocity = velo;
        }

        public override string ToString() //Print the brand and model of the vehicle
        {
            //return base.ToString();
            return "Vehicle => brand: " + _brand + ", model: " + _model;
        }

        public void IncreaseKm(int k)
        {
            this._km = _km + k; //increase by addition
        }

        public virtual void ChangeColor(string color)
        {
            Console.WriteLine("Color not assigned");
        }
    }

    class Car : Vehicle //inheritance class 
    {
        private int codLicense;
        private string color;
        public Car(){ }

        public Car(string brand, string model, double km, int velo, int codlic, string color):
            base(brand, model, km, velo)
        {
            this.codLicense = codlic;
            this.color = color;
        }
        public void method()
        {
            _brand = "";
        }
        public double ShowKm
        {
            get { return this._km; }
        }
        public override void ChangeColor(string col) //method for changing the color 
        {
            this.color = col;
            Console.WriteLine("color: "+color);
        }
    }
}
