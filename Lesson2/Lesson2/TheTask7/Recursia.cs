using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask7
{
    
    public class Recursia
    {
        static void Loo(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b) Loo(a + 1, b);
        }
        public static void Print()
        {
            Loo(1, 30);
        }
    }
}
