using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1; //
            char continuee = 'n';
            int option;
            while (x <= 10)
            {
                Console.WriteLine(x.ToString());
                x++;
            }
            string sayHI = "hello";
            for(int i = 0;i<4; i++)
            {
                Console.WriteLine(i.ToString());
            }
            foreach(char c in sayHI)
            {
                Console.WriteLine(c);
            }
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1.- Add values");
                Console.WriteLine("2.- count");
                Console.WriteLine("3.- Separate chain");
                Console.WriteLine("4.- Out");

                Console.WriteLine("choose an option");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        double value1, value2;
                        Console.WriteLine("enter 1st number");
                        value1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("enter 2nd number");
                        value2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Added values: {0} + {1} = {2} ",value1,value2,value1+value2);
                        break;
                    case 2:
                        int number;
                        Console.WriteLine("write number between 2-40"); //printed message
                        number = int.Parse(Console.ReadLine()); //declar input number to count from
                        for(int j = 1; j <= number; j++)
                        {
                            Console.WriteLine(j.ToString());
                        }
                        break;
                    case 3:
                        string chain;
                        Console.WriteLine("write your name");
                        chain = Console.ReadLine();
                        foreach(char c in chain)
                        {
                            Console.WriteLine(c.ToString());
                        }
                        break;
                    case 4:
                        Console.Clear(); //Clean before closing
                        Console.WriteLine("closing system");
                        return; //breaks out of all loops
                }

                Console.WriteLine("continue with more options? y/n");
                continuee = char.Parse(Console.ReadLine());
            }while(continuee == 'Y' || continuee == 'y');
            Console.Clear(); //clean console output
            Console.WriteLine("closing");

            Console.ReadKey();
        }
    }
}
