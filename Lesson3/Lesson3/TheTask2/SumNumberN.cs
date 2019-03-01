using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask2
{
    /// <summary>
    /// Структура посчета сумму  нечетных чисел
    /// </summary>
    public struct SumNumberN
    {
        /// <summary>
        /// поля 
        /// </summary>
        public double Num;
        public double result;

        /// <summary>
        /// Функция подсчета суммы
        /// </summary>
        /// <returns></returns>
        public double Sum(double n)
        {

            Num = n;
           
            if (Num % 2 != 0)
            {
                result += Num;
            }


            return result;


        }
        /// <summary>
        /// вывод результата
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "Сумма введеных чисел:" + result;
        }

    }
}
