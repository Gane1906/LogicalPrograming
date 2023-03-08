using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class Prime
    {
        public void primeCheck(int num)
        {
            int count = 0;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count == 0)
                Console.WriteLine(num + " is prime number");
            else
                Console.WriteLine(num + " is not a prime number");
        }
    }
}
