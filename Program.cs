using System;

namespace w3ExArrays //{ }
{
    class Exercise3
    {
        public static void Main(string[] args)
        {
            int n, i, sum = 0;
            Console.WriteLine("Input the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine($"\nInput {n} elements in the array:");

            for (i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum = sum + array[i];
            }

            Console.Write($"\nThe sum of all elements stored in the array is: {sum}");


            Console.ReadLine();
        }
    }
}
