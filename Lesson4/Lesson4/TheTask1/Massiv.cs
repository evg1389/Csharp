using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Работу выполнил Удалов Евгений Александрович курс разработчик С#
 */
namespace TheTask1
{
    public class Massiv
    {
        /// <summary>
        /// Поля для работы с массивом
        /// </summary>
        private static int[] Mas = new int[20];
        public static int n = 0;

        /// <summary>
        /// Метод для рандомного заполнения массива
        /// </summary>
        /// <returns></returns>
        public static int[] Array()
        {
            Random rnd = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rnd.Next(-10000, 10000);
            }
            return Mas;
        }


        /// <summary>
        /// Метод для проверки пар на деление 3 без остатка
        /// </summary>
        public static void PrintCouple()
        {
            int Temp;
            int Temp2;
            
            
            for (int i=0; i < Mas.Length;)
            {
                Temp = Mas[i];
                
                if (Temp % 3 == 0)
                {

                    n++;
                    i++;
                }
                else
                {
                    i++;
                    for (int j = i; j < Mas.Length;)
                    {
                        Temp2 = Mas[j];
                        
                        if (Temp2 % 3 == 0)
                        {
                            n++;
                            
                        }


                        i++;
                        break;

                    }
                }

            }
        }


        /// <summary>
        /// основной метод вывода сообщения
        /// </summary>
        /// <returns></returns>
        public static string  Print()
        {
            
            if (n == 0)
            {
                return "Количество пар деленных на 3 без остатка не найдено!";
            }
            else
            {
                return $"Количество пар деленных на 3 без остатка найденнот :{n}";
            }
            
        }
    }
}
