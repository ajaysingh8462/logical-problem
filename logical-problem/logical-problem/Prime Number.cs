using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_problem
{
    internal class Prime_Number
    {
        public void prime()
        {
            Console.WriteLine("Enter nummber Is this Number is Prime or Composite");
            int num =Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1; i<=num; i++)
            {
                if(num % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("Number is Prime");
            else
                Console.WriteLine("Number is not a Prime");
        }

    }
    
}
