using System;
using System.Collections.Generic;

namespace Anagramma
{
    public class Anagram
    {
        
        public string[] ReverseEachWordIn(string sentence)
        {
           
            var words = CutBySpace(sentence);
            string[] newSentence = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                newSentence[i] = ReverseOne(words[i]);
            }

            return newSentence;  
        }

       
        public string ReverseOne(string word)
        {
            int index = word.Length;
            int endIndex = index - 1;
            char[] wordToArray = new char[index];
            wordToArray = word.ToCharArray();

            index = 0;
            while (index < endIndex)
            {
               
                if (!char.IsLetter(wordToArray[index]))
                {
                    index++;
                }
                else if (!char.IsLetter(wordToArray[endIndex]))
                {
                    endIndex--;
                }
                
                else
                {
                    char tempChar = wordToArray[index];
                    wordToArray[index] = wordToArray[endIndex];
                    wordToArray[endIndex] = tempChar;
                    index++;
                    endIndex--;
                }
            }

           
            string wordResult = new String(wordToArray);
            return wordResult;
        }

        
        public string[] CutBySpace(string sentence)
        {
            
            var tempArray = sentence.ToCharArray();
            int index = 0;
            string word = "";
            List<string> sentenceCutBySpace = new List<string>();

            while (index < tempArray.Length)
            {
                
                while (index < tempArray.Length)
                {
                    word += tempArray[index];
                    if (Char.IsWhiteSpace(tempArray[index]))
                        break;
                    index++;
                }
                sentenceCutBySpace.Add(word);
                word = "";
                index++;

            }
            var resultArray = sentenceCutBySpace.ToArray();
            return resultArray;
        }

    }
}
