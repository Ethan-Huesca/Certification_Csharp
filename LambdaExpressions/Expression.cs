using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Expression
    {
        static void Main(string[] args)
        {
            Func<string, int, int, decimal> H; //Encapsulate a method with 3parameters
            H = (msg, a, b) => Add(msg, a, b); //lambda expression set to H
            var value = H("daredevil", 100, 200); //set parameters to lambda expression and to a variable
            Console.WriteLine(value); //print variable
            Console.WriteLine(H("punisher", 100, 250)); //lambda expression with input parameters

            Func<string, int, int, decimal> V;
            V = (msg, a, b) => //lambda expression containing the Add method
             {
                 Console.WriteLine($"{msg} {a} {b}");
                 return a + b;
             };

            Console.WriteLine(V("Moonknight", 300, 5)); //set parameters so the previously declared lambda expression

            Console.ReadKey();
        }

        static decimal Add(string msg, int a, int b)
        {
            Console.WriteLine($"{msg} {a} {b}");
            return a + b;
        }

    }
}
