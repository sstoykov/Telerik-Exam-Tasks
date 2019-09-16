using System;

namespace Mutant_Squirrels
{
    class Program
    {
        static void Main()
        {

            int trees = int.Parse(Console.ReadLine());
            int branches = int.Parse(Console.ReadLine());
            int squirrels = int.Parse(Console.ReadLine());
            int tails = int.Parse(Console.ReadLine());

            int sum = (trees * branches * squirrels * tails);

            if(sum%2==0)
            {
                ulong result = (ulong)sum * 376439;
                Console.WriteLine("{0:0.000}", result);
            }
            else
            {
                float result = (float)sum / 7;
                Console.WriteLine("{0:0.000}", result);
            }
        }
    }
}
