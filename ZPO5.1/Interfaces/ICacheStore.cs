using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO5.Interfaces
{
    public interface ICacheStore
    {
        bool AddOrUpdate(string id, string message);
        string Get(string id);
    }
}
