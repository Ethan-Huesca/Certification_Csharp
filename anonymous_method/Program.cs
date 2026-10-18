using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_method
{
    class Program
    {
        delegate void ShowMessageDelegate();
        static void Main(string[] args)
        {
            Action E = ShowMessage; //Delegate method by setting to action
            E(); //Executing action

            Action D = delegate () //Anonymous method (no name, just create the method)
            {
                Console.WriteLine("Anonymous - wakanda 4ever");
            };
            D(); //Execute anonymous method
            ShowMessageDelegate C = delegate ()
            {
                Console.WriteLine("delegate anonymous method");
            };
            C(); //Execut delegate anonymous method
            Console.ReadKey();
        }

        static void ShowMessage()
        {
            Console.WriteLine("Delegate - wakanda forever");
        }
    }
}
