using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int opernBracketsCount = 0;
            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                if (i == 0 && a == ")")
                {
                    Console.WriteLine("UNBALANCED");
                    break;
                }
                if (a == "(")
                {
                    opernBracketsCount += 1;
                }
                else if (a == ")")
                {
                    opernBracketsCount -= 1;
                }
            }
            if (opernBracketsCount == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
