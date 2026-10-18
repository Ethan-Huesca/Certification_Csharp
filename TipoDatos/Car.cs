using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDatos
{
    class Car
    {
        string brand = "BMW";
        double lengh = 4.9;
        double wide = 1.89;
        int guarantee = 5;
        char state = 'A';
        bool enabled = true;

        string[] varArray = { "HOLA", "JORGE", "NOSE", "QUE MAS", "DECIR" };

        delegate void mydelegate(string _name); //signatures to invoke different methods that comply with the delegate´s characteristics

        enum colors: short //short type to point 16bit int
        {
            red = 1,
            black = 0,
            blue = 0
        }

        struct properties
        {
            public string model;
            //create constructor to assign values
            public properties(string _mod)
            {
                model = _mod;
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            properties pro = new properties("c230z"); //create new object from propertoes
            int[] numbers = new int[] { 1, 2, 4, 5 }; //create new int array 
            mydelegate del = new mydelegate(Run); //method to be controlled muust be specified as a parameter
            
            Console.WriteLine(car.brand + " " + car.guarantee.ToString());
            Console.WriteLine(colors.red + " " +car.enabled.ToString()+ " " + pro.model);
            Console.WriteLine(car.varArray[1].ToString());
            del("delegate316");
            Console.ReadKey();
        }

        static public void Run(string name) 
        {
            Console.WriteLine("hello hello "+name);
            //throw new NotImplementedException();
        }
    }
}
