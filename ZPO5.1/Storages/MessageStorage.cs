using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO5.Interfaces;

namespace ZPO5
{
    public class MessageStorage
    {
        public virtual ICacheStore Cache => new Cache();
        public virtual Logger Logger => new Logger();
        public virtual IStore FileStorage => new FileStorage(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
    }
}
