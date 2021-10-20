using System;

namespace zerbis_chinka
{
    class Program
    {
        public static string IsEvenNumber(int x)
        {
            Console.WriteLine("Let's see if the number is even or odd...");
            Console.WriteLine("Type in the number you would like to test...");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                return $"{x} is an even number...";
            }
            
            {
                return $"{x} is an odd number...";
            }
                
            
        }








        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(IsEvenNumber(4));


        }
    }
}
