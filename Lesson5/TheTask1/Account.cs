using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
namespace TheTask1
{
    public class Account
    {
        /// <summary>
        /// поля класса Аккаунт
        /// </summary>
        public string login;
        public string result;
        public bool chek1;
        /// <summary>
        /// метод вохврящающий результат прверки
        /// </summary>
        /// <returns></returns>
        public string check()
        {
            LoginCorrect();
            if (chek1 == true)
            {
                return result = "коректный";
            }
            else
            {
                return result = "не коректный!";
            }

        }
        /// <summary>
        /// метод проверки по регулярному выражению
        /// </summary>
        /// <param name="login">поле логин</param>
        /// <returns></returns>
        public string CorrectLoginReg(string login)
        {
            
            Regex login_regex = new Regex("^[A-Za-z][a-zA-Z0-9]{2,10}$");
            

            if (login_regex.Match(login).Success) // если совпадение удачно
            {

                return result="Коректный";
            }
            else
            {
                return result="не коректный!";
            }



        }
        /// <summary>
        /// метод проверяющий условия правила ввода логина
        /// </summary>
        /// <returns></returns>
        public bool LoginCorrect()
        {

            if (login.Length < 2 || login.Length > 10)
            {
                chek1 = true;
                

            }

            if (!Char.IsDigit(login[0]))
            {
                chek1 = true;


            }
            else
            {
                chek1 = false;
            }

            return chek1;
            
        }
        /// <summary>
        /// метод для показа результата проверок
        /// </summary>
        /// <returns></returns>
        public string PrintTo()
        {
            return "Ваш логин "+result;
        }
    }
}
