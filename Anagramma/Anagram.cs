using System;

namespace Anagramma
{
    public class Anagram
    {
        /// <summary>
        /// Разворачивает каждое слово во введнном в консоль предложении. Аргумент - строка. 
        /// Возвращает массив строк
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public string[] ReverseEachWordIn(string sentence)
        {
            string[] words = sentence.Split();
            string[] newSentence = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                newSentence[i] = ReverseOne(words[i]);
            }

            return newSentence;
        }

        /// <summary>
        /// Разварачивает слово переданное в качестве аргумента
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string ReverseOne(string word)
        {
            int index = word.Length;
            int endIndex = index - 1;
            char[] wordToArray = new char[index];
            wordToArray = word.ToCharArray();

            index = 0;
            while (index < endIndex)
            {
                //игнорируем "не буквы"
                if (!char.IsLetter(wordToArray[index]))
                {
                    index++;
                }
                else if (!char.IsLetter(wordToArray[endIndex]))
                {
                    endIndex--;
                }
                // обмен букв в массиве местами
                else
                {
                    char tempChar = wordToArray[index];
                    wordToArray[index] = wordToArray[endIndex];
                    wordToArray[endIndex] = tempChar;
                    index++;
                    endIndex--;
                }
            }

            // возвращаем строку
            string wordResult = new String(wordToArray);
            return wordResult;
        }

        #region ввод с консоли

        /// <summary>
        /// Получение данных с консоли.
        /// </summary>
        /// <returns></returns>
        public string GetWordsFromConsole()
        {
            Console.WriteLine("ВВЕДИТЕ СЛОВО ИЛИ СЛОВА");
            string words = Console.ReadLine();
            return words;
        }


        #endregion

    }
}
