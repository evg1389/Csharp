using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask1
{
    /// <summary>
    /// Комплексные числа структура
    /// </summary>
    public struct Compleks
    {
        public double real;
        public double imag;
        /// <summary>
        /// Сумма комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Compleks Plus(Compleks x)
        {
            Compleks y;
            y.imag = imag + x.imag;
            y.real = real + x.real;
            return y;
        }
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Compleks Minus(Compleks x)
        {
            Compleks y;
            y.imag = imag - x.imag;
            y.real = real - x.real;
            return y;
        }
        /// <summary>
        /// Произведение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Compleks Multi(Compleks x)
        {
            Compleks y;
            y.imag = real * x.imag + imag * x.real;
            y.real = real * x.real - imag * x.imag;
            return y;
        }

        public string ToString()
        {
            return real + "+" + imag + "i";
        }

    }
}
