using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Connect()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint direction = new IPEndPoint(IPAddress.Parse("192.168.0.195"), 80); //connection point like an IP address
            
            //try catch for exceptions
            try
            {
                socket.Bind(direction); //associate socket to ip address
                socket.Listen(1); //listen to only 1 ipaddress once is associated
                Console.WriteLine("Listening...");

                Socket listener = socket.Accept(); //accepts connection with a client 

                Console.WriteLine(  "succesfull connection");
                socket.Close();
                //while (true)
                //{
                //    listener.RemoteEndPoint{ }
                //}
            }
            catch(Exception exc)
            {
                Console.WriteLine("Error: "+exc.Message.ToString()); //show error message if exception occurs 
            }
            Console.WriteLine("insert key");
            Console.ReadKey();
          
        }
    }
}
