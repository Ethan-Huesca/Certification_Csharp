using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[20]; //initialize new array
            string[] mystring = new string[20];
            bool[] mybool = new bool[2];
            int[,] array_bi = new int[3,2];

            array_bi[0,0] = 2;

            myarray[0] = 1;
            myarray[3] = 4;

            mystring[0] = "2";
            mystring[1] = "jorgito";
            mystring[2] = "es";
            mystring[3] = "una vieja";

            array_bi[0, 0] = 2;
            array_bi[0, 1] = 2;
            array_bi[1, 0] = 3;
            array_bi[1, 1] = 3;
            array_bi[2, 0] = 4;
            array_bi[2, 1] = 4;

            Console.WriteLine("array length: " + myarray.Length.ToString());
            foreach (string element in mystring)
            {
                Console.WriteLine(element);
            }
            
            for(int i = 0; i <= array_bi.GetUpperBound(0); i++)
            {
                for(int j = 0; j<=array_bi.GetUpperBound(1); j++)
                {
                    Console.WriteLine(array_bi[i,j].ToString());
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
