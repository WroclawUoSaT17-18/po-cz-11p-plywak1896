using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszaAplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Witam w programie liczącym średnią.");
            Console.WriteLine("Proszę podać ilość studentów:");
            int ilosc = int.Parse(Console.ReadLine());

            for (int g = 0 ; g < ilosc; g++) 
            {
                Console.WriteLine("Proszę podać numer indeksu:");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine("Proszę podać pierwszą ocenę (AiSUK):");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Proszę podać drugą ocenę (Podstawy Automatyki):");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Proszę podać trzecią ocenę (Metrologia Elektryczna):");
                double f = double.Parse(Console.ReadLine());
                student student1 = new student(d, e, f, h);
                Console.WriteLine(student1.Srednia());//
                
            }
            
            Console.ReadKey(); 
        }
    }
}

class student
{
    private double a ;
    private double b ;
    private double c ;
    private int d;

    public student(double a1, double b2, double c3, int d4)
    {
     a = a1;
     b = b2;
     c = c3;
     d = d4;
}
    public double Srednia()
    {
    Console.WriteLine("Średnia studenta nr. " + d + " ma wartość:");
        int f = 3;
        double g = ((a + b + c) / f );

        return Math.Round(g, 2);
        


    }
}


