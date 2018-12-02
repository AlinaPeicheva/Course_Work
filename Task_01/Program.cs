using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Превърнете 2098 в 2, 8 и 16 - ична бройна система*/
            int value = 2098;
            string convert1 = Convert.ToString(value, 2);
            string convert2 = Convert.ToString(value, 8);
            string convert3 = Convert.ToString(value, 16);
            
            Console.WriteLine("2098 в 2 бройна система = 100000110010\n2098  | 2  Остатък 0\n1049  | 2  Остатък 1\n 524  | 2  Остатък 0\n 262  | 2  Остатък 0\n 131  | 2  Остатък 1" +
                "\n  65  | 2  Остатък 1\n  32  | 2  Остатък 0\n  16  | 2  Остатък 0\n   8  | 2  Остатък 0\n   4  | 2  Остатък 0" +
                "\n   2  | 2  Остатък 0\n   1  | 2  Остатък 1");
            Console.WriteLine("Проверка: {0}", convert1);

            Console.WriteLine("\n\n2098 в 8 бройна система = 4062\n2098  | 8  Остатък 2\n 262  | 8  Остатък 6\n  32  | 8  Остатък 0\n   4  | 8  Остатък 4");
            Console.WriteLine("Проверка: {0}", convert2);

            Console.WriteLine("\n\n2098 в 16 бройна система = 832\n2098  | 16  Остатък 2\n 131  | 16  Остатък 3\n   8  | 16  Остатък 8");
            Console.WriteLine("Проверка: {0}", convert3);
        }
    }
}
