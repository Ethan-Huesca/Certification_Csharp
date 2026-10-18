using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Queue cola = new Queue();
            Stack pila = new Stack();

            Hashtable table = new Hashtable();
            SortedList list = new SortedList();

            Dictionary<int,string> dic = new Dictionary<int, string>();

            Figure<double> fig = new Figure<double>(); //instantiation of a generic class
            fig.size = 2.22;
            Console.WriteLine("size of the figure: "+fig.size.ToString());

            //add elements of type object to arraylist
            al.Add(23);
            al.Add("hola");
            al.Add(true);

            for(int d=0; d < al.Count; d++)
            {
                Console.WriteLine(al[d].ToString());
            }
            Console.Read();
        }
    }
}
