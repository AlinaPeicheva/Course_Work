using System;

namespace Task_04__83a_
{
    class Program
    {
        static void Main(string[] args)
        {   // Да се изведат числата от 1 до 100 по следния начин: 1,2,100,99,3,4,98,97,...,49,50,52,51.

            Console.WriteLine("Числа от 1 до 100:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", " + (i + 1) + ", ");
                }
                else Console.Write((100 - i + 2) + ", " + (100 - i + 1) + ", ");
            }
        }
    }
}
