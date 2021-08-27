using System;
using System.IO;
using System.Text;

namespace Trucket.Tests
{
    public class FileHelper
    {
        public static void CreateFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(content);
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }
    }
}