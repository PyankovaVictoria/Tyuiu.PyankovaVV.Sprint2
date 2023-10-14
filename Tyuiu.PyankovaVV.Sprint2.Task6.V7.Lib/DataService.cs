using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PyankovaVV.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int allMonths = n % 12;
            string month;
            switch (allMonths)
            {
                case 0:
                    month = "январь";
                    break;
                case 1:
                    month = "февраль";
                    break;
                case 2:
                    month = "март";
                    break;
                case 3:
                    month = "апрель";
                    break;
                case 4:
                    month = "май";
                    break;
                case 5:
                    month = "июнь";
                    break;
                case 6:
                    month = "июль";
                    break;
                case 7:
                    month = "август";
                    break;
                case 8:
                    month = "сентябрь";
                    break;
                case 9:
                    month = "октябрь";
                    break;
                case 10:
                    month = "ноябрь";
                    break;
                case 11:
                    month = "декабрь";
                    break;
                default:
                    month = "неверное значение";
                    break;
            }
            return month;
        }
    }
}
