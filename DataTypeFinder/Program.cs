using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentInput = Console.ReadLine();
            while (currentInput != "END")
            {
                string input = currentInput;
                if (int.TryParse(input, out int resultInt))
                {
                    Console.WriteLine("int");
                }
                else if (float.TryParse(input, out float resultFloat))
                {
                    Console.WriteLine("int");
                }
                else if (char.TryParse(input, out char resultChar))
                {

                }
                else if (bool.TryParse(input, out bool resultBoolean))
                {

                }
                else if (string.TryParse(input, out string resultString))
                {

                }
                currentInput = Console.ReadLine();
            }
        }
    }
}
