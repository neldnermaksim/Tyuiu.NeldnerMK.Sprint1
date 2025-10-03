using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint1.Task4.V1.Lib;


namespace Tyuiu.NeldnerMK.Sprint1.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К. | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Class MathФайл                                    *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране. *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:Написать программу для вычисления площади прямоугольного треугольника по длинам двух катетов  *");
            Console.WriteLine();


            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());



            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine($"{ds.Calculate(x):F3}");
        }
    }
}