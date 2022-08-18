using System;
namespace LeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sums = "";
            string sum = "";
            for (int i = 0; i < n; i++)
            {
                string nums = Console.ReadLine();
                for (int j = 0; j < nums.Length; j++)
                {
                    char charToInt = nums[j];
                    sums += charToInt;
                    sum += charToInt;
                    if (nums[j].ToString() == " ")
                    {
                        sums = "";
                    }
                }
                string numTwo = sums.ToString();
                int sumSecondNum = 0;
                for (int x = 0; x < numTwo.Length; x++)
                {
                    switch (numTwo[x])
                    {
                        case '1':
                            sumSecondNum += 1;
                            break;
                        case '2':
                            sumSecondNum += 2;
                            break;
                        case '3':
                            sumSecondNum += 3;
                            break;
                        case '4':
                            sumSecondNum += 4;
                            break;
                        case '5':
                            sumSecondNum += 5;
                            break;
                        case '6':
                            sumSecondNum += 6;
                            break;
                        case '7':
                            sumSecondNum += 7;
                            break;
                        case '8':
                            sumSecondNum += 8;
                            break;
                        case '9':
                            sumSecondNum += 9;
                            break;
                        case '0':
                            sumSecondNum += 0;
                            break;
                    }
                }
                string sumNums = sum.ToString();
                int result = 0;
                for (int x = 0; x < sumNums.Length; x++)
                {
                    switch (sumNums[x])
                    {
                        case '1':
                            result += 1;
                            break;
                        case '2':
                            result += 2;
                            break;
                        case '3':
                            result += 3;
                            break;
                        case '4':
                            result += 4;
                            break;
                        case '5':
                            result += 5;
                            break;
                        case '6':
                            result += 6;
                            break;
                        case '7':
                            result += 7;
                            break;
                        case '8':
                            result += 8;
                            break;
                        case '9':
                            result += 9;
                            break;
                        case '0':
                            result += 0;
                            break;
                    }
                }
                int sumFirstNumber = result - sumSecondNum;
                if (sumFirstNumber > sumSecondNum)
                {
                    Console.WriteLine(sumFirstNumber);
                }
                else
                {
                    Console.WriteLine(sumSecondNum);
                }
                sums = "";
                sum = "";
            }
        }
    }
}
