using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KozhevnikovDG.Sprint2.Task4.V14.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint2.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Кожевников Д. Г. | ИИПБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Кожевников Данил Георгиевич | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x, y с ");
            Console.WriteLine("* клавиатуры.                                                              ");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());
          
            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();


        }
    }
}
