using System;

namespace Conductors
{
    class Program
    {
        static void Main(string[] args)
        {
            int device = int.Parse(Console.ReadLine());
            string binDevice = Convert.ToString(device, 2);

            int countOfTickets = int.Parse(Console.ReadLine());
            int[] tickets = new int[countOfTickets];

            for (int i = 0; i < countOfTickets; i++)
            {
                tickets[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < countOfTickets; i++)
            {
                char[] temp = Convert.ToString(tickets[i], 2).ToCharArray();

                for (int j = temp.Length - 1; j >= binDevice.Length - 1; j--)
                {
                    int counter = 0;

                    for (int k = 0; k < binDevice.Length; k++)
                    {
                        if (temp[j - k] == binDevice[binDevice.Length - k - 1])
                        {
                            counter++;
                        }
                    }

                    if (counter == binDevice.Length)
                    {
                        for (int l = j; l > j - counter; l--)
                        {
                            temp[l] = '0';
                        }
                    }
                }

                string result = new string(temp);
                int decResult = Convert.ToInt32(result, 2);

                Console.WriteLine(decResult);

            }


        }
    }
}
