using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ca = new Car("Audi","A4", 100, 300, 1196533,"black");
            ca.IncreaseKm(10);
            ca.ChangeColor("gray");
            Console.WriteLine("km: "+ca.ShowKm.ToString());

            Vehicle ve = new Vehicle("Chevrolet", "corvette", 10, 500);
            ve.ChangeColor("blue");
            Console.WriteLine(ve.ToString());
            Console.ReadKey();
        }
    }
}
