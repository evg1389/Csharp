using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Работу выполнил Удалов Евгений курс разработчик С#
*/

namespace TheTask1
{
    public class CompValue
    {


        //Метод сравнения и вывод минимального числа
        public static void MinValue(in int x,in  int y, in int f)
        {
            if (x < y && x < f)
            {
                Console.WriteLine($"самое меньшее число х = {x}");
            }
            else if (y<x&& y<f)
            {
                Console.WriteLine($"Самое меньшее число у={y}");
            }
            else
            {
                Console.WriteLine($"Самое меньшее число f={f}");
            }
        }


        //метод для ввода чисел
        public static void SetValue(out int x, out int y, out int f )
        {

            Console.WriteLine("Введите первое число:");
             x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторе число:");
             y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
             f = Int32.Parse(Console.ReadLine());
        }


        //стартовый метод 
        public static void PrintValue()
        {
            int x, y, f;
            Console.WriteLine("Задание первое на сравнение целых чисел вывод наименьщего числа.");
            SetValue(out x,out y, out f);
            MinValue(x,y,f);
        }
    }
}
