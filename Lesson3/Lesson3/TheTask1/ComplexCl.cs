using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask1
{
    /// <summary>
    /// комлексные числа класс
    /// </summary>
    public class ComplexCl
    {
       
            // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
            public double im;
            public double re;
        /// <summary>
        /// Суммма комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
            public ComplexCl Plus(ComplexCl x2)
            {
            
                ComplexCl x3 = new ComplexCl();
                x3.im = x2.im + this.im;
                x3.re = x2.re + this.re;
                return x3;
            }
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
        public ComplexCl Minus(ComplexCl x2)
        {
            ComplexCl x3 = new ComplexCl();
            x3.im = x2.im - this.im;
            x3.re = x2.re - this.re;
            return x3;
        }
        /// <summary>
        /// Произведение комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns></returns>
        public ComplexCl Multi(ComplexCl x2)
        {
            ComplexCl x3 = new ComplexCl();
            x3.im = x2.re * this.im + x2.im * this.re;
            x3.re = x2.re * this.re - x2.im * this.im;
            return x3;
        }
        public string ToString()
            {
                return re + "+" + im + "i";
            }
        


    }
}
