using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTask1;
using TheTask2;

/*
 Работу выполнил Удалов Евгений Александрович курс разработчик С#

    1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000
    до 10 000 включительно. Написать программу, позволяющую найти и вывести количество пар элементов массива,
    в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента
    массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной 
размерности и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которые 
возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий
каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
В Main продемонстрировать работу класса.
б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 */
namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Задание 1
            Console.WriteLine("Домашнее задание 1");

            Massiv.Array();
            Massiv.PrintCouple();
            Console.WriteLine(Massiv.Print());
            Console.ReadKey();
            #endregion
            */
            Console.Clear();
            #region Задание 2
            Massiv2 ar = new Massiv2(5);
            for(int i=0;i<ar.Mas.Length;i++)
            {
                Console.WriteLine(ar.Mas[i]);
                
            }

            ar.Sum();
            Console.WriteLine("сумма массивов");
            Console.WriteLine(ar.Print());
            int n = 2;
            ar.Multi(n);
            Console.WriteLine("произведение массивов");
            Console.WriteLine(ar.Print());
            Massiv2 ar2 = new Massiv2(6, 0, 20);

            for (int i = 0; i < ar2.Mas.Length; i++)
            {
                Console.WriteLine(ar2.Mas[i]);

            }

            Console.WriteLine("max");
            Console.WriteLine(ar2.MaxCount());
            Console.WriteLine("Create");
            Massiv2 ar3 = new Massiv2();
            ar3.LoadMasTxT();

            for (int i = 0; i < ar3.Mas.Length; i++)
            {
                Console.WriteLine(ar3.Mas[i]);

            }
            #endregion
            Console.ReadKey();
        }
    }
}
