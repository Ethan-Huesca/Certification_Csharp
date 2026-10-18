using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pile = new Stack(); //create object of new stack
            pile.Push(34); //Adds an object in the pile
            pile.Push("ethan"); //Adds an object in the pile
            pile.Push(true); //adds an object in the pile
            pile.Push(34.6); //Can add any type since its an object

            Console.WriteLine("number of elements on pile: " + pile.Count.ToString());

            double lastelement = double.Parse(pile.Pop().ToString()); //Get the last element and convert it to double
            bool value = bool.Parse(pile.Peek().ToString()); //check which is the last element

            Console.WriteLine("Element out: "+lastelement.ToString());
            Console.WriteLine("Now we have "+pile.Count.ToString()+" elements");
            Console.WriteLine("Last element now is: "+value.ToString());
            Console.WriteLine();
            Books library = new Books(); //Instance the books class
            library.AddBook(6); //add 6 books
            string value2 = library.ReturnLastElement().ToString(); //get last element on pile and convert to string
            Console.WriteLine("last element: "+value2);
            Console.WriteLine("number of elements: "+library.CountBooks().ToString());
            
            Console.WriteLine();

            Console.WriteLine("type the book you want to consult: ");
            if (library.ConsultBook(Console.ReadLine())){ //Ask the user for the name of a specific book
                Console.WriteLine("found the book"); //text if true
            }
            else
            {
                Console.WriteLine("book not found"); //text to display if false
            }

            Console.WriteLine("wish to remove one? Y/N");
            if(Console.ReadLine()=="Y" || Console.ReadLine() == "y")
            {
                library.RemoveBook(); //Call for the remove book method
            }
            Console.WriteLine("number of elements: " + library.CountBooks().ToString());
            Console.ReadKey(); //Pause
        }
    }
}
