using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KozhevnikovDG.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int year = g;
            int month = m;
            int day = n;
            
            switch (m)
            {
                case 1:
                    m = 12;
                    g--;
                    break;
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (n == 1)
                    {
                        n = 30;
                        m--;
                    }
                    else
                    {
                        n--;
                    }
                    break;
                case 2:
                case 4:
                case 6:
                case 9:
                case 11:
                    if (n == 1)
                    {
                        n = 31;
                        m--;
                    }
                    else
                    {
                        n--;
                    }
                    break;
                    
                    
            }    return $"{g}.{m}.{n}";
        }   
    }
}
