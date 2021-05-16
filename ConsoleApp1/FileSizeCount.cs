using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    static class FileSizeCount
    {
        public static long GetCountFiles(string path)
        {
            long countL = 0;

            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo f in di.GetFiles())
                {
                    countL += f.Length;
                }

                string[] dir = Directory.GetDirectories(path);
                foreach (var item in dir)
                {
                    countL += GetCountFiles(item);
                }
            }
            return countL;
        }
    }
}
