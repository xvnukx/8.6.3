using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class MyClass
    {
        string path;

        public MyClass()
        {
            Console.Write("Введите URL: ");
            this.path = Console.ReadLine();
            Console.WriteLine();
        }

        public void Do()
        {
            Console.WriteLine($"Размер папки {FileSizeCount.GetCountFiles(path)} байт");
            Console.WriteLine($"\nУдалено {DeliteLogicClass.DelFile(path)} файлов");
            Console.WriteLine($"Размер папки {FileSizeCount.GetCountFiles(path)} байт");
        }
    }
}
