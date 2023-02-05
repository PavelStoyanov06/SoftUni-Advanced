namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double size = GetFolderSize(folderPath) / 1024.0;
            using(StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine(size);
            }
        }

        public static long GetFolderSize (string path)
        {
            string[] files = Directory.GetFiles(path);
            long size = 0;

            foreach (string file in files) 
            { 
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }

            string[] dirs = Directory.GetDirectories(path);
            if(dirs.Length > 0)
            {
                foreach (string dir in dirs)
                {
                    size += GetFolderSize(dir);
                }
            }

            return size;
        }
    }
}
