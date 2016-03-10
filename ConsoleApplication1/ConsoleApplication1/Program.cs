using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\S*(метал)\S*";
            string text = "Металлические болванки широко используются на металлопрокатных заводах. " +
                          "Металличекая стружка. Металлопластиковые окна.\n";
            RegexOptions option = RegexOptions.IgnoreCase;
            Regex newReg = new Regex(pattern, option);
            MatchCollection matches = newReg.Matches(text);

            Console.WriteLine("Исходный текст: {0}", text);
            Console.WriteLine("Однокоренные слова по корню 'металл':\n");
            foreach (Match mat in matches)
            {
                Console.WriteLine(mat.Value);
            }


            Console.WriteLine("Колличество однокоренных слов в тексте: {0}", matches.Count);
            Console.ReadLine();



        }
    }
}