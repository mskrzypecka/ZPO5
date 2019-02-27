using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO5
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStorage storage = new FileStorage(new System.IO.DirectoryInfo("some_directory"));
            storage.Read("some_id");
            storage.Save("del_info", "Delete file?");


            Console.ReadKey();
        }
    }
}
