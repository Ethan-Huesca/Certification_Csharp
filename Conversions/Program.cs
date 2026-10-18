using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversion - int to int
            int num = 5;
            int num2 = num;

            //Explicit conversion - int to double
            int num3 = 6;
            double num4 = num3;

            //Conversion double to int
            double num5 = 7;
            int num6 = (int)num5;

            //Coonversion from string to int
            string chain = "34";
            int num7 = Convert.ToInt32(chain);

            //Explicit Conversion parse
            string chain2 = "35";
            int num8 = int.Parse(chain2);

            //Explicit conversion string to bool
            string chain3 = "True";
            bool bo = bool.Parse(chain3);

            Console.WriteLine("Implicit conversion: "+num2.ToString());
            Console.WriteLine("Explicit conversion: "+num4.ToString());
            Console.WriteLine("String to int: "+num7.ToString());
            Console.WriteLine("String to int with parse: "+num8.ToString());
            Console.WriteLine("String to bool: "+bo.ToString());
            Console.ReadKey();
        }
    }
}
