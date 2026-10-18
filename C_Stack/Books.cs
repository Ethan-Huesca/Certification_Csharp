using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Stack
{
    public class Books
    {
        private Stack pileDB = new Stack();

        public void AddBook(int number)
        {
            Console.WriteLine("please add " + number.ToString() + " elements");
            for(int i=1;i<=number; i++)
            {
                object element; //create an object variable
                element = Console.ReadLine(); //Read value from input console
                pileDB.Push(element); //add element to pile
            }
        }

        public object RemoveBook()
        {
            object element;
            element = pileDB.Pop(); //removes object from pile stack
            return element;
        }

        public bool ConsultBook(object search)
        {
            bool find = false; //find variable as false as predetermined
            find = pileDB.Contains(search); //Contains function to check if search variable is in pile
            return find; //returns true or false
        }

        public object ReturnLastElement()
        {
            object element;
            element = pileDB.Peek(); //This method returns last element on the pile
            return element; //return the found element
        }

        public void CleanBooks()
        {
            pileDB.Clear(); //Clean all elements from the pile
        }

        public int CountBooks()
        {
            return pileDB.Count; //return the count of elements
        }
    }
}
