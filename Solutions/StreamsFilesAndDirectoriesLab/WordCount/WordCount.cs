namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var words = new Dictionary<string, int>();

            var allWords = File.ReadAllText(wordsFilePath).Split(" ");
            var allText = new Regex(@"[A-Za-z']+")
                .Matches(File.ReadAllText(textFilePath))
                .Select(x => x.ToString().ToLower())
                .ToList();
            foreach (var word in allWords)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 0);
                    foreach (var sepWord in allText)
                    {
                        if (word == sepWord)
                        {
                            words[word]++;
                        }
                    }
                }
            }

            words = words
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            using (var writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in words)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
