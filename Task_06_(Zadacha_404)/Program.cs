using System;

namespace Task_06__Zadacha_404_
{
    class Program
    {       /*Да се въведе едномерен целочислен масив с дължина (брой елементи) в интервала [2;50]. Да се контролира въвеждането на дължината в този интервал.
            а) Да се напише метод Sum(k), който връща сумата от всички елементи на масива, по-големи от парамътра k 
            (формалният парамътра k се въвежда от потребителя). След изчислението, сумата да се отпечата от екрана.
            б) Да се намери и отпечата на екрана броят на всички трицифрени елементи на масива, сумата на чиито съставни цифри е четно число*/
        static void Main(string[] args)
        {

            byte choice;
            do
            {
                Console.Clear();
                Console.WriteLine("**********************************************************************************************\n" +
                    "**************************************** М Е Н Ю *********************************************\n" +
                    "**********************************************************************************************\n");
                Console.WriteLine("1. Въвеждане на масив в интервала [2;50]. \nИзвеждане на сумата от всички елементи на масива по-големи от парамътра k.");
                Console.WriteLine("2. Въвеждане на нов масив за отпечатване на \nекрана броят на всички трицифрени елементи, " +
                    "сумата на чиито съставни цифри е четно число");
                Console.WriteLine("3.Изход.");
                Console.Write("\nВъведете номера от менюто: ");

                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: InputArr(); break;
                    case 2: ThreeDigitNumbers(); break;
                }

            } while (choice != 3);

            Console.WriteLine(Environment.NewLine + "Приятен ден!");
            Console.ReadLine();
        }
    

        static void InputArr()
        {
            Console.Clear();
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] nums = new int[length];


            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i + 1);
                string afterVaildate = Console.ReadLine();
                int inputNum = Validation(afterVaildate);

                nums[i] = inputNum;
            }
            string result = string.Join(" | ", nums);
            Console.WriteLine("[" + result + "]");
            Console.Write("\nВъведете параметър k: ");
            int k = Int32.Parse(Console.ReadLine());
            int sum = Sum(k, nums);

            Console.Write("Сумата на всички елементи по-големи от параметъра k: ");
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static int Validation(string input)
        {
            int checkInput = Int32.Parse(input);
            if (checkInput >= 2 && checkInput <= 50)
            {
                return checkInput;
            }
            else
            {
                Console.Write("Числото " + checkInput + " не вхожда в интервала, моля въведете число в интервала [2;50]:  ");
                string validateString = Console.ReadLine();
                return Validation(validateString);
            }
        }

        static int Sum(int k, int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > k)
                {
                    sum = nums[i] + sum;
                }
            }
            return sum;
        }
      
        static void ThreeDigitNumbers()
        {
            Console.Clear();
            Console.Write("Въведете дължината на масива: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Random num = new Random();

            for (int i = 0; i < k; i++)
            {
                arr[i] = num.Next(0, 1000);
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum++;
                }
            }
            string result = string.Join(" | ", arr);
            Console.WriteLine("[" + result + "]");
            Console.WriteLine("Брой на елементи, сумата на чиито съставни чифри е четно число: {0}", sum);
            Console.ReadKey();
        }
    }
}
