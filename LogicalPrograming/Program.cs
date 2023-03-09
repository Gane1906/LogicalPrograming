using System;
using System.Linq.Expressions;

namespace LogicalPrograming
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to logical programming");
            bool flag = true;
            while (flag)
            {
                Console.Write("1.Fibonacci\n2.Perfect number\n3.Prime check\n4.Reverse of number\n5.Coupon number\n6.Stop watch\n7.exit\nEnter your option to execute: ");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibonacci fib=new Fibonacci();
                        Console.WriteLine("Enter the number for fibonacci");
                        int num= Convert.ToInt32(Console.ReadLine());
                        fib.fibonacciSeries(num);
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        Console.WriteLine("Enter the number to check perfect number");
                        int value = Convert.ToInt32(Console.ReadLine());
                        perfectNumber.checkPerfectNumber(value);
                        break;
                    case 3:
                        Console.WriteLine("Enter any number to check prime");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Prime prime = new Prime();
                        prime.primeCheck(number);
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        Console.WriteLine("Enter the number");
                        int rev = Convert.ToInt32(Console.ReadLine());
                        reverseNumber.reverse(rev);
                        break;
                    case 5:
                        CouponNumber coupon = new CouponNumber();
                        Console.WriteLine("Enter the number");
                        int variable = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        StopWatch watch = new StopWatch();
                        watch.calculateTime();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}