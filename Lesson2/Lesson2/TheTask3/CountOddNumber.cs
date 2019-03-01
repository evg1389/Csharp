using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Работу выполнил Удалов Евгений курс разработчик С#
*/

namespace TheTask3
{
    public class CountOddNumber
    {
        public static void Print()
        {
            int x, count = 0;
            Console.WriteLine("Введите целые числа:");
            Console.WriteLine("Для отмены введите 0 ");
            do
            {
                x = int.Parse(Console.ReadLine());
                if(x%2!=0)
                {
                    count++;
                }

            }
            while (x != 0);
            Console.WriteLine(count);
        }
    }
}
