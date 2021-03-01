using System;

namespace w3ExArrays //{ }
{
    class Exercise1
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Insert a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You inserted the following numbers");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
