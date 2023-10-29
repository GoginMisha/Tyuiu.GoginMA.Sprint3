﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GoginMA.Sprint3.Task4.V17.Lib;

namespace Tyuiu.GoginMA.Sprint3.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах               *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение    *");
            Console.WriteLine("* функции y=cos(x)/sin(x). При х = 0 прервать цикл.                      *");
            Console.WriteLine("* Полученные значения перемножать.                                       *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
