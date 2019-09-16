using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Odd_Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(i%j==0 && j % 2 == 1)
                    {
                        sum += j;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
