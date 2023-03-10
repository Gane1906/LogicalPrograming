using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class CouponNumber
    { 
       public void CouponGenerator(int num)
        {
            int count = 0;
            int[] arr = new int[10];
            Random random = new Random();
            arr[0] = random.Next(0, num);
            for(int i = 0; i < 10; i++)
            {
                int coupon = random.Next(0, num);
                for(int j = 0; j < i; j++)
                {
                    if (arr[j] != coupon)
                        arr[i] = coupon;
                }
                count++;
            }
            Console.WriteLine("The cout for distinct 10 numbers is: " + count);
        }
    }
}
