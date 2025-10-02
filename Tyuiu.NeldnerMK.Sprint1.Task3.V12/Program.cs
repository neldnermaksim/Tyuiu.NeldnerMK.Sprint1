using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint1.Task3.V12.Lib;


namespace Tyuiu.NeldnerMK.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К. | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваиванияФайл                                      *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране. *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:Написать программу для вычисления площади прямоугольного треугольника по длинам двух катетов  *");                                     
            Console.WriteLine();


            Console.Write("Введите длину первого катета: ");
            double lengthCathetus1 = double.Parse(Console.ReadLine());

            Console.Write("Введите длину второго катета: ");
            double lengthCathetus2 = double.Parse(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"{ds.TriangleArea(lengthCathetus1, lengthCathetus2):F3}");
        }
    }
}