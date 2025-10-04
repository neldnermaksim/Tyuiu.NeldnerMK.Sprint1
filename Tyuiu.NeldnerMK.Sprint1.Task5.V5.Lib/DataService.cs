using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.NeldnerMK.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
       
        int ISprint1Task5V5.Calculate(double x)
        {
            return (int)(x * 10) % 10;
        }
    }
}
