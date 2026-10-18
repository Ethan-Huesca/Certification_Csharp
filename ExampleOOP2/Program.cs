using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person per = new Person(); //instance person class (create object)

            //per.SetName("jorgito"); //call name method. Since its a void method it can be invoked without assigning it to a variable 
            //per.SetLastname("mela pela"); //Set lastname 
            //per.SetAge(33);
            //Console.WriteLine("name: "+per.GetName() + " apellido: "+per.GetLastname() + " edad: "+ per.GetAge().ToString()); //


            Professor prof = new Professor("drzola", "1234", "ala chingada y másallá"); //Instance prof class
            Console.WriteLine("Name: "+prof.GetName());
            Console.WriteLine("dni: "+prof.GetDni());
            Console.WriteLine("direction: "+prof.GetDirection());

            Personal per = new Personal("personal jorgito", "123jorgito");
            per.Wave();
            per = new Student("student jorge","456");
            per.Wave();
            Console.ReadKey();
        }
    }
}
