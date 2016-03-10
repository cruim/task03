using System;

namespace ConsoleApplication3
{
    public class Example
    {
        public static void Main()
        {
            int i;
            double d;
            long l;
            string s = "Вводите только целые и вещественные числа!";
            if (double.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Абсолютное значение числа({0}) = {1}", d, Math.Abs(d));
            }
            else if (int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Абсолютное значение числа({0}) = {1}", i, Math.Abs(i));
            }
            else if (long.TryParse(Console.ReadLine(), out l))
            {
                Console.WriteLine("Абсолютное значение числа({0}) = {1}", i, Math.Abs(i));
            }
            else
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}