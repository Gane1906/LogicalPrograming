using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class CouponNumber
    {
        public void couponGenerate(int num)
        {
            int count = 0;
            int[] arr = new int[num];
            Random random = new Random();
            for(int i = 0; i < num; i++)
            {
                int coupon = random.Next(0, num);
                for(int j = 0; j < (i + 1); j++)
                {
                    if (arr[j] != coupon)
                        arr[i] = coupon;
                    count++;
                }
            }
            Console.WriteLine("The number of random numbers generated for distinct numbers is " + count);
        }
    }
}
