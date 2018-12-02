using System;

namespace Task_02__Zadacha_15_
{
    class Program
    {
        static void Main(string[] args)
        {    /*Да се състави алгоритъм за изчисляване на разстоянието d между две точки в равнината - А и В, 
             зададени със своите декартови координати - Ха,Ya и Xb,Yb. Упътване: Разстоянието d се определя по формула зададена на стр.31 */

            Console.WriteLine("Въведете координатите на точкити");
            Console.Write("Координатата Xa: ");
            double Xa = double.Parse(Console.ReadLine());
            Console.Write("Координатата Xb: ");
            double Xb = double.Parse(Console.ReadLine());
            Console.Write("Координатата Ya: ");
            double Ya = double.Parse(Console.ReadLine());
            Console.Write("Координатата Yb: ");
            double Yb = double.Parse(Console.ReadLine());

            double dif1 = Math.Pow(Xa - Xb, 2);
            double dif2 = Math.Pow(Ya - Yb, 2);
            double d = Math.Sqrt(dif1 + dif2);
            Console.WriteLine("Разстоянието между две точки в равнината d = " + d);
        }
    }
}
