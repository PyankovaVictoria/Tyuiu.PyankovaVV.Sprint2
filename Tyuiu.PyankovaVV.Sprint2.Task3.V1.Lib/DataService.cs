using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PyankovaVV.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                return Math.Round(Math.Exp(x) - 12 * x + Math.Cos(x), 3);
            }
            else if (x == 0)
            {
                return Math.Round(x + (15 / x), 3);
            }
            else if (x > -5 && x < 0)
            {
                return Math.Round(x + 10 * x - (1 / x), 3);
            }
            else if (x < -5)
            {
                return Math.Round(x + 10 * x - (1 / x * x * x + 3), 3);
            }
            else
            {
                return 0;
            }
        }
    }
}
