using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 Работу выполнил Удалов Евгений Александрович курс разработчик С#
 */
namespace TheTask2
{
    public class Massiv2
    {
        /// <summary>
        /// Поля для работы с массивом
        /// </summary>
        public  int[] Mas ;
        public  int result;
        public  int maxN;


        /// <summary>
        /// Свойство максимальное число массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = Mas[0];
                for (int i = 1; i < Mas.Length; i++)
                    if (Mas[i] > max) max = Mas[i];
                return max;
            }
        }

        /// <summary>
        /// Свойство минимальное число массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = Mas[0];
                for (int i = 1; i < Mas.Length; i++)
                    if (Mas[i] < min) min = Mas[i];
                return min;
            }
        }


        /// <summary>
        ///  Класс для рандомного заполнения массива и определения количества ячеик
        /// </summary>
        /// <returns></returns>
        public Massiv2(int n)
        {
            Mas= new int [n];
            Random rnd = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rnd.Next();
            }

            
        }

        /// <summary>
        /// конструктор для класса массива для определения количества массива и шагом
        /// </summary>
        /// <param name="n"> количество ячеик массива</param>
        /// <param name="min">минимальное число массива</param>
        /// <param name="max">максимальное число массива</param>
        public Massiv2(int n, int min,int max)
        {
            Mas = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rnd.Next(min,max);
            }
            
        }
        /// <summary>
        /// функция суммы массива
        /// </summary>
        /// <returns></returns>
        public  int Sum()
        {
            for(int i=0;i<Mas.Length;i++)
            {
                result += Mas[i];
            }
            return result;
        }
        /// <summary>
        /// функция замены местами в обратном порятде массива
        /// </summary>
        /// <returns></returns>
        public  int[] Inverse()
        {
            Mas.Reverse();
            return Mas;
        }
        /// <summary>
        /// функция замены знаков местами плюс на минус минус на плюс
        /// </summary>
        /// <returns></returns>
        public  int [] Csigns()
        {
            for(int i=0;i<Mas.Length;i++)
            {
                Mas[i] = Mas[i] * (-1);
            }
            return Mas;
        }
        /// <summary>
        /// функция умножения на число
        /// </summary>
        /// <param name="U">число на которое будет умножение</param>
        /// <returns></returns>
        public  int Multi(int U)
        {
            for(int i=0;i<Mas.Length;i++)
            {
                result = Mas[i] * U;
            
            }
            return result;
        }
        /// <summary>
        /// Функция нахождения максимального числа
        /// </summary>
        /// <returns></returns>
        public  int MaxCount()
        {
            maxN=Mas[0];
            for(int i=0;i<Mas.Length;i++)
            {
                
                if (maxN<Mas[i])
                {
                    maxN = Mas[i];
                }
            }
            return maxN;
        }

        /// <summary>
        /// функция записи массива в фаил
        /// </summary>
        public  void GreateTxT()
        {
            StreamReader sr = new StreamReader(@"Massiv2.txt");
            sr.Close();
        }
        /// <summary>
        /// функция считывания с файла
        /// </summary>
        /// <returns></returns>
        public  int[] LoadMasTxT()
        {
            try
            {
                StreamReader sr = new StreamReader(@"d:\Massiv2.txt");

                int n = int.Parse(sr.ReadLine());
                Mas = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Mas[i] = int.Parse(sr.ReadLine());
                }
                
            }
            catch
            {
                Console.WriteLine("Фаил не найден!");
            }
            return Mas;
        }
        public Massiv2()
        {

        }
        public string Print()
        {
            return "результат:" + result;
           
        }
    }
}
