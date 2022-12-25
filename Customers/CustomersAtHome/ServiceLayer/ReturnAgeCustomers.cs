using DomainLayer.Models;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ReturnAgeCustomers : IReturnAgeCustomers
    {
        public double AverageAge(Customer[] arr)
        {
            double sum = 0;
            double count = 0;
            foreach (var item in arr)
            {
                sum=sum+item.Age; 
                count++;
            }
            var result=sum/count;
            return result;
        }

        /*Yashi 25 - 30 arasinda olan Customer-lerin sayini gosteren method*/
        public int ReturnAge(Customer[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (item.Age > 25 && item.Age < 30)
                {
                    count++;    
                }
            }
            return count;
        }
    }
}
