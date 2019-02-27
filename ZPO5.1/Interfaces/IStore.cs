using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO5.Interfaces
{
    public interface IStore
    {
        bool Save(string id, string message);
        string Read(string id);
        FileInfo GetFileInfo(string name);
    }
}
