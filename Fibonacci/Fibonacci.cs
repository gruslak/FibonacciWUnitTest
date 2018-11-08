using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
        }
        public List<int> GetFirstNNumbers(int n)
        {
            List<int> fibonacciNumbers = new List<int>();

            int firstNumber = 1;
            int secondNumber = 1;
            fibonacciNumbers.Add(firstNumber);
            fibonacciNumbers.Add(secondNumber);

            for(int i = 2; i < n; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
            }
            return fibonacciNumbers;
        }
    }
}
