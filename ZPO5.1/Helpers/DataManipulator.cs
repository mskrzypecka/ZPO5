using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO5.Interfaces;

namespace ZPO5
{
    public class DataManipulator 
    {
        public MessageStorage storage { get; set; }

        public DataManipulator()
        {
            storage = new MessageStorage();
        }

        public bool Save(string fileName, string message)
        {
            storage.FileStorage.Save(fileName, message);

            return true;
        }

        public string Read(string fileName) => storage.FileStorage.Read(fileName);
    }
}
