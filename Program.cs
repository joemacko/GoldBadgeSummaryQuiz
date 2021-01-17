using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeSummaryQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Program console = new Program();
            console.SumsList();
        }

        public void EvenlyDivisible()
        {
            int number = 9;
            int modulus = number % 3;

            if (modulus == 0)
            {
                Console.WriteLine($"{number} is evenly divisible by 3");
            }
            else
            {
                Console.WriteLine($"{number} is not evenly divisible by 3");
            }
            Console.ReadLine();
        }

        public void TimesTables()
        {
            int numberOne;
            int numberTwo;

            for(numberOne = 1; numberOne <=5; numberOne++)
            {
                for (numberTwo = 1; numberTwo <= 12; numberTwo++)
                {
                    int numbersMultiplied = numberOne * numberTwo;
                    Console.WriteLine($"{numberOne} x {numberTwo} = {numbersMultiplied}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void Index()
        {
            int[] allNums = { 1, 2, 3, 4, 5 };

            int index = 0;

            while (index <= 5)
            {
                Console.WriteLine($"Last index {allNums[index]}");
                index++;
            }
        }

        public void SumsList()
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };
            int sum = integers.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
