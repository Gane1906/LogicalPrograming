using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class PerfectNumber
    {
        public void checkPerfectNumber(int num)
        {
            int sumValue = 0;
            for(int i = 1; i < num; i++)
            {
                if(num%i==0)
                {
                    sumValue += i;
                }
            }
            if (sumValue == num)
            {
                Console.WriteLine(num + " is a perfect number");
            }
            else Console.WriteLine(num + " is not a perfect number");
        }
    }
}
