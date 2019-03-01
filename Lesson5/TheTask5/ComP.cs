using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
namespace TheTask3
{
    public class ComP
    {
        /// <summary>
        /// Поля
        /// </summary>
        public static bool pr;
        public static string s1 ;
        public static string s2 ;
        /// <summary>
        /// Функция проверки строк
        /// </summary>
        /// <returns></returns>
        public static bool Com()
        {
            
            int indx1 = s1.Length;
            int indx2 = s2.Length;
            if (indx1==indx2)
            {


                var chars1 = s1.ToCharArray();
                var chars2 = s2.ToCharArray();
                int count = 0;
                int ctr2 = chars2.Length-1;
                do
                {

                    for (int ctr1 = 0; ctr1 < chars1.Length; ctr1++)
                    {
                        if (chars1[ctr1] == chars2[ctr2])
                        {
                            count++;
                        }
                        ctr2--;
                    }
                } while (indx1-1 >= s1.Length);
                if(count==indx1 && count==indx2)
                {
                   return pr = true;
                }
            }
            else
            {
                pr = false;
            }
            return pr;
        }

        public static string Toprint()
        {
            return @"является ли одна строка перестановкой другой:" + pr;
        }
    }
}
