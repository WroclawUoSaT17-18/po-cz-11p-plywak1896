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

            
                listener.Start(); // rozpoczęcie nasłuchiwania 
            
            TcpClient newClient = listener.AcceptTcpClient(); // akceptacja
            Console.WriteLine("Połączono nowego klienta");


            for (; ; ) // pętla nieskończoności
            {
                BinaryReader reader = new BinaryReader(newClient.GetStream());
                Console.WriteLine(reader.ReadString());

            }
        }
    }
}