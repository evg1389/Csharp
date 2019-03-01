using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Udvoitel
    {
        static public int Number;
         static public int Count;

       static public int Sum()
        {
            Number++;
            Count++;
            return Number;
        }
        static public int Multi()
        {
            Number = Number * 2;
            Count++;
            return Number;
        }
    }
}
