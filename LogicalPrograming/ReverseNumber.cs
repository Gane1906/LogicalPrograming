using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class ReverseNumber
    {
        public void reverse(int num)
        {
            int rerverseNumber = 0,temp=num;
            while(num>0)
            {
                int rem = num % 10;
                rerverseNumber = (rerverseNumber * 10) + rem;
                num /= 10;
            }
            Console.WriteLine("The reversal of " + temp + " is " + rerverseNumber);
        }
    }
}
 