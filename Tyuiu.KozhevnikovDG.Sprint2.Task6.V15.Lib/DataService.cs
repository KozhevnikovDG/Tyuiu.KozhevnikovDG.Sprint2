using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozhevnikovDG.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            
            switch ((k - 1) % 7)
            {
                case 0:return "Понедельник";
                case 1:return "Вторник";
                case 2:return "Среда";
                case 3:return "Четверг";
                case 4:return "Пятница";
                case 5:return "Суббота";
                case 6:return "Воскресенье";
                default: throw new ArgumentException($"день делжен быть от 1 до 365. Значение {k}");
                



            }
        }
    }
}
