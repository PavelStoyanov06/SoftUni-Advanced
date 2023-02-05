using System;
using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (var sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                var fileLength = sourceStream.Length;
                var partOneLength = fileLength / 2;
                var partTwoLength = fileLength - partOneLength;
                if (fileLength % 2 != 0)
                {
                    partOneLength++;
                }

                using (var partOneStream = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                {
                    sourceStream.CopyTo(partOneStream, (int)partOneLength);
                }

                using (var partTwoStream = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    sourceStream.CopyTo(partTwoStream, (int)partTwoLength);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var partOneStream = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var partTwoStream = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var joinedStream = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
                    {
                        partOneStream.CopyTo(joinedStream);
                        partTwoStream.CopyTo(joinedStream);
                    }
                }
            }
        }
    }
}
