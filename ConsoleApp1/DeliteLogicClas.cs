using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    static class DeliteLogicClass
    {
        public static int DelFile(string path)
        {
            int countDelite = 0;
            TimeSpan accessTime = TimeSpan.FromMinutes(30);

            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo f in di.GetFiles())
                {
                    TimeSpan time = DateTime.Now - f.LastAccessTime;
                    if (time.TotalMinutes > accessTime.Minutes)
                    {
                        Console.WriteLine($"Удаляем {f}");
                        countDelite++;
                        f.Delete();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Доступ к {f} был {time.TotalMinutes} минут назад.");
                    }
                }

                string[] dir = Directory.GetDirectories(path);
                foreach (var item in dir)
                {
                    countDelite += DelFile(item);
                }
            }

            return countDelite;
        }
    }
}

