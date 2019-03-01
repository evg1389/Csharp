using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTask1;
using TheTask2;
using TheTask3;
using TheTask4;
using TheTask5;
using TheTask7;

/*
 Работу выполнил Удалов Евгений курс разработчик С#
*/
namespace Lesson2
{
    class Program
    {
        static void Clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            
            #region 1
            Console.WriteLine("Задание 1:");
            CompValue.PrintValue();
            #endregion
            
            
             Clear();
            Console.WriteLine("Задание 2:");
            CountNumber.Print();
            Clear();

            Console.WriteLine("Задание 3:");
            CountOddNumber.Print();

            Clear();
            Console.WriteLine("Задание 4:");
            Authoriz.Print();

            Clear();
            Console.WriteLine("Задание 5:");
            Person.Print();
            
            Console.WriteLine("Задание 7:");
            Recursia.Print();

            Clear();
        }
    }
}
