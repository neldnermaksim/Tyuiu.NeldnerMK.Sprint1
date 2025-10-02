using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint1.Task1.V30.Lib;


namespace Tyuiu.NeldnerMK.Sprint1.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К. | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложенияхФайл             *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле (2+x)/2 и печатает его на экране.         *");
            Console.WriteLine("* одинаковых массивов по длине.                                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   (2+x)/2                                               *");
            Console.WriteLine();
           

            double x;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate(x));
        }
    }
}