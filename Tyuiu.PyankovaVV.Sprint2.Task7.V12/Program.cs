using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyankovaVV.Sprint2.Task7.V12.Lib;

namespace Tyuiu.PyankovaVV.Sprint2.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Пьянкова В. В. | АСОиУб-23-2 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Пьянкова Виктория Вячеславовна | АСОиУб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("  ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res == true)
            {
                Console.WriteLine("Точка входит в указанную область!");
            }
            else
            {
                Console.WriteLine("Точка НЕ входит в указанную область!");
            }
            Console.ReadLine();
        }
    }
}
