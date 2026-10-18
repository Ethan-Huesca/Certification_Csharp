using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action D; //Delegate type action 
            D = MT1; //set method to delegate D
            D += () => Console.WriteLine("Method2"); //Set lambda expression additional to current delegate

            D += delegate () //set delegate expression additional to current delegate
            {
                Thread.Sleep(3000);
                Console.WriteLine("Method3");
            };

            D += () => //another way of displaying, lambda expression
             {
                 Console.WriteLine("Method4");
                 Console.WriteLine("Method5");
             };

            D(); //Execute delegate by calling method

            Console.ReadKey();
        }

        static void MT1()
        {
            Console.WriteLine("Method1");
        }
    }
}
