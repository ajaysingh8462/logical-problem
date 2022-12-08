using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_problem
{
    internal class Perfect_Number
    {
        public void Check()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (num == sum)
                Console.WriteLine("Number provided is Perfect Number");
            else
                Console.WriteLine("Number provided is not a Perfect Number");
        }
    }
}
