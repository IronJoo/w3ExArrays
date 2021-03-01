using System;

namespace w3ExArrays //{ }
{
    class Exercise2
    {
        public static void Main(string[] args)
        {
            int[] num = new int[3];
            int i;

            for (i = 0; i < num.Length; i++)
            {
                Console.Write("Insert a number: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You inserted the numbers: ");
            for (i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

            Console.WriteLine("In reverse, your numbers are: ");
            for (i = num.Length-1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
