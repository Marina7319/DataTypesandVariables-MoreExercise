﻿using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                char word = (char)(key + letter);
                Console.Write(word);
            }
        }
    }
}
