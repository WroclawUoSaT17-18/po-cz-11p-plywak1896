using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1024); // nasz serwer
           
            try
            {
                listener.Start(); // rozpoczęcie nasłuchiwania 
                

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
            }

            try
            {

               
                TcpClient newClient = listener.AcceptTcpClient(); // akceptacja
                Console.WriteLine("Połączono nowego klienta");
                
                while (true)
                {
                BinaryReader reader = new BinaryReader(newClient.GetStream());
                Console.WriteLine("Klient przesyła:" + reader.ReadString());
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();

            }
            
        }
    }
}



