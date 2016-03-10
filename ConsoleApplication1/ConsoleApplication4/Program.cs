using System;

namespace ConsoleApplication4
{

    class Program
    {
        static void Main(string[] args)
        {
            char operation = '\0';


            Console.Write("Введите ширину точки A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите долготу точки A: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту точки A: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Координаты точки A: {0}/{1}/{2} ", a.ToString(), b.ToString(), c.ToString());

            Console.Write("Введите ширину точки B: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите долготу точки B: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту точки B: ");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Координаты точки B: {0}/{1}/{2} ", d.ToString(), e.ToString(), f.ToString());

            Console.WriteLine("Введите знак + или - для получения координат новой точки: ");
            operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine("Координаты новой точки: {0}/{1}/{2}", (a + d), (b + e), (c + f));
                    break;
                case '-':

                    Console.WriteLine("Координаты новой точки: {0}/{1}/{2}", (a - d), (b - e), (c - f));
                    break;
                default:

                    Console.WriteLine("Вводите только + или -");
                    break;

            }

            Console.ReadLine();

        }
    }
}