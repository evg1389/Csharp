using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Работу выполнил Удалов Евгений курс разработчик С#
*/

namespace TheTask2
{
    public class CountNumber
    {
        public static void Print()
        {
            Console.WriteLine("Введите число для посчета количества цифр");
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            while(x!=0)
            {
                count++;
                x = x / 10;

            }
            Console.WriteLine(count);

        }
    }
}
