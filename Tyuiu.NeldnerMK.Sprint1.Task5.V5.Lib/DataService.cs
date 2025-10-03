using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.NeldnerMK.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public double Calculate(double x)
        {
            return (int)(x * 10) % 10;
        }
    }
}
