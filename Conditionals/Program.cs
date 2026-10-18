using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string study = string.Empty; //empty string
            int career = 0;
            Console.WriteLine("insert new age"); //text
            age = int.Parse(Console.ReadLine()); //readline asks for user console input
            if (age > 6)
            {
                Console.WriteLine("old enough");
                Console.WriteLine("Study? y/n");
                study = Console.ReadLine();
                if(study == "Y" || study == "y")
                {
                    Console.WriteLine("udem or tec");
                }
                else
                {
                    Console.WriteLine("you are trash brock");
                    Console.WriteLine("Select career");
                    Console.WriteLine("1-industrial");
                    Console.WriteLine("2-mechatronic");
                    Console.WriteLine("3-architect");
                    Console.WriteLine("4-medic");
                    career = int.Parse(Console.ReadLine());
                    switch (career)
                    {
                        case 1:
                            Console.WriteLine("industrial");
                            break;
                        case 2:
                            Console.WriteLine("mecha");
                            break;
                        case 3:
                            Console.WriteLine("arch");
                            break;
                        case 4:
                            Console.WriteLine("medic");
                            break;
                    }
                }
                    
            }
            else { Console.WriteLine("basura brock"); }

            Console.ReadKey();
        }
    }
}
