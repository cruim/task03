using System;

namespace ConsoleApplication2
{
    internal class Program
    {

        static void Main(string[] args)
        {
        metka:
            Console.WriteLine("Введите логин");
            string str = Console.ReadLine();
            char[] arr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }

            int len = arr.Length;
            if (len > 10 || len < 2)
            {
                Console.WriteLine("Логин должен иметь длину от 2 до 10 символов\n" +
                                     "Состоять из латинских букв или цифр и \n" +
                                     "Обязательно начинаться на букву!");

                goto metka;
            }

            else if (char.IsNumber(arr[0]))
            {
                Console.WriteLine("Логин должен иметь длину от 2 до 10 символов\n" +
                                 "Состоять из букв или цифр и \n" +
                                 "Обязательно начинаться на букву!");

                goto metka;
            }

            else
            {
                Console.WriteLine("Ваш логин: {0}", str);
            }


            Console.ReadLine();
        }
    }
}


/*
 Создать стринговую переменную, которая будет заполняться с консоли.
 * Длина и содержание будет записываться в массив типа char.
 * Создать интовую переменную, значение которой
 * будет равно длине массива.
 * Создать условную конструкцию, которая будет проверять
 * кол-во и вид вводимых символов.
*/