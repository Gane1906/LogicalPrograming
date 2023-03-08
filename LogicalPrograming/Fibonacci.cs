using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    public class Fibonacci
    {
        public void fibonacciSeries(int num)
        {
            int firstNum = 0, secondNum = 1, fibonacciValue = 0;
            Console.Write(firstNum + " " + secondNum+" ");
            for(int i=2;i<num;i++)
            {
                fibonacciValue = firstNum + secondNum;
                Console.Write(fibonacciValue + " ");
                firstNum = secondNum;
                secondNum = fibonacciValue;
            }
            Console.WriteLine();
        }
    }
}
