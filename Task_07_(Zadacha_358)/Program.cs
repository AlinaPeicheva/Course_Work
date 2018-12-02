using System;

namespace Task_07__Zadacha_358_
{
    class Program
    {
        static void Main(string[] args)
        {    /* Съставете програма, в която се въвеждат произволен брой имена отделени с точно един интервал, 
             а се извеждат инициалите на първите две имена и последното име. 
             Например, въвежда се Абу Джафар Мохамед ибн Муса ал-Хорезми, а се извежда А.Д. ал-Хорезми*/

            Console.WriteLine("Въведете вашите имена: ");

            string YourName = Console.ReadLine();
            string first = YourName.Substring(0, 1);
            string second = YourName.Substring(YourName.IndexOf(" ") + 1, 1);
            string[] names = YourName.Split(' ');
            string last = names[names.Length - 1];

            Console.WriteLine("\nВашите инициали и последното име:\n{0}. {1}. {2}", first, second, last);
        }
    }
}
