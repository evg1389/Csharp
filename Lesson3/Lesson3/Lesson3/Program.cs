using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTask1;
using TheTask2;

//Работу выполнил Удалов Евгений Александровис курс разработчик С#

/*    1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму 
всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении
ошибки вывести сообщение.Напишите соответствующую функцию;
*/

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            // структура Cpmpleks
            Compleks complex1;
            complex1.real = 1;
            complex1.imag = 1;

            Compleks complex2;
            complex2.real = 2;
            complex2.imag = 2;

            Compleks result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());



            // класс Complex
            ComplexCl complex3 = new ComplexCl();
            complex3.re = 1;
            complex3.im = 1;

            ComplexCl complex4 = new ComplexCl();
            complex4.re = 2;
            complex4.im = 2;

            ComplexCl result2 = complex3.Plus(complex4);
            Console.WriteLine(result.ToString());
            result2 = complex3.Minus(complex4);
            Console.WriteLine(result.ToString());
            result2 = complex3.Multi(complex4);
            Console.WriteLine(result.ToString());
            #endregion

            #region Задание 2
            SumNumberN SumNumber1 =new SumNumberN();
            double j;
            Console.WriteLine("Вводите числа для отмены наберите 0:");
            do
            {
                string input = Console.ReadLine();


                
                if (double.TryParse(input, out j))
                {


                    if (j >= 0)
                    {

                        SumNumber1.Sum(j);

                        Console.WriteLine(SumNumber1.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели отрицательное число!");
                    }

                }
                else
                {
                    Console.WriteLine("Не коректный ввод!");
                }
            } while (j != 0);

            #endregion

            Console.ReadKey();
        }
    }
}
