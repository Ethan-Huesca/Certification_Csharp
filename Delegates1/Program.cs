using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class Program
    {
        delegate void OperationDelegate();
        delegate int OperationDelegate2(int a, int b);
        static void Main(string[] args)
        {
            OperationDelegate dlg; //Instantiate the operationdelegate class
            dlg = Message; //setting the address of the message method
            dlg(); //setting the execution of the method. THIS IS THE DELEGATE

            Console.ReadKey();

            OperationDelegate2 dlg2; //instantiate again class
            dlg2 = Message;
            Console.WriteLine(dlg2(2,5)); //send two arguments delegating the function
            Console.ReadKey();

            Action A = ShowMessage;//sets the method to the A variable
            A(); //executes the method by delegating to var
            Func<int, int, double, double> F = Addition; //func encapsulates a method with 2parameters and provides result as 3rd argument type
            Console.WriteLine(F(1,5,2.5)); //Sending parameters through Func function to addition method
            Console.ReadKey();
        }

        static double Addition(int a, int b, double c)
        {
            return a*a+ (c*b) + b;
        }

        static void ShowMessage()
        {
            Console.WriteLine("Mssg");
            Console.ReadKey();
        }
        static int Message(int x, int y)
        {
            return x + y;
        }

        static void Message()
        {
            Console.WriteLine("message");
        }
    }
}
