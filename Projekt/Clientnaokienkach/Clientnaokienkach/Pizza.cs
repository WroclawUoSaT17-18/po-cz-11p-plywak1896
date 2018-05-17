using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientnaokienkach
{
    public class Pizza
    {
      public string Nazwa { get; set; }
      public string Skladniki { get; set; }
        
        int[] ceny =  new int[] { 10, 15, 20, 30 };
        public int Suma(ceny)
        {
            int sum = 0;
            for(int i=0; i<5; i++)
            {
                sum += ceny[i];
            }

            return sum;
        }
    }
}
