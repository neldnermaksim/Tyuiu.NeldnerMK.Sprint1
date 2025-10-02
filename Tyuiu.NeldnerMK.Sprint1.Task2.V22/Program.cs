using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint1.Task2.V22.Lib;


namespace Tyuiu.NeldnerMK.Sprint1.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К. | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #22                                                              *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Заданы три числа. Вычислить среднее значение из них.                     *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:Первое число (целое число), Второе число (целое число),  *");
            Console.WriteLine("* Третье число (целое число)                                               *");
            Console.WriteLine();


            Console.Write("Введите первое число: ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int valueTwo = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int valueThree = int.Parse(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.CalculateAVGValue(value, valueTwo, valueThree));


        }
    }
}