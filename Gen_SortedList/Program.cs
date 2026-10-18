using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sList = new SortedList<int, string>(); //create object of sorted list

            sList.Add(1, "one");
            sList.Add(10, "ten");
            sList.Add(100, "hundred");
            sList.Add(15, "fifteen");

            for(int i = 0; i < sList.Count; i++)
            {
                Console.WriteLine("keys: {0}, values: {1}", sList.Keys[i].ToString(), sList.Values[i]);
            }

            string value;
            //tryGetValue checks for a specific key to show its value
            if(sList.TryGetValue(10,out value)) //out shows the output from the key 10
            {
                Console.WriteLine("index 10 value is: "+value); //output value from key
            }
            else
            {
                Console.WriteLine("key not found"); //if key is not found
            }

            bool key = sList.ContainsKey(15); //checks if key 15 exists on list
            bool val = sList.ContainsValue("one"); //checks if one value exists on list
            Console.WriteLine("key 15 exists? "+key.ToString());
            Console.WriteLine("value one exists? " + val.ToString());
            Console.ReadKey();
        }
    }
}
