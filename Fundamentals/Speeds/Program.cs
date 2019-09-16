using System;

namespace Speeds
{
    class Program
    {
        static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine());
            int[] speeds = new int[carsCount];

            for (int i = 0; i < carsCount; i++)
            {
                speeds[i] = int.Parse(Console.ReadLine());
            }

            int result = 0;
            int length = 0;

            int tempSum = speeds[0];
            int tempLength = 1;

            for (int i = 0; i < carsCount - 1; i++)
            {
                if (speeds[i] < speeds[i + 1])
                {
                    tempSum += speeds[i + 1];
                    tempLength++;

                    if (tempLength > length)
                    {
                        result = tempSum;
                        length = tempLength;
                    }
                }
                else if(speeds[i] == speeds[i + 1])
                {
                    tempLength = 1;
                    tempSum = speeds[i + 1];

                    if (tempLength > length)
                    {
                        result = speeds[i];
                        length = tempLength;
                    }
                }
                else if (speeds[i] > speeds[i + 1])
                {
                    tempLength = 1;
                    tempSum = speeds[i + 1];

                    if (tempLength > length)
                    {
                        result = speeds[i];
                        length = tempLength;
                    }
                }
                else
                { 
                    tempSum = speeds[i + 1];
                    tempLength = 1;
                }

            }

            Console.WriteLine(result);
        }
    }
}
