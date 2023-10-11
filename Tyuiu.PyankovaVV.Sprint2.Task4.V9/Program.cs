﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyankovaVV.Sprint2.Task4.V9.Lib;

namespace Tyuiu.PyankovaVV.Sprint2.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Пьянкова В. В. | АСОиУб-23-2";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема:Тернарный оператор                                               *");
            Console.WriteLine("* Задание #4                                                            *");
            Console.WriteLine("* Вариант #9                                                            *");
            Console.WriteLine("* Выполнила: Пьянкова Виктория Вячеславовна | АСОиУб-23-2               *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с            *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение *");
            Console.WriteLine("* x, y с клавитатуры, если x + 5 < y / 2, то z = (7 + 1/x^2)^y, иначе   *");
            Console.WriteLine("* x ^ 4 - (3/y)                                                         *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите значения переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Значение функции" + res);
            Console.ReadKey();
        }
    }
}
