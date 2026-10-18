using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_method
{
    class Parameters
    {
        static void Main(string[] args)
        {
            Func<int, int, int> F = delegate (int A, int B)
              {
                  return A + B;
              };
            F(9,99); 
            Action<string> S;
            S = delegate (string message)
            {
                Console.WriteLine(message);
            };
            S("message wakanda");
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
