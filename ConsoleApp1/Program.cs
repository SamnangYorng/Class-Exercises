﻿using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var words1 = new string[] { "hello", "the", "quick", "brown", "fox", "hello", "something" };

            var words2 = InsertWorld(strings);

            for (int i = 0; i < words1.Length; i++)
                Console.Write($"{words1[i]} ");

            Console.WriteLine("");

            for (int i = 0; i < words2.Length; i++)
                Console.Write($"{words2[i]} ");
        }
    }
}
