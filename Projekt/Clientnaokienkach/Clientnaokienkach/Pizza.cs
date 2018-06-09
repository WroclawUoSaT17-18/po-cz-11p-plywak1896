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
      public int Cena { get; set; }

      public static string Adding(float arg1, float arg2)
       {
            return (arg1 + arg2).ToString();
       }

    }

    
}
