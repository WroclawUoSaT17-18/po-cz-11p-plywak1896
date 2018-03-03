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
            Console.WriteLine("Witam w programie liczącym średnią..");
            Console.WriteLine("Proszę podać pierwszą ocenę:");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać drugą ocenę:");
            float e = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać trzecią ocenę:");
            float f = float.Parse(Console.ReadLine());
            student student1 = new student(d,e,f);
            Console.WriteLine(student1.srednia());
            Console.ReadKey(); 
        }
    }
}

class student
{
    private float a ;
    private float b ;
    private float c ;

    public student(float a1,float b2,float c3)
    {
     a = a1;
     b = b2;
     c = c3;
}
    public float srednia()
    {
    Console.WriteLine("Średnia ma wartość:");
        return ((a + b + c) / 3);
        
    }
}