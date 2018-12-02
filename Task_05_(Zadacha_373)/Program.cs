using System;

namespace Task_05__Zadacha_373_
{
    class Program
    {
        static void Main(string[] args)
            {
                byte choice;

                do
                {
                    Console.Clear();
                    Console.WriteLine("**********************************************************************************************\n" +
                        "**************************************** М Е Н Ю *********************************************\n" +
                        "**********************************************************************************************\n");
                    Console.WriteLine("1.Генериране на редица от 70 случайни цели числа принадлежащи на интервала [0,200], които се различни от нула.");
                    Console.WriteLine("2.Въвеждане на 10 числа. Отпечатване на екрана произведението на тези от тях, които са в интервала[10, 20].");
                    Console.WriteLine("3.Решаване сумата: Sum(a)+Sum(b*c).");
                    Console.WriteLine("4.Изход.");
                    Console.Write("\nВъведете номера от менюто: ");

                    choice = byte.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: RandDifZero(); break;
                        case 2: Product(); break;
                        case 3: Summa(); break;
                    }

                } while (choice != 4);

                Console.WriteLine(Environment.NewLine + "Приятен ден!");
                Console.ReadLine();
            }
        static void RandDifZero()
        {
            //Да се генерира редица от 70 случайни цели числа принадлежащи на интервала [0,200].Да се отпечатат, които се различни от нула.

            Console.Clear();
            Console.WriteLine("************************************************Подусловие 1************************************************\n");
            Console.WriteLine("Редица от 70 случайни цели числа");
            Random num = new Random();
            for (int i = 0; i <= 70; i++)
            {
                int x = num.Next(0, 200);
                if (i != 0)
                {
                    Console.WriteLine(" {0}.  {1}", i, x);
                }

            }
            Console.ReadLine();
        }

        static void Product()
        {
            /* Да се въведат от клавиатурата 10 числа. 
            Да се намери и отпечата на екрана произведението на тези от тях, които са в интервала [10,20]. */

            Console.Clear();
            Console.WriteLine("************************************************Подусловие 2************************************************\n");
            Console.WriteLine("\n***************************************************************\n***********************Въведете 10 числа***********************" +
                "\n***************************************************************\nЗа да пресмята числата трябва да има числа в интервала [10,20].\n");
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
            Console.ReadLine();
        }

        static void Summa()
        {
            /* Да се създаде метод Sum(k), който генерира k на брой случайни цели числа и като резултат връща сумата на тези от тях, 
               които са четни. В главния метод да се въведат 3 цели положителни числа a,b,c. Да се намери и отпечата: Sum(a)+Sum(b*c).*/
            Console.Clear();
            Console.WriteLine("************************************************Подусловие 3************************************************\n");
            Console.Write("Въведете число k: ");
            int k = int.Parse(Console.ReadLine());
            int sum = Sum(k);

            Console.WriteLine("\n\nSum(a)+Sum(b*c):");
            Console.Write("\nВъведете число 'a' > 0: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете число 'b' > 0: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете число 'c' > 0: ");
            int c = Int32.Parse(Console.ReadLine());

            int totalSum = Sum(a) + Sum(b * c);
            Console.WriteLine("\nSum(a)+Sum(b*c): " + totalSum);
            Console.ReadLine();
        }
        static int Sum(int k)
        {
            int[] arr = new int[k];
            Random num = new Random();
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                arr[i] = num.Next(0, 100);
                if (arr[i] % 2 == 0)
                {
                    sum = arr[i] + sum;

                }
            }
            string result = string.Join(" | ", arr);
            Console.WriteLine("\nМасив от " + k + " числa: " + "[" + result + "]");
            Console.WriteLine("Сумата на четните числа от масива c " + k + " числа: " + sum);

            return sum;
        }  
    }
}

