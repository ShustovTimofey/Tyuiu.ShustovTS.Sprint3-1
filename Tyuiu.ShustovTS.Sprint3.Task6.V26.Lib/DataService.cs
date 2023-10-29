using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShustovTS.Sprint3.Task6.V26.Lib
{
    public class DataService : ISprint3Task6V26
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    if (i % k == 0)
                    {
                        sum += 1;
                    }
                }
            }
            return sum;
        }
    }
}
