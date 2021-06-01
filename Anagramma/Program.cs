using System;

namespace Anagramma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВЕДИТЕ СЛОВО ИЛИ СЛОВА");
            var sentence = Console.ReadLine();
            Anagram anagram = new Anagram();
            Print(anagram.ReverseEachWordIn(sentence));

            Console.ReadKey();
        }

        public static void Print(string[] sentence)
        {
            foreach (string word in sentence)
                Console.Write(word);
        }
        

    }
}
