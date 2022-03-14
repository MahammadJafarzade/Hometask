using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=2;
            int m=50;
            int count = 0;
            
               for (int i = n; i < m; i++)
            {
                if (i % 15 == 0)
                {
                    count++ ;
                }  
            }
            
            Console.WriteLine(count);

        }
    }
}
            
