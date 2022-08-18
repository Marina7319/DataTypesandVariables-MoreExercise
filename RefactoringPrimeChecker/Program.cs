using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool isPrime = true;
                for (int d = 2; d < i; d++)
                {
                    if (i % d == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                // Console.WriteLine("{0} -> {1}", i, isPrime);
                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", i);
                }
                else
                {
                    Console.WriteLine("{0} -> false", i);

                }
            }
        }
    }
}
