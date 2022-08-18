using System;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string number = "";
            for (int i = 0; i < n; i++)
            {
                string nums = Console.ReadLine();
                for (int j = 0; j < nums.Length; j++)
                {
                    char charToInt = nums[j];
                    number += charToInt;
                    if (nums[j].ToString() == " ")
                    {
                        number = "";
                    }
                }
                long secondNum = long.Parse(number);
                long compareSecondNumber = secondNum;
                string sumFirstNum = "";
                for (int x = 0; x < nums.Length - number.Length; x++)
                {
                    sumFirstNum += nums[x];
                }
                long firstNum = long.Parse(sumFirstNum);
                long compareFirstNumber = firstNum;
                long sumNumSecond = 0;
                while (secondNum != 0)
                {
                    long currNum = secondNum % 10;
                    sumNumSecond += currNum;
                    secondNum = secondNum / 10;
                }
                long sumFirstNums = 0;
                while (firstNum != 0)
                {
                    long currNum = firstNum % 10;
                    sumFirstNums += currNum;
                    firstNum = firstNum / 10;
                }
                number = "";
                if (compareSecondNumber > compareFirstNumber)
                {
                    Console.WriteLine(sumNumSecond);
                }
                else
                {
                    Console.WriteLine(sumFirstNums);
                }
            }
        }
    }
}
