using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Работу выполнил Удалов Евгений Александрович курс разработчик C#
 1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double).
 Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке 
находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
возвращает минимум через параметр. 
 */
namespace TheTask2
{
    public delegate double Func(double x);
    public delegate void SF(string F, double a, double b, double h);
    public delegate double Lo(string F);

    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вы зашли в программу нахождения минимума функции");
            Console.WriteLine (@"Что вы хотите сделать введите свой выбор где:
              1) Сохранить данные
              2) Загрузить данные
              3) Либо просто подсчитать?
                ");
            int vb =Convert.ToInt32(Console.ReadLine());
            SF sf = SaveFunc;
            Lo l = Load;
            Func fu = F;
            switch (vb)
            {
                case 1:
                    Console.WriteLine("Сначало введите файл после этого нажмите enter и введите поочередно три числа");
                    string f = Console.ReadLine();
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    double n3 = Convert.ToDouble(Console.ReadLine());
                    
                    sf(f, n1, n2, n3);
                    break;
                case 2:
                    Console.WriteLine("Введите название файла с которого долны считать числа ");

                    string f2 = Console.ReadLine();
                    
                    l(f2);
                    break;
                case 3:
                    Console.WriteLine("Введите число");
                    
                    double num = Convert.ToDouble(Console.ReadLine());
                    double result=fu(num);
                    Console.WriteLine("результат" + result);
                    break;
                default:
                    Console.WriteLine("Ввывели неверное значение!");
                    break;
            }
            Console.WriteLine("");
            ArrayList  d = new ArrayList(3);
            d.Add(sf);
            d.Add(l);
            d.Add(fu);
            d.Sort();
            
            //SaveFunc
            //Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }


    }
}



