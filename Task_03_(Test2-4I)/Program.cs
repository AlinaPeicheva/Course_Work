using System;

namespace Task_03__Test2_4I_
{
    class Program
    {
        static void Main(string[] args)
        {    /*Да се състави програма, която по зададен номер на месец отпечатва името на сезона, 
             като декември, януари, февруари са зима;март, април, май - пролет и т.н. */

            Console.Write("Въведете номера на месяца: ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Пролет");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лято");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Есен");
                    break;
                default:
                    Console.WriteLine("Некоректен номер на месец!");
                    break;
            }
        }
    }
}
