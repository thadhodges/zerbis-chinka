﻿using System;

namespace zerbis_chinka
{
    class Program
    {
        public static string IsEvenNumber(int x)
        {
            Console.WriteLine("Let's see if the number is even or odd...");

            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                return $"{x} is an even number...";
            }
            else 
                return $"{x} is an odd number...";
            
        }








        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IsEvenNumber(int.Parse(Console.ReadLine()));


        }
    }
}
