using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TheTask1;
using TheTask3;




/*Работу выполнил Удалов Евгений Александрович курс разработчик С#
 * 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет 
 * строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не 
 * может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.

    3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. 
    Регистр можно не учитывать:
а) с использованием методов C#;
б) *разработав собственный алгоритм.
Например:
badc являются перестановкой abcd.
 * 
 * 
*/
namespace Lesson5
{
    class Program
    {
        public static void Pause()
        {
            Console.ReadKey();
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static void Print(string n)
        {
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            Print("Домашнее задание 1");
            Print("Введите логин");
            Account ac1 = new Account();
            string a = Console.ReadLine();
            ac1.CorrectLoginReg(a);
            Print(ac1.PrintTo());
            Print("Для продолжения нажмите enter");
            Pause();
            Clear();
            Account ac2 = new Account();
            Print("Введите логин");
            ac2.login = Console.ReadLine();
            ac2.check();
            Print(ac2.PrintTo());
            Console.ReadKey();

            Print("Домашнее задание 2");
            Print(@"хотите проверить вариант: abcd и dcba Введите <y> для того чтобы " +
                "проверить abcd и badc введите любую букву");
            string vib = Console.ReadLine();
            if (vib == "y")
            {
                ComP.s1 = "abcd";
                ComP.s2 = "dcba";
                ComP.Com();
                Print(ComP.Toprint());
            }
            else
            {
                ComP.s1 = "abcd";
                ComP.s2 = "badc";
                ComP.Com();
                Print(ComP.Toprint());
            }

            Pause();
        }
    }
}
