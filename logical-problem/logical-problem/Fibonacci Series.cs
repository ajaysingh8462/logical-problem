using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace logical_problem
{
    internal class Fibonacci_Series
    {
        public void print()
        {
            Console.WriteLine("Enter Fn for n : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int firstNum = 0, secondNum = 1, thirdNum = 0;
            Console.WriteLine(firstNum + "\n" + secondNum);
            for (int i = 0; i < num; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                Console.WriteLine(thirdNum);
            }
        }
    }
}
