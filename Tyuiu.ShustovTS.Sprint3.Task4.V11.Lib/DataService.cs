using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShustovTS.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    res *= i / (Math.Sin(i) - i) + 2;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
