using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask5
{
    public class Person
    {
        public static void MassCalculation(out double r, in double growth, in double weight)
        {
            r = weight / (growth * growth);
        }
        public static void WriteP(in double r)
        {
            if (r <= 16)
            {
                Console.WriteLine("Ты как еще живой?");
            }
            else if (r >= 16.1 & r <= 18.5)
            {
                Console.WriteLine("Тебе надо покушать");
            }
            else if (r >= 18.6 & r <= 24.99)
            {
                Console.WriteLine("Эх не парься все нормально");
            }
            else if (r >= 25 & r <= 30)
            {
                Console.WriteLine("Так тебе нужно взять гантельки");
            }
            else if (r >= 30.1 & r <= 35)
            {
                Console.WriteLine("Взял гантели и побежал марш бросок на 10 км");
            }
            else
            {
                Console.WriteLine("Ты вообще человек?");
            }

        }
        public static void Print()
        {
            double r;
            Console.WriteLine("Введите свой рост м.см пример 1,75: ");

            double growth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес в кг:");
            double weight = Convert.ToDouble(Console.ReadLine());
            MassCalculation(out r, growth, weight);
            WriteP(r);

        }
    }
}
