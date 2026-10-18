using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start of process 1");
            //ThreadStart delegated = new ThreadStart(Method); //declare thread start so you can use thread, but input another method
            //Thread threads11 = new Thread(delegated); //input threadstart declared object
            //Thread.Sleep(1000);
            //threads11.Start();//from this point, every task will be executed on second hand
            //Console.WriteLine("finish process 1");

            Thread threads11 = new Thread(new ThreadStart(Task1)); //Set thread object with task1 input
            Thread threads22 = new Thread(new ThreadStart(Task2)); //Set thread object with task2 input
            threads11.Start(); //Start thread deployment
            threads22.Start(); //start 2nd thread deployment at the same time
            threads11.Priority = ThreadPriority.Highest; //Set higher priority than thread22
            threads22.Priority = ThreadPriority.Lowest; //set lowest priority 
            Console.ReadKey();
        }

        static private void Method()
        {
            Console.WriteLine("start of process 2");
            Console.WriteLine("finish process 2");
        }

        static private void Task1()
        {
            for (int i = 1; i<=10;i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i.ToString());
            }
        }

        static void Task2()
        {
            for (int j = 11; j <= 20; j++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(j.ToString());
            }
        }
    }
}
