using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=27;
            int i=1;
            while (i*i <= n)
            {
                i++;
            }
            Console.WriteLine(i-1);
        }
    }
}
