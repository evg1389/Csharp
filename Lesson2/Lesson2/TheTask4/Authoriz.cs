using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Работу выполнил Удалов Евгений курс разработчик С#
*/

namespace TheTask4
{
    public class Authoriz
    {
        public static void Print()
        {
            string Login = "root";
            string Password = "GeekBrains";
            Console.WriteLine("Для доступпа введите логин и пароль");
            int i = 0;
            int x = 2;
            bool bo = false;
            do// первый цикл для выхода должно быть значение true
            {
                if (i == 0 )// проверяем должны ли мы войти во второй цикл для проверки правильности логина и пароля
                {
                    do
                    {
                        
                        Console.WriteLine("Введите логин:");
                        string login = Console.ReadLine();
                        Console.WriteLine("Введите пароль:");
                        string password = Console.ReadLine();
                        if (login == Login & password == Password)
                        {
                            Console.WriteLine("Вы успешно вошли!");
                            bo = true; //все гуд ставим значение true для выхода из первого цикла
                            break;// прекращаем второй цикл
                            
                        }
                        else
                        {
                            Console.WriteLine($"Вы ввели неверный логин или пароль у вас осталось {x} попытки");
                            x--;
                            i++;
                        }
                    } while (i <= 2);
                    
                    
                }
                else
                {
                    Console.WriteLine("Вы исчерпали свои попытки!Программа закрываеться!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            } while (bo != true);//
            Console.WriteLine("Добро пожаловать");
        }
    }
}
