using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се генерира редица от 70 случайни цели числа принадлежащи на интервала [0,200].Да се отпечатат, които се различни от нула.

            Console.WriteLine("Подусловие 1\n");
            Console.WriteLine("Редица от 70 случайни цели числа");
            Random num = new Random();
            for (int i = 0; i <= 70; i++)
            {
                int x = num.Next(0, 200);
                if (i != 0)
                {
                    Console.WriteLine("{0}.  {1}", i, x);
                }

            }
            /* Да се въведат от клавиатурата 10 числа. 
              Да се намери и отпечата на екрана произведението на тези от тях, които са в интервала [10,20]. */

            Console.WriteLine("\nПодусловие 2\n");
            Console.WriteLine("                ******Въведете 10 числа******\nЗа да пресмята числата трябва да има числа в интервала [10,20].\n");
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());
            }
            int calculate = 1;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] >= 10 && nums[i] <= 20)
                {
                    calculate *= nums[i];
                }
            }

            string result = string.Join("; ", nums);
            Console.WriteLine("\nВъведенете числа: {0}", result);
            Console.WriteLine("\nПроизведението на тези, които са в интервала [10,20]= {0}", calculate);

            /* Да се създаде метод Sum(k), който генерира k на брой случайни цели числа и като резултат връща сумата на тези от тях, 
         които са четни. В главния метод да се въведат 3 цели положителни числа a,b,c. Да се намери и отпечата: Sum(a)+Sum(b*c).*/
            Console.WriteLine("\nПодусловие 3\n");
        }
    }
}
