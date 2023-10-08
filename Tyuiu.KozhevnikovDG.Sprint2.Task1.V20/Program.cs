using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KozhevnikovDG.Sprint2.Task1.V20.Lib;
namespace Tyuiu.KozhevnikovDG.Sprint2.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Кожевников Д. Г. | ИИПБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Кожевников Данил Георгиевич | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,)        *");
            Console.WriteLine("* и логических операций (|,&,||,&&,!,^) последовательность которых         ");
            Console.WriteLine("* не должна нарушаться                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
}
