using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue tail = new Queue(); //Queue is a first In - first Out method
            tail.Enqueue("chain"); //Enqueue method takes type object
            tail.Enqueue(18);
            tail.Enqueue(98.2);
            char continue_ = 'y'; //variable for the do-while cycle
            int option = 0; //variable for selecting option in do-while

            Console.WriteLine("number of elements: " + tail.Count.ToString());
            object last_element = tail.Dequeue(); //removes 1st element
            Console.WriteLine("removed element");

            Console.WriteLine("number of elements: " + tail.Count.ToString());
            Console.WriteLine("first element removed: "+last_element.ToString());
            Console.WriteLine("last element: "+tail.Peek().ToString());

            do
            {
                Console.Clear();
                Console.WriteLine("--------MENU--------"); //Display menu
                Console.WriteLine("1. add element: ");
                Console.WriteLine("2. count elements: ");
                Console.WriteLine("3. Search element: ");
                Console.WriteLine("4. clean tail ");

                Console.WriteLine("Enter option: ");
                option = int.Parse(Console.ReadLine()); //convert input to int

                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter element");
                        tail.Enqueue(Console.ReadLine()); //enqueue method to enter element into queue
                        Console.WriteLine("element added");
                        break; //
                    case 2:
                        Console.WriteLine("number of elements: "+tail.Count.ToString()); //.count to count 
                        break;
                    case 3:
                        if (tail.Contains(Console.ReadLine()))
                        {
                            Console.WriteLine("found element");
                        }
                        else
                        {
                            Console.WriteLine("couldn´t find element");
                        }
                        break;
                    case 4:
                        tail.Clear();
                        Console.WriteLine(tail.Count.ToString()+" elementos");
                        break;
                }

                Console.ReadKey();


            } while (continue_ == 'y'||continue_=='Y');
            Console.ReadKey();

        }
    }
}
