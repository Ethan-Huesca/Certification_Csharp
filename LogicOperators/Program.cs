using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 8;
            int number2 = 9;
            int answer;
            int answer2;

            answer = ((number1 + number2) - number2) * 3;
            answer2 = (number2^2) % number1;

            Console.WriteLine("First answ: "+answer.ToString());
            Console.WriteLine("2nd answ: "+answer2.ToString());

            Console.ReadKey();
        }
    }
}
