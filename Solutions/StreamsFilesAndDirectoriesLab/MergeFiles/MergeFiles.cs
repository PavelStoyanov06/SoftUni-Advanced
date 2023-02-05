namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var allLines1 = File.ReadAllLines(firstInputFilePath).ToList();
            var allLines2 = File.ReadAllLines(secondInputFilePath).ToList();

            var allList = new List<string>();

            for (int i = 0; i < allLines1.Count + allLines2.Count; i++)
            {
                if (i < allLines1.Count)
                {
                    allList.Add(allLines1[i]);
                }
                if (i < allLines2.Count)
                {
                    allList.Add(allLines2[i]);
                }
            }

            File.WriteAllLines(outputFilePath, allList);
        }
    }
}
