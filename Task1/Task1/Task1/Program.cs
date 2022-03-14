using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 7, 6, 3, 2, 1 };
            int counter = 0;
            for (int i = 0; i <array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] + array[j] < 10)
                        counter++;
                }
                Console.WriteLine(counter);
            }

        }
    }
}
