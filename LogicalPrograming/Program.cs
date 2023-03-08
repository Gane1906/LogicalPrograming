using System;
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
                Console.Write("1.Fibonacci\n2.Perfect number\n3.exit\nEnter your option to execute: ");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}