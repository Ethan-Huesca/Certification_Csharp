using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();

            IDictionary<string, string> myDict2 = new Dictionary<string, string>();
            myDict2.Add("key1", "value1");
            myDict2.Add("key2", "value2");
            myDict2.Add("key3", "value3");
            myDict2.Add(new KeyValuePair<string, string>("1", "one")); //different waay to add value
            

            foreach(KeyValuePair<string,string> element in myDict2) //cycle to print keys and values
            {
                Console.WriteLine("Keys: {0}, values: {1}", element.Key, element.Value);
            }

            string val; 
            if(myDict2.TryGetValue("key3",out val))
            {
                Console.WriteLine("Value found: "+val.ToString());
            }
            Console.ReadKey();
        }
    }
}
