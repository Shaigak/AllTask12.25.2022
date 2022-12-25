using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CalculateService : ICalculateService
    {
        public int Arry(int[] arry)
        {
            int multiple = 1;
            for (int i = 1; i < arry.Length; i++)
            {
                if (arry[i] > 1 && arry[i] < 20)
                {
                    multiple *= i;
                }
            }
            return multiple;

        }

        public double Calculate(int[] arry, int power)
        {
            int sum = 0;
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] % 2 == 0)
                {
                    sum = sum + i;
                }
            }
        double result = Math.Pow(sum, power);

        return result;

        }
            
        }
    }



