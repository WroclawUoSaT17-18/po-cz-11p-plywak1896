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
            TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1024);
                try
                {
                    listener.Start(); // rozpoczęcie nasłuchiwania 


                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.Read();
                }

            for (; ; )
            {
                
                



                try
                {

                    bool check = true;
                    TcpClient newClient = listener.AcceptTcpClient(); // akceptacja
                    Console.WriteLine("Połączono nowego klienta");

                    while (check)
                    {
                        BinaryReader reader = new BinaryReader(newClient.GetStream());
                        String value = reader.ReadString();
                        
                        if (value == "#!32")
                        {
                            check = false;
                        }
                        else
                         {
                        Console.WriteLine("Klient przesyła:" + value);
                         }
                    }
                    newClient.Close();
                   
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.Read();

                }
            }
        }
    }
}