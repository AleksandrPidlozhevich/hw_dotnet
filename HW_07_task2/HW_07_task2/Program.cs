using System;

namespace HW_07_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Input string in one line with ' ' separator: ");
            string inputtedString = Console.ReadLine();
            Program.MaxWord(inputtedString);
            Program.MaxMinWords(inputtedString);
            Program.CalcCount(inputtedString);
            Program.SortArray(inputtedString);
        }
        static void MaxWord(string line)
        {
            int MaxLengthWord = 0, lengthMax = 0;

            string[] wordsArray = line.Split(' ');
            for (int i = wordsArray.Length - 1; i >= 0; i--)
            {
                if (wordsArray[i].Length <= lengthMax)
                {
                    continue;
                }
                MaxLengthWord = i;
                lengthMax = wordsArray[i].Length;
            }
            var wordsMaxValue = Array.FindAll(wordsArray, word => word != wordsArray[MaxLengthWord]);
            string lineMaxValue = string.Join(' ', wordsMaxValue);

            Console.WriteLine(lineMaxValue + "\n");
        }
        static void MaxMinWords(string line)
        {
            int indexMinWord, lengthOfMaxWord, lengthOfMinWord;
            NewMethod(out int indexMaxWord,
                      out indexMinWord,
                      out lengthOfMaxWord,
                      out lengthOfMinWord);

            lengthOfMinWord = line.Split(' ')[0].Length;
            for (int i = 0; i < line.Split(' ').Length; i++)
            {
                switch (line.Split(' ')[i])
                {
                    case string word when word.Length < lengthOfMinWord:
                        lengthOfMinWord = word.Length;
                        indexMinWord = i;
                        break;
                    case string word when word.Length > lengthOfMaxWord:
                        lengthOfMaxWord = word.Length;
                        indexMaxWord = i;
                        break;
                }
            }
            string wordStorage = line.Split(' ')[indexMinWord];
            line.Split(' ')[indexMinWord] = line.Split(' ')[indexMaxWord];
            line.Split(' ')[indexMaxWord] = wordStorage;
            string ChangedWords = string.Join(' ', line.Split(' '));
            Console.WriteLine(ChangedWords + "\n");
        }
        static void NewMethod(out int indexMaxWord, out int indexMinWord, out int lengthOfMaxWord, out int lengthOfMinWord)
        {
            indexMaxWord = 0;
            indexMinWord = 0;
            lengthOfMaxWord = 0;
            lengthOfMinWord = 0;
        }
        static void CalcCount(string line)
        {
            int punctuatorCounter = 0, letterCounter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                switch (line[i])
                {
                    case char symbol when symbol >= 'a' && symbol <= 'z':
                        letterCounter++;
                        break;
                    case char symbol when symbol >= 'A' && symbol <= 'Z':
                        letterCounter++;
                        break;
                    case char symbol when symbol >= 'а' && symbol <= 'я':
                        letterCounter++;
                        break;
                    case char symbol when symbol >= 'А' && symbol <= 'Я':
                        letterCounter++;
                        break;
                    case char symbol when symbol.Equals('\'') || symbol.Equals('\"') || symbol.Equals(',') || symbol.Equals('.')
                                          || symbol.Equals('?') || symbol.Equals('!') || symbol.Equals(':') || symbol.Equals('-')
                                          || symbol.Equals(';') || symbol.Equals('(') || symbol.Equals(')'):
                        punctuatorCounter++;
                        break;
                }
            }

            Console.WriteLine($"In line \"{line}\" there are {punctuatorCounter} punctuators and {letterCounter} letters of Slavic or/and Latin alphabeat\n");
        }
        static void SortArray(string line)
        {
            string[] wordsArray = line.Split(' ');
            Array.Sort(wordsArray, (x, y) => y.Length.CompareTo(x.Length));
            Console.WriteLine("\nSorted array:");
            foreach (var item in wordsArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        
    }
}