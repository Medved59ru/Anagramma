using System;

namespace Anagramma
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();
            var sentence = anagram.GetWordsFromConsole();
            Print(anagram.ReverseEachWordIn(sentence));
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод в консоль. Аргумент - массив строк.
        /// </summary>
        /// <param name="sentence"></param>
        public static void Print(string[] sentence)
        {
            foreach (string word in sentence)
                Console.Write(word + ' ');
        }



    }
}
